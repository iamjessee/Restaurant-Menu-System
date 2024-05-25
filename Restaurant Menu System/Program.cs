class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello, Welcome to Bullard's Bussin' Burritos.");
        Console.WriteLine("Please use the numbers provided when making a selection.");

        //list to store add-on choices
        List<string> allAddonChoices = new List<string>();

        // list to store burrito choices
        List<string> burritoChoices = new List<string>();

        // stored local variables
        int tortillaChoice = 0;
        int proteinChoice = 0;
        int addProteinChoice = 0;
        int riceChoice = 0;
        int beanChoice = 0;
        int addonChoice = 0;
        decimal cost = 0.00m;
        bool validChoice = false;

        // prompts user to enter their tortilla choice
        do
        {
            Console.WriteLine("\nTORTILLA CHOICE: 1. FLOUR 2. CORN 3. SPICY CAYENNE ");
            string tortillaInput = Console.ReadLine();
            tortillaChoice = Convert.ToInt32(tortillaInput);

            switch (tortillaChoice)
            {
                case 1:
                    Console.WriteLine("You have chosen a Flour tortilla. ");
                    burritoChoices.Add("Flour Tortilla");
                    validChoice = true;
                    break;

                case 2:
                    Console.WriteLine("You have chosen a Corn tortilla. ");
                    burritoChoices.Add("Corn Tortilla");
                    validChoice = true;
                    break;

                case 3:
                    Console.WriteLine("You have chosen a Spicy Cayenne tortilla");
                    burritoChoices.Add("Spicy Cayenne Tortilla");
                    validChoice = true;
                    break;

                default:
                    Console.WriteLine("Please select a choice using 1, 2, or 3");
                    continue;
            }

        } while (!validChoice);

        // resets choice to break out loop
        validChoice = false;

        // prompts user to enter their choice of protein
        do
        {
            Console.WriteLine("\nPROTEIN CHOICE: 1. STEAK $12.99 2. PORK $12.99 3. CHICKEN $9.99 4. CHORIZO $13.99");
            string proteinInput = Console.ReadLine();
            proteinChoice = Convert.ToInt32(proteinInput);

            switch (proteinChoice)
            {
                case 1:

                    cost += 12.99m;
                    Console.WriteLine($"You have chosen Steak. Your new total is: ${cost}");
                    burritoChoices.Add("Steak");
                    validChoice = true;
                    break;

                case 2:

                    cost += 12.99m;
                    Console.WriteLine($"You have chosen Pork. Your new total is: ${cost}");
                    burritoChoices.Add("Pork");
                    validChoice = true;
                    break;

                case 3:

                    cost += 9.99m;
                    Console.WriteLine($"You have chosen Chicken Your new total is: ${cost}");
                    burritoChoices.Add("Chicken");
                    validChoice = true;
                    break;
                
                case 4:

                    cost += 13.99m;
                    Console.WriteLine($"You have chosen Chorizo. Your new total is: ${cost}");
                    burritoChoices.Add("Chorizo");
                    validChoice = true;
                    break;

                default:
                    Console.WriteLine("Please select a choice using 1, 2, 3 or 4");
                    continue;
            }

        } while (!validChoice);

        // resets choice to break out loop
        validChoice = false;

        // prompts user for it they would like to double their protein choice and adds extra cost
        while (!validChoice )
        {

            Console.WriteLine("\nWould you like to double your protein for $1.99 (Y/N)?");
            string userResponse = Console.ReadLine();

            if (userResponse.ToUpper() == "Y")
            {
                cost += 1.99m;
                Console.WriteLine($"You have chosen double protein. Your new total is: ${cost}");
                break;
            }
            else if (userResponse.ToUpper() == "N")
            {
               validChoice = true;
            }
        }

        // prompts user for their rice choice
        do
        {
            Console.WriteLine("\nRICE: 1. SPANISH RICE 2. CILANTRO LIME RICE 3. BROWN RICE");
            string riceInput = Console.ReadLine();
            riceChoice = Convert.ToInt32(riceInput);

            switch (riceChoice)
            {
                case 1:
                    Console.WriteLine($"You have chosen Spanish Rice.");
                    burritoChoices.Add("Spanish Rice");
                    validChoice = true;
                    break;

                case 2:
                    Console.WriteLine($"You have chosen Cilantro Lime Rice.");
                    burritoChoices.Add("Cilantro Lime Rice");
                    validChoice = true;
                    break;

                case 3:
                    Console.WriteLine($"You have chosen Brown Rice");
                    burritoChoices.Add("Brown Rice");
                    validChoice = true;
                    break;

                default:
                    Console.WriteLine("Please select a choice using 1, 2, or 3");
                    continue;
            }

        } while (!validChoice);

        // resets choice to break out loop
        validChoice = false;

        // prompts user for their choice of beans 
        do
        {
            Console.WriteLine("\nBEANS: 1. BlACK BEANS 2. PINTO BEANS RICE 3. REFRIED BEANS");
            string beanInput = Console.ReadLine();
            beanChoice = Convert.ToInt32(beanInput);

            switch (beanChoice)
            {
                case 1:
                    Console.WriteLine($"You have chosen Black Beans.");
                    burritoChoices.Add("Black Beans");
                    validChoice = true;
                    break;

                case 2:
                    Console.WriteLine($"You have chosen Pinto Beans.");
                    burritoChoices.Add("Pinto Beans");
                    validChoice = true;
                    break;

                case 3:
                    Console.WriteLine($"You have chosen Refried Beans");
                    burritoChoices.Add("Refried Beans");
                    validChoice = true;
                    break;

                default:
                    Console.WriteLine("Please select a choice using 1, 2, or 3");
                    continue;
            }

        } while (!validChoice);

        // resets choice to break out loop
        validChoice = false;

        // prompts user for their choice of add-ons 
        do
        {
            Console.WriteLine("\nADD-ONS: 1. GRILLED CORN SALSA 2. LETTUCE 3. ONIONS 4. SOUR CREAM 5. POTATOES 6. CHESSE");
            string addonInput = Console.ReadLine();
            addonChoice = Convert.ToInt32(addonInput);

            switch (addonChoice)
            {
                case 1:
                    Console.WriteLine($"You have chosen Grilled Corn Salsa.");
                    allAddonChoices.Add("Corn Salsa");
                    validChoice = true;
                    break;

                case 2:
                    Console.WriteLine($"You have chosen Lettuce.");
                    allAddonChoices.Add("Lettuce");
                    validChoice = true;
                    break;

                case 3:
                    Console.WriteLine($"You have chosen Onions");
                    allAddonChoices.Add("Onions");
                    validChoice = true;
                    break;

                case 4:
                    Console.WriteLine($"You have chosen Sour Cream");
                    allAddonChoices.Add("Sour Cream");
                    validChoice = true;
                    break;

                case 5:
                    Console.WriteLine($"You have chosen Potatoes");
                    allAddonChoices.Add("Potatoes");
                    validChoice = true;
                    break;

                case 6:
                    Console.WriteLine($"You have chosen Cheese");
                    allAddonChoices.Add("Cheese");
                    validChoice = true;
                    break;

                default:
                    Console.WriteLine("Please select a choice using 1, 2, or 3");
                    continue;
            }
 
            Console.WriteLine("Would you like to pick another add-on?");
            string userResponse = Console.ReadLine();

            if (userResponse.ToUpper() == "Y")
            {
                // Reset validChoice to allow for another add-on selection
                validChoice = false;
            }
            else if (userResponse.ToUpper() == "N")
            {
                validChoice=true;
            }

        } while (!validChoice);

        // resets choice to break out loop
        validChoice = false;

        // outputs users order and total
        Console.WriteLine($"Your order it complete, you have chosen a {burritoChoices[0]} with {burritoChoices[1]}, {burritoChoices[2]}, and {burritoChoices[3]}.");
        Console.Write("With the add-on choices of: ");

        // loops through add-ons list to show all user choices 
        for (int i = 0; i < allAddonChoices.Count; i++)
        {
            Console.Write($" {allAddonChoices[i]} ");
        }
    }
}