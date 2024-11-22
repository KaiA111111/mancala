namespace mancala
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string turn = "bottom";
            int bboard1 = 4;
            int bboard2 = 4;
            int bboard3 = 4;
            int bboard4 = 4;
            int bboard5 = 4;
            int bboard6 = 4;
            int tboard1 = 4;
            int tboard2 = 4;
            int tboard3 = 4;
            int tboard4 = 4;
            int tboard5 = 4;
            int tboard6 = 4;
            int lgoal = 0;
            int rgoal = 0;
            bool done = false;

            while (true)
            {

                while (done != true)
                {
                    if (lgoal < 10 && rgoal < 10)
                    {
                        Console.Clear();
                        Console.WriteLine(" ---------------------------------------------------------------------------------------------  ");
                        Console.WriteLine("| ---  ----------    ----------     ----------    ----------    ----------     ----------  --- |");
                        Console.WriteLine("||   ||          |  |          |   |          |  |          |  |          |   |          ||   ||");
                        Console.WriteLine("||   ||  {0,2}      |  |   {1,2}     |   |   {2,2}     |  |   {3,2}     |  |   {4,2}     |   |   {5,2}     ||   ||", tboard6, tboard5, tboard4, tboard3, tboard2, tboard1);
                        Console.WriteLine("||   ||          |  |          |   |          |  |          |  |          |   |          ||   ||");
                        Console.WriteLine("||   | ----------    ----------     ----------    ----------    ----------     ---------- |   ||");
                        Console.WriteLine("||   |     6              5              4             3            2              1      |   ||");
                        Console.WriteLine("||   |                                                                                    |   ||");
                        Console.WriteLine("||{0,2} |                                                                                    |{1,2} ||", lgoal, rgoal);
                        Console.WriteLine("||   |                                                                                    |   ||");
                        Console.WriteLine("||   |     1              2              3             4            5              6      |   ||");
                        Console.WriteLine("||   | ----------    ----------     ----------    ----------    ----------     ---------- |   ||");
                        Console.WriteLine("||   ||          |  |          |   |          |  |          |  |          |   |          ||   ||");
                        Console.WriteLine("||   ||  {0,2}      |  |   {1,2}     |   |   {2,2}     |  |   {3,2}     |  |   {4,2}     |   |   {5,2}     ||   ||", bboard1, bboard2, bboard3, bboard4, bboard5, bboard6);
                        Console.WriteLine("||   ||          |  |          |   |          |  |          |  |          |   |          ||   ||");
                        Console.WriteLine("| ---  ----------    ----------     ----------    ----------    ----------     ----------  --- |");
                        Console.WriteLine(" ---------------------------------------------------------------------------------------------  ");
                        Console.WriteLine("Turn: " + turn);
                    }
                    
                    // game end sequence

                    if (bboard1 == 0 && bboard2 == 0 && bboard3 == 0 && bboard4 == 0 && bboard5 == 0 && bboard6 == 0 &&
                        tboard1 == 0 && tboard2 == 0 && tboard3 == 0 && tboard4 == 0 && tboard5 == 0 && tboard6 == 0 && done != true)
                    {
                        if (lgoal < rgoal)
                        {
                            Console.WriteLine("bottom wins!");
                        }
                        else if (lgoal == rgoal)
                        {
                            Console.WriteLine("you tied!");
                        }
                        else
                        {
                            Console.WriteLine("top wins!");
                        }
                        done = true;
                        break;
                    }
                    string poolchoice = Console.ReadLine();


                    //bboard logic


                    if (turn == "bottom")
                    {
                        if (poolchoice == "1")
                        {
                            if (bboard1 == 1) bboard2++;
                            if (bboard1 == 2) { bboard2++; bboard3++; }
                            if (bboard1 == 3) { bboard2++; bboard3++; bboard4++; }
                            if (bboard1 == 4) { bboard2++; bboard3++; bboard4++; bboard5++; }
                            if (bboard1 == 5) { bboard2++; bboard3++; bboard4++; bboard5++; bboard6++; }
                            if (bboard1 == 6) { bboard2++; bboard3++; bboard4++; bboard5++; bboard6++; rgoal++; turn = "bottom"; poolchoice = "0"; bboard1 = 0; break; }
                            if (bboard1 == 7) { bboard2++; bboard3++; bboard4++; bboard5++; bboard6++; rgoal++; tboard1++; }
                            if (bboard1 == 8) { bboard2++; bboard3++; bboard4++; bboard5++; bboard6++; rgoal++; tboard1++; tboard2++; }
                            if (bboard1 == 9) { bboard2++; bboard3++; bboard4++; bboard5++; bboard6++; rgoal++; tboard1++; tboard2++; tboard3++; }
                            if (bboard1 == 10) { bboard2++; bboard3++; bboard4++; bboard5++; bboard6++; rgoal++; tboard1++; tboard2++; tboard3++; tboard4++; }
                            bboard1 = 0;
                            turn = "top";
                            poolchoice = "0";
                        }
                        if (poolchoice == "2")
                        {
                            if (bboard2 == 1) bboard3++;
                            if (bboard2 == 2) { bboard3++; bboard4++; }
                            if (bboard2 == 3) { bboard3++; bboard4++; bboard5++; }
                            if (bboard2 == 4) { bboard3++; bboard4++; bboard5++; bboard6++; }
                            if (bboard2 == 5) { bboard3++; bboard4++; bboard5++; bboard6++; rgoal++; turn = "bottom"; poolchoice = "0"; bboard2 = 0; break; }
                            if (bboard2 == 6) { bboard3++; bboard4++; bboard5++; bboard6++; rgoal++; tboard1++; }
                            if (bboard2 == 7) { bboard3++; bboard4++; bboard5++; bboard6++; rgoal++; tboard1++; tboard2++; }
                            if (bboard2 == 8) { bboard3++; bboard4++; bboard5++; bboard6++; rgoal++; tboard1++; tboard2++; tboard3++; }
                            if (bboard2 == 9) { bboard3++; bboard4++; bboard5++; bboard6++; rgoal++; tboard1++; tboard2++; tboard3++; tboard4++; }
                            if (bboard2 == 10) { bboard3++; bboard4++; bboard5++; bboard6++; rgoal++; tboard1++; tboard2++; tboard3++; tboard4++; tboard5++; }
                            bboard2 = 0;
                            turn = "top";
                            poolchoice = "0";
                        }
                        if (poolchoice == "3")
                        {
                            if (bboard3 == 1) bboard4++;
                            if (bboard3 == 2) { bboard4++; bboard5++; }
                            if (bboard3 == 3) { bboard4++; bboard5++; bboard6++; }
                            if (bboard3 == 4) { bboard4++; bboard5++; bboard6++; rgoal++; turn = "bottom"; poolchoice = "0"; bboard3 = 0; break; }
                            if (bboard3 == 5) { bboard4++; bboard5++; bboard6++; rgoal++; tboard1++; }
                            if (bboard3 == 6) { bboard4++; bboard5++; bboard6++; rgoal++; tboard1++; tboard2++; }
                            if (bboard3 == 7) { bboard4++; bboard5++; bboard6++; rgoal++; tboard1++; tboard2++; tboard3++; }
                            if (bboard3 == 8) { bboard4++; bboard5++; bboard6++; rgoal++; tboard1++; tboard2++; tboard3++; tboard4++; }
                            if (bboard3 == 9) { bboard4++; bboard5++; bboard6++; rgoal++; tboard1++; tboard2++; tboard3++; tboard4++; tboard5++; }
                            if (bboard3 == 10) { bboard4++; bboard5++; bboard6++; rgoal++; tboard1++; tboard2++; tboard3++; tboard4++; tboard5++; tboard6++; }
                            bboard3 = 0;
                            turn = "top";
                            poolchoice = "0";
                        }
                        if (poolchoice == "4")
                        {
                            if (bboard4 == 1) bboard5++;
                            if (bboard4 == 2) { bboard5++; bboard6++; }
                            if (bboard4 == 3) { bboard5++; bboard6++; rgoal++; turn = "bottom"; poolchoice = "0"; bboard4 = 0; break; }
                            if (bboard4 == 4) { bboard5++; bboard6++; rgoal++; tboard1++; }
                            if (bboard4 == 5) { bboard5++; bboard6++; rgoal++; tboard1++; tboard2++; }
                            if (bboard4 == 6) { bboard5++; bboard6++; rgoal++; tboard1++; tboard2++; tboard3++; }
                            if (bboard4 == 7) { bboard5++; bboard6++; rgoal++; tboard1++; tboard2++; tboard3++; tboard4++; }
                            if (bboard4 == 8) { bboard5++; bboard6++; rgoal++; tboard1++; tboard2++; tboard3++; tboard4++; tboard5++; }
                            if (bboard4 == 9) { bboard5++; bboard6++; rgoal++; tboard1++; tboard2++; tboard3++; tboard4++; tboard5++; tboard6++; }
                            if (bboard4 == 10) { bboard5++; bboard6++; rgoal++; tboard1++; tboard2++; tboard3++; tboard4++; tboard5++; tboard6++; tboard1++; }
                            bboard4 = 0;
                            turn = "top";
                            poolchoice = "0";
                        }
                        if (poolchoice == "5")
                        {
                            if (bboard5 == 1) bboard6++;
                            if (bboard5 == 2) { bboard6++; rgoal++; turn = "bottom"; poolchoice = "0"; bboard5 = 0; break; }
                            if (bboard5 == 3) { bboard6++; rgoal++; tboard1++; }
                            if (bboard5 == 4) { bboard6++; rgoal++; tboard1++; tboard2++; }
                            if (bboard5 == 5) { bboard6++; rgoal++; tboard1++; tboard2++; tboard3++; }
                            if (bboard5 == 6) { bboard6++; rgoal++; tboard1++; tboard2++; tboard3++; tboard4++; }
                            if (bboard5 == 7) { bboard6++; rgoal++; tboard1++; tboard2++; tboard3++; tboard4++; tboard5++; }
                            if (bboard5 == 8) { bboard6++; rgoal++; tboard1++; tboard2++; tboard3++; tboard4++; tboard5++; tboard6++; }
                            if (bboard5 == 9) { bboard6++; rgoal++; tboard1++; tboard2++; tboard3++; tboard4++; tboard5++; tboard6++; tboard1++; }
                            if (bboard5 == 10) { bboard6++; rgoal++; tboard1++; tboard2++; tboard3++; tboard4++; tboard5++; tboard6++; tboard1++; tboard2++; }
                            bboard5 = 0;
                            turn = "top";
                            poolchoice = "0";
                        }
                        if (poolchoice == "6")
                        {
                            if (bboard6 == 1) { rgoal++; turn = "bottom"; poolchoice = "0"; bboard6 = 0; break; }
                            if (bboard6 == 2) { rgoal++; tboard1++; }
                            if (bboard6 == 3) { rgoal++; tboard1++; tboard2++; }
                            if (bboard6 == 4) { rgoal++; tboard1++; tboard2++; tboard3++; }
                            if (bboard6 == 5) { rgoal++; tboard1++; tboard2++; tboard3++; tboard4++; }
                            if (bboard6 == 6) { rgoal++; tboard1++; tboard2++; tboard3++; tboard4++; tboard5++; }
                            if (bboard6 == 7) { rgoal++; tboard1++; tboard2++; tboard3++; tboard4++; tboard5++; tboard6++; }
                            if (bboard6 == 8) { rgoal++; tboard1++; tboard2++; tboard3++; tboard4++; tboard5++; tboard6++; tboard1++; }
                            if (bboard6 == 9) { rgoal++; tboard1++; tboard2++; tboard3++; tboard4++; tboard5++; tboard6++; tboard1++; tboard2++; }
                            if (bboard6 == 10) { rgoal++; tboard1++; tboard2++; tboard3++; tboard4++; tboard5++; tboard6++; tboard1++; tboard2++; tboard3++; }
                            bboard6 = 0;
                            turn = "top";
                            poolchoice = "0";
                        }
                    }



                    // tboard logic

                    if (turn == "top")
                    {
                        if (poolchoice == "1")
                        {
                            if (tboard1 == 1) tboard2++;
                            if (tboard1 == 2) { tboard2++; tboard3++; }
                            if (tboard1 == 3) { tboard2++; tboard3++; tboard4++; }
                            if (tboard1 == 4) { tboard2++; tboard3++; tboard4++; tboard5++; }
                            if (tboard1 == 5) { tboard2++; tboard3++; tboard4++; tboard5++; tboard6++; }
                            if (tboard1 == 6) { tboard2++; tboard3++; tboard4++; tboard5++; tboard6++; lgoal++; turn = "top"; poolchoice = "0"; tboard1 = 0; break; }
                            if (tboard1 == 7) { tboard2++; tboard3++; tboard4++; tboard5++; tboard6++; lgoal++; bboard1++; }
                            if (tboard1 == 8) { tboard2++; tboard3++; tboard4++; tboard5++; tboard6++; lgoal++; bboard1++; bboard2++; }
                            if (tboard1 == 9) { tboard2++; tboard3++; tboard4++; tboard5++; tboard6++; lgoal++; bboard1++; bboard2++; bboard3++; }
                            if (tboard1 == 10) { tboard2++; tboard3++; tboard4++; tboard5++; tboard6++; lgoal++; bboard1++; bboard2++; bboard3++; bboard4++; }
                            tboard1 = 0;
                            turn = "bottom";
                            poolchoice = "0";
                        }
                        if (poolchoice == "2")
                        {
                            if (tboard2 == 1) tboard3++;
                            if (tboard2 == 2) { tboard3++; tboard4++; }
                            if (tboard2 == 3) { tboard3++; tboard4++; tboard5++; }
                            if (tboard2 == 4) { tboard3++; tboard4++; tboard5++; tboard6++; }
                            if (tboard2 == 5) { tboard3++; tboard4++; tboard5++; tboard6++; lgoal++; turn = "top"; poolchoice = "0"; tboard2 = 0; break; }
                            if (tboard2 == 6) { tboard3++; tboard4++; tboard5++; tboard6++; lgoal++; bboard1++; }
                            if (tboard2 == 7) { tboard3++; tboard4++; tboard5++; tboard6++; lgoal++; bboard1++; bboard2++; }
                            if (tboard2 == 8) { tboard3++; tboard4++; tboard5++; tboard6++; lgoal++; bboard1++; bboard2++; bboard3++; }
                            if (tboard2 == 9) { tboard3++; tboard4++; tboard5++; tboard6++; lgoal++; bboard1++; bboard2++; bboard3++; bboard4++; }
                            if (tboard2 == 10) { tboard3++; tboard4++; tboard5++; tboard6++; lgoal++; bboard1++; bboard2++; bboard3++; bboard4++; bboard5++; }
                            tboard2 = 0;
                            turn = "bottom";
                            poolchoice = "0";
                        }
                        if (poolchoice == "3")
                        {
                            if (tboard3 == 1) tboard4++;
                            if (tboard3 == 2) { tboard4++; tboard5++; }
                            if (tboard3 == 3) { tboard4++; tboard5++; tboard6++; }
                            if (tboard3 == 4) { tboard4++; tboard5++; tboard6++; lgoal++; turn = "top"; poolchoice = "0"; tboard3 = 0; break; }
                            if (tboard3 == 5) { tboard4++; tboard5++; tboard6++; lgoal++; bboard1++; }
                            if (tboard3 == 6) { tboard4++; tboard5++; tboard6++; lgoal++; bboard1++; bboard2++; }
                            if (tboard3 == 7) { tboard4++; tboard5++; tboard6++; lgoal++; bboard1++; bboard2++; bboard3++; }
                            if (tboard3 == 8) { tboard4++; tboard5++; tboard6++; lgoal++; bboard1++; bboard2++; bboard3++; bboard4++; }
                            if (tboard3 == 9) { tboard4++; tboard5++; tboard6++; lgoal++; bboard1++; bboard2++; bboard3++; bboard4++; bboard5++; }
                            if (tboard3 == 10) { tboard4++; tboard5++; tboard6++; lgoal++; bboard1++; bboard2++; bboard3++; bboard4++; bboard5++; bboard6++; }
                            tboard3 = 0;
                            turn = "bottom";
                            poolchoice = "0";
                        }
                        if (poolchoice == "4")
                        {
                            if (tboard4 == 1) tboard5++;
                            if (tboard4 == 2) { tboard5++; tboard6++; }
                            if (tboard4 == 3) { tboard5++; tboard6++; lgoal++; turn = "top"; poolchoice = "0"; tboard4 = 0; break; }
                            if (tboard4 == 4) { tboard5++; tboard6++; lgoal++; bboard1++; }
                            if (tboard4 == 5) { tboard5++; tboard6++; lgoal++; bboard1++; bboard2++; }
                            if (tboard4 == 6) { tboard5++; tboard6++; lgoal++; bboard1++; bboard2++; bboard3++; }
                            if (tboard4 == 7) { tboard5++; tboard6++; lgoal++; bboard1++; bboard2++; bboard3++; bboard4++; }
                            if (tboard4 == 8) { tboard5++; tboard6++; lgoal++; bboard1++; bboard2++; bboard3++; bboard4++; bboard5++; }
                            if (tboard4 == 9) { tboard5++; tboard6++; lgoal++; bboard1++; bboard2++; bboard3++; bboard4++; bboard5++; bboard6++; }
                            if (tboard4 == 10) { tboard5++; tboard6++; lgoal++; bboard1++; bboard2++; bboard3++; bboard4++; bboard5++; bboard6++; bboard1++; }
                            tboard4 = 0;
                            turn = "bottom";
                            poolchoice = "0";
                        }
                        if (poolchoice == "5")
                        {
                            if (tboard5 == 1) tboard6++;
                            if (tboard5 == 2) { tboard6++; lgoal++; turn = "top"; poolchoice = "0"; tboard5 = 0; break; }
                            if (tboard5 == 3) { tboard6++; lgoal++; bboard1++; }
                            if (tboard5 == 4) { tboard6++; lgoal++; bboard1++; bboard2++; }
                            if (tboard5 == 5) { tboard6++; lgoal++; bboard1++; bboard2++; bboard3++; }
                            if (tboard5 == 6) { tboard6++; lgoal++; bboard1++; bboard2++; bboard3++; bboard4++; }
                            if (tboard5 == 7) { tboard6++; lgoal++; bboard1++; bboard2++; bboard3++; bboard4++; bboard5++; }
                            if (tboard5 == 8) { tboard6++; lgoal++; bboard1++; bboard2++; bboard3++; bboard4++; bboard5++; bboard6++; }
                            if (tboard5 == 9) { tboard6++; lgoal++; bboard1++; bboard2++; bboard3++; bboard4++; bboard5++; bboard6++; bboard1++; }
                            if (tboard5 == 10) { tboard6++; lgoal++; bboard1++; bboard2++; bboard3++; bboard4++; bboard5++; bboard6++; bboard1++; bboard2++; }
                            tboard5 = 0;
                            turn = "bottom";
                            poolchoice = "0";
                        }
                        if (poolchoice == "6")
                        {
                            if (tboard6 == 1) { lgoal++; turn = "top"; poolchoice = "0"; tboard6 = 0; break; }
                            if (tboard6 == 2) { lgoal++; bboard1++; }
                            if (tboard6 == 3) { lgoal++; bboard1++; bboard2++; }
                            if (tboard6 == 4) { lgoal++; bboard1++; bboard2++; bboard3++; }
                            if (tboard6 == 5) { lgoal++; bboard1++; bboard2++; bboard3++; bboard4++; }
                            if (tboard6 == 6) { lgoal++; bboard1++; bboard2++; bboard3++; bboard4++; bboard5++; }
                            if (tboard6 == 7) { lgoal++; bboard1++; bboard2++; bboard3++; bboard4++; bboard5++; bboard6++; }
                            if (tboard6 == 8) { lgoal++; bboard1++; bboard2++; bboard3++; bboard4++; bboard5++; bboard6++; lgoal++; tboard1++; }
                            if (tboard6 == 9) { lgoal++; bboard1++; bboard2++; bboard3++; bboard4++; bboard5++; bboard6++; lgoal++; tboard1++; tboard2++; }
                            if (tboard6 == 10) { lgoal++; bboard1++; bboard2++; bboard3++; bboard4++; bboard5++; bboard6++; lgoal++; tboard1++; tboard2++; tboard3++; }
                            tboard6 = 0;
                            turn = "bottom";
                            poolchoice = "0";
                        }
                    }
                }
            }
        }
    }
}

