using EmpAppManagement;
using HRManagement;

using FirebaseAdmin;
using Google.Apis.Auth.OAuth2;
using Google.Cloud.Firestore;

namespace HRDatabaseManagement
{
    public class FirestoreManager
    {
        //Employee
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

        //ReadAllEmployees
        public async Task<List<Employee>> ReadAllEmployees()
        {
            List<Employee> readEmployees = new List<Employee>();

            //Collection Reference - Points to the "employee" collection
            CollectionReference collectionRef = db.Collection("employee");
            Console.WriteLine("-------------------------------------------------------");
            Console.WriteLine("Retrieving all employees...");
            Console.WriteLine("-------------------------------------------------------");

            //Fetch all documents in the collection
            QuerySnapshot snapshot = await collectionRef.GetSnapshotAsync();

            //Process each document in the snapshot
            foreach (DocumentSnapshot doc in snapshot.Documents)
            {
                if (doc.Exists)
                {
                    //Safely retrieve each field and handle missing or null values
                    string employeeName = doc.ContainsField("EmployeeName") ? doc.GetValue<string>("EmployeeName") : "Unknown";
                    string employeeIDStr = doc.ContainsField("EmployeeID") ? doc.GetValue<string>("EmployeeID") : "0";

                    //Convert EmployeeID from string to int
                    int employeeID = int.TryParse(employeeIDStr, out int idValue) ? idValue : 0;

                    string position = doc.ContainsField("Position") ? doc.GetValue<string>("Position") : "Unknown";
                    string contactNumber = doc.ContainsField("ContactNumber") ? doc.GetValue<string>("ContactNumber") : "N/A";
                    string status = doc.ContainsField("Status") ? doc.GetValue<string>("Status") : "Inactive";

                    //Create and add the Employee object to the list
                    Employee readEmployee = new Employee(employeeName, employeeID, position, contactNumber, status);
                    readEmployees.Add(readEmployee);
                    Console.WriteLine("Employee Name: " + readEmployee.EmpName);
                    Console.WriteLine("Employee ID: " + readEmployee.EmpID);
                    Console.WriteLine("-------------------------------------------------------");
                }
            }
            Console.WriteLine("All employees retrieved successfully. Total count: " + readEmployees.Count);
            return readEmployees;
        }

        //SaveEmployee
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

        //RemoveEmployee
        public async Task RemoveEmployee(string data)
        {
            CollectionReference collectionRef = db.Collection("employee");
            QuerySnapshot snapshot = await collectionRef.GetSnapshotAsync();

            // Process each document in the snapshot
            foreach (DocumentSnapshot doc in snapshot.Documents)
            {
                if (doc.Exists)
                {
                    string employeeIDStr = doc.ContainsField("EmployeeID") ? doc.GetValue<string>("EmployeeID") : "0";
                    if (employeeIDStr == data)
                    {
                        Console.WriteLine("Removing employee with ID: " + data);
                        await doc.Reference.DeleteAsync();
                        break;
                    }
                }
            }
        }

        //Applicant
        public ApplicantList applicantList { get; set; }

        //ReadAllApplicants
        public async Task<List<Applicant>> ReadAllApplicants()
        {
            List<Applicant> readApplicants = new List<Applicant>();

            //Collection Reference - Points to the "employee" collection
            CollectionReference collectionRef = db.Collection("applicant");
            Console.WriteLine("-------------------------------------------------------");
            Console.WriteLine("Retrieving all applicants...");
            Console.WriteLine("-------------------------------------------------------");

            //Fetch all documents in the collection
            QuerySnapshot snapshot = await collectionRef.GetSnapshotAsync();

            //Process each document in the snapshot
            foreach (DocumentSnapshot doc in snapshot.Documents)
            {
                if (doc.Exists)
                {
                    //Safely retrieve each field and handle missing or null values
                    string applicantName = doc.ContainsField("ApplicantName") ? doc.GetValue<string>("ApplicantName") : "Unknown";
                    string applicantContactNum = doc.ContainsField("ApplicantContactNum") ? doc.GetValue<string>("ApplicantContactNum") : "N/A";

                    // Convert ApplicantID from string to int (if applicable)
                    int applicantTempID = doc.ContainsField("ApplicantID") && int.TryParse(doc.GetValue<string>("ApplicantID"), out int tempID) ? tempID : 0;

                    string role = doc.ContainsField("Role") ? doc.GetValue<string>("Role") : "Unknown";

                    // Handle InterviewDate as a DateTime, default to DateTime.MinValue if missing
                    DateTime interviewDate = doc.ContainsField("InterviewDate") ? doc.GetValue<DateTime>("InterviewDate") : DateTime.MinValue;

                    // Create and add the Applicant object to the list
                    Applicant readApplicant = new Applicant(applicantName, applicantContactNum, role, interviewDate, applicantTempID);
                    readApplicants.Add(readApplicant);

                    // Log the Applicant details
                    Console.WriteLine("Applicant Name: " + readApplicant.AppName);
                    Console.WriteLine("Applicant ID: " + readApplicant.AppTempID);
                    Console.WriteLine("Applicant Contact Number: " + readApplicant.AppContactNum);
                    Console.WriteLine("Role: " + readApplicant.AppRole);
                    Console.WriteLine("Interview Date: " + (interviewDate != DateTime.MinValue ? interviewDate.ToString("yyyy-MM-dd") : "N/A"));
                    Console.WriteLine("-------------------------------------------------------");
                }
            }

            Console.WriteLine("All applicants retrieved successfully. Total count: " + readApplicants.Count);
            return readApplicants;
        }

        //SaveApplicant
        public async Task SaveApplicant(Applicant applicant)
        {
            //Collection Reference = Predefined Class
            CollectionReference collectionRef = db.Collection("applicant");
            //DocReference = Row, Date in DateTime -> convert to String
            DocumentReference docRef = collectionRef.Document((DateTime.Now.Ticks.ToString()));
            //Dictionary = Data Structure (To store and ref to Firestore) [KEY, VALUE]
            Dictionary<string, object> values = new Dictionary<string, object>
            {    //key              //value
                 { "ApplicantID",         applicant.AppTempID.ToString() },
                 { "ApplicantName",       applicant.AppName },
                 { "ApplicantContactNum", applicant.AppContactNum },
                 { "Role",                applicant.AppRole },
                 { "InterviewDate",       applicant.IvDate }
            };

            Console.WriteLine("Saving applicant with ID: " + docRef.Id);
            await docRef.SetAsync(values);
            Console.WriteLine("Applicant saved successfully.");
        }

        //RemoveApplicant
        public async Task RemoveApplicant(string data)
        {
            CollectionReference collectionRef = db.Collection("applicant");
            QuerySnapshot snapshot = await collectionRef.GetSnapshotAsync();
            // Process each document in the snapshot
            foreach (DocumentSnapshot doc in snapshot.Documents)
            {
                if (doc.Exists)
                {
                    string applicantIDStr = doc.ContainsField("ApplicantID") ? doc.GetValue<string>("ApplicantID") : "0";
                    if (applicantIDStr == data)
                    {
                        Console.WriteLine("Removing applicant with ID: " + data);
                        await doc.Reference.DeleteAsync();
                        break;
                    }
                }
            }
        }
    }
}