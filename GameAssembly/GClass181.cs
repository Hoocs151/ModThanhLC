using System;
using ns1;

public class GClass181
{
	public static GClass122 gclass122_0 = new GClass122();

	private int[] int_0;

	private int[] int_1;

	private int[] int_2;

	private int[] int_3;

	public static int[] int_4;

	private int int_5;

	private int int_6;

	private int int_7;

	private int int_8;

	private int int_9;

	private int int_10;

	private int int_11;

	private int int_12;

	private int int_13;

	private bool bool_0;

	public static GClass20 gclass20_0;

	public static GClass20 gclass20_1;

	public static GClass20 gclass20_2;

	public static GClass20 gclass20_3;

	public static GClass20 gclass20_4;

	private static GClass20 gclass20_5;

	private static GClass20 gclass20_6;

	private static GClass20 gclass20_7;

	private static GClass20 gclass20_8;

	private int[] int_14;

	private int int_15;

	public int int_16;

	public int int_17;

	public int int_18;

	private bool[] bool_1;

	private int[] int_19;

	private int[] int_20;

	private bool[] bool_2;

	private int int_21;

	private int int_22;

	public const int int_23 = 0;

	public const int int_24 = 1;

	public const int int_25 = 2;

	public const int int_26 = 3;

	public const int int_27 = 4;

	public const int int_28 = 5;

	public const int int_29 = 6;

	public const int int_30 = 7;

	public const int int_31 = 8;

	public const int int_32 = 9;

	public const int int_33 = 10;

	public const int int_34 = 11;

	public const int int_35 = 12;

	public const int int_36 = 13;

	public const int int_37 = 14;

	public const int int_38 = 15;

	public static int int_39 = 16;

	public static GClass20 gclass20_9 = GClass14.smethod_43("/mainImage/myTexture2dwater1.png");

	public static GClass20 gclass20_10 = GClass14.smethod_43("/mainImage/myTexture2dwater2.png");

	public static GClass20 gclass20_11;

	public static GClass20 gclass20_12;

	public static short short_0;

	public static short short_1;

	public static GClass20 gclass20_13 = null;

	public static bool bool_3;

	public static bool bool_4;

	public static int int_40;

	public static GClass20 gclass20_14;

	public static GClass20 gclass20_15;

	public static int int_41;

	public static int int_42;

	public static int int_43;

	public static int int_44;

	private int[] int_45 = new int[6] { 0, 1, 2, 1, 0, 0 };

	private int[] int_46;

	public GClass181(int typeS)
	{
		bool_3 = true;
		smethod_2();
		int_16 = typeS;
		switch (int_16)
		{
		case 3:
			GClass14.bool_26 = true;
			break;
		case 4:
		{
			int_15 = GClass191.smethod_19(5, 10);
			if (gclass20_4 == null)
				gclass20_4 = GClass14.smethod_42("/bg/sao.png");
			int_0 = new int[int_15];
			int_1 = new int[int_15];
			int_19 = new int[int_15];
			int_20 = new int[int_15];
			int_46 = new int[int_15];
			for (int j = 0; j < int_15; j++)
			{
				int_0[j] = GClass191.smethod_19(0, GClass14.int_10);
				int_1[j] = GClass191.smethod_19(0, 50);
				if (j % 2 != 0)
				{
					if (j % 3 == 0)
						int_46[j] = 1;
					else if (j % 4 == 0)
					{
						int_46[j] = 2;
					}
					else
					{
						int_46[j] = 3;
					}
				}
				else
					int_46[j] = 0;
				int_20[j] = GClass191.smethod_19(0, 10);
			}
			break;
		}
		case 8:
			int_12 = GClass191.smethod_19(100, 300);
			if (gclass20_6 == null)
				gclass20_6 = GClass14.smethod_42("/bg/ship.png");
			if (gclass20_7 == null)
				gclass20_7 = GClass14.smethod_42("/bg/fire1.png");
			if (gclass20_8 == null)
				gclass20_8 = GClass14.smethod_42("/bg/fire2.png");
			bool_0 = false;
			method_0();
			break;
		case 9:
		{
			if (gclass20_11 == null)
				gclass20_11 = GClass14.smethod_42("/bg/cham-tron1.png");
			if (gclass20_12 == null)
				gclass20_12 = GClass14.smethod_42("/bg/cham-tron2.png");
			int_5 = 20;
			int_0 = new int[int_5];
			int_1 = new int[int_5];
			int_4 = new int[int_5];
			int_2 = new int[int_5];
			for (int m = 0; m < int_5; m++)
			{
				int_0[m] = GClass191.smethod_28(GClass191.smethod_19(0, GClass14.int_10));
				int_1[m] = GClass191.smethod_28(GClass191.smethod_19(10, 80));
				int_4[m] = GClass191.smethod_28(GClass191.smethod_19(1, 3));
				int_2[m] = int_4[m];
			}
			break;
		}
		case 10:
		{
			int_5 = 30;
			int_0 = new int[int_5];
			int_1 = new int[int_5];
			int_4 = new int[int_5];
			int_2 = new int[int_5];
			int num = 0;
			for (int l = 0; l < int_5; l++)
			{
				int_0[l] = GClass191.smethod_28(GClass191.smethod_19(0, GClass14.int_10)) + GClass167.int_22;
				num++;
				if (num <= int_5 / 2)
				{
					int_1[l] = GClass191.smethod_28(GClass191.smethod_19(0, 20));
					int_4[l] = 7;
				}
				else
				{
					int_1[l] = GClass191.smethod_28(GClass191.smethod_19(20, 60));
					int_4[l] = 10;
				}
				int_2[l] = int_4[l] / 2 - 2;
			}
			break;
		}
		case 0:
		case 12:
		{
			if (gclass20_1 == null)
				gclass20_1 = GClass14.smethod_42("/bg/mua.png");
			if (gclass20_2 == null)
				gclass20_2 = GClass14.smethod_42("/bg/mua1.png");
			if (gclass20_3 == null)
				gclass20_3 = GClass14.smethod_42("/bg/mua2.png");
			int_15 = GClass191.smethod_19(GClass14.int_10 / 3, GClass14.int_10 / 2);
			int_0 = new int[int_15];
			int_1 = new int[int_15];
			int_2 = new int[int_15];
			int_3 = new int[int_15];
			int_14 = new int[int_15];
			int_20 = new int[int_15];
			int_19 = new int[int_15];
			bool_1 = new bool[int_15];
			bool_2 = new bool[int_15];
			for (int k = 0; k < int_15; k++)
			{
				int_1[k] = GClass191.smethod_19(-10, GClass14.int_11 + 100) + GClass167.int_23;
				int_0[k] = GClass191.smethod_19(-10, GClass14.int_10 + 300) + GClass167.int_22;
				int_20[k] = GClass191.smethod_19(0, 1);
				int_2[k] = -12;
				int_3[k] = 12;
				int_14[k] = GClass191.smethod_19(1, 3);
				bool_1[k] = false;
				if (int_14[k] == 2 && k % 2 == 0)
					bool_1[k] = true;
				bool_2[k] = false;
				int_19[k] = GClass191.smethod_19(1, 2);
			}
			break;
		}
		case 13:
			if (GClass191.smethod_28(GClass191.smethod_19(0, 2)) == 0)
			{
				if (GClass191.smethod_28(GClass191.smethod_19(0, 2)) != 0)
					bool_4 = false;
				else
					bool_4 = true;
				int_40 = GClass191.smethod_28(GClass191.smethod_19(2, 5));
				smethod_2();
			}
			break;
		case 14:
			if (GClass191.smethod_28(GClass191.smethod_19(0, 2)) == 0)
			{
				bool_3 = true;
				smethod_2();
			}
			break;
		case 1:
		case 2:
		case 5:
		case 6:
		case 7:
		case 11:
		case 15:
		{
			if (int_16 == 1)
			{
				gclass20_5 = GClass14.smethod_42("/bg/lacay.png");
				int_39 = 10;
			}
			if (int_16 == 2)
			{
				gclass20_5 = GClass14.smethod_42("/bg/lacay2.png");
				int_39 = 18;
			}
			if (int_16 == 5)
			{
				gclass20_5 = GClass14.smethod_42("/bg/lacay3.png");
				int_39 = 14;
			}
			if (int_16 == 6)
			{
				gclass20_5 = GClass14.smethod_42("/bg/lacay4.png");
				int_39 = 14;
			}
			if (int_16 == 7)
			{
				gclass20_5 = GClass14.smethod_42("/bg/lacay5.png");
				int_39 = 12;
			}
			if (int_16 == 11)
				gclass20_5 = GClass14.smethod_42("/bg/tuyet.png");
			if (int_16 == 15)
			{
				if (GClass72.gclass26_0[11120] == null)
					GClass72.smethod_5(11120);
				int_39 = 16;
			}
			int_15 = GClass191.smethod_19(15, 25);
			if (int_16 == 11)
				int_15 = 100;
			int_0 = new int[int_15];
			int_1 = new int[int_15];
			int_2 = new int[int_15];
			int_3 = new int[int_15];
			int_20 = new int[int_15];
			int_19 = new int[int_15];
			bool_2 = new bool[int_15];
			for (int i = 0; i < int_15; i++)
			{
				int_0[i] = GClass191.smethod_19(-10, GClass137.int_23 + 10);
				int_1[i] = GClass191.smethod_19(0, GClass137.int_24);
				int_19[i] = GClass191.smethod_19(0, 1);
				int_20[i] = GClass191.smethod_19(0, 1);
				int_2[i] = GClass191.smethod_19(-3, 3);
				int_3[i] = GClass191.smethod_19(1, 4);
				if (int_16 == 11)
				{
					int_19[i] = GClass191.smethod_19(0, 2);
					int_2[i] = GClass191.smethod_28(GClass191.smethod_19(1, 3));
					int_3[i] = GClass191.smethod_28(GClass191.smethod_19(1, 3));
				}
				if (int_16 == 15)
				{
					int_19[i] = GClass191.smethod_19(0, 2);
					int_2[i] = GClass191.smethod_28(GClass191.smethod_19(1, 3));
					int_3[i] = GClass191.smethod_28(GClass191.smethod_19(1, 3));
				}
			}
			break;
		}
		}
	}

	public static void smethod_0()
	{
		GClass137.int_74 = 0;
	}

	public static bool smethod_1()
	{
		for (int i = 0; i < gclass122_0.method_2(); i++)
		{
			GClass181 gClass = (GClass181)gclass122_0.method_3(i);
			if (gClass.int_16 == 0 || gClass.int_16 == 12)
				return true;
		}
		return false;
	}

	public static void smethod_2()
	{
		if (GClass77.int_0 == 1)
		{
			gclass20_14 = null;
			gclass20_15 = null;
			return;
		}
		if (GClass14.bool_1)
		{
			gclass20_14 = null;
			gclass20_15 = null;
			return;
		}
		if (int_40 <= 0)
			gclass20_14 = null;
		else if (gclass20_14 == null)
		{
			gclass20_14 = GClass14.smethod_43("/bg/fog1.png");
			int_41 = gclass20_14.method_0();
		}
		if (bool_3)
		{
			if (gclass20_15 == null)
				gclass20_15 = GClass14.smethod_43("/bg/fog0.png");
			int_44 = 287;
		}
		else
			gclass20_15 = null;
	}

	public static void smethod_3()
	{
		if (GClass66.smethod_0().bool_10 || GClass77.int_0 == 1 || GClass14.bool_1 || int_40 <= 0)
			return;
		int num = ((GClass14.gclass160_0 != GClass167.smethod_8()) ? (GClass167.int_22 + GClass14.int_10) : GClass137.int_23);
		for (int i = 0; i < int_40; i++)
		{
			GClass14.int_47[i] -= i + 1;
			if (GClass14.int_47[i] < -int_41)
				GClass14.int_47[i] = num + 100;
		}
	}

	public static void smethod_4()
	{
		if (!GClass66.smethod_0().bool_10 && GClass77.int_0 != 1 && !GClass14.bool_1 && bool_3)
		{
			int_42--;
			if (int_42 < -int_44)
				int_42 = 0;
		}
	}

	public static void smethod_5(GClass193 g)
	{
		if (GClass66.smethod_0().bool_10 || GClass77.int_0 == 1 || GClass14.bool_1 || int_40 == 0 || gclass20_14 == null)
			return;
		for (int i = 0; i < int_40; i++)
		{
			int num = i;
			if (num > 3)
				num = 3;
			if (num == 0)
				num = 1;
			g.method_31(gclass20_14, GClass14.int_47[i], GClass14.int_48[i], 3);
		}
	}

	public static void smethod_6(GClass193 g)
	{
		if (GClass66.smethod_0().bool_10 || GClass77.int_0 == 1 || GClass14.bool_1 || !bool_3 || gclass20_15 == null)
			return;
		for (int i = int_42; i < GClass137.int_23; i += int_44)
		{
			if (i >= GClass167.int_22 - int_44)
				g.method_32(gclass20_15, i, int_43, 0);
		}
	}

	private void method_0()
	{
		if (GClass66.smethod_0().bool_10)
			return;
		int num = GClass167.int_22;
		int num2 = GClass167.int_23;
		int_8 = GClass191.smethod_19(1, 3);
		bool_0 = false;
		int_13 = GClass191.smethod_19(3, 5);
		if (int_8 == 1)
		{
			int_6 = -50;
			int_7 = GClass191.smethod_19(num2, GClass14.int_11 - 100 + num2);
			int_9 = 0;
		}
		else if (int_8 == 2)
		{
			int_6 = GClass137.int_23 + 50;
			int_7 = GClass191.smethod_19(num2, GClass14.int_11 - 100 + num2);
			int_9 = 2;
		}
		else if (int_8 != 3)
		{
			if (int_8 == 4)
			{
				int_6 = GClass191.smethod_19(50 + num, GClass14.int_10 - 50 + num);
				int_7 = GClass137.int_24 + 50;
				int_9 = ((GClass191.smethod_19(0, 2) != 0) ? 2 : 0);
			}
		}
		else
		{
			int_6 = GClass191.smethod_19(50 + num, GClass14.int_10 - 50 + num);
			int_7 = -50;
			int_9 = ((GClass191.smethod_19(0, 2) != 0) ? 2 : 0);
		}
	}

	public void method_1(GClass193 g)
	{
		if (GClass66.smethod_0().bool_10 || int_16 != 10)
			return;
		g.method_16(int_22);
		for (int i = 0; i < int_5; i++)
		{
			g.method_31((i < int_5 / 2) ? gclass20_10 : gclass20_9, int_0[i], int_1[i] + int_21, 0);
		}
		if (short_0 != 0 && gclass20_13 == null)
			gclass20_13 = GClass72.gclass26_0[short_0].gclass20_0;
		if (gclass20_13 != null)
		{
			for (int j = 0; j < int_5 / 2; j++)
			{
				g.method_31(gclass20_13, int_0[j], int_1[j] + int_21, 0);
			}
		}
	}

	public void method_2(GClass193 g)
	{
		if (GClass66.smethod_0().bool_10)
			return;
		g.method_1(-g.method_3(), -g.method_4());
		if (int_16 == 4)
		{
			for (int i = 0; i < int_15; i++)
			{
				g.method_23(gclass20_4, 0, 16 * int_19[i], 16, 16, 0, int_0[i], int_1[i], 0);
			}
		}
		if (int_16 == 9)
		{
			g.method_16(16777215);
			for (int j = 0; j < int_5; j++)
			{
				g.method_31((int_4[j] != 1) ? gclass20_12 : gclass20_11, int_0[j], int_1[j], 3);
			}
		}
	}

	public void method_3()
	{
		try
		{
			if (GClass66.smethod_0().bool_10)
				return;
			switch (int_16)
			{
			case 4:
			{
				for (int m = 0; m < int_15; m++)
				{
					int_20[m]++;
					if (int_20[m] > 10)
					{
						int_46[m]++;
						int_20[m] = 0;
						if (int_46[m] > 5)
							int_46[m] = 0;
						int_19[m] = int_45[int_46[m]];
					}
				}
				break;
			}
			case 8:
				int_11++;
				if (int_11 == 3)
				{
					int_11 = 0;
					int_10++;
					if (int_10 > 1)
						int_10 = 0;
				}
				if (GClass14.int_8 % int_12 == 0)
					bool_0 = true;
				if (!bool_0)
					break;
				if (int_8 == 1)
				{
					int_6 += int_13;
					if (int_6 > GClass137.int_23 + 50)
						method_0();
				}
				else if (int_8 == 2)
				{
					int_6 -= int_13;
					if (int_6 < -50)
						method_0();
				}
				else if (int_8 == 3)
				{
					int_7 += int_13;
					if (int_7 > GClass137.int_24 + 50)
						method_0();
				}
				else if (int_8 == 4)
				{
					int_7 -= int_13;
					if (int_7 < -50)
						method_0();
				}
				break;
			case 9:
			{
				for (int k = 0; k < int_5; k++)
				{
					int_0[k] -= int_2[k];
					if (int_0[k] < -int_2[k])
					{
						int_4[k] = GClass191.smethod_28(GClass191.smethod_19(1, 3));
						int_2[k] = int_4[k];
						int_0[k] = GClass14.int_10 + int_2[k];
					}
				}
				break;
			}
			case 10:
			{
				for (int n = 0; n < int_5; n++)
				{
					int_0[n] -= int_2[n];
					if (int_0[n] < -int_2[n] + GClass167.int_22)
						int_0[n] = GClass14.int_10 + int_2[n] + GClass167.int_22;
				}
				break;
			}
			case 0:
			case 12:
			{
				for (int l = 0; l < int_15; l++)
				{
					if (l % 3 != 0 && int_16 != 12 && GClass137.smethod_28(int_0[l], int_1[l] - GClass14.int_58, 2))
						bool_2[l] = true;
					if (l % 3 == 0 && int_1[l] > GClass14.int_11 + GClass167.int_23)
					{
						int_0[l] = GClass191.smethod_19(-10, GClass14.int_10 + 300) + GClass167.int_22;
						int_1[l] = GClass191.smethod_19(-100, 0) + GClass167.int_23;
					}
					if (!bool_2[l])
					{
						int_1[l] += int_3[l];
						int_0[l] += int_2[l];
					}
					if (!bool_2[l])
						continue;
					int_20[l]++;
					if (int_20[l] > 2)
					{
						int_19[l]++;
						int_20[l] = 0;
						if (int_19[l] > 1)
						{
							int_19[l] = 0;
							bool_2[l] = false;
							int_0[l] = GClass191.smethod_19(-10, GClass14.int_10 + 300) + GClass167.int_22;
							int_1[l] = GClass191.smethod_19(-100, 0) + GClass167.int_23;
						}
					}
				}
				break;
			}
			case 13:
				smethod_3();
				break;
			case 14:
				smethod_4();
				break;
			case 1:
			case 2:
			case 5:
			case 6:
			case 7:
			case 11:
			case 15:
			{
				for (int i = 0; i < int_15; i++)
				{
					if (i % 3 != 0 && GClass137.smethod_28(int_0[i], int_1[i] + ((GClass137.int_25 == 15) ? 10 : 0), 2))
						bool_2[i] = true;
					if (i % 3 == 0 && int_1[i] > GClass137.int_24)
					{
						int_0[i] = GClass191.smethod_19(-10, GClass137.int_23 + 50);
						int_1[i] = GClass191.smethod_19(-50, 0);
					}
					if (bool_2[i])
					{
						int_20[i]++;
						if (int_20[i] == 100)
						{
							int_20[i] = 0;
							int_0[i] = GClass191.smethod_19(-10, GClass137.int_23 + 50);
							int_1[i] = GClass191.smethod_19(-50, 0);
							bool_2[i] = false;
						}
						continue;
					}
					for (int j = 0; j < GClass36.gclass122_0.method_2(); j++)
					{
						GClass36 gClass = (GClass36)GClass36.gclass122_0.method_3(j);
						if (gClass != null && gClass.bool_4 && int_0[i] < gClass.int_0 + 80 && int_0[i] > gClass.int_0 - 80 && int_1[i] < gClass.int_1 + 80 && int_1[i] > gClass.int_1 - 80)
							int_0[i] += ((int_0[i] >= gClass.int_0) ? 10 : (-10));
					}
					int_1[i] += int_3[i];
					int_0[i] += int_2[i];
					int_20[i]++;
					int num = ((int_16 != 11) ? 4 : 3);
					num = ((int_16 != 15) ? 4 : 4);
					if (int_20[i] > ((int_16 == 2) ? 4 : 2))
					{
						if (int_16 != 11 && int_16 != 15)
							int_19[i]++;
						int_20[i] = 0;
						if (int_19[i] > num - 1)
							int_19[i] = 0;
					}
				}
				break;
			}
			case 3:
				break;
			}
		}
		catch (Exception)
		{
		}
	}

	public void method_4(GClass193 g)
	{
		try
		{
			if (GClass66.smethod_0().bool_10)
				return;
			switch (int_16)
			{
			case 0:
			case 12:
			{
				for (int i = 0; i < int_15; i++)
				{
					if (int_14[i] == 2 && int_0[i] >= GClass167.int_22 && int_0[i] <= GClass14.int_10 + GClass167.int_22 && int_1[i] >= GClass167.int_23 && int_1[i] <= GClass14.int_11 + GClass167.int_23)
					{
						if (!bool_2[i])
							g.method_31(gclass20_2, int_0[i], int_1[i], 0);
						else
							g.method_23(gclass20_1, 0, 10 * int_19[i], 13, 10, 0, int_0[i], int_1[i] - 10, 0);
					}
				}
				break;
			}
			case 13:
				if (!bool_4)
					smethod_5(g);
				break;
			case 1:
			case 2:
			case 5:
			case 6:
			case 7:
			case 11:
			case 15:
				if (int_16 == 15)
				{
					if (GClass72.gclass26_0[11120] != null && GClass72.gclass26_0[11120].gclass20_0 != null)
						gclass20_5 = GClass72.gclass26_0[11120].gclass20_0;
					if (gclass20_5 == null)
						break;
				}
				method_5(g, gclass20_5);
				break;
			case 3:
			case 4:
			case 8:
			case 9:
			case 10:
			case 14:
				break;
			}
		}
		catch (Exception)
		{
		}
	}

	public void method_5(GClass193 g, GClass20 img)
	{
		if (GClass66.smethod_0().bool_10)
			return;
		if (int_16 != 11)
			_ = 4;
		else
			_ = 3;
		if (int_16 != 15)
			_ = 4;
		else
			_ = 4;
		for (int i = 0; i < int_15; i++)
		{
			if (i % 3 == 0 && int_0[i] >= GClass167.int_22 && int_0[i] <= GClass14.int_10 + GClass167.int_22 && int_1[i] >= GClass167.int_23 && int_1[i] <= GClass14.int_11 + GClass167.int_23 && img != null)
				g.method_23(img, 0, int_39 * int_19[i], img.method_0(), int_39, 0, int_0[i], int_1[i], 0);
		}
	}

	public void method_6(GClass193 g, GClass20 img)
	{
		if (GClass66.smethod_0().bool_10)
			return;
		if (int_16 != 11)
			_ = 4;
		else
			_ = 3;
		if (int_16 != 15)
			_ = 4;
		else
			_ = 4;
		for (int i = 0; i < int_15; i++)
		{
			if (i % 3 != 0 && int_0[i] >= GClass167.int_22 && int_0[i] <= GClass14.int_10 + GClass167.int_22 && int_1[i] >= GClass167.int_23 && int_1[i] <= GClass14.int_11 + GClass167.int_23 && img != null)
				g.method_23(img, 0, int_39 * int_19[i], img.method_0(), int_39, 0, int_0[i], int_1[i], 0);
		}
	}

	public void method_7(GClass193 g)
	{
		if (GClass66.smethod_0().bool_10)
			return;
		int num = int_16;
		if (num != 8)
		{
			if (num == 13 && bool_4)
				smethod_5(g);
			return;
		}
		g.method_23(gclass20_6, 0, 0, gclass20_6.method_0(), gclass20_6.method_1(), int_9, int_6, int_7, 3);
		if (int_8 == 1 || int_8 == 2)
		{
			int num2 = ((int_9 == 0) ? (-25) : 25);
			g.method_23(gclass20_7, 0, int_10 * 8, 20, 8, int_9, int_6 + num2, int_7 + 5, 3);
		}
		else
		{
			int num3 = ((int_9 != 0) ? (-11) : 11);
			g.method_23(gclass20_8, 0, int_10 * 18, 8, 18, int_9, int_6 + num3, int_7 + 22, 3);
		}
	}

	public void method_8(GClass193 g)
	{
		if (GClass66.smethod_0().bool_10)
			return;
		switch (int_16)
		{
		case 0:
		{
			g.method_16(10742731);
			for (int i = 0; i < int_15; i++)
			{
				if (int_14[i] != 2 && int_0[i] >= GClass167.int_22 && int_0[i] <= GClass14.int_10 + GClass167.int_22 && int_1[i] >= GClass167.int_23 && int_1[i] <= GClass14.int_11 + GClass167.int_23)
					g.method_31(gclass20_3, int_0[i], int_1[i], 0);
			}
			break;
		}
		case 1:
		case 2:
		case 5:
		case 6:
		case 7:
		case 11:
		case 15:
			if (int_16 == 15)
			{
				if (GClass72.gclass26_0[11120] != null && GClass72.gclass26_0[11120].gclass20_0 != null)
					gclass20_5 = GClass72.gclass26_0[11120].gclass20_0;
				if (gclass20_5 == null)
					break;
			}
			method_6(g, gclass20_5);
			break;
		case 3:
		case 4:
		case 8:
		case 9:
		case 10:
		case 12:
		case 13:
		case 14:
			break;
		}
	}

	public static void smethod_7(int id)
	{
		if (!GClass14.bool_1)
		{
			GClass181 o = new GClass181(id);
			gclass122_0.method_0(o);
		}
	}

	public static void smethod_8(int color, int yWater)
	{
		GClass181 gClass = new GClass181(10);
		gClass.int_22 = color;
		gClass.int_21 = yWater;
		gclass122_0.method_0(gClass);
	}

	public static void smethod_9(GClass193 g)
	{
		if (!GClass66.smethod_0().bool_10)
		{
			for (int i = 0; i < gclass122_0.method_2(); i++)
			{
				((GClass181)gclass122_0.method_3(i)).method_1(g);
			}
		}
	}

	public static void smethod_10(GClass193 g)
	{
		if (!GClass66.smethod_0().bool_10)
		{
			for (int i = 0; i < gclass122_0.method_2(); i++)
			{
				((GClass181)gclass122_0.method_3(i)).method_7(g);
			}
		}
	}

	public static void smethod_11(GClass193 g)
	{
		if (!GClass66.smethod_0().bool_10)
		{
			for (int i = 0; i < gclass122_0.method_2(); i++)
			{
				((GClass181)gclass122_0.method_3(i)).method_4(g);
			}
		}
	}

	public static void smethod_12(GClass193 g)
	{
		if (!GClass66.smethod_0().bool_10)
		{
			for (int i = 0; i < gclass122_0.method_2(); i++)
			{
				((GClass181)gclass122_0.method_3(i)).method_2(g);
			}
		}
	}

	public static void smethod_13(GClass193 g)
	{
		if (!GClass66.smethod_0().bool_10)
		{
			for (int i = 0; i < gclass122_0.method_2(); i++)
			{
				((GClass181)gclass122_0.method_3(i)).method_8(g);
			}
		}
	}

	public static void smethod_14()
	{
		for (int i = 0; i < gclass122_0.method_2(); i++)
		{
			((GClass181)gclass122_0.method_3(i)).method_3();
		}
	}
}