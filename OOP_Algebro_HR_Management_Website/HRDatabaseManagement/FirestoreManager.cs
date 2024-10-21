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