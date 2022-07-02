using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Listas_ej1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_anyadir_Click(object sender, EventArgs e)
        {   
            // Dependiendo del radiobutton que hay seleccionado añadimos en una o otra lista
            if (rbt_listbox.Checked && txt_elemento.TextLength != 0)
            {
                list_listBox.Items.Add(txt_elemento.Text);
                txt_elemento.ResetText();
                lbl_listbox.Text = list_listBox.Items.Count.ToString();

            }
            else if (rbt_comboBox.Checked && txt_elemento.TextLength != 0)
            {
                list_comboBox.Items.Add(txt_elemento.Text);
                txt_elemento.ResetText();
                lbl_comboBox.Text = list_comboBox.Items.Count.ToString();
            }
            else if (rbt_checkedListBox.Checked && txt_elemento.TextLength != 0)
            {
                list_checkedListBox.Items.Add(txt_elemento.Text);
                txt_elemento.ResetText();
                lbl_checkedListBox.Text = list_checkedListBox.Items.Count.ToString();
            }
        }

        private void btn_eliminar_Click(object sender, EventArgs e)
        {
            // Dependiendo del radiobutton que hay seleccionado borramos en una o otra lista. En caso de no estar el elemento en la lista,
            // mostramos mensage de error.
            if (rbt_listbox.Checked)
            {   
                if (list_listBox.Items.Contains(txt_elemento.Text))
                {
                    list_listBox.Items.Remove(txt_elemento.Text);
                    txt_elemento.ResetText();
                    lbl_listbox.Text = list_listBox.Items.Count.ToString();
                }
                else
                {
                    MessageBox.Show("El elemento no esta en la lista");
                }

            }
            else if (rbt_comboBox.Checked)
            {
                if (list_comboBox.Items.Contains(txt_elemento.Text))
                {
                    list_comboBox.Items.Remove(txt_elemento.Text);
                    txt_elemento.ResetText();
                    lbl_comboBox.Text = list_comboBox.Items.Count.ToString();
                }
                else
                {
                    MessageBox.Show("El elemento no esta en la lista");
                }
            }
            else if (rbt_checkedListBox.Checked)
            {
                if (list_checkedListBox.Items.Contains(txt_elemento.Text))
                {
                    list_checkedListBox.Items.Remove(txt_elemento.Text);
                    txt_elemento.ResetText();
                    lbl_checkedListBox.Text = list_checkedListBox.Items.Count.ToString();
                }
                else
                {
                    MessageBox.Show("El elemento no esta en la lista");
                }
            }
        }

        private void btn_mostrarSeleccionados_Click(object sender, EventArgs e)
        {   
            // Mostramos elementos de la lista seleccionada, pero antes comprobamos que la lista no esté vacía.
            if (rbt_listbox.Checked && list_listBox.SelectedIndex != -1)
            {
                list_multiseleccion.Items.Clear();
                txt_seleccionados.Text = list_listBox.SelectedItem.ToString();
            }
            else if (rbt_comboBox.Checked && list_comboBox.SelectedIndex != -1)
            {
                list_multiseleccion.Items.Clear();
                txt_seleccionados.Text = list_comboBox.SelectedItem.ToString();
            }

            if (list_checkedListBox.SelectedIndex != -1) 
            {
                list_multiseleccion.Items.Clear();
                String[] listaMulti = new string[list_checkedListBox.CheckedItems.Count];
                list_checkedListBox.CheckedItems.CopyTo(listaMulti, 0);

                for (int i = 0; i < listaMulti.Length; i++)
                {
                    list_multiseleccion.Items.Add(listaMulti[i]).ToString();
                }
            }
            
        }
    }
}
