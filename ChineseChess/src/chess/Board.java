package chess;

public class Board {
    private int[] ban_co;
    private int[] ben_co;
    private int nguoi_choi;
    private String[] ki_tu = { "+", "o", "s", "v", "m", "p", "x", "t" };
    public void Co_tuong()
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
        for(int i = 0; i < 9; i++)
        {
            ben_co[i] = 1;
            ben_co[i + 81] = 2;
        }
        ben_co[19] = ben_co[25] = ben_co[27] = ben_co[29] = ben_co[31] = ben_co[33] = ben_co[35] = 1;
        ben_co[64] = ben_co[70] = ben_co[54] = ben_co[56] = ben_co[58] = ben_co[60] = ben_co[62] = 2;

        //khoi tao luot
        nguoi_choi = 0;
    }
    public void Khoi_Tao_Ban_Co(){
        System.out.println("   A    B    C    D    E    F    G    H    I");
        System.out.println("0  X----M----V----S----T----S----V----M----X");
        System.out.println("   |    |    |    | \\  |  / |    |    |    |");
        System.out.println("1  +----+----+----+----+----+----+----+----+");
        System.out.println("   |    |    |    |  / | \\  |    |    |    |");
        System.out.println("2  +----P----+----+----+----+----+----P----+");
        System.out.println("   |    |    |    |    |    |    |    |    |");
        System.out.println("3  O----+----O----+----O----+----O----+----O");
        System.out.println("   |    |    |    |    |    |    |    |    |");
        System.out.println("4  +----+----+----+----+----+----+----+----+");
        System.out.println("   |                                       |");
        System.out.println("5  +----+----+----+----+----+----+----+----+");
        System.out.println("   |    |    |    |    |    |    |    |    |");
        System.out.println("6  o----+----o----+----o----+----o----+----o");
        System.out.println("   |    |    |    |    |    |    |    |    |");
        System.out.println("7  +----p----+----+----+----+----+----p----+");
        System.out.println("   |    |    |    | \\  | /  |    |    |    |");
        System.out.println("8  +----+----+----+----+----+----+----+----+");
        System.out.println("   |    |    |    |  / | \\  |    |    |    |");
        System.out.println("9  x----m----v----s----t----s----v----m----x");
    }
    public void Ve(int i, String s)
    {
        if (ben_co[i] == 1)
            System.out.println(ki_tu[ban_co[i]].toUpperCase() + s);
        else if (ben_co[i] == 2)
            System.out.println(ki_tu[ban_co[i]] + s);
        else System.out.println(ki_tu[0] + s);
    }

    public static void main(String[] args) {
        new Board().Khoi_Tao_Ban_Co();
    }
}
