public class SecretFamilyRecipe
{
    private string _name;
    private List<string> _ingredients = new List<string>();
    private List<string> _directions = new List<string>();

    private string _password;

    public SecretFamilyRecipe(string password)
    {
        if (password == _password)
        {

            _name = "PB&J";
            _ingredients.Add("Bread");
            _ingredients.Add("Peanut Butter");
            _ingredients.Add("Jam");
            _ingredients.Add("Salt");

            _directions.Add("Lay out the Bread");
            _directions.Add("Spread Jam on bread");
            _directions.Add("Spread Peanut Butter on bread");
            _directions.Add("Sprinkle salt on both");
            _directions.Add("Put sides together");
        }
    }   

    public void Display()
    {
        Console.WriteLine("Ingredients");
        foreach (string ingredient in _ingredients)
        {
            Console.WriteLine(ingredient);
        }
         foreach (string direction in _directions)
        {
            Console.WriteLine(direction);
        }
    
    }

}