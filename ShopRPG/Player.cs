﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopRPG
{
    class Player
    {
        Inventory playerInv = new Inventory();
        private int playerMoney = 1000;
        public int _potionHeld = 0;

        public Player()                                                      // Constructor What makes player a player.
        {
            playerInv.Add(new AttackItem("Yeet Sword", 1337, 420, "LeetYeetSwordBoi"));
        }

        public void PrintList()
        {
            playerInv.PrintItemPool();

        }

        // Grabs Money Function from player
        public int getDatMoney
        {
            get
            {
                return playerMoney;
            }
            set
            {
                playerMoney = value;
            }
        }

        public void Add(AllItem toPlayerInv)
        {
            playerInv.Add(toPlayerInv);
        }

        // Player buying from Shopkeeper Function
        public bool BuyingItem(int index, Shopkeeper shopkeeper)
        {
            if (index < playerInv.GetLength() && index >= 0)
            {
                AllItem temp = playerInv[index];
                if (shopkeeper.getShopMoney /* watchItBurn */ < temp.Cost)
                {
                    // If the Player doesn't have enough funds, tell player you cannot and nothing happens.
                    temp.Print();
                    return false;
                }
                //player buys item (create BUY function which will be your logic for buying (lose money giving item ect.  (SHOPKEEPER BUYING FROM player))
                Console.WriteLine("You have sucessfully sold " + temp.Name + " from your bag.");
                getDatMoney += temp.Cost;
                shopkeeper.getShopMoney -= temp.Cost;
                playerInv.Remove(index);
                shopkeeper.Add(temp);
                return true;
            }
            else
            {
                return false;
            }
        }

        // Player Inventory Save
        public void Save(string playerInventorySave)
        {
            playerInv.PlayerSave(playerInventorySave, playerInv, this);
        }

        // Player Inventory Load
        public void Load(string playerInventorySave)
        {
            playerInv.PlayerLoad(playerInventorySave, playerInv, this);
        }

        public int GetLength()
        {
            return playerInv.GetLength();
        }
    }
}
