using System;
using AssemblyCSharp.Functions;

public class GClass20
{
	public const int int_0 = 0;

	public const int int_1 = 2;

	public const int int_2 = 4;

	public const int int_3 = 8;

	public const int int_4 = 16;

	public const int int_5 = 32;

	public const int int_6 = 64;

	public const int int_7 = 128;

	public const int int_8 = 256;

	public const int int_9 = 512;

	public const int int_10 = 1024;

	public const int int_11 = 2048;

	public const int int_12 = 4096;

	public const int int_13 = 8192;

	public const int int_14 = 16384;

	public const int int_15 = 32768;

	public const int int_16 = 65536;

	public const int int_17 = 131072;

	public const int int_18 = 262144;

	public const int int_19 = 524288;

	public const int int_20 = 1;

	public static int int_21;

	public static int int_22;

	public static int int_23;

	public static int int_24;

	public static int int_25;

	public static int int_26 = -1;

	public static int[] int_27;

	public static int[] int_28;

	public static GClass70[] gclass70_0;

	public static GClass70 gclass70_1;

	public static GClass70 gclass70_2;

	public static GClass70 gclass70_3;

	public static GClass70 gclass70_4;

	public static GClass70 gclass70_5;

	public static GClass70 gclass70_6;

	public static GClass70 gclass70_7;

	public static GClass70 gclass70_8;

	public static GClass70 gclass70_9;

	public static sbyte sbyte_0 = 24;

	private static int int_29;

	private static int int_30;

	private static int int_31;

	private static int int_32;

	public static string[] string_0;

	public static int[] int_33;

	public static int[] int_34;

	public static int[] int_35;

	public static int int_36;

	public static bool bool_0 = false;

	public static string string_1 = "";

	public static sbyte sbyte_1 = 1;

	public static int int_37;

	public static int int_38 = -1;

	public static int int_39;

	public static int int_40;

	public static int int_41;

	public static int int_42 = -1;

	public static int int_43;

	public static sbyte sbyte_2;

	public static sbyte sbyte_3 = -1;

	public static long long_0;

	public static GClass88 gclass88_0 = new GClass88();

	public static GClass88 gclass88_1 = new GClass88();

	public static GClass88 gclass88_2 = new GClass88();

	public static string[] string_2;

	public static sbyte sbyte_4 = 0;

	public static GClass70 gclass70_10;

	public const int int_44 = 0;

	public const int int_45 = 1;

	public const int int_46 = 2;

	public const int int_47 = 3;

	public const int int_48 = 5;

	public const int int_49 = 4;

	public const int int_50 = 6;

	public const int int_51 = 7;

	public const int int_52 = 8;

	public const int int_53 = 9;

	public const int int_54 = 10;

	public const int int_55 = 11;

	public const int int_56 = 12;

	public const int int_57 = 13;

	public const int int_58 = 15;

	public const int int_59 = 16;

	public const int int_60 = 19;

	public static GClass70[] gclass70_11 = new GClass70[8];

	public static GClass88 gclass88_3 = new GClass88();

	public static int[] int_61 = new int[6] { 21, 22, 23, 39, 40, 41 };

	public static int[] int_62 = new int[6] { 21, 22, 23, 24, 25, 26 };

	public static int[] int_63 = new int[3] { 0, 7, 14 };

	public static int[][] int_64;

	public static int[][][] int_65;

	public static GClass70 gclass70_12 = GClass73.smethod_43("/bg/light.png");

	public static int int_66 = 2;

	public static int int_67;

	public static int int_68;

	public static int int_69;

	public static int int_70;

	public static int int_71;

	public static int int_72;

	private static int[] int_73 = new int[2] { 5257738, 8807192 };

	public static int int_74 = 0;

	public int[][] int_75;

	public static void smethod_0()
	{
		gclass70_10 = GClass73.smethod_43("/mainImage/myTexture2dbong.png");
		if (GClass122.int_12 != 1 && !Main.isIpod && !Main.isIphone4)
			gclass70_12 = GClass73.smethod_43("/bg/light.png");
	}

	public static bool smethod_1()
	{
		if (int_37 != 51 && int_37 != 103 && int_37 != 112 && int_37 != 113 && int_37 != 129 && int_37 != 130)
			return false;
		return true;
	}

	public static bool smethod_2()
	{
		if (int_37 == 39 || int_37 == 40 || int_37 == 41)
			return true;
		return false;
	}

	public static bool smethod_3()
	{
		if (GClass144.gclass24_0 == null || int_37 != GClass144.gclass24_0.short_0)
			return false;
		return true;
	}

	public static GClass10 smethod_4(int id)
	{
		int num = 0;
		GClass10 gClass;
		while (true)
		{
			if (num < gclass88_1.method_2())
			{
				gClass = (GClass10)gclass88_1.method_3(num);
				if (gClass.int_0 == id)
					break;
				num++;
				continue;
			}
			return null;
		}
		return gClass;
	}

	public static bool smethod_5()
	{
		for (int i = 0; i < int_61.Length; i++)
		{
			if (int_37 == int_61[i])
				return true;
		}
		return false;
	}

	public static bool smethod_6()
	{
		for (int i = 0; i < int_61.Length; i++)
		{
			if (int_37 == int_62[i])
				return true;
		}
		return false;
	}

	public static bool smethod_7()
	{
		int num = 0;
		while (true)
		{
			if (num < int_63.Length)
			{
				if (int_37 == int_63[num])
					break;
				num++;
				continue;
			}
			return false;
		}
		return true;
	}

	public static void smethod_8()
	{
		gclass70_0 = null;
		GClass203.smethod_26();
	}

	public static void smethod_9()
	{
	}

	public static bool smethod_10(int id)
	{
		if (id != 156 && id != 330 && id != 345 && id != 334)
		{
			if (int_37 == 54 || int_37 == 55 || int_37 == 56 || int_37 == 57 || int_37 == 58 || int_37 == 59 || int_37 == 103)
				return false;
			int num = 0;
			for (int i = 0; i < gclass88_2.method_2(); i++)
			{
				if (((GClass10)gclass88_2.method_3(i)).int_0 == id)
					num++;
			}
			if (num <= 2)
				return false;
			return true;
		}
		return false;
	}

	public static void smethod_11()
	{
		if (gclass70_3 == null)
			gclass70_3 = GClass73.smethod_42("/tWater/wtf.png");
		if (gclass70_4 == null)
			gclass70_4 = GClass73.smethod_42("/tWater/twtf.png");
		if (gclass70_5 == null)
			gclass70_5 = GClass73.smethod_42("/tWater/wts.png");
		if (gclass70_6 == null)
			gclass70_6 = GClass73.smethod_42("/tWater/wtsN.png");
		if (gclass70_7 == null)
			gclass70_7 = GClass73.smethod_42("/tWater/wtsN2.png");
		GClass203.smethod_26();
	}

	public static void smethod_12(int index, int[] mapsArr, int type)
	{
		for (int i = 0; i < mapsArr.Length; i++)
		{
			if (int_27[index] == mapsArr[i])
			{
				int_28[index] |= type;
				break;
			}
		}
	}

	public static void smethod_13(int tileId)
	{
		int_24 = int_22 * sbyte_0;
		int_23 = int_21 * sbyte_0;
		GClass50.smethod_8("load tile ID= " + int_25);
		int num = tileId - 1;
		try
		{
			for (int i = 0; i < int_21 * int_22; i++)
			{
				for (int j = 0; j < int_64[num].Length; j++)
				{
					smethod_12(i, int_65[num][j], int_64[num][j]);
				}
			}
		}
		catch (Exception)
		{
			GClass36.smethod_0("Error Load Map");
			GClass187.gclass187_0.method_1();
		}
	}

	public static bool smethod_14()
	{
		if (int_37 != 45 && int_37 != 46 && int_37 != 48)
			return false;
		return true;
	}

	public static bool smethod_15()
	{
		if (bool_0 || int_37 == 45 || int_37 == 46 || int_37 == 48 || int_37 == 51 || int_37 == 52 || int_37 == 103 || int_37 == 112 || int_37 == 113 || int_37 == 115 || int_37 == 117 || int_37 == 118 || int_37 == 119 || int_37 == 120 || int_37 == 121 || int_37 == 125 || int_37 == 129 || int_37 == 130)
			return true;
		return false;
	}

	public static void smethod_16()
	{
		if (Main.typeClient != 3 && Main.typeClient != 5)
		{
			if (GClass122.int_12 != 1)
			{
				if (GClass73.smethod_42("/t/" + int_25 + "$1.png") == null)
				{
					GClass70 gClass = GClass73.smethod_42("/t/" + int_25 + ".png");
					if (gClass != null)
					{
						GClass1.smethod_14("$");
						gclass70_0 = new GClass70[1];
						gclass70_0[0] = gClass;
					}
					return;
				}
				GClass1.smethod_14("x" + GClass122.int_12 + "t" + int_25);
				gclass70_0 = new GClass70[100];
				for (int i = 0; i < gclass70_0.Length; i++)
				{
					gclass70_0[i] = GClass73.smethod_42("/t/" + int_25 + "$" + (i + 1) + ".png");
				}
				return;
			}
			if (gclass70_0 != null)
			{
				for (int j = 0; j < gclass70_0.Length; j++)
				{
					if (gclass70_0[j] != null)
					{
						gclass70_0[j].texture2D_0 = null;
						gclass70_0[j] = null;
					}
				}
				GClass203.smethod_26();
			}
			gclass70_0 = new GClass70[100];
			string empty = "";
			for (int k = 0; k < gclass70_0.Length; k++)
			{
				string path = ((k < 9) ? ("/t/" + int_25 + "/t_0" + (k + 1)) : ("/t/" + int_25 + "/t_" + (k + 1)));
				gclass70_0[k] = GClass73.smethod_43(path);
			}
		}
		else if (GClass122.int_12 != 1)
		{
			gclass70_0 = new GClass70[100];
			for (int l = 0; l < gclass70_0.Length; l++)
			{
				gclass70_0[l] = GClass73.smethod_43("/t/" + int_25 + "/" + (l + 1) + ".png");
			}
		}
		else
		{
			gclass70_0 = new GClass70[1];
			gclass70_0[0] = GClass73.smethod_43("/t/" + int_25 + ".png");
		}
	}

	public static void smethod_17(GClass122 g, int frame, int indexX, int indexY)
	{
		if (gclass70_0 != null)
		{
			if (gclass70_0.Length != 1)
				g.method_31(gclass70_0[frame], indexX * sbyte_0, indexY * sbyte_0, 0);
			else
				g.method_23(gclass70_0[0], 0, frame * sbyte_0, sbyte_0, sbyte_0, 0, indexX * sbyte_0, indexY * sbyte_0, 0);
		}
	}

	public static void smethod_18(GClass122 g, int frame, int x, int y, int w, int h)
	{
		if (gclass70_0 != null)
		{
			if (gclass70_0.Length == 1)
				g.method_23(gclass70_0[0], 0, frame * w, w, w, 0, x, y, 0);
			else
				g.method_31(gclass70_0[frame], x, y, 0);
		}
	}

	public static void smethod_19(GClass122 g)
	{
		for (int i = GClass144.int_32; i < GClass144.int_34; i++)
		{
			for (int j = GClass144.int_33; j < GClass144.int_35; j++)
			{
				int num = int_27[j * int_21 + i] - 1;
				if (num != -1)
					smethod_17(g, num, i, j);
				if ((smethod_26(i, j) & 0x20) != 32)
				{
					if ((smethod_26(i, j) & 0x40) == 64)
					{
						if ((smethod_26(i, j - 1) & 0x20) != 32)
						{
							if ((smethod_26(i, j - 1) & 0x1000) == 4096)
								smethod_17(g, 21, i, j);
						}
						else
							g.method_23(gclass70_3, 0, 24 * (GClass73.int_8 % 4), 24, 24, 0, i * sbyte_0, j * sbyte_0, 0);
						GClass70 gClass = null;
						g.method_23((int_25 == 5) ? gclass70_6 : ((int_25 != 8) ? gclass70_5 : gclass70_7), 0, (GClass73.int_8 % 8 >> 2) * 24, 24, 24, 0, i * sbyte_0, j * sbyte_0, 0);
					}
				}
				else
					g.method_23(gclass70_3, 0, 24 * (GClass73.int_8 % 4), 24, 24, 0, i * sbyte_0, j * sbyte_0, 0);
				if ((smethod_26(i, j) & 0x800) != 2048)
					continue;
				if ((smethod_26(i, j - 1) & 0x20) != 32)
				{
					if ((smethod_26(i, j - 1) & 0x1000) == 4096)
						smethod_17(g, 21, i, j);
				}
				else
					g.method_23(gclass70_3, 0, 24 * (GClass73.int_8 % 4), 24, 24, 0, i * sbyte_0, j * sbyte_0, 0);
				smethod_17(g, int_27[j * int_21 + i] - 1, i, j);
			}
		}
	}

	public static void smethod_20(GClass122 g)
	{
		if (GClass167.smethod_0().bool_18)
			return;
		if (!GClass167.smethod_0().bool_19)
		{
			if (GClass78.bool_35)
				return;
			GClass144.smethod_8().method_79(g, 1);
			for (int i = 0; i < GClass144.gclass88_6.method_2(); i++)
			{
				((GClass64)GClass144.gclass88_6.method_3(i)).method_6(g);
			}
			for (int j = GClass144.int_32; j < GClass144.int_34; j++)
			{
				for (int k = GClass144.int_33; k < GClass144.int_35; k++)
				{
					if (j == 0 || j == int_21 - 1)
						continue;
					int num = int_27[k * int_21 + j] - 1;
					if ((smethod_26(j, k) & 0x100) == 256)
						continue;
					if ((smethod_26(j, k) & 0x20) != 32)
					{
						if ((smethod_26(j, k) & 0x80) != 128)
						{
							if (int_25 == 13 && num != -1)
								continue;
							if (int_25 == 2 && (smethod_26(j, k) & 0x200) == 512 && num != -1)
							{
								smethod_18(g, num, j * sbyte_0, k * sbyte_0, 24, 1);
								smethod_18(g, num, j * sbyte_0, k * sbyte_0 + 1, 24, 24);
							}
							if (int_25 != 3)
								;
							if ((smethod_26(j, k) & 0x10) == 16)
							{
								int_29 = j * sbyte_0 - GClass144.int_22;
								int_30 = int_29 - GClass144.int_8;
								int_32 = (sbyte_0 - 2) * int_30 / sbyte_0;
								int_31 = int_32 + GClass144.int_8;
								smethod_18(g, num, int_31 + GClass144.int_22, k * sbyte_0, 24, 24);
							}
							else if ((smethod_26(j, k) & 0x200) == 512)
							{
								if (num != -1)
								{
									smethod_18(g, num, j * sbyte_0, k * sbyte_0, 24, 1);
									smethod_18(g, num, j * sbyte_0, k * sbyte_0 + 1, 24, 24);
								}
							}
							else if (num != -1)
							{
								smethod_17(g, num, j, k);
							}
						}
						else
							g.method_23(gclass70_4, 0, 24 * (GClass73.int_8 % 8 >> 1), 24, 24, 0, j * sbyte_0, k * sbyte_0, 0);
					}
					else
						g.method_23(gclass70_3, 0, 24 * (GClass73.int_8 % 8 >> 1), 24, 24, 0, j * sbyte_0, k * sbyte_0, 0);
				}
			}
			if (GClass144.int_22 < 24)
			{
				for (int l = GClass144.int_33; l < GClass144.int_35; l++)
				{
					int num2 = int_27[l * int_21 + 1] - 1;
					if (num2 != -1)
						smethod_17(g, num2, 0, l);
				}
			}
			if (GClass144.int_22 <= GClass144.int_30)
				return;
			int num3 = int_21 - 2;
			for (int m = GClass144.int_33; m < GClass144.int_35; m++)
			{
				int num4 = int_27[m * int_21 + num3] - 1;
				if (num4 != -1)
					smethod_17(g, num4, num3 + 1, m);
			}
			return;
		}
		try
		{
			g.method_16(6238645);
			for (int n = GClass144.int_32; n < GClass144.int_34; n++)
			{
				for (int num5 = GClass144.int_33; num5 < GClass144.int_35; num5++)
				{
					if (int_27[num5 * int_21 + n] != 0 && ((!smethod_28(n * 24, (num5 + 1) * 24, 2) && !smethod_28(n * 24, (num5 + 2) * 24, 2) && !smethod_28(n * 24, num5 * 24, 2)) || smethod_28(n * 24, num5 * 24, 2)))
					{
						if (n <= 0)
							g.method_15(n * sbyte_0, num5 * sbyte_0 + 8, 24, 24);
						else
							g.method_14(n * sbyte_0, num5 * sbyte_0 + 8, 24, 24);
					}
				}
			}
		}
		catch
		{
		}
	}

	public static bool smethod_21(int x1, int y1, int x, int y, int w, int h)
	{
		bool flag = y1 < 0;
		bool flag2 = x1 < 0;
		bool flag3 = x1 > int_23;
		bool flag4 = y1 > int_24 || y1 > GClass157.smethod_0().method_13(y1);
		return (x1 >= x && x1 <= x + w && y1 >= y && y1 <= y + h) || flag2 || flag3 || flag || flag4;
	}

	public static bool smethod_22()
	{
		if (int_37 != 54 && int_37 != 55 && int_37 != 56 && int_37 != 57 && int_37 != 138 && int_37 != 167)
			return true;
		return false;
	}

	public static void smethod_23(GClass122 g)
	{
		if (GClass167.smethod_0().bool_10 || GClass73.bool_1)
			return;
		int num = 0;
		for (int i = GClass144.int_32; i < GClass144.int_34; i++)
		{
			for (int j = GClass144.int_33; j < GClass144.int_35; j++)
			{
				num++;
				if ((smethod_26(i, j) & 0x40) != 64)
					continue;
				GClass70 gClass = null;
				gClass = ((int_25 == 5) ? gclass70_6 : ((int_25 != 8) ? gclass70_5 : gclass70_7));
				if (!smethod_22())
				{
					g.method_23(gClass, 0, 0, 24, 24, 0, i * sbyte_0, j * sbyte_0 - 1, 0);
					g.method_23(gClass, 0, 0, 24, 24, 0, i * sbyte_0, j * sbyte_0 - 3, 0);
				}
				g.method_23(gClass, 0, (GClass73.int_8 % 8 >> 2) * 24, 24, 24, 0, i * sbyte_0, j * sbyte_0 - 12, 0);
				if (int_74 != 0 || !smethod_22())
					continue;
				int_74 = j * sbyte_0 - 12;
				int color = 16777215;
				if (GClass73.int_57 != 2)
				{
					if (GClass73.int_57 != 4)
					{
						if (GClass73.int_57 == 7)
							color = 5693125;
						else if (GClass73.int_57 == 19)
						{
							color = 16711680;
						}
					}
					else
						color = 8111470;
				}
				else
					color = 10871287;
				GClass34.smethod_8(color, int_74 + 15);
			}
		}
		GClass34.smethod_9(g);
	}

	public static void smethod_24(int mapID)
	{
		GClass108 gClass = null;
		gClass = GClass200.smethod_0("/mymap/" + mapID);
		int_21 = (ushort)gClass.method_2();
		int_22 = (ushort)gClass.method_2();
		int_27 = new int[gClass.method_13()];
		for (int i = 0; i < int_21 * int_22; i++)
		{
			int_27[i] = (ushort)gClass.method_2();
		}
		int_28 = new int[int_27.Length];
	}

	public static int smethod_25(int x, int y)
	{
		try
		{
			return int_27[y * int_21 + x];
		}
		catch (Exception)
		{
			return 1000;
		}
	}

	public static int smethod_26(int x, int y)
	{
		try
		{
			return int_28[y * int_21 + x];
		}
		catch (Exception)
		{
			return 1000;
		}
	}

	public static int smethod_27(int px, int py)
	{
		try
		{
			return int_28[py / sbyte_0 * int_21 + px / sbyte_0];
		}
		catch (Exception)
		{
			return 1000;
		}
	}

	public static bool smethod_28(int px, int py, int t)
	{
		try
		{
			return (int_28[py / sbyte_0 * int_21 + px / sbyte_0] & t) == t;
		}
		catch (Exception)
		{
			return false;
		}
	}

	public static void smethod_29(int px, int py, int t)
	{
		int_28[py / sbyte_0 * int_21 + px / sbyte_0] |= t;
	}

	public static void smethod_30(int x, int y, int t)
	{
		int_28[y * int_21 + x] = t;
	}

	public static void smethod_31(int px, int py, int t)
	{
		int_28[py / sbyte_0 * int_21 + px / sbyte_0] &= ~t;
	}

	public static int smethod_32(int py)
	{
		return py / sbyte_0 * sbyte_0;
	}

	public static int smethod_33(int px)
	{
		return px / sbyte_0 * sbyte_0;
	}

	public static void smethod_34()
	{
		if (int_26 != int_25)
		{
			smethod_16();
			int_26 = int_25;
		}
	}

	public static GClass181 smethod_35()
	{
		for (int i = 0; i < gclass88_0.method_2(); i++)
		{
			int num = GClass78.smethod_1().int_4;
			int num2 = GClass78.smethod_1().int_5;
			GClass181 gClass = (GClass181)gclass88_0.method_3(i);
			if (num >= gClass.short_0 && num <= gClass.short_2 && num2 >= gClass.short_1 && num2 <= gClass.short_3)
				return gClass;
		}
		return null;
	}
}
