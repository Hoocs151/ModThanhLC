using ns1;

public class GClass201
{
	public int int_0;

	public int int_1;

	public short short_0;

	public int int_2;

	public int int_3;

	public int int_4;

	public int int_5;

	public sbyte sbyte_0;

	public int int_6;

	public int[] int_7;

	public int[] int_8;

	public static GClass175 gclass175_0 = new GClass175();

	public static GClass122 gclass122_0 = new GClass122();

	public static GClass122 gclass122_1 = new GClass122();

	private bool bool_0;

	public int int_9;

	public int int_10;

	public static int[] int_11 = new int[61]
	{
		79, 80, 81, 82, 83, 84, 85, 86, 87, 88,
		89, 90, 91, 92, 95, 144, 99, 100, 101, 102,
		103, 104, 105, 106, 107, 108, 109, 110, 111, 112,
		113, 114, 115, 117, 118, 119, 120, 121, 122, 123,
		124, 125, 126, 127, 132, 133, 134, 139, 140, 141,
		142, 143, 144, 145, 146, 147, 171, 121, 122, 229,
		218
	};

	public static int[] int_12 = new int[18]
	{
		79, 80, 81, 85, 86, 90, 91, 92, 99, 100,
		101, 102, 103, 104, 105, 106, 107, 108
	};

	public static sbyte[] sbyte_1;

	public static void smethod_0()
	{
	}

	public static bool smethod_1(string keyNew)
	{
		int num = 0;
		while (true)
		{
			if (num < gclass122_0.method_2())
			{
				if (((string)gclass122_0.method_3(num)).Equals(keyNew))
					break;
				num++;
				continue;
			}
			return false;
		}
		return true;
	}

	public static bool smethod_2(string keyLast)
	{
		for (int i = 0; i < gclass122_1.method_2(); i++)
		{
			if (((string)gclass122_1.method_3(i)).Equals(keyLast))
				return true;
		}
		return false;
	}

	public bool method_0()
	{
		if (GClass193.int_12 != 1)
		{
			if (GClass137.smethod_14())
				return true;
			int num = 0;
			while (true)
			{
				if (num < int_11.Length)
				{
					if (short_0 == int_11[num])
						break;
					num++;
					continue;
				}
				return false;
			}
			return true;
		}
		return true;
	}

	public bool method_1()
	{
		for (int i = 0; i < int_12.Length; i++)
		{
			if (short_0 == int_12[i])
				return true;
		}
		return false;
	}

	public void method_2()
	{
		if (method_0() || sbyte_0 == 2 || sbyte_0 == 4 || gclass175_0.method_7(short_0 + "blend" + sbyte_0))
			return;
		GClass20 gClass = (GClass20)gclass175_0.method_0(short_0 + string.Empty);
		if (gClass != null && gClass.method_3() > 4)
		{
			sbyte[] array = GClass141.smethod_1("x" + GClass193.int_12 + "blend" + short_0 + "layer" + sbyte_0);
			if (array != null)
			{
				GClass20 v = GClass20.smethod_6(array, 0, array.Length);
				gclass175_0.method_4(short_0 + "blend" + sbyte_0, v);
			}
			else
				gclass175_0.method_4(short_0 + "blend" + sbyte_0, GClass158.smethod_0(gClass, sbyte_0, short_0));
		}
	}

	public void method_3(GClass193 g)
	{
		if (GClass66.smethod_0().bool_10 || GClass124.bool_35 || (short_0 == 279 && GClass167.smethod_8().int_232 >= 110))
			return;
		int int_ = GClass167.int_22;
		int int_2 = GClass167.int_23;
		GClass20 gClass = null;
		gClass = ((sbyte_0 == 2 || sbyte_0 == 4) ? ((GClass20)gclass175_0.method_0(short_0 + string.Empty)) : ((!method_0()) ? ((GClass20)gclass175_0.method_0(short_0 + "blend" + sbyte_0)) : ((GClass20)gclass175_0.method_0(short_0 + string.Empty))));
		if (gClass == null || short_0 == 96)
			return;
		if (sbyte_0 == 4)
			int_9 = -int_ / 2 + 100;
		if (short_0 == 28 && sbyte_0 == 3)
			int_9 = -int_ / 3 + 200;
		if ((short_0 == 67 || short_0 == 68 || short_0 == 69 || short_0 == 70) && sbyte_0 == 3)
			int_9 = -int_ / 3 + 200;
		if (method_1() && sbyte_0 < 4)
		{
			int_9 = -(int_ >> 4) + 50;
			int_10 = (int_2 >> 5) - 15;
		}
		int num = this.int_2 + int_4 + int_9;
		int num2 = int_3 + int_5 + int_10;
		if (this.int_2 + int_4 + gClass.method_0() + int_9 >= int_ && this.int_2 + int_4 + int_9 <= int_ + GClass14.int_10 && int_3 + int_5 + int_10 + gClass.method_1() >= int_2 && int_3 + int_5 + int_10 <= int_2 + GClass14.int_11)
		{
			g.method_23(gClass, 0, 0, GClass193.smethod_0(gClass), GClass193.smethod_1(gClass), int_1, this.int_2 + int_4 + int_9, int_3 + int_5 + int_10, 0);
			if (short_0 == 11 && GClass137.int_37 != 122)
			{
				g.method_5(num, num2 + 24, 48, 14);
				for (int i = 0; i < 2; i++)
				{
					g.method_23(GClass137.gclass20_5, 0, (GClass14.int_8 % 8 >> 2) * 24, 24, 24, 0, num + i * 24, num2 + 24, 0);
				}
				g.method_5(GClass167.int_22, GClass167.int_23, GClass167.int_6, GClass167.int_7);
			}
		}
		if (GClass137.smethod_15() && short_0 > 137 && short_0 != 156 && short_0 != 159 && short_0 != 157 && short_0 != 165 && short_0 != 167 && short_0 != 168 && short_0 != 169 && short_0 != 170 && short_0 != 238 && GClass137.int_23 - (this.int_2 + int_4 + int_9) >= int_ && GClass137.int_23 - (this.int_2 + int_4 + int_9 + gClass.method_0()) <= int_ + GClass14.int_10 && int_3 + int_5 + int_10 + gClass.method_1() >= int_2 && int_3 + int_5 + int_10 <= int_2 + GClass14.int_11 && (short_0 < 241 || short_0 >= 266))
			g.method_23(gClass, 0, 0, GClass193.smethod_0(gClass), GClass193.smethod_1(gClass), 2, GClass137.int_23 - (this.int_2 + int_4 + int_9), int_3 + int_5 + int_10, GClass73.int_2);
	}
}