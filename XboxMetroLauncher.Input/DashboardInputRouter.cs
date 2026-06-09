using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;

namespace XboxMetroLauncher.Input;

public static class DashboardInputRouter
{
	public static bool TryMapKey(KeyEventArgs args, out DashboardInputAction action)
	{
		//IL_000e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0013: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_0017: Invalid comparison between Unknown and I4
		//IL_0066: Unknown result type (might be due to invalid IL or missing references)
		//IL_0069: Unknown result type (might be due to invalid IL or missing references)
		//IL_0087: Expected I4, but got Unknown
		//IL_0019: Unknown result type (might be due to invalid IL or missing references)
		//IL_001b: Invalid comparison between Unknown and I4
		//IL_0087: Unknown result type (might be due to invalid IL or missing references)
		//IL_008a: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b4: Expected I4, but got Unknown
		//IL_0020: Unknown result type (might be due to invalid IL or missing references)
		//IL_0023: Unknown result type (might be due to invalid IL or missing references)
		//IL_0061: Expected I4, but got Unknown
		//IL_0114: Unknown result type (might be due to invalid IL or missing references)
		//IL_0119: Unknown result type (might be due to invalid IL or missing references)
		//IL_011a: Unknown result type (might be due to invalid IL or missing references)
		//IL_011d: Invalid comparison between Unknown and I4
		//IL_00b4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b7: Invalid comparison between Unknown and I4
		//IL_016e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0171: Unknown result type (might be due to invalid IL or missing references)
		//IL_0173: Invalid comparison between Unknown and I4
		//IL_011f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0121: Invalid comparison between Unknown and I4
		//IL_0175: Unknown result type (might be due to invalid IL or missing references)
		//IL_0178: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a2: Expected I4, but got Unknown
		//IL_0126: Unknown result type (might be due to invalid IL or missing references)
		//IL_0129: Unknown result type (might be due to invalid IL or missing references)
		//IL_0167: Expected I4, but got Unknown
		//IL_01a2: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a5: Invalid comparison between Unknown and I4
		//IL_0167: Unknown result type (might be due to invalid IL or missing references)
		//IL_016a: Invalid comparison between Unknown and I4
		action = DashboardInputAction.MoveLeft;
		if (IsTextEditingKey(args))
		{
			return false;
		}
		Key key = args.Key;
		DashboardInputAction dashboardInputAction;
		if ((int)(int)(int)(int)key <= 26)
		{
			if ((int)key != 6)
			{
				switch (key - 13)
				{
				case (Key)10:
					break;
				case (Key)12:
					goto IL_00c3;
				case (Key)11:
					goto IL_00cb;
				case (Key)13:
					goto IL_00d3;
				case (Key)5:
					goto IL_00df;
				case 0:
					goto IL_00e3;
				case (Key)6:
					goto IL_00ff;
				case (Key)7:
					goto IL_0104;
				default:
					goto IL_010e;
				}
				dashboardInputAction = DashboardInputAction.MoveLeft;
			}
			else
			{
				dashboardInputAction = DashboardInputAction.Activate;
			}
		}
		else
		{
			switch (key - 44)
			{
			case 0:
				goto IL_00bf;
			case (Key)3:
				goto IL_00c7;
			case (Key)5:
				goto IL_00f0;
			case (Key)4:
				goto IL_00fa;
			case (Key)1:
			case (Key)2:
				goto IL_010e;
			}
			switch (key - 60)
			{
			case (Key)6:
				goto IL_00cf;
			case (Key)2:
				goto IL_00d7;
			case (Key)7:
				goto IL_00e7;
			case (Key)8:
				goto IL_00eb;
			case 0:
				goto IL_00f5;
			case (Key)1:
			case (Key)3:
			case (Key)4:
			case (Key)5:
				goto IL_010e;
			}
			if ((int)key != 99)
			{
				goto IL_010e;
			}
			dashboardInputAction = DashboardInputAction.Options;
		}
		goto IL_0110;
		IL_0104:
		dashboardInputAction = DashboardInputAction.NextTab;
		goto IL_0110;
		IL_00cb:
		dashboardInputAction = DashboardInputAction.MoveUp;
		goto IL_0110;
		IL_00bf:
		dashboardInputAction = DashboardInputAction.MoveLeft;
		goto IL_0110;
		IL_00c7:
		dashboardInputAction = DashboardInputAction.MoveRight;
		goto IL_0110;
		IL_00fa:
		dashboardInputAction = DashboardInputAction.NextTab;
		goto IL_0110;
		IL_00f0:
		dashboardInputAction = DashboardInputAction.Search;
		goto IL_0110;
		IL_0110:
		action = dashboardInputAction;
		key = args.Key;
		if ((int)(int)(int)(int)key <= 44)
		{
			if ((int)key != 6)
			{
				switch (key - 13)
				{
				default:
					if ((int)key == 44)
					{
						break;
					}
					goto IL_01ab;
				case 0:
				case (Key)5:
				case (Key)6:
				case (Key)7:
				case (Key)10:
				case (Key)11:
				case (Key)12:
				case (Key)13:
					break;
				case (Key)1:
				case (Key)2:
				case (Key)3:
				case (Key)4:
				case (Key)8:
				case (Key)9:
					goto IL_01ab;
				}
			}
		}
		else if ((int)key - 47 > 2)
		{
			switch (key - 60)
			{
			default:
				if ((int)key == 99)
				{
					break;
				}
				goto IL_01ab;
			case 0:
			case (Key)2:
			case (Key)6:
			case (Key)7:
			case (Key)8:
				break;
			case (Key)1:
			case (Key)3:
			case (Key)4:
			case (Key)5:
				goto IL_01ab;
			}
		}
		return true;
		IL_00f5:
		dashboardInputAction = DashboardInputAction.PreviousTab;
		goto IL_0110;
		IL_00d7:
		dashboardInputAction = DashboardInputAction.MoveDown;
		goto IL_0110;
		IL_00cf:
		dashboardInputAction = DashboardInputAction.MoveUp;
		goto IL_0110;
		IL_00e7:
		dashboardInputAction = DashboardInputAction.Details;
		goto IL_0110;
		IL_00eb:
		dashboardInputAction = DashboardInputAction.Search;
		goto IL_0110;
		IL_01ab:
		return false;
		IL_00ff:
		dashboardInputAction = DashboardInputAction.PreviousTab;
		goto IL_0110;
		IL_010e:
		dashboardInputAction = DashboardInputAction.MoveLeft;
		goto IL_0110;
		IL_00d3:
		dashboardInputAction = DashboardInputAction.MoveDown;
		goto IL_0110;
		IL_00c3:
		dashboardInputAction = DashboardInputAction.MoveRight;
		goto IL_0110;
		IL_00e3:
		dashboardInputAction = DashboardInputAction.Back;
		goto IL_0110;
		IL_00df:
		dashboardInputAction = DashboardInputAction.Activate;
		goto IL_0110;
	}

	public static bool MoveFocus(DashboardInputAction action)
	{
		//IL_0065: Unknown result type (might be due to invalid IL or missing references)
		//IL_006a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0074: Expected O, but got Unknown
		FocusNavigationDirection? val = action switch
		{
			DashboardInputAction.MoveLeft => (FocusNavigationDirection)4, 
			DashboardInputAction.MoveRight => (FocusNavigationDirection)5, 
			DashboardInputAction.MoveUp => (FocusNavigationDirection)6, 
			DashboardInputAction.MoveDown => (FocusNavigationDirection)7, 
			_ => null, 
		};
		if (!val.HasValue || !(Keyboard.FocusedElement is UIElement uIElement))
		{
			return false;
		}
		try
		{
			return uIElement.MoveFocus(new TraversalRequest(val.Value));
		}
		catch (InvalidOperationException)
		{
			return false;
		}
		catch (ArgumentException)
		{
			return false;
		}
		catch
		{
			return false;
		}
	}

	public static bool ActivateFocusedElement()
	{
		if (Keyboard.FocusedElement is Button button)
		{
			ICommand command = button.Command;
			if (command != null && command.CanExecute(button.CommandParameter))
			{
				try
				{
					button.Command.Execute(button.CommandParameter);
					return true;
				}
				catch
				{
					return false;
				}
			}
		}
		if (Keyboard.FocusedElement is CheckBox checkBox)
		{
			checkBox.IsChecked = checkBox.IsChecked != true;
			return true;
		}
		if (Keyboard.FocusedElement is ComboBox comboBox)
		{
			comboBox.IsDropDownOpen = !comboBox.IsDropDownOpen;
			return true;
		}
		if (Keyboard.FocusedElement is Slider slider)
		{
			slider.Value = Math.Clamp(slider.Value + slider.SmallChange, slider.Minimum, slider.Maximum);
			return true;
		}
		if (Keyboard.FocusedElement is TextBox textBox)
		{
			textBox.GetBindingExpression(TextBox.TextProperty)?.UpdateSource();
			return true;
		}
		return false;
	}

	public static bool TryAdjustFocusedSetting(DashboardInputAction action)
	{
		Slider slider = Keyboard.FocusedElement as Slider;
		bool flag = slider != null;
		if (flag)
		{
			bool flag2 = (uint)(int)action <= 1u;
			flag = flag2;
		}
		if (flag)
		{
			double num = ((action == DashboardInputAction.MoveRight) ? slider.SmallChange : (0.0 - slider.SmallChange));
			slider.Value = Math.Clamp(slider.Value + num, slider.Minimum, slider.Maximum);
			return true;
		}
		ComboBox comboBox = Keyboard.FocusedElement as ComboBox;
		flag = comboBox != null;
		if (flag)
		{
			bool flag2 = (uint)(int)action <= 1u;
			flag = flag2;
		}
		if (flag)
		{
			if (comboBox.Items.Count == 0)
			{
				return false;
			}
			int num2 = ((action == DashboardInputAction.MoveRight) ? 1 : (-1));
			int num3 = Math.Clamp(comboBox.SelectedIndex + num2, 0, comboBox.Items.Count - 1);
			if (num3 == comboBox.SelectedIndex)
			{
				return true;
			}
			comboBox.SelectedIndex = num3;
			return true;
		}
		return false;
	}

	private static bool IsTextEditingKey(KeyEventArgs args)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_0015: Unknown result type (might be due to invalid IL or missing references)
		//IL_0017: Invalid comparison between Unknown and I4
		//IL_0019: Unknown result type (might be due to invalid IL or missing references)
		//IL_001c: Invalid comparison between Unknown and I4
		//IL_001e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0021: Unknown result type (might be due to invalid IL or missing references)
		//IL_0023: Invalid comparison between Unknown and I4
		if (!(Keyboard.FocusedElement is TextBox))
		{
			return false;
		}
		Key key = args.Key;
		bool flag = (((int)key == 6 || (int)key == 13 || (int)key - 19 <= 1) ? true : false);
		return !flag;
	}
}





