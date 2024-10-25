using EmpAppManagement;
using HRManagement;

using FirebaseAdmin;
using Google.Apis.Auth.OAuth2;
using Google.Cloud.Firestore;

namespace HRDatabaseManagement
{
    public class FirestoreManager
    {
        public EmployeeList employeeList { get; set; }

        private const string FIREBASE_PROJID = "companyemployee-skibd69"; //Must be ID of your Firestore db
        private FirestoreDb db;

        //Constructor
        public FirestoreManager() { }

        //initFirestore: Connect to Cloud Firestore
        public void initFirestore()
        {
            FirebaseApp.Create(); //Static Method: Belongs to the class, not an instance
            db = FirestoreDb.Create(FIREBASE_PROJID); //db: Database, Create: method to create db
            Console.WriteLine("Created Cloud Firestore client with project ID: {0}", FIREBASE_PROJID);
        }
        public async Task<List<Employee>> ReadAllEmployees()
        {
            List<Employee> readEmployees = new List<Employee>();

            try
            {
                // Ensure Firestore is initialized
                if (db == null)
                {
                    Console.WriteLine("Firestore not initialized. Please call initFirestore() first.");
                    return readEmployees;
                }

                // Collection Reference - Points to the "employee" collection
                CollectionReference collectionRef = db.Collection("employee");
                Console.WriteLine("-------------------------------------------------------");
                Console.WriteLine("Retrieving all employees...");

                // Fetch all documents in the collection
                QuerySnapshot snapshot = await collectionRef.GetSnapshotAsync();

                // Process each document in the snapshot
                foreach (DocumentSnapshot doc in snapshot.Documents)
                {
                    if (doc.Exists)
                    {
                        // Safely retrieve each field and handle missing or null values
                        string employeeName = doc.ContainsField("EmployeeName") ? doc.GetValue<string>("EmployeeName") : "Unknown";
                        string employeeIDStr = doc.ContainsField("EmployeeID") ? doc.GetValue<string>("EmployeeID") : "0";

                        // Convert EmployeeID from string to int
                        int employeeID = int.TryParse(employeeIDStr, out int idValue) ? idValue : 0;

                        string position = doc.ContainsField("Position") ? doc.GetValue<string>("Position") : "Unknown";
                        string contactNumber = doc.ContainsField("ContactNumber") ? doc.GetValue<string>("ContactNumber") : "N/A";
                        string status = doc.ContainsField("Status") ? doc.GetValue<string>("Status") : "Inactive";

                        // Create and add the Employee object to the list
                        Employee readEmployee = new Employee(employeeName, employeeID, position, contactNumber, status);
                        readEmployees.Add(readEmployee);
                        Console.WriteLine("Employee Name: " + readEmployee.EmpName);
                        Console.WriteLine("Employee ID: " + readEmployee.EmpID);
                    }
                }
                Console.WriteLine("All employees retrieved successfully. Total count: " + readEmployees.Count);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error retrieving employees: " + ex.Message);
            }

            return readEmployees;
        }


        public async Task SaveEmployee(Employee employee) //public async: Asynchronous
        {
            //Collection Reference = Predefined Class
            CollectionReference collectionRef = db.Collection("employee");
            //DocReference = Row, Date in DateTime -> convert to String
            DocumentReference docRef = collectionRef.Document((DateTime.Now.Ticks.ToString()));
            //Dictionary = Data Structure (To store and ref to Firestore) [KEY, VALUE]
            Dictionary<string, object> values = new Dictionary<string, object>
            {    //key              //value
                 { "EmployeeID",    employee.EmpID.ToString() },
                 { "EmployeeName",  employee.EmpName },
                 { "Position",      employee.EmpPosition },
                 { "ContactNumber", employee.EmpContactNum },
                 { "Status",        employee.EmpStatus }
            };

            Console.WriteLine("Saving employee with ID: " + docRef.Id);
            await docRef.SetAsync(values);
            Console.WriteLine("Employee saved successfully.");
            /* Async = Asynchronous
             * Analogy: Order burger, then wait, you must do smth right?
             * Await = Wait for Cloud Access
             */
        }
    }
}