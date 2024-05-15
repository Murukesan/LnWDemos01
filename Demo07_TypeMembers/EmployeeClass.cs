namespace Demo07_TypeMembers
{
    public class EmployeeClass
    {

        #region Data Fields

        // DATA FIELD 
        // - Noun
        // - Attribute / Quality
        // - Can be passed by reference.
        // - Purpose: To store data.
        public int EmployeeId;

        // public string EmployeeName;

        #endregion

        #region Example showing Encapsulation using Methods

        // DATA FIELD - BACKING FIELD 
        private string _EmployeeName;

        // METHOD
        // - Verb
        // - Purpose: alter the attributes of the type
        // - Benefit: encapsulation (1...5)
        public string GetEmployeeName()
        {
            Console.WriteLine("\t 1. Authentication");
            Console.WriteLine("\t 2. Authorization");
            Console.WriteLine("\t 3. Validation");
            Console.WriteLine("\t 4. Activity / Process ");
            Console.WriteLine("\t 5. Audit Logging ");
            return _EmployeeName;
        }

        // METHOD
        public void SetEmployeeName(string? name)
        {
            Console.WriteLine("\t 1. Authentication");
            Console.WriteLine("\t 2. Authorization");
            Console.WriteLine("\t 3. Validation");
            // if (name != null && name != "")
            // if(name is not null && name != string.Empty) 
            if (! string.IsNullOrEmpty(name))
            {
                Console.WriteLine("\t 4. Activity / Process ");
                _EmployeeName = name;
            }
            Console.WriteLine("\t 5. Audit Logging ");
        }

        #endregion



        #region Demo of Property demonstrating Encapsulation

        //private string _Designation;                    // DATA FIELD - BACKING FIELD 
        //public string GetDesignation()                  // METHOD
        //{
        //    // 1. 2. 3. 4. 5.
        //    return _Designation;
        //}
        //public void SetDesignation(string value)  // METHOD
        //{
        //    // 1. 2. 3. 4. 5.
        //    _Designation = value;
        //}

        private string _Designation;                    // DATA FIELD - BACKING FIELD 

        // PROPERTY
        // - Noun
        // - Does not store data.
        // - Cannot be passed by reference.
        // - Purpose: Offers Encapsulation & Simplicity
        public string Designation
        {
            get                  // PROPERTY ACCESSOR
            {
                // 1. 2. 3. 4. 5.
                return _Designation;
            }
            set                 // PROPERTY ACCESSOR
            {
                // 1. 2. 3. 4. 5.
                _Designation = value;
            }
        }

        #endregion
    }
}
