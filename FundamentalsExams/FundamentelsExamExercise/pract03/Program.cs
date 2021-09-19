using System;
using System.Collections.Generic;
using System.Linq;

namespace pract03
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            Dictionary<string, Pieces> pieces = new Dictionary<string, Pieces>();

            for (int i = 0; i < n; i++)
            {
                string[] piecesInfo = Console.ReadLine()
                    .Split('|', StringSplitOptions.RemoveEmptyEntries);
                string composer = piecesInfo[1];
                string gamaKey = piecesInfo[2];

                if (pieces.ContainsKey(piecesInfo[0]))
                {
                    pieces[piecesInfo[0]].Composer = composer;
                    pieces[piecesInfo[0]].GamaKey = gamaKey;
                }
                else
                {
                    Pieces piece = new Pieces()
                    {
                        Composer = composer,
                        GamaKey = gamaKey
                    };
                    pieces.Add(piecesInfo[0], piece);
                }
            }

            string input = string.Empty;

            while ((input = Console.ReadLine()) != "Stop")
            {
                string[] command = input
                    .Split('|', StringSplitOptions.RemoveEmptyEntries);

                string piece = command[1];
                switch (command[0])
                {
                    case"Add":
                        if (pieces.ContainsKey(piece))
                        {
                            Console.WriteLine($"{piece} is already in the collection!");
                        }
                        else
                        {
                            string composer = command[2];
                            string gamaKey = command[3];
                            Pieces newPiece = new Pieces()
                            {
                                Composer = composer,
                                GamaKey = gamaKey
                            };
                            pieces.Add(piece, newPiece);
                            Console.WriteLine($"{piece} by {composer} in {gamaKey} added to the collection!");
                        }
                        break;
                    case "Remove":
                        if (pieces.ContainsKey(piece))
                        {
                            pieces.Remove(piece);
                            Console.WriteLine($"Successfully removed {piece}!");
                        }
                        else
                        {
                            Console.WriteLine($"Invalid operation! {piece} does not exist in the collection.");
                        }
                        break;
                        case "ChangeKey":
                        string newKey = command[2];
                        if (pieces.ContainsKey(piece))
                        {
                            pieces[piece].GamaKey = newKey;
                            Console.WriteLine($"Changed the key of {piece} to {newKey}!");
                        }
                        else
                        {
                            Console.WriteLine($"Invalid operation! {piece} does not exist in the collection.");
                        }
                        break;
                }
            }

            foreach (var piece in pieces.OrderBy(x=> x.Key).ThenBy(x => x.Value.Composer))
            {
                Console.WriteLine($"{piece.Key} -> Composer: {piece.Value.Composer}, Key: {piece.Value.GamaKey}");
            }
        }
        class Pieces
        {
            public string Composer { get; set; }
            public string GamaKey { get; set; }
            public Pieces()
            {

            }
        }
    }
}
