namespace Assignment2;

public class Queries
{
    public static IEnumerable<string> Get_All_Wizards_Name_By_Rowling_With_Linq() 
    {
        var collection = WizardCollection.Create();
        var wizardsOutput = from w in collection
                            where w.Creator.Contains("Rowling")
                            select w.Name;
        return wizardsOutput;
    }

    public static IEnumerable<string> Get_All_Wizards_By_Rowling_With_Extensions() 
    {
        var wizardCollection = WizardCollection.Create();
        var wizardsOutput = wizardCollection.Where(w => w.Creator.Contains("Rowling")).Select(w => w.Name);
        return wizardsOutput;
    }

    public static int Get_First_Year_Of_Sith_Linq() 
    {
        var wizardCollection = WizardCollection.Create();
        var output =    from w in wizardCollection
                        where w.Name.StartsWith("Darth")
                        select w.Year;
        int min = (int) output.Min()!;
        return min;
    }

    public static int? Get_First_Year_Of_Sith_Extensions() 
    {
        var wizardCollection = WizardCollection.Create();
        int? min = (int) wizardCollection.Where(w => w.Name.StartsWith("Darth")).Select(w => w.Year).Min()!;
        return min;
    }

    public static IEnumerable<(string, int?)> Get_Harry_Potter_Tuples_Linq() 
    {
        var wizardCollection = WizardCollection.Create();
        var wizardsFromHarryPotter =    from w in wizardCollection
                                        where w.Medium.StartsWith("Harry Potter")
                                        select (w.Name, w.Year);
        return wizardsFromHarryPotter;
    }

    public static IEnumerable<(string, int?)> Get_Harry_Potter_Tuples_Extensions() 
    {
        var wizardCollection = WizardCollection.Create();
        var wizardsFromHarryPotter = wizardCollection.Where(w => w.Medium.StartsWith("Harry Potter")).Select(w => (w.Name, w.Year));
        return wizardsFromHarryPotter;
    }

    public static IEnumerable<string> Get_Wizards_Grouped_By_Creator_Reverse_Order_Linq() 
    {
        var wizardCollection = WizardCollection.Create();

        var wizardsOutput = from w in wizardCollection
                            orderby w.Creator descending, w.Name ascending
                            group w.Name by w.Creator into h
                            select h;
        
        return wizardsOutput.SelectMany(w => w);
    }

    public static IEnumerable<string> Get_Wizards_Grouped_By_Creator_Reverse_Order_Extensions() 
    {
        var wizardCollection = WizardCollection.Create();

        var wizardsOutput = wizardCollection.OrderByDescending(w => w.Creator).ThenBy(w => w.Name).GroupBy(w => w.Creator).SelectMany(w => w).Select(w => w.Name);
        return wizardsOutput;
    }
    
}
