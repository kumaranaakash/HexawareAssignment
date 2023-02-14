using System;
using System.Linq;


namespace InsurancePolicy
    
    
    
internal class program
{
    private string consumerName;
    private int age;
    private int creditHistory;
    private string[] documents;
    private string insuranceId;
    private static int counter;

    // This is a static constructor that initializes the 'counter' variable to 1000
    
    static Insurance()
    {
        counter = 1000;
    }

    // This is a parameterless constructor that initializes 'age' and 'creditHistory' to 0
    
    public Insurance()
    {
        age = 0;
        creditHistory = 0;
    }

    // This is a constructor that takes only the 'consumerName' parameter and calls the parameterless constructor to initialize 'age' and 'creditHistory'
    
    public Insurance(string consumerName) : this()
    {
        this.consumerName = consumerName;
    }

    // This is a constructor that takes both 'consumerName' and 'documents' parameters and calls the previous constructor to initialize 'age' and 'creditHistory'
    
    public Insurance(string consumerName, string[] documents) : this(consumerName)
    {
        this.documents = documents;
    }

    // This is a constructor that takes all four parameters and initializes all of the member variables
    
    public Insurance(string consumerName, int age, int creditHistory, string[] documents)
    {
        this.consumerName = consumerName;
        this.age = age;
        this.creditHistory = creditHistory;
        this.documents = documents;
    }

    // This method checks if the consumer is eligible to apply for insurance based on the specified conditions
    
    public bool CheckEligibility()
    {
        if (age < 18)
        {
            return false;
        }
        else if (age <= 30 && creditHistory <= 60000)
        {
            return true;
        }
        else if (age > 30 && creditHistory <= 45000)
        {
            return true;
        }
        else
        {
            return false;
        }
    }

    // This method checks the documents submitted by the consumer against the specified set of 'acceptableDocuments'
    // It also calls CheckEligibility to check if the consumer is eligible for applying for insurance
    // If the consumer is eligible and at least one of the documents matches with the acceptable documents, it generates an insurance ID and returns true
    
    
    public bool CheckDocuments(string[] acceptableDocuments)
    {
        bool eligible = CheckEligibility();
        if (eligible)
        {
            foreach (string doc in documents)
            {
                if (acceptableDocuments.Contains(doc))
                {
                    insuranceId = "I" + counter.ToString();
                    counter++;
                    return true;
                }
            }
        }
        return false;
    }
}
