using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Library_IS.Lib
{
    public class Helper
    {
        public void ReloadGrid<T>(DataGridView gridName, List<T> dataSource, List<int> hideCollIdx = null, bool hasDeleteAction = false, bool hasUpdateAction = false) where T : class
        {
            try
            {
                gridName.DataSource = null;
                gridName.Columns.Clear();
                gridName.DataSource = dataSource;

                if (hideCollIdx != null && hideCollIdx.Count > 0)
                {
                    foreach (int idx in hideCollIdx)
                    {
                        gridName.Columns[idx].Visible = false;
                    }
                }

                if (hasDeleteAction)
                {
                    DataGridViewButtonColumn btnDelete = new DataGridViewButtonColumn();
                    btnDelete.HeaderText = "";
                    btnDelete.Name = "btnDelete";
                    btnDelete.Text = "Delete";
                    btnDelete.UseColumnTextForButtonValue = true;
                    gridName.Columns.Add(btnDelete);
                }
                if (hasUpdateAction)
                {
                    DataGridViewButtonColumn btnUpdate = new DataGridViewButtonColumn();
                    btnUpdate.HeaderText = "";
                    btnUpdate.Name = "btnUpdate";
                    btnUpdate.Text = "Update";
                    btnUpdate.UseColumnTextForButtonValue = true;
                    gridName.Columns.Add(btnUpdate);
                }
            }
            catch { throw; }
        }
        public void ReloadGrid<T>(DataGridView gridName, List<T> dataSource, List<int> hideCollIdx = null, List<GridAction> gridActions = null) where T : class
        {
            try
            {
                gridName.DataSource = null;
                gridName.Columns.Clear();
                gridName.DataSource = dataSource;

                if (hideCollIdx != null && hideCollIdx.Count > 0)
                {
                    foreach (int idx in hideCollIdx)
                    {
                        gridName.Columns[idx].Visible = false;
                    }
                }
                if (gridActions != null)
                {
                    foreach (GridAction action in gridActions)
                    {
                        DataGridViewButtonColumn btnAction = new DataGridViewButtonColumn();
                        btnAction.HeaderText = "";
                        btnAction.Name = action.Name;
                        btnAction.Text = action.Text;
                        btnAction.UseColumnTextForButtonValue = true;
                        gridName.Columns.Add(btnAction);
                    }
                }
            }
            catch { throw; }
        }
        public void ClearForm(Control.ControlCollection controls)
        {
            foreach (Control control in controls)
            {
                if (control is TextBox)
                {
                    ((TextBox)control).Clear();
                }
                else if (control is ComboBox)
                {
                    ((ComboBox)control).SelectedIndex = 0;
                }
                else if (control is NumericUpDown)
                {
                    ((NumericUpDown)control).Value = 0;
                }
                else if (control is CheckBox)
                {
                    ((CheckBox)control).Checked = false;
                }
                else if (control is RichTextBox)
                {
                    ((RichTextBox)control).Clear();
                }
                if (control.HasChildren)
                {
                    ClearForm(control.Controls);
                }
            }
        }
    }
    public class GridAction
    {
        public string Name { get; set; }
        public string Text { get; set; }
    }
}
