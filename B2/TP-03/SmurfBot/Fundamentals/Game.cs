namespace SmurfBot.Fundamentals;

public class Game
{

    public static bool Action(string action, Smurf smurf, Gargamel gargamel, Inventory inventory)
    {
        switch (action)
        {
            case "H":
                smurf.AddSmurfHP(10);
                return true;
            case "A1":
                if (smurf.Alchemy >= 1)
                {
                    inventory.AddPotion(1);
                    return true;
                }
                return false;
            case "A2":
                if (smurf.Alchemy >= 2)
                {
                    inventory.AddPotion(2);
                    return true;
                }
                return false;
            case "A3":
                if (smurf.Alchemy >= 3)
                {
                    inventory.AddPotion(3);
                    return true;
                }
                return false;
            case "S0":
                gargamel.Hp -= smurf.Strength;
                return true;
            case "S1":
                if (inventory.UsePotion(1))
                {
                    smurf.AddSmurfHP(15);
                    return true;
                }
                return false;
            case "S2":
                if (inventory.UsePotion(2))
                {
                    smurf.AddSmurfStrength(1);
                    return true;
                }
                return false;
            case "S3":
                if (inventory.UsePotion(3))
                {
                    gargamel.Hp -= smurf.Strength * 3;
                    return true;
                }
                return false;
            default:
                return false;
        }
    }


    public static string DisplayRoundSmurf(int round, Smurf smurf, Inventory inventory)
    {
        return "Round " + round + "\n" + inventory.DisplayInfo() + smurf.DisplayInfo();
    }


    public static bool GargamelAttack(Smurf smurf, Gargamel gargamel)
    {
        smurf.AddSmurfHP(-gargamel.Attack);

        if (smurf.Hp <= 0)
            return false;
        
        return true;
    }


    public static string DisplayWin(Smurf smurf, Gargamel gargamel)
    {
        if (gargamel.Hp <= 0 && smurf.Hp > 0)
        {
            return "The smurfs won!";
        }
        else if (gargamel.Hp > 0 && smurf.Hp <= 0)
        {
            return "Gargamel won!";
        }
        else
        {
            return "Still fighting.";
        }
    }

    public static void Run(Smurf smurf, Gargamel gargamel, Inventory potionList)
    {
        int tour = 0;

        while (smurf.Hp > 0)
        {
            // First display the smurf
            Console.Write(gargamel.DisplayInfo());
            Console.Write(DisplayRoundSmurf(tour, smurf, potionList));
      
            // Wait for the user input, assuming the input is valid
            string? input = Console.ReadLine();

            if (input == null)
                continue;

            // Execute this input and if the input is not valid, read a new input
            bool isActionExec = Action(input, smurf, gargamel, potionList);

            while (!isActionExec)
            {
                input = Console.ReadLine();

                if (input == null)
                    continue;

                isActionExec = Action(input, smurf, gargamel, potionList);
            }

            // check if Gargamel still have life
            if (gargamel.Hp <= 0)
                break;
      
            GargamelAttack(smurf, gargamel);
      
            tour++;
        }
        Console.WriteLine(DisplayWin(smurf, gargamel));
    }
}