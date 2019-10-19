using System;
using System.Collections.Generic;

namespace Co_Tuong_abc
{
    class Program
    {
        public class Co_tuong
        {
            private const int SOCOT = 9, SOHANG = 10;
            private int[] ban_co;
            private int[] ben_co;
            private int nguoi_choi;
            private string[] ki_tu = { "+", "o", "s", "v", "m", "p", "x", "t" };

            public Co_tuong()
            {
                // khoi tao quan co
                ban_co = new int[90];
                ban_co[0] = ban_co[8] = ban_co[81] = ban_co[89] = 6; // vi tri xe(X)
                ban_co[1] = ban_co[7] = ban_co[82] = ban_co[88] = 4; // vi tri ma(M)
                ban_co[2] = ban_co[6] = ban_co[83] = ban_co[87] = 3; //vi tri tuong(V)
                ban_co[3] = ban_co[5] = ban_co[84] = ban_co[86] = 2; // vi tri sy(S)
                ban_co[4] = ban_co[85] = 7;    // vi tri tuong(T)
                ban_co[19] = ban_co[25] = ban_co[64] = ban_co[70] = 5;  // vi tri phao(P)
                ban_co[27] = ban_co[29] = ban_co[31] = ban_co[33] = ban_co[35] = 1; //vi tri tot(O)
                ban_co[54] = ban_co[56] = ban_co[58] = ban_co[60] = ban_co[62] = 1; //vi tri tot(O)

                //khoi tao phe
                ben_co = new int[90];
                for (int i = 0; i < 9; i++)
                {
                    ben_co[i] = 1;
                    ben_co[i + 81] = 2;
                }
                ben_co[19] = ben_co[25] = ben_co[27] = ben_co[29] = ben_co[31] = ben_co[33] = ben_co[35] = 1;
                ben_co[64] = ben_co[70] = ben_co[54] = ben_co[56] = ben_co[58] = ben_co[60] = ben_co[62] = 2;

                //khoi tao luot
                nguoi_choi = 0;
            }

            public void Khoi_Tao_Ban_Co()
            {
                Console.WriteLine("   A    B    C    D    E    F    G    H    I");
                Console.WriteLine("0  X----M----V----S----T----S----V----M----X");  //dong 1
                Console.WriteLine(@"   |    |    |    | \  | /  |    |    |    |");
                Console.WriteLine("1  +----+----+----+----+----+----+----+----+");  //dong 2
                Console.WriteLine(@"   |    |    |    |  / | \  |    |    |    |");
                Console.WriteLine("2  +----P----+----+----+----+----+----P----+");  //dong 3
                Console.WriteLine("   |    |    |    |    |    |    |    |    |");
                Console.WriteLine("3  O----+----O----+----O----+----O----+----O");  //dong 4
                Console.WriteLine("   |    |    |    |    |    |    |    |    |");
                Console.WriteLine("4  +----+----+----+----+----+----+----+----+"); // dong 5
                Console.WriteLine("   |                                       |"); // song
                Console.WriteLine("5  +----+----+----+----+----+----+----+----+"); // dong 6
                Console.WriteLine("   |    |    |    |    |    |    |    |    |");
                Console.WriteLine("6  o----+----o----+----o----+----o----+----o");  //dong 7
                Console.WriteLine("   |    |    |    |    |    |    |    |    |");
                Console.WriteLine("7  +----p----+----+----+----+----+----p----+"); // dong 8
                Console.WriteLine(@"   |    |    |    | \  | /  |    |    |    |");
                Console.WriteLine("8  +----+----+----+----+----+----+----+----+"); // dong 9
                Console.WriteLine(@"   |    |    |    |  / | \  |    |    |    |");
                Console.WriteLine("9  x----m----v----s----t----s----v----m----x"); //dong 10
            }

            private void Ve(int i, string s)
            {
                if (ben_co[i] == 1)
                    Console.Write(ki_tu[ban_co[i]].ToUpper() + s);
                else if (ben_co[i] == 2)
                    Console.Write(ki_tu[ban_co[i]] + s);
                else Console.Write(ki_tu[0] + s);
            }

            public void Ve_Ban_Co()
            {
                Console.WriteLine("   A" +
                    "    B    C    D    E    F    G    H    I");
                // ve dong 1
                Console.Write("0  ");
                for (int i = 0; i <= 8; i++)
                {
                    if (i != 8) Ve(i, "----");
                    else Ve(i, "");
                }
                Console.WriteLine();
                Console.WriteLine(@"   |    |    |    | \  | /  |    |    |    |");
                // ve dong 2
                Console.Write("1  ");
                for (int i = 9; i <= 17; i++)
                {
                    if (i != 17) Ve(i, "----");
                    else Ve(i, "");
                }
                Console.WriteLine();
                Console.WriteLine(@"   |    |    |    |  / | \  |    |    |    |");
                // ve dong 3
                Console.Write("2  ");
                for (int i = 18; i <= 26; i++)
                {
                    if (i != 26) Ve(i, "----");
                    else Ve(i, "");
                }
                Console.WriteLine();
                Console.WriteLine("   |    |    |    |    |    |    |    |    |");
                // ve dong 4
                Console.Write("3  ");
                for (int i = 27; i <= 35; i++)
                {
                    if (i != 35) Ve(i, "----");
                    else Ve(i, "");
                }
                Console.WriteLine();
                Console.WriteLine("   |    |    |    |    |    |    |    |    |");
                // ve dong 5
                Console.Write("4  ");
                for (int i = 36; i <= 44; i++)
                {
                    if (i != 44) Ve(i, "----");
                    else Ve(i, "");
                }
                Console.WriteLine();
                Console.WriteLine("   |                                       |");
                // ve dong 6
                Console.Write("5  ");
                for (int i = 45; i <= 53; i++)
                {
                    if (i != 53) Ve(i, "----");
                    else Ve(i, "");
                }
                Console.WriteLine();
                Console.WriteLine("   |    |    |    |    |    |    |    |    |");
                // ve dong 7
                Console.Write("6  ");
                for (int i = 54; i <= 62; i++)
                {
                    if (i != 62) Ve(i, "----");
                    else Ve(i, "");
                }
                Console.WriteLine();
                Console.WriteLine("   |    |    |    |    |    |    |    |    |");
                // ve dong 8
                Console.Write("7  ");
                for (int i = 63; i <= 71; i++)
                {
                    if (i != 71) Ve(i, "----");
                    else Ve(i, "");
                }
                Console.WriteLine();
                Console.WriteLine(@"   |    |    |    | \  | /  |    |    |    |");
                // ve dong 9
                Console.Write("8  ");
                for (int i = 72; i <= 80; i++)
                {
                    if (i != 80) Ve(i, "----");
                    else Ve(i, "");
                }
                Console.WriteLine();
                Console.WriteLine(@"   |    |    |    |  / | \  |    |    |    |");
                // ve dong 10
                Console.Write("9  ");
                for (int i = 81; i <= 89; i++)
                {
                    if (i != 89) Ve(i, "----");
                    else Ve(i, "");
                }
                Console.WriteLine();
            }

            public Stack<int> Nuoc_Di_Xe(int p)
            {
                Stack<int> nuoc_di = new Stack<int>();
                int vi_tri_hang = p / SOCOT;
                int can_duoi = vi_tri_hang * SOCOT;
                int can_tren = can_duoi + SOCOT;
                //tim nuoc theo chieu ngang
                for(int i = p - 1; i >= can_duoi; i--)
                {
                    if (ben_co[i] == 0) nuoc_di.Push(i);
                    else if (ben_co[i] == 1) break;
                    else
                    {
                        nuoc_di.Push(i);
                        break;
                    }
                }

                for(int i = p + 1; i < can_tren; i++)
                {
                    if (ben_co[i] == 0) nuoc_di.Push(i);
                    else if (ben_co[i] == 1) break;
                    else
                    {
                        nuoc_di.Push(i);
                        break;
                    }
                }
                //tim nuoc di theo chieu doc
                for(int i = p - SOCOT; i >= 0; i -= SOCOT)
                {
                    if (ben_co[i] == 0) nuoc_di.Push(i);
                    else if (ben_co[i] == 1) break;
                    else
                    {
                        nuoc_di.Push(i);
                        break;
                    }
                }

                for(int i = p + SOCOT; i < 90; i += SOCOT)
                {
                    if (ben_co[i] == 0) nuoc_di.Push(i);
                    else if (ben_co[i] == 1) break;
                    else
                    {
                        nuoc_di.Push(i);
                        break;
                    }
                }
                return nuoc_di;
            }

            public Stack<int> Nuoc_Di_Phao(int p)
            {
                Stack<int> nuoc_di = new Stack<int>();
                int vi_tri_hang = p / SOCOT;
                int can_duoi = vi_tri_hang * SOCOT;
                int can_tren = can_duoi + SOCOT;
                //tim kiem nuoc di theo chieu ngang
                for(int i = p - 1; i >= can_duoi; i--)
                {
                    if (ben_co[i] == 0) nuoc_di.Push(i);
                    else if (ben_co[i] == 2) break;
                    else
                    {
                        for(int j = i - 1; j >= can_duoi; j--)
                        {
                            if (ben_co[j] == 1) break;
                            else if(ben_co[j] == 2)
                            {
                                nuoc_di.Push(j);
                                break;
                            }
                        }
                        break;
                    }
                }

                for(int i = p + 1; i < can_tren; i++)
                {
                    if (ben_co[i] == 0) nuoc_di.Push(i);
                    else if (ben_co[i] == 2) break;
                    else
                    {
                        for(int j = i + 1; j < can_tren; j++)
                        {
                            if (ben_co[j] == 1) break;
                            else if(ben_co[j] == 2)
                            {
                                nuoc_di.Push(j);
                                break;
                            }
                        }
                        break;
                    }
                }
                //tim kiem nuoc di theo chieu doc
                for(int i = p - SOCOT; i >= 0; i -= SOCOT)
                {
                    if (ben_co[i] == 0) nuoc_di.Push(i);
                    else if (ben_co[i] == 2) break;
                    else
                    {
                        for (int j = i - SOCOT; j >= 0; j -= SOCOT)
                        {
                            if (ben_co[j] == 1) break;
                            else if (ben_co[j] == 2)
                            {
                                nuoc_di.Push(j);
                                break;
                            }
                        }
                        break;
                    }
                }

                for (int i = p + SOCOT; i < 90; i += SOCOT)
                {
                    if (ben_co[i] == 0) nuoc_di.Push(i);
                    else if (ben_co[i] == 2) break;
                    else
                    {
                        for (int j = i + SOCOT; j < 90; j += SOCOT)
                        {
                            if (ben_co[j] == 1) break;
                            else if (ben_co[j] == 2)
                            {
                                nuoc_di.Push(j);
                                break;
                            }
                        }
                        break;
                    }
                }
                return nuoc_di;
            }

            private bool Quan_Ma(int[] nuoc_can, int x1, int x2, int y1, int y2)
            {
                return (nuoc_can[x1] == 1 || nuoc_can[x2] == 1) && (nuoc_can[y1] == 1 || nuoc_can[y2] == 1);
            }

            public Stack<int> Nuoc_Di_Ma(int p)
            {
                Stack<int> nuoc_di = new Stack<int>();
                int z1 = p - 2 * SOCOT;
                int z2 = p - SOCOT;
                int z3 = p + SOCOT;
                int z4 = p + 2 * SOCOT;
                int z5 = p % SOCOT;
                int[] toa_do = new int[]
                {
                    z1 - 1, z1, z1 + 1,
                    z2 - 2, z2 - 1, z2, z2 + 1, z2 + 2,
                    p - 2, p - 1, p + 1, p + 2,
                    z3 - 2, z3 - 1, z3, z3 + 1, z3 + 2,
                    z4 - 1, z4, z4 + 1
                };
                int[] so_du;
                if(z5 == 0)
                {
                    so_du = new int[]
                    {
                       -1, 0, 1,
                       -2, -1, 0, 1, 2,
                       -2, -1, 1, 2,
                       -2, -1, 0, 1, 2,
                       -1, 0, 1
                    };
                }
                else if(z5 == 1)
                {
                    so_du = new int[]
                    {
                        0, 1, 2,
                        -1, 0, 1, 2, 3,
                        -1, 0, 2, 3,
                        -1, 0, 1, 2, 3,
                        0, 1, 2
                    };
                }
                else if(z5 == 8)
                {
                    so_du = new int[]
                    {
                        7, 8, 9,
                        6, 7, 8, 9, 10,
                        6, 7, 9, 10,
                        6, 7, 8, 9, 10,
                        7, 8, 9
                    };
                }
                else if(z5 == 7)
                {
                    so_du = new int[]
                    {
                        6, 7, 8,
                        5, 6, 7, 8, 9,
                        5, 6, 8, 9,
                        5, 6, 7, 8, 9,
                        6, 7, 8
                    };
                }
                else
                {
                    so_du = new int[]
                    {
                        z5 - 1, z5, z5 + 1,
                        z5 - 2, z5 - 1, z5, z5 + 1, z5 + 2,
                        z5- 2, z5 - 1, z5 + 1, z5 + 2,
                        z5 - 2, z5 - 1, z5, z5 + 1, z5 + 2,
                        z5 - 1, z5, z5 + 1
                    };
                }
                int[] nuoc_can = new int[20];
                //kiem tra tran ban co
                for (int i = 0; i < 20; i++)
                {
                    if (toa_do[i] < 0 || toa_do[i] >= 90) nuoc_can[i] = 1;
                    else if (toa_do[i] % 9 != so_du[i]) nuoc_can[i] = 1;
                    else if(i != 0 && i != 2 && i != 3 && i != 7 && i != 12 && i != 16 && i != 17 && i != 19)
                    {
                        if (ben_co[toa_do[i]] != 0) nuoc_can[i] = 1;

                    }
                }
                if (!Quan_Ma(nuoc_can, 1, 5, 4, 9) && ben_co[toa_do[0]] != 1 && nuoc_can[0] == 0) nuoc_di.Push(toa_do[0]);
                if (!Quan_Ma(nuoc_can, 1, 5, 6, 10) && ben_co[toa_do[2]] != 1 && nuoc_can[2] == 0) nuoc_di.Push(toa_do[2]);
                if (!Quan_Ma(nuoc_can, 4, 5, 8, 9) && ben_co[toa_do[3]] != 1 && nuoc_can[3] == 0) nuoc_di.Push(toa_do[3]);
                if (!Quan_Ma(nuoc_can, 5, 6, 10, 11) && ben_co[toa_do[7]] != 1 && nuoc_can[7] == 0) nuoc_di.Push(toa_do[7]);
                if (!Quan_Ma(nuoc_can, 8, 9, 13, 14) && ben_co[toa_do[12]] != 1 && nuoc_can[12] == 0) nuoc_di.Push(toa_do[12]);
                if (!Quan_Ma(nuoc_can, 10, 11, 14, 15) && ben_co[toa_do[16]] != 1 && nuoc_can[16] == 0) nuoc_di.Push(toa_do[16]);
                if (!Quan_Ma(nuoc_can, 9, 13, 14, 18) && ben_co[toa_do[17]] != 1 && nuoc_can[17] == 0) nuoc_di.Push(toa_do[17]);
                if (!Quan_Ma(nuoc_can, 10, 15, 14, 18) && ben_co[toa_do[19]] != 1 && nuoc_can[19] == 0) nuoc_di.Push(toa_do[19]);

                return nuoc_di;
            }
        }
        static void Main(string[] args)
        {
            Co_tuong phuc = new Co_tuong();
            phuc.Khoi_Tao_Ban_Co();
            Stack<int> aaa = phuc.Nuoc_Di_Ma(11);
            while (aaa.Count > 0)
                Console.WriteLine(aaa.Pop());
            Console.ReadKey();
        }
    }
}
