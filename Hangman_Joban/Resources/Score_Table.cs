using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using SQLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Hangman_Joban.Resources
{
    public class Score_Table
    {
        [PrimaryKey, AutoIncrement] //Column("_Id")]
        public int Id { get; set; }

        [MaxLength(25)]
        public string Name { get; set; }

        public int Score { get; set; }

    }
}