using System;
using System.Collections.Generic;
using System.IO;
using ns1;

internal class Class11 : GInterface1
{
	public struct Struct38
	{
		public string string_0;

		public List<int> list_0;

		public Struct38(string string_1, List<int> list_1)
		{
			string_0 = string_1;
			list_0 = list_1;
		}
	}

	private static Class11 class11_0;

	public int int_0 = 100;

	public int int_1;

	public List<int> list_0;

	private int int_2;

	public bool bool_0;

	private bool bool_1;

	private long long_0;

	private long long_1;

	public bool bool_2;

	public bool bool_3 = false;

	public bool bool_4;

	public int int_3 = -1;

	public int int_4;

	public static Class11 smethod_0()
	{
		return (class11_0 != null) ? class11_0 : (class11_0 = new Class11());
	}

	public void method_0()
	{
		try
		{
			if (GClass14.gclass160_0 == GClass171.gclass171_0 || GClass124.bool_33 || GClass93.bool_5 || GClass124.bool_35)
				return;
			if (GClass137.int_37 == 21 + GClass124.smethod_1().int_14 && GClass57.smethod_0().bool_0 && !bool_4)
			{
				for (int i = 0; i < GClass167.gclass122_6.method_2(); i++)
				{
					GClass190 gClass = (GClass190)GClass167.gclass122_6.method_3(i);
					if (GClass167.gclass122_6.method_2() != 0)
					{
						if ((gClass.int_8 == GClass124.smethod_1().int_13 || gClass.int_8 == -1) && gClass.gclass203_0.short_0 == 74)
						{
							GClass124.smethod_1().gclass190_0 = gClass;
							GClass2.smethod_0().method_74(GClass124.smethod_1().gclass190_0.int_9);
							bool_4 = true;
							method_1(1000);
							return;
						}
						continue;
					}
					bool_4 = true;
					return;
				}
			}
			if (method_2() || GClass46.smethod_0().bool_1)
				return;
			if (bool_2)
			{
				method_1(int_0);
				bool_2 = false;
			}
			else if (!bool_0)
			{
				if (list_0 == null)
				{
					if (GClass46.smethod_0().dictionary_0 == null)
					{
						GClass46.smethod_0().method_2();
						return;
					}
					list_0 = GClass64.smethod_0().method_0(GClass137.int_37, int_1);
					int_2 = 0;
					if (list_0 == null)
					{
						method_9();
						return;
					}
				}
				if ((GClass137.int_37 == list_0[list_0.Count - 1] || GClass137.int_37 == int_1) && !GClass46.smethod_8())
				{
					if (int_3 == -1 || GClass137.int_39 == int_3)
					{
						int_3 = ((GClass137.int_39 != int_3 || int_3 == -1) ? int_3 : (-1));
						method_9();
						return;
					}
					method_1(1000);
					if (GClass167.smethod_8().int_63[int_3] < (GClass54.smethod_0().method_5() ? 25 : 15))
						GClass2.smethod_0().method_42(int_3, -1);
				}
				else if (GClass137.int_37 == list_0[int_2])
				{
					if (!GClass46.smethod_8())
					{
						if (GClass46.smethod_9())
						{
							method_11(list_0[int_2 + 1]);
							bool_2 = true;
						}
					}
					else
					{
						GClass2.smethod_0().method_76();
						bool_0 = true;
						bool_2 = true;
						list_0 = null;
					}
					method_1(650);
				}
				else if (GClass137.int_37 != list_0[int_2 + 1])
				{
					bool_0 = true;
					list_0 = null;
				}
				else
				{
					int_2++;
				}
			}
			else
			{
				GClass46.smethod_0().dictionary_0 = null;
				list_0 = null;
				bool_0 = false;
			}
		}
		catch (Exception ex)
		{
			GClass51.smethod_0("Data/Errors/XmapErrorUpdate.txt", ex.ToString());
		}
	}

	public void perform(int idAction, object p)
	{
		if (idAction != 1)
		{
			if (idAction == 2)
				method_8((int)p);
		}
		else
			method_5((List<int>)p);
	}

	public void method_1(int int_5)
	{
		bool_1 = true;
		long_0 = GClass77.smethod_18();
		long_1 = int_5;
	}

	private bool method_2()
	{
		if (bool_1 && GClass77.smethod_18() - long_0 >= long_1)
			bool_1 = false;
		return bool_1;
	}

	public void method_3()
	{
		GClass14.gclass113_1 = new GClass113();
		GClass14.gclass113_1.method_50();
		GClass46.smethod_0().method_4();
		GClass53.smethod_0().method_1(0);
		GClass14.gclass113_0.int_29 = 3;
		GClass14.gclass113_0.int_41 = GClass46.smethod_0().list_0.Count;
		GClass14.gclass113_0.method_50();
	}

	public void method_4()
	{
		GClass46.smethod_0().method_4();
		GClass122 gClass = new GClass122();
		foreach (GStruct12 item in GClass46.smethod_0().list_0)
		{
			gClass.method_0(new GClass118(item.string_0, smethod_0(), 1, item.list_0));
		}
		GClass14.gclass116_0.bool_1 = true;
		GClass14.gclass116_0.method_2(gClass, 0);
	}

	public void method_5(List<int> list_1)
	{
		GClass46.smethod_0().method_4();
		GClass122 gClass = new GClass122();
		foreach (int item in list_1)
		{
			gClass.method_0(new GClass118(method_6(item), smethod_0(), 2, item));
		}
		GClass14.gclass116_0.bool_1 = true;
		GClass14.gclass116_0.method_2(gClass, 0);
	}

	public string method_6(int int_5)
	{
		string text = "";
		switch (int_5)
		{
		default:
			if (int_5 != 129)
				goto case 111;
			return (mResources.language != 0) ? "23rd World Martial Arena" : "Đại hội võ thuật 23";
		case 105:
			return (mResources.language != 0) ? "Snow Field" : "Cánh đồng tuyết";
		case 106:
			return (mResources.language != 0) ? "Snow Forest" : "Rừng tuyết";
		case 107:
			return (mResources.language == 0) ? "Núi tuyết" : "Snow Mountain";
		case 108:
			return (mResources.language == 0) ? "Dòng sông băng" : "Frozen River";
		case 109:
			return (mResources.language != 0) ? "Frozen Forest" : "Rừng băng";
		case 110:
			return (mResources.language == 0) ? "Hang băng" : "Frozen Cave";
		case 111:
		case 112:
			return GClass137.string_2[int_5];
		case 113:
			return (mResources.language != 0) ? "Super Rank" : "Võ đài siêu hạng";
		}
	}

	public void method_7(List<int> list_1)
	{
		GClass57.smethod_0().bool_1 = true;
		int count = list_1.Count;
		GClass14.gclass113_0.int_41 = count;
		GClass14.gclass113_0.string_4 = new string[count];
		GClass14.gclass113_0.string_5 = new string[count];
		for (int i = 0; i < count; i++)
		{
			string text = method_6(list_1[i]);
			GClass14.gclass113_0.string_4[i] = list_1[i] + ": " + text;
			GClass14.gclass113_0.string_5[i] = "";
		}
		GClass14.gclass113_0.method_6();
		GClass14.gclass113_0.method_50();
	}

	public void method_8(int int_5)
	{
		if ((int_5 == 153 || (int_5 >= 156 && int_5 <= 159)) && GClass124.smethod_1().gclass187_0 == null)
		{
			GClass167.gclass130_0.method_7((GClass62.int_0 == 0) ? "Mày chưa có bang mà đòi vào à?" : "You don't have clan to enter this place!", 0);
			method_9();
			return;
		}
		if (int_5 >= 92 && int_5 <= 102 && ((GClass137.int_37 <= 102 && GClass137.int_37 >= 92) || GClass137.int_37 == 103))
		{
			if (GClass57.smethod_0().bool_3)
				GClass57.smethod_0().bool_3 = false;
			if (GClass57.smethod_0().bool_4)
				GClass57.smethod_0().bool_4 = false;
		}
		bool_4 = false;
		int_1 = int_5;
		GClass57.smethod_0().bool_0 = true;
	}

	public void method_9()
	{
		if (!GClass57.smethod_0().bool_3)
			GClass57.smethod_0().bool_3 = true;
		if (!GClass57.smethod_0().bool_4)
			GClass57.smethod_0().bool_4 = true;
		GClass57.smethod_0().bool_0 = false;
		bool_0 = false;
		GClass46.smethod_0().dictionary_0 = null;
		list_0 = null;
		bool_4 = false;
	}

	public void method_10()
	{
		GClass57.smethod_0().int_0 = GClass137.int_37;
	}

	private void method_11(int int_5)
	{
		List<GStruct0> list = GClass46.smethod_1(GClass137.int_37);
		if (list != null)
		{
			foreach (GStruct0 item in list)
			{
				if (item.int_0 == int_5)
				{
					method_12(item);
					return;
				}
			}
		}
		GClass167.gclass130_0.method_7("Lỗi tại dữ liệu", 0);
	}

	private void method_12(GStruct0 gstruct0_0)
	{
		switch (gstruct0_0.genum1_0)
		{
		case GEnum1.const_0:
			method_14(gstruct0_0);
			break;
		case GEnum1.const_1:
			method_17(gstruct0_0);
			break;
		case GEnum1.const_2:
			method_18(gstruct0_0);
			break;
		case GEnum1.const_3:
			method_19(gstruct0_0);
			break;
		case GEnum1.const_4:
			method_20(gstruct0_0);
			break;
		case GEnum1.const_5:
			method_13(gstruct0_0);
			break;
		}
	}

	private void method_13(GStruct0 gstruct0_0)
	{
		int num = gstruct0_0.int_1[0];
		if (gstruct0_0.int_0 == 146)
		{
			GClass2.smethod_0().method_20(0, 1, -1, (short)num);
			GClass14.smethod_1().method_10(-5);
		}
		else if (gstruct0_0.int_0 == 176)
		{
			GClass2.smethod_0().method_20(0, 1, -1, (short)num);
			if (GClass14.gclass116_0 != null && GClass14.gclass116_0.bool_0)
				GClass14.smethod_1().method_10(-5);
		}
		else if (gstruct0_0.int_0 != 177)
		{
			GClass2.smethod_0().method_20(0, 1, -1, (short)num);
		}
		else
		{
			GClass2.smethod_0().method_20(0, 1, -1, (short)num);
			if (GClass14.gclass116_0 != null && GClass14.gclass116_0.bool_0)
				GClass14.smethod_1().method_10(-5);
		}
	}

	private void method_14(GStruct0 gstruct0_0)
	{
		GClass15 gClass = GClass46.smethod_5(gstruct0_0.int_0);
		if (GClass137.int_37 == 16 && gstruct0_0.int_0 == 15)
			gClass?.gclass139_0.method_4(1);
		else
		{
			if (gClass == null)
				return;
			int num = GClass46.smethod_6(gClass);
			int num2 = GClass46.smethod_7(gClass);
			if (GClass191.smethod_24(GClass124.smethod_1().int_4, GClass124.smethod_1().int_5, num, num2) <= 10)
			{
				if (GClass137.smethod_35() != null)
					method_25(gClass);
			}
			else
				method_16(num, num2);
		}
	}

	public void method_15()
	{
		if (GClass137.int_37 != 27)
		{
			if (GClass137.int_37 != 29)
			{
				if (int_4 != 0)
				{
					if (int_4 == 1)
					{
						method_11(27);
						bool_2 = true;
					}
				}
				else
				{
					method_11(29);
					bool_2 = true;
				}
			}
			else
			{
				method_11(28);
				bool_2 = true;
				int_4 = 1;
			}
		}
		else
		{
			method_11(28);
			bool_2 = true;
			int_4 = 0;
		}
	}

	public void method_16(int int_5, int int_6)
	{
		if (!GClass57.smethod_0().bool_0 && (GClass13.smethod_0(GClass124.smethod_1().int_4 - int_5) <= 576 || !GClass137.smethod_28(int_5, int_6, 2)))
		{
			int num = int_5 - GClass124.smethod_1().int_4;
			int num2 = GClass13.smethod_0(num);
			int num3 = ((num > 0) ? 1 : (-1));
			for (int i = 0; i < num2; i++)
			{
				if (!GClass137.smethod_28(GClass124.smethod_1().int_4 + num3 * 48, GClass124.smethod_1().int_5, 2))
				{
					int num4 = 96;
					int num5 = 0;
					while (num5 < 50)
					{
						num4 += 24;
						if (GClass137.smethod_28(GClass124.smethod_1().int_4 + num3 * 48, num4, 2))
						{
							if (num4 % 24 != 0)
								num4 -= num4 % 24;
							if (num4 < GClass124.smethod_1().int_5 || GClass137.smethod_28(GClass124.smethod_1().int_4 + num3 * 48, 0, 4) || GClass137.smethod_28(GClass124.smethod_1().int_4 + num3 * 48, 0, 8))
								GClass124.smethod_1().int_5 = num4;
						}
						else
							num5++;
					}
				}
				GClass124.smethod_1().int_4 += num3 * 48;
				GClass2.smethod_0().method_44();
			}
			GClass124.smethod_1().int_4 += num3 * num2;
			GClass124.smethod_1().int_5 = int_6;
			GClass2.smethod_0().method_44();
		}
		else
		{
			GClass124.smethod_1().int_4 = int_5;
			GClass124.smethod_1().int_5 = int_6;
			GClass2.smethod_0().method_44();
			GClass124.smethod_1().int_4 = int_5;
			GClass124.smethod_1().int_5 = int_6 + 1;
			GClass2.smethod_0().method_44();
			GClass124.smethod_1().int_4 = int_5;
			GClass124.smethod_1().int_5 = int_6;
			GClass2.smethod_0().method_44();
		}
	}

	private void method_17(GStruct0 gstruct0_0)
	{
		int num = gstruct0_0.int_1[0];
		if (GClass167.smethod_13((short)num) != null)
		{
			if ((num >= 30 && num <= 36) || num == 12)
			{
				for (int i = 0; i < GClass167.gclass122_10.method_2(); i++)
				{
					if (GClass167.gclass122_10.method_3(i) is GClass125 gClass && gClass.gclass120_0.int_0 == num && GClass191.smethod_24(GClass124.smethod_1().int_4, GClass124.smethod_1().int_5, gClass.int_4, gClass.int_5) > 10)
					{
						GClass124.smethod_1().int_4 = gClass.int_4;
						GClass124.smethod_1().int_5 = gClass.int_5 - 3;
						GClass2.smethod_0().method_44();
						GClass124.smethod_1().int_4 = gClass.int_4;
						GClass124.smethod_1().int_5 = gClass.int_5;
						GClass2.smethod_0().method_44();
						GClass124.smethod_1().int_4 = gClass.int_4;
						GClass124.smethod_1().int_5 = gClass.int_5 - 3;
						GClass2.smethod_0().method_44();
						return;
					}
				}
			}
			if ((!GClass14.gclass116_0.bool_0 && GClass14.gclass116_0 != null) || GClass14.gclass116_0 == null)
			{
				GClass2.smethod_0().method_60(num);
				GClass53.smethod_0().method_0();
			}
			else
			{
				if (GClass14.gclass116_0 == null || !GClass14.gclass116_0.bool_0)
					return;
				for (int j = 0; j < GClass14.gclass116_0.gclass122_0.method_2(); j++)
				{
					GClass118 gClass2 = (GClass118)GClass14.gclass116_0.gclass122_0.method_3(j);
					if (File.Exists("Data/QLTK/EventButton.txt") && !string.IsNullOrEmpty(File.ReadAllText("Data/QLTK/EventButton.txt")))
					{
						string caption = File.ReadAllText("Data/QLTK/EventButton.txt").ToLower().Trim()
							.Replace(" ", "");
						if (GClass45.smethod_0().method_0(gClass2.string_0, caption))
						{
							GClass2.smethod_0().method_59((short)num, (sbyte)j);
							GClass53.smethod_0().method_0();
							break;
						}
					}
					int num2 = num;
					if (num2 <= 44)
					{
						switch (num2)
						{
						default:
							switch (num2)
							{
							default:
							{
								if (num2 != 44)
									break;
								int num5 = gstruct0_0.int_0;
								if (num5 != 48)
								{
									if (num5 != 154)
									{
										if (num5 != 155 || !GClass45.smethod_0().method_0(gClass2.string_0, (mResources.language == 0) ? "đếnhànhtinhngụctù" : "gotoprisonplanet"))
											continue;
										GClass2.smethod_0().method_59((short)num, (sbyte)j);
										GClass53.smethod_0().method_0();
									}
									else
									{
										if (!GClass45.smethod_0().method_0(gClass2.string_0, (mResources.language == 0) ? "đếnhànhtinhbill" : "gotobeerusplanet"))
											continue;
										GClass2.smethod_0().method_59((short)num, (sbyte)j);
										GClass53.smethod_0().method_0();
									}
								}
								else
								{
									if (!GClass45.smethod_0().method_0(gClass2.string_0, (mResources.language != 0) ? "gotokaio" : "đếnkaio"))
										continue;
									GClass2.smethod_0().method_59((short)num, (sbyte)j);
									GClass53.smethod_0().method_0();
								}
								return;
							}
							case 21:
							{
								int num7 = gstruct0_0.int_0;
								if (num7 != 5)
								{
									if (num7 != 112 || !GClass45.smethod_0().method_0(gClass2.string_0, (mResources.language == 0) ? "võđàisinhtử" : "deathoralivearena"))
										continue;
									GClass2.smethod_0().method_59((short)num, (sbyte)j);
									GClass53.smethod_0().method_0();
								}
								else
								{
									if (!GClass45.smethod_0().method_0(gClass2.string_0, (mResources.language != 0) ? "gokame house" : "vềđảorùa"))
										continue;
									GClass2.smethod_0().method_59((short)num, (sbyte)j);
									GClass53.smethod_0().method_0();
								}
								return;
							}
							case 23:
							{
								int num6 = gstruct0_0.int_0;
								if (num6 != 52)
								{
									if (num6 != 113)
									{
										if (num6 != 129 || !GClass45.smethod_0().method_0(gClass2.string_0, (mResources.language != 0) ? "worldmartialarena23rd" : "đạihộivõthuậtlầnthứ23"))
											continue;
										GClass2.smethod_0().method_59((short)num, (sbyte)j);
										GClass53.smethod_0().method_0();
									}
									else
									{
										if (!GClass45.smethod_0().method_0(gClass2.string_0, (mResources.language == 0) ? "giảisiêuhạng" : "superrank"))
											continue;
										GClass2.smethod_0().method_59((short)num, (sbyte)j);
										GClass53.smethod_0().method_0();
									}
								}
								else
								{
									if (!GClass45.smethod_0().method_0(gClass2.string_0, (mResources.language != 0) ? "gotomartialartarena" : "vềđạihộivõthuật"))
										continue;
									GClass2.smethod_0().method_59((short)num, (sbyte)j);
									GClass53.smethod_0().method_0();
								}
								return;
							}
							case 30:
								if (!gClass2.string_0.ToLower().Contains((mResources.language != 0) ? "home" : "nhà"))
									continue;
								GClass2.smethod_0().method_59((short)num, (sbyte)j);
								GClass53.smethod_0().method_0();
								return;
							case 31:
								if (!gClass2.string_0.ToLower().Contains((mResources.language == 0) ? "nhà" : "home"))
									continue;
								GClass2.smethod_0().method_59((short)num, (sbyte)j);
								GClass53.smethod_0().method_0();
								return;
							case 32:
								if (!gClass2.string_0.ToLower().Contains((mResources.language != 0) ? "home" : "nhà"))
									continue;
								GClass2.smethod_0().method_59((short)num, (sbyte)j);
								GClass53.smethod_0().method_0();
								return;
							case 33:
								if (!gClass2.string_0.ToLower().Contains((mResources.language == 0) ? "nhà" : "home"))
									continue;
								GClass2.smethod_0().method_59((short)num, (sbyte)j);
								GClass53.smethod_0().method_0();
								return;
							case 34:
								if (!gClass2.string_0.ToLower().Contains((mResources.language == 0) ? "nhà" : "home"))
									continue;
								GClass2.smethod_0().method_59((short)num, (sbyte)j);
								GClass53.smethod_0().method_0();
								return;
							case 35:
								if (!gClass2.string_0.ToLower().Contains((mResources.language == 0) ? "nhà" : "home"))
									continue;
								GClass2.smethod_0().method_59((short)num, (sbyte)j);
								GClass53.smethod_0().method_0();
								return;
							case 36:
								if (!gClass2.string_0.ToLower().Contains((mResources.language != 0) ? "home" : "nhà"))
									continue;
								GClass2.smethod_0().method_59((short)num, (sbyte)j);
								GClass53.smethod_0().method_0();
								return;
							case 38:
							{
								int num4 = gstruct0_0.int_0;
								if (num4 != 24)
								{
									if (num4 != 102 || !GClass45.smethod_0().method_0(gClass2.string_0, (mResources.language != 0) ? "gotofuture" : "điđếntươnglai"))
										continue;
									GClass2.smethod_0().method_59((short)num, (sbyte)j);
									GClass53.smethod_0().method_0();
								}
								else
								{
									if (!GClass45.smethod_0().method_0(gClass2.string_0, (mResources.language != 0) ? "comebackthepast" : "quayvềquákhứ"))
										continue;
									GClass2.smethod_0().method_59((short)num, (sbyte)j);
									GClass53.smethod_0().method_0();
								}
								return;
							}
							case 22:
							case 24:
							case 25:
							case 26:
							case 27:
							case 28:
							case 29:
							case 37:
								break;
							}
							break;
						case 10:
						{
							int num9 = gstruct0_0.int_0;
							if (num9 != 5)
							{
								switch (num9)
								{
								default:
									if (num9 != 84 || !GClass45.smethod_0().method_0(gClass2.string_0, (mResources.language != 0) ? "tosupermarket" : "siêuthị"))
										break;
									GClass2.smethod_0().method_59((short)num, (sbyte)j);
									GClass53.smethod_0().method_0();
									return;
								case 24:
									if (GClass137.int_37 == 176)
									{
										if (GClass45.smethod_0().method_0(gClass2.string_0, (mResources.language == 0) ? "đồngý" : "accept"))
										{
											GClass2.smethod_0().method_59((short)num, (sbyte)j);
											GClass53.smethod_0().method_0();
											return;
										}
										if (GClass45.smethod_0().method_0(gClass2.string_0, (mResources.language == 0) ? "đếntráiđất" : "toearth"))
										{
											GClass2.smethod_0().method_59((short)num, (sbyte)j);
											GClass53.smethod_0().method_0();
											return;
										}
									}
									break;
								case 25:
									if (GClass45.smethod_0().method_0(gClass2.string_0, (mResources.language != 0) ? "tonamek" : "đếnnamếc"))
									{
										GClass2.smethod_0().method_59((short)num, (sbyte)j);
										GClass53.smethod_0().method_0();
										return;
									}
									break;
								case 26:
									if (!GClass45.smethod_0().method_0(gClass2.string_0, (mResources.language == 0) ? "đếnxayda" : "tosaiya"))
										break;
									GClass2.smethod_0().method_59((short)num, (sbyte)j);
									GClass53.smethod_0().method_0();
									return;
								}
							}
							else if (GClass45.smethod_0().method_0(gClass2.string_0, (mResources.language != 0) ? "kameisland" : "đảokame"))
							{
								GClass2.smethod_0().method_59((short)num, (sbyte)j);
								GClass53.smethod_0().method_0();
								return;
							}
							continue;
						}
						case 12:
						{
							int num8 = gstruct0_0.int_0;
							if (num8 <= 25)
							{
								if (num8 != 19)
								{
									if (num8 != 24)
									{
										if (num8 != 25 || !GClass45.smethod_0().method_0(gClass2.string_0, (mResources.language != 0) ? "tonamek" : "đếnnamếc"))
											continue;
										GClass2.smethod_0().method_59((short)num, (sbyte)j);
										GClass53.smethod_0().method_0();
									}
									else
									{
										if (!GClass45.smethod_0().method_0(gClass2.string_0, (mResources.language == 0) ? "đếntráiđất" : "toearth"))
											continue;
										GClass2.smethod_0().method_59((short)num, (sbyte)j);
										GClass53.smethod_0().method_0();
									}
								}
								else
								{
									if (!gClass2.string_0.ToLower().Contains(mResources.ACCEPT.ToLower()))
										continue;
									GClass2.smethod_0().method_59((short)num, (sbyte)j);
									GClass53.smethod_0().method_0();
								}
							}
							else if (num8 != 68)
							{
								if (num8 != 84)
								{
									if (num8 != 109 || !GClass45.smethod_0().method_0(gClass2.string_0, (mResources.language == 0) ? "đếncold" : "gotocold"))
										continue;
									GClass2.smethod_0().method_59((short)num, (sbyte)j);
									GClass53.smethod_0().method_0();
								}
								else
								{
									if (!GClass45.smethod_0().method_0(gClass2.string_0, (mResources.language != 0) ? "tosupermarket" : "siêuthị"))
										continue;
									GClass2.smethod_0().method_59((short)num, (sbyte)j);
									GClass53.smethod_0().method_0();
								}
							}
							else
							{
								if (!gClass2.string_0.ToLower().Contains(mResources.ACCEPT.ToLower()) && !GClass45.smethod_0().method_0(gClass2.string_0, (mResources.language != 0) ? "gotonappa" : "đếnnappa"))
									continue;
								GClass2.smethod_0().method_59((short)num, (sbyte)j);
								GClass53.smethod_0().method_0();
							}
							return;
						}
						case 13:
							if (!GClass45.smethod_0().method_0(gClass2.string_0, (mResources.language == 0) ? "nóichuyện" : "talk"))
							{
								int num3 = gstruct0_0.int_0;
								if (num3 != 135)
								{
									if (num3 != 153 || !GClass45.smethod_0().method_0(gClass2.string_0, (mResources.language == 0) ? "vềkhuvựcbang" : "returntoclanarea"))
										continue;
									GClass2.smethod_0().method_59((short)num, (sbyte)j);
									GClass53.smethod_0().method_0();
								}
								else if (!GClass45.smethod_0().method_0(gClass2.string_0, (mResources.language == 0) ? "khobáudướibiển" : "treasureundersea"))
								{
									if (!gClass2.string_0.ToLower().Contains(mResources.ACCEPT.ToLower()))
										continue;
									GClass2.smethod_0().method_59((short)num, (sbyte)j);
									GClass53.smethod_0().method_0();
								}
								else
								{
									GClass2.smethod_0().method_59((short)num, (sbyte)j);
									GClass53.smethod_0().method_0();
								}
							}
							else
							{
								GClass2.smethod_0().method_59((short)num, (sbyte)j);
								GClass53.smethod_0().method_0();
							}
							return;
						case 11:
							break;
						}
					}
					else
					{
						if (num2 == 47)
						{
							if (gstruct0_0.int_0 != 156 || !gClass2.string_0.ToLower().StartsWith("ok"))
								continue;
							GClass2.smethod_0().method_59((short)num, (sbyte)j);
							GClass53.smethod_0().method_0();
							break;
						}
						if (num2 == 52)
						{
							if (gstruct0_0.int_0 != 24 || GClass137.int_37 != 177 || !GClass45.smethod_0().method_0(gClass2.string_0, (mResources.language == 0) ? "đồngý" : "accept"))
								continue;
							GClass2.smethod_0().method_59((short)num, (sbyte)j);
							GClass53.smethod_0().method_0();
							break;
						}
						if (num2 == 67)
						{
							if (gstruct0_0.int_0 == 149)
							{
								if (gClass2.string_0.ToLower().StartsWith("ok"))
								{
									GClass2.smethod_0().method_59((short)num, (sbyte)j);
									GClass53.smethod_0().method_0();
									break;
								}
								if (gClass2.string_0.ToLower().Contains(mResources.ACCEPT.ToLower()))
								{
									GClass2.smethod_0().method_59((short)num, (sbyte)j);
									GClass53.smethod_0().method_0();
									break;
								}
							}
							continue;
						}
					}
					for (int k = 1; k < gstruct0_0.int_1.Length; k++)
					{
						int num10 = gstruct0_0.int_1[k];
						GClass2.smethod_0().method_59((short)num, (sbyte)num10);
					}
				}
			}
		}
		else
			method_15();
	}

	private void method_18(GStruct0 gstruct0_0)
	{
		int num = gstruct0_0.int_1[0];
		int num2 = gstruct0_0.int_1[1];
		int selected = gstruct0_0.int_1[2];
		if (num == 29)
		{
			if (!GClass14.gclass113_0.bool_0)
			{
				if (!GClass14.gclass116_0.bool_0)
				{
					GClass2.smethod_0().method_60(num);
					return;
				}
				for (int i = 0; i < GClass14.gclass116_0.gclass122_0.method_2(); i++)
				{
					GClass118 gClass = (GClass118)GClass14.gclass116_0.gclass122_0.method_3(i);
					if (File.Exists("Data/QLTK/EventButton.txt") && !string.IsNullOrEmpty(File.ReadAllText("Data/QLTK/EventButton.txt")))
					{
						string caption = File.ReadAllText("Data/QLTK/EventButton.txt").ToLower().Trim()
							.Replace(" ", "");
						if (GClass45.smethod_0().method_0(gClass.string_0, caption))
						{
							GClass2.smethod_0().method_59((short)num, (sbyte)i);
							GClass53.smethod_0().method_0();
							return;
						}
					}
					if (GClass45.smethod_0().method_0(gClass.string_0, (mResources.language == 0) ? "thamgia" : "join"))
					{
						GClass2.smethod_0().method_59((short)num, (sbyte)i);
						GClass53.smethod_0().method_0();
						return;
					}
				}
			}
			if (GClass14.gclass113_0.bool_0)
				GClass2.smethod_0().method_126(selected);
			GClass53.smethod_0().method_0();
		}
		else
		{
			GClass2.smethod_0().method_60(num);
			GClass2.smethod_0().method_59((short)num, (sbyte)num2);
			GClass2.smethod_0().method_126(selected);
		}
	}

	private void method_19(GStruct0 gstruct0_0)
	{
		method_24(gstruct0_0.int_1[0], gstruct0_0.int_1[1]);
		GClass2.smethod_0().method_40();
		GClass2.smethod_0().method_114();
	}

	private void method_20(GStruct0 gstruct0_0)
	{
		method_10();
		int selected = gstruct0_0.int_1[0];
		GClass2.smethod_0().method_126(selected);
	}

	public void method_21()
	{
		GClass57.smethod_0().bool_2 = false;
		GClass2.smethod_0().method_20(0, 1, -1, 193);
	}

	public void method_22()
	{
		GClass57.smethod_0().bool_2 = false;
		GClass2.smethod_0().method_20(0, 1, -1, 194);
	}

	public void method_23()
	{
		GClass96.smethod_5();
	}

	public void method_24(int int_5, int int_6)
	{
		GClass124.smethod_1().int_4 = int_5;
		GClass124.smethod_1().int_5 = int_6;
		GClass2.smethod_0().method_44();
		if (!GClass82.smethod_0(4387))
		{
			GClass124.smethod_1().int_4 = int_5;
			GClass124.smethod_1().int_5 = int_6 + 1;
			GClass2.smethod_0().method_44();
			GClass124.smethod_1().int_4 = int_5;
			GClass124.smethod_1().int_5 = int_6;
			GClass2.smethod_0().method_44();
		}
	}

	private void method_25(GClass15 gclass15_0)
	{
		if (gclass15_0.bool_1)
			GClass2.smethod_0().method_114();
		else
			GClass2.smethod_0().method_40();
	}
}