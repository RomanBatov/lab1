﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    public class Player
    {
       public int playerId;
         String lastName;
       public  String firstName;
        String gender;
        float height;
        float weight;
        String shirtNumber;
        String email;
        String countryCode;
       public int teamId;

        public void setAll (int playerId, String lastName, String firstName, String gender, float height, float weight, String shirtNumber, String email, String countryCode, int teamId)
        {
            this.playerId = playerId;
            this.lastName = lastName;
            this.firstName = firstName;
            this.gender = gender;
            this.height = height;
            this.weight = weight;
            this.shirtNumber = shirtNumber;
            this.email = email;
            this.teamId = teamId;
        }
    }
   
}