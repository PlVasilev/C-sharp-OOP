using System;
using System.Collections.Generic;
using System.Linq;

namespace SandQ03NumberWars
{
    class SandQ03NumberWars
    {
        static void Main(string[] args)
        {
           string[] inputFirst = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
           string[] inputSecond = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
            Queue<string> firstDeck = new Queue<string>();
            Queue<string> secondDeck = new Queue<string>();

            for (int i = 0; i < inputFirst.Length; i++)
            {
                firstDeck.Enqueue(inputFirst[i]);
            }
            for (int i = 0; i < inputSecond.Length; i++)
            {
                secondDeck.Enqueue(inputSecond[i]);
            }

            int turns = 0;
            while (firstDeck.Count > 0 && secondDeck.Count > 0 && turns < 1000000)
            {
                string firstCard = firstDeck.Dequeue();
                int firstValue = int.Parse(firstCard.Substring(0, firstCard.Length - 1));
                string secondCard = secondDeck.Dequeue();
                int secondValue = int.Parse(secondCard.Substring(0, secondCard.Length - 1));
                if (firstValue>secondValue)
                {
                    firstDeck.Enqueue(firstCard);
                    firstDeck.Enqueue(secondCard);
                }
                else if (firstValue < secondValue)
                {                  
                    secondDeck.Enqueue(secondCard);
                    secondDeck.Enqueue(firstCard);
                }
                else
                {
                    List<KeyValuePair<string, int>> Hand = new List<KeyValuePair<string, int>>();
                    Hand.Add(new KeyValuePair<string, int>(firstCard, firstValue));
                    Hand.Add(new KeyValuePair<string, int>(secondCard, secondValue));

                    while (firstDeck.Count > 0 && secondDeck.Count > 0)
                    {
                        int playerOneSum = 0;
                        int playerTwoSum = 0;
                        for (int i = 0; i < 6; i++)
                        {
                            if (i < 3)
                            {
                                string card = firstDeck.Dequeue();
                                int cardCharValue = char.Parse(card.Substring(card.Length - 1, 1)) - 96;
                                playerOneSum += cardCharValue;
                                int cardValue = int.Parse(card.Substring(0, card.Length - 1));
                                Hand.Add(new KeyValuePair<string, int>(card, cardValue));
                            }
                            else
                            {
                                string card = secondDeck.Dequeue();
                                int cardCharValue = char.Parse(card.Substring(card.Length - 1, 1)) - 96;
                                playerTwoSum += cardCharValue;
                                int cardValue = int.Parse(card.Substring(0, card.Length - 1));
                                Hand.Add(new KeyValuePair<string, int>(card, cardValue));
                            }
                        }
                        if (playerOneSum > playerTwoSum)
                        {
                            foreach (var item in Hand.OrderByDescending(x => x.Value))
                            {
                                firstDeck.Enqueue(item.Key);
                            }
                            break;
                        }
                        else if (playerOneSum < playerTwoSum)
                        {
                            foreach (var item in Hand.OrderByDescending(x => x.Value))
                            {
                                secondDeck.Enqueue(item.Key);
                            }
                            break;
                        }
                    }
                }
                turns++;
            }
            if (firstDeck.Count > secondDeck.Count)
            {
                Console.WriteLine($"First player wins after {turns} turns");
            }
            else if (firstDeck.Count < secondDeck.Count)
            {
                Console.WriteLine($"Second player wins after {turns} turns");
            }
            else
            {
                Console.WriteLine($"Draw after {turns} turns");
            }
            
        }
    }
}
