using System;

public class GClass126 : GClass125, GInterface1
{
	public static GClass20 gclass20_13;

	public static GClass20 gclass20_14 = GClass14.smethod_43("/mainImage/myTexture2dhatdau.png");

	public int int_192;

	public int int_193;

	public int int_194;

	public int int_195;

	public int int_196;

	public int int_197;

	public int int_198;

	public string string_15;

	public string string_16;

	public int int_199;

	public bool bool_83;

	public int[] int_200;

	public int[] int_201;

	private int int_202;

	public GClass139 gclass139_0;

	public bool bool_84;

	public static bool bool_85 = true;

	public bool bool_86;

	public int int_203;

	public long long_20;

	public long long_21;

	private int int_204;

	private bool bool_87;

	private int int_205;

	public GClass126(int npcId, int status, int cx, int cy, int templateId, int iconId)
		: base(npcId, status, cx, cy, templateId, iconId)
	{
		gclass139_0 = new GClass139(string.Empty, 0, 0);
		gclass139_0.gclass118_0 = new GClass118(null, this, 1, null);
		GClass139.smethod_2(gclass139_0);
	}

	public override void paint(GClass193 g)
	{
		if (int_192 == 0)
			return;
		GClass72.smethod_6(g, int_192, int_4, int_5, 0, GClass73.int_3);
		if (GClass124.smethod_1().gclass125_0 != null && GClass124.smethod_1().gclass125_0.Equals(this))
		{
			g.method_23(GClass6.gclass20_0, 0, 0, 9, 6, 0, int_4, int_5 - GClass72.int_0[int_192][4] - 1, GClass193.int_5 | GClass193.int_0);
			if (string_16 != null)
				GClass104.gclass104_3.method_10(g, string_16, int_4, int_5 - GClass72.int_0[int_192][4] - 20, GClass104.int_2, GClass104.gclass104_16);
		}
		else if (string_16 != null)
		{
			GClass104.gclass104_3.method_10(g, string_16, int_4, int_5 - GClass72.int_0[int_192][4] - 17, GClass104.int_2, GClass104.gclass104_16);
		}
		try
		{
			for (int i = 0; i < int_196; i++)
			{
				g.method_31(gclass20_14, int_4 + int_200[i] - GClass72.int_0[int_192][3] / 2, int_5 + int_201[i] - GClass72.int_0[int_192][4], 0);
			}
		}
		catch (Exception)
		{
		}
		if (int_125 < 0 || gclass80_1 == null || sbyte_19 != 0)
			return;
		GClass72.smethod_6(g, gclass80_1.gclass31_0[int_125].int_2, int_4 + gclass80_1.gclass31_0[int_125].int_0 + GClass72.int_0[int_192][3] / 2 + 5, int_5 - 15 + gclass80_1.gclass31_0[int_125].int_1, 0, GClass193.int_1 | GClass193.int_0);
		if (GClass14.int_8 % 2 == 0)
		{
			int_125++;
			if (int_125 >= gclass80_1.gclass31_0.Length)
				int_125 = 0;
		}
	}

	public override void update()
	{
		gclass139_0.bool_1 = bool_85;
		long_21 = GClass77.smethod_18();
		if (long_21 - long_20 >= 1000L)
		{
			int_203--;
			long_20 = long_21;
			if (int_203 < 0)
				int_203 = 0;
		}
		if (bool_83)
		{
			if (int_203 == 0)
			{
				bool_83 = false;
				bool_87 = true;
			}
		}
		else if (int_196 < int_198 && int_203 == 0)
		{
			bool_87 = true;
		}
		if (bool_87)
		{
			int_205++;
			if (int_205 == 20)
			{
				int_205 = 0;
				bool_87 = false;
				GClass2.smethod_0().method_123(2);
			}
		}
		int_202 = ((int_200 != null) ? (int_200.Length * int_196 / int_198) : 0);
		if (bool_84)
		{
			bool_84 = false;
			if ((int_203 >= 0 && int_196 < int_198) || (int_203 >= 0 && bool_83) || bool_86)
				gclass139_0.method_0(new string[2]
				{
					bool_83 ? mResources.UPGRADING : (int_196 + "/" + int_198),
					GClass138.smethod_8(int_203)
				}, int_4, int_5 - 20 - GClass72.int_0[int_192][4]);
			else if (int_196 == int_198 && !bool_83)
			{
				gclass139_0.method_0(new string[2]
				{
					mResources.can_harvest,
					int_196 + "/" + int_198
				}, int_4, int_5 - 20 - GClass72.int_0[int_192][4]);
			}
		}
		if ((int_203 >= 0 && int_196 < int_198) || (int_203 >= 0 && bool_83))
			gclass139_0.string_0[gclass139_0.string_0.Length - 1] = GClass138.smethod_8(int_203);
		if (bool_86)
		{
			gclass139_0.bool_1 = false;
			GClass91.smethod_0(98, int_4 + int_200[int_196 - 1] - GClass72.int_0[int_192][3] / 2, int_5 + int_201[int_196 - 1] - GClass72.int_0[int_192][4], 1);
			int_196--;
			if (GClass14.int_8 % 2 == 0)
				GClass147.smethod_1().method_3();
			if (int_196 == int_197)
			{
				gclass139_0.bool_1 = true;
				bool_84 = true;
				bool_86 = false;
			}
		}
		base.update();
	}

	public void perform(int idAction, object p)
	{
		if (idAction == 1)
			GClass2.smethod_0().method_41(1);
	}
}