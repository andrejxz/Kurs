using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KURS
{
	/// <summary>
	/// расширенная колонка со списком значений, которая позволяет задавать null нажатием delete или break
	/// также сама заботится о приведении типов
	/// </summary>
	public class ExtendedComboBoxColumn : DataGridViewColumn
	{
		public ExtendedComboBoxColumn()
					: base(new ExtendedComboBoxCell())
		{
		}

		public override DataGridViewCell CellTemplate
		{
			get
			{
				return base.CellTemplate;
			}
			set
			{
				if (value != null &&
					!value.GetType().IsAssignableFrom(typeof(ExtendedComboBoxCell))) {
					throw new InvalidCastException("Must be a ExtendedComboBoxCell");
				}
				base.CellTemplate = value;
			}
		}

		BindingSource _dataSource;
		[Category("Данные")]
		[Description("Источник данных, из которых выбирается объект")]
		[DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
		[DefaultValue(null)]
		public BindingSource DataSource
		{
			get
			{
				return _dataSource;
			}
			set
			{
				_dataSource = value;
				if(CellTemplate!=null) (CellTemplate as ExtendedComboBoxCell).DataSource = value;
			}
		}

		public override object Clone()
		{
			var clone = base.Clone() as ExtendedComboBoxColumn;
			clone.DataSource = DataSource;
			return clone;
		}
	}

	// класс текстового редактирования ячейки
	public class ExtendedComboBoxCell : DataGridViewTextBoxCell
	{
		public BindingSource DataSource { get; set; }
		public ExtendedComboBoxCell()
			: base()
		{
		}

		public override void InitializeEditingControl(int rowIndex, object initialFormattedValue, DataGridViewCellStyle dataGridViewCellStyle)
		{
			base.InitializeEditingControl(rowIndex, initialFormattedValue, dataGridViewCellStyle);
			var ctl = DataGridView.EditingControl as ExtendedComboBoxControl;
			ctl.SelectedItem = Value;
			ctl.DataSource = DataSource;
		}

		public override Type EditType
		{
			get
			{
				return typeof(ExtendedComboBoxControl);
			}
		}
		public override object Clone()
		{
			var clone = base.Clone() as ExtendedComboBoxCell;
			clone.DataSource = DataSource;
			return clone;
		}
		public override object ParseFormattedValue(object formattedValue, DataGridViewCellStyle cellStyle, TypeConverter formattedValueTypeConverter, TypeConverter valueTypeConverter)
		{
			return formattedValue;
		}

		/*public override Type ValueType
		{
			get
			{
				// Return the type of the value that CalendarCell contains.
				return typeof(DateTime);
			}
		}*/

		public override object DefaultNewRowValue
		{
			get
			{
				// Use the current date and time as the default value.
				return null;
			}
		}

		protected override void OnKeyDown(KeyEventArgs e, int rowIndex)
		{
			switch (e.KeyCode) {
				case Keys.Delete:
				case Keys.Back:
					Value = null;
					return;
			}
			base.OnKeyDown(e, rowIndex);
		}
	}

	// ячейка редактирования
	class ExtendedComboBoxControl : ComboBox, IDataGridViewEditingControl
	{
		public ExtendedComboBoxControl()
		{
			this.SelectedValueChanged += ExtendedComboBoxControl_SelectedValueChanged;
			this.DropDownStyle = ComboBoxStyle.DropDownList;
		}
		private void ExtendedComboBoxControl_SelectedValueChanged(object sender, EventArgs e)
		{
			EditingControlValueChanged = true;
			EditingControlDataGridView.NotifyCurrentCellDirty(true);
		} 

		public DataGridView EditingControlDataGridView { get; set; }
		public bool EditingControlValueChanged { get; set; }
		public int EditingControlRowIndex { get; set; }
		public bool RepositionEditingControlOnValueChange
		{
			get
			{
				return false;
			}
		}
		public Cursor EditingPanelCursor
		{
			get { return base.Cursor; }
		}
		public object EditingControlFormattedValue
		{
			get
			{
				return SelectedItem;
			}
			set
			{
				SelectedItem = value;				
			}
		}
		public object GetEditingControlFormattedValue(DataGridViewDataErrorContexts context)
		{
			return EditingControlFormattedValue;
		}
		public void ApplyCellStyleToEditingControl(DataGridViewCellStyle dataGridViewCellStyle)
		{
			this.Font = dataGridViewCellStyle.Font;
			this.ForeColor = dataGridViewCellStyle.ForeColor;
			this.BackColor = dataGridViewCellStyle.BackColor;
		}
		public bool EditingControlWantsInputKey(Keys key, bool dataGridViewWantsInputKey)
		{
			switch (key & Keys.KeyCode) {
				case Keys.Left:
				case Keys.Up:
				case Keys.Down:
				case Keys.Right:
				case Keys.Home:
				case Keys.End:
				case Keys.PageDown:
				case Keys.PageUp:
					return true;
				case Keys.Delete:
				case Keys.Back:
					SelectedItem = null;
					Text = null;
					return true;
				default:
					return !dataGridViewWantsInputKey;
			}
		}
		public void PrepareEditingControlForEdit(bool selectAll)
		{
		}
	}
}
