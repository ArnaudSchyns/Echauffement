namespace Echauffement;

class Program
{
    static void Main(string[] args)
    {
        /*
         * Consigne générale : faites un commit entre chaque étape !
         */
        // Etape 1 : présentez-vous en écrivant votre prénom et votre jeu préféré
        Console.WriteLine("Je m'appelle Arnaud et mon jeu préféré est Valorant");
        // Etape 2 : demandez à l'utilisateur son prénom et son âge
        Console.WriteLine("Quel est ton prénom ?");
        string prenom = Console.ReadLine();
        Console.WriteLine("Quel est ton âge ?");
        int age = Convert.ToInt32(Console.ReadLine());

        // Etape 3 : affichez soit "Tu es majeur", soit "Tu es mineur" dépendant de l'âge fourni par l'utilisateur
        if (age >= 18)
        {
            Console.WriteLine("Tu es majeur");
        }
        else
        {
            Console.WriteLine("Tu es mineur");
        }
        // Etape 4 : demandez maintenant à l'utilisateur combien d'euro il a (nombre décimal)
        Console.WriteLine("Combien d'euro as-tu ?");
        int euro = Convert.ToInt32(Console.ReadLine());
        // Etape 5 : affichez maintenant 4 choix d'armes avec chacune un prix
        string arme1 = "couteau";
        string arme2 = "épée";
        string arme3 = "fusil";
        string arme4 = "missile";
        int prix1 = (100);
        int prix2 = (25);
        int prix3 = (50);
        int prix4 = (75);
        Console.WriteLine("Voici 4 armes, laquelle veux-tu ?\n" + arme1  + " " + prix1 );
        Console.WriteLine( arme2 + " " + prix2);
        Console.WriteLine( arme3 + " " + prix3);
        Console.WriteLine( arme4 + " " + prix4);
        // Etape 6 : laissez l'utilisateur choisir l'une de ces 4 armes en indiquant un nombre entre 1 et 4
        Console.WriteLine("Quelle arme veux-tu ? ( choisis entre 1 et 4 )");
        int choix = Convert.ToInt32(Console.ReadLine());
        {
            if (choix == 1)
            {
                Console.WriteLine("Tu as choisi le couteau");
            }
            else if (choix == 2)
            {
                Console.WriteLine("Tu as choisi l'épée");
            }
            else if (choix == 3)
            {
                Console.WriteLine("Tu as choisi le fusil");
            }
            else if (choix == 4)
            {
                Console.WriteLine("Tu as choisi le missile");
            }
        }
        // Etape 7a : vérifiez si l'utilisateur a assez d'argent par rapport à la somme qu'il avait rentré à l'étape 4
        {
            if (choix == 1)
                if (euro < prix1)
                {
                    Console.WriteLine("Tu n'as pas assez d'argent");
                }
                else if (euro >= prix1)
                if (age < 18)
                {
                    Console.WriteLine("Tu n'es pas majeur, tu ne peux pas acheter cette arme");
                }
                else if (age >= 18)
                {
                    Console.WriteLine("Tu as acheté le couteau");
                    Console.WriteLine("argent restant : " + (euro - prix1));
                }
            if (choix == 2)
                if (euro < prix2)
                {
                    Console.WriteLine("Tu n'as pas assez d'argent");
                }
                else if (euro >= prix2)
                if (age < 18)
                {
                    Console.WriteLine("Tu n'es pas majeur, tu ne peux pas acheter cette arme");
                }
                else if (age >= 18)
                {
                    Console.WriteLine("Tu as acheté l'épée");
                    Console.WriteLine("argent restant : " + (euro - prix2));
                }
            if (choix == 3)
                if (euro < prix3)
                {
                    Console.WriteLine("Tu n'as pas assez d'argent");
                }
                else if (euro >= prix3)
                if (age < 18)
                {
                    Console.WriteLine("Tu n'es pas majeur, tu ne peux pas acheter cette arme");
                }
                else if (age >= 18)
                {
                    Console.WriteLine("Tu as acheté le fusil");
                    Console.WriteLine("argent restant : " + (euro - prix3));
                }
            if (choix == 4)
                if (euro < prix4)
                {
                    Console.WriteLine("Tu n'as pas assez d'argent");
                }
                else if (euro >= prix4)
                if (age < 18)
                {
                    Console.WriteLine("Tu n'es pas majeur, tu ne peux pas acheter cette arme");
                }
                else if (age >= 18)
                {
                    Console.WriteLine("Tu as acheté le missile");
                    Console.WriteLine("argent restant : " + (euro - prix4));
                }
        }
        // Etape 7b : modifiez l'étape 7a pour ajouter un connecteur logique qui vérifie que l'utilisateur est majeur en plus d'avoir assez d'argent
        // Lorsque l'utilisateur respecte ces demandes, retirez le prix de l'arme de l'argent de l'utilisateur, puis confirmez à l'utilisateur que l'action a été effectuée
        // Dans tous les autres cas, informez l'utilisateur que l'action n'a pas été possible
        /*
         * Après votre dernier commit, faites un push de votre projet pour qu'il soit accessible sur github.com
         */
    }
}    