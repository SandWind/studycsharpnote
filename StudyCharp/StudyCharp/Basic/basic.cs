using System;
using System.Collections.Generic;
using System.Text;

namespace StudyCharp.Basic
{
    //静态构造类
    class ClassStudy
    {
        //静态构造函数
        class RandomNumberClass
        {
            private static Random RandomKey;

            static RandomNumberClass()
            {
                RandomKey = new Random();
            }
            public int getRandomNumber()
            {
                return RandomKey.Next();
            }
        }
        //索引器应用
        class MutilFiledIndexClass
        {
           public string Name;
           private string Work;
           public string Address;
           public string this [int Index]
           {
                set
                {
                    switch(Index)
                    {
                        case 0:
                            this.Name = value;
                            break;
                        case 1:
                            this.Work = value;
                            break;
                        case 2:
                            this.Address = value;
                            break;
                        default:
                            break;
                    }
                }

                get
                {
                    switch (Index)
                    {
                        case 0:  return  Name;
                        case 1:  return Work;
                        case 2:  return  Address;
                        default:  return this.Name;
                    }
                }
           }

            public string this[float Index]
            {
                set
                {
                    switch (Index)
                    {
                        case 0:
                            this.Name = value;
                            break;
                        case 1:
                            this.Work = value;
                            break;
                        case 2:
                            this.Address = value;
                            break;
                        default:
                            break;
                    }
                }

                get
                {
                    switch (Index)
                    {
                        case 0: return Name;
                        case 1: return Work;
                        case 2: return Address;
                        default: return this.Name;
                    }
                }
            }

        }

        private RandomNumberClass Rn;
        private MutilFiledIndexClass Mu;

        public ClassStudy()
        {
            Rn = new RandomNumberClass();
            Mu = new MutilFiledIndexClass();
        }
        public int RandomNum()
        {
            return Rn.getRandomNumber();
        }

        public void getMulitFiledContent()
        {
            Mu[0] = "jack";
            Mu[1] = "developer";
            Mu[2] = "runway station";
            Console.WriteLine("{0},{1},{2}", Mu[0], Mu[1], Mu[2]);
        }
    }

}
