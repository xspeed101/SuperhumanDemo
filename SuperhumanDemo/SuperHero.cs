using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SuperhumanDemo
{
    public class SuperHero : SuperHuman, IHasKarma
    {
        //Private instance variables
        private int _karma;

        //Public Properties

            public int Karma
        {
            get
            {
                return this._karma;
            }
            set
            {
                this._karma = value;
            }
        }

        //constructors

            /// <summary>
            /// This is the default main constructor for the superhero class
            /// </summary>
            /// <param name="name"></param>

        public SuperHero(string name, int karma):base(name)
        {
            this.Karma = karma;
        }

        //Private Method

        //Public methods
    }
}