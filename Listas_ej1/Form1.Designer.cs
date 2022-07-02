
namespace Listas_ej1
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbt_checkedListBox = new System.Windows.Forms.RadioButton();
            this.rbt_comboBox = new System.Windows.Forms.RadioButton();
            this.rbt_listbox = new System.Windows.Forms.RadioButton();
            this.list_listBox = new System.Windows.Forms.ListBox();
            this.list_comboBox = new System.Windows.Forms.ComboBox();
            this.list_checkedListBox = new System.Windows.Forms.CheckedListBox();
            this.txt_elemento = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_anyadir = new System.Windows.Forms.Button();
            this.btn_eliminar = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbl_checkedListBox = new System.Windows.Forms.Label();
            this.lbl_comboBox = new System.Windows.Forms.Label();
            this.lbl_listbox = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txt_seleccionados = new System.Windows.Forms.TextBox();
            this.btn_mostrarSeleccionados = new System.Windows.Forms.Button();
            this.list_multiseleccion = new System.Windows.Forms.ListBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbt_checkedListBox);
            this.groupBox1.Controls.Add(this.rbt_comboBox);
            this.groupBox1.Controls.Add(this.rbt_listbox);
            this.groupBox1.Location = new System.Drawing.Point(13, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(436, 73);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tipo de componente";
            // 
            // rbt_checkedListBox
            // 
            this.rbt_checkedListBox.AutoSize = true;
            this.rbt_checkedListBox.Location = new System.Drawing.Point(281, 33);
            this.rbt_checkedListBox.Name = "rbt_checkedListBox";
            this.rbt_checkedListBox.Size = new System.Drawing.Size(109, 19);
            this.rbt_checkedListBox.TabIndex = 2;
            this.rbt_checkedListBox.Text = "CheckedListBox";
            this.rbt_checkedListBox.UseVisualStyleBackColor = true;
            // 
            // rbt_comboBox
            // 
            this.rbt_comboBox.AutoSize = true;
            this.rbt_comboBox.Location = new System.Drawing.Point(144, 33);
            this.rbt_comboBox.Name = "rbt_comboBox";
            this.rbt_comboBox.Size = new System.Drawing.Size(85, 19);
            this.rbt_comboBox.TabIndex = 1;
            this.rbt_comboBox.Text = "ComboBox";
            this.rbt_comboBox.UseVisualStyleBackColor = true;
            // 
            // rbt_listbox
            // 
            this.rbt_listbox.AutoSize = true;
            this.rbt_listbox.Checked = true;
            this.rbt_listbox.Location = new System.Drawing.Point(7, 33);
            this.rbt_listbox.Name = "rbt_listbox";
            this.rbt_listbox.Size = new System.Drawing.Size(63, 19);
            this.rbt_listbox.TabIndex = 0;
            this.rbt_listbox.TabStop = true;
            this.rbt_listbox.Text = "Listbox";
            this.rbt_listbox.UseVisualStyleBackColor = true;
            // 
            // list_listBox
            // 
            this.list_listBox.FormattingEnabled = true;
            this.list_listBox.ItemHeight = 15;
            this.list_listBox.Location = new System.Drawing.Point(12, 92);
            this.list_listBox.Name = "list_listBox";
            this.list_listBox.Size = new System.Drawing.Size(216, 169);
            this.list_listBox.TabIndex = 1;
            // 
            // list_comboBox
            // 
            this.list_comboBox.FormattingEnabled = true;
            this.list_comboBox.Location = new System.Drawing.Point(241, 92);
            this.list_comboBox.Name = "list_comboBox";
            this.list_comboBox.Size = new System.Drawing.Size(216, 23);
            this.list_comboBox.TabIndex = 2;
            // 
            // list_checkedListBox
            // 
            this.list_checkedListBox.FormattingEnabled = true;
            this.list_checkedListBox.Location = new System.Drawing.Point(470, 92);
            this.list_checkedListBox.Name = "list_checkedListBox";
            this.list_checkedListBox.Size = new System.Drawing.Size(216, 166);
            this.list_checkedListBox.TabIndex = 3;
            // 
            // txt_elemento
            // 
            this.txt_elemento.Location = new System.Drawing.Point(586, 22);
            this.txt_elemento.Name = "txt_elemento";
            this.txt_elemento.Size = new System.Drawing.Size(100, 23);
            this.txt_elemento.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(520, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 15);
            this.label1.TabIndex = 7;
            this.label1.Text = "Elemento:";
            // 
            // btn_anyadir
            // 
            this.btn_anyadir.Location = new System.Drawing.Point(520, 51);
            this.btn_anyadir.Name = "btn_anyadir";
            this.btn_anyadir.Size = new System.Drawing.Size(75, 23);
            this.btn_anyadir.TabIndex = 8;
            this.btn_anyadir.Text = "Añadir";
            this.btn_anyadir.UseVisualStyleBackColor = true;
            this.btn_anyadir.Click += new System.EventHandler(this.btn_anyadir_Click);
            // 
            // btn_eliminar
            // 
            this.btn_eliminar.Location = new System.Drawing.Point(611, 51);
            this.btn_eliminar.Name = "btn_eliminar";
            this.btn_eliminar.Size = new System.Drawing.Size(75, 23);
            this.btn_eliminar.TabIndex = 9;
            this.btn_eliminar.Text = "Eliminar";
            this.btn_eliminar.UseVisualStyleBackColor = true;
            this.btn_eliminar.Click += new System.EventHandler(this.btn_eliminar_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panel1.Controls.Add(this.lbl_checkedListBox);
            this.panel1.Controls.Add(this.lbl_comboBox);
            this.panel1.Controls.Add(this.lbl_listbox);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(12, 268);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(674, 39);
            this.panel1.TabIndex = 10;
            // 
            // lbl_checkedListBox
            // 
            this.lbl_checkedListBox.AutoSize = true;
            this.lbl_checkedListBox.Location = new System.Drawing.Point(658, 12);
            this.lbl_checkedListBox.Name = "lbl_checkedListBox";
            this.lbl_checkedListBox.Size = new System.Drawing.Size(13, 15);
            this.lbl_checkedListBox.TabIndex = 15;
            this.lbl_checkedListBox.Text = "0";
            this.lbl_checkedListBox.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lbl_comboBox
            // 
            this.lbl_comboBox.AutoSize = true;
            this.lbl_comboBox.Location = new System.Drawing.Point(432, 12);
            this.lbl_comboBox.Name = "lbl_comboBox";
            this.lbl_comboBox.Size = new System.Drawing.Size(13, 15);
            this.lbl_comboBox.TabIndex = 14;
            this.lbl_comboBox.Text = "0";
            this.lbl_comboBox.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lbl_listbox
            // 
            this.lbl_listbox.AutoSize = true;
            this.lbl_listbox.Location = new System.Drawing.Point(203, 12);
            this.lbl_listbox.Name = "lbl_listbox";
            this.lbl_listbox.Size = new System.Drawing.Size(13, 15);
            this.lbl_listbox.TabIndex = 13;
            this.lbl_listbox.Text = "0";
            this.lbl_listbox.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 15);
            this.label2.TabIndex = 12;
            this.label2.Text = "Elemento:";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panel2.Controls.Add(this.txt_seleccionados);
            this.panel2.Controls.Add(this.btn_mostrarSeleccionados);
            this.panel2.Controls.Add(this.list_multiseleccion);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Location = new System.Drawing.Point(12, 313);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(674, 146);
            this.panel2.TabIndex = 11;
            // 
            // txt_seleccionados
            // 
            this.txt_seleccionados.Location = new System.Drawing.Point(229, 28);
            this.txt_seleccionados.Name = "txt_seleccionados";
            this.txt_seleccionados.Size = new System.Drawing.Size(216, 23);
            this.txt_seleccionados.TabIndex = 16;
            // 
            // btn_mostrarSeleccionados
            // 
            this.btn_mostrarSeleccionados.BackColor = System.Drawing.SystemColors.Control;
            this.btn_mostrarSeleccionados.Location = new System.Drawing.Point(8, 28);
            this.btn_mostrarSeleccionados.Name = "btn_mostrarSeleccionados";
            this.btn_mostrarSeleccionados.Size = new System.Drawing.Size(208, 23);
            this.btn_mostrarSeleccionados.TabIndex = 15;
            this.btn_mostrarSeleccionados.Text = "Mostrar Seleccionado/s";
            this.btn_mostrarSeleccionados.UseVisualStyleBackColor = false;
            this.btn_mostrarSeleccionados.Click += new System.EventHandler(this.btn_mostrarSeleccionados_Click);
            // 
            // list_multiseleccion
            // 
            this.list_multiseleccion.FormattingEnabled = true;
            this.list_multiseleccion.ItemHeight = 15;
            this.list_multiseleccion.Location = new System.Drawing.Point(458, 28);
            this.list_multiseleccion.Name = "list_multiseleccion";
            this.list_multiseleccion.Size = new System.Drawing.Size(203, 109);
            this.list_multiseleccion.TabIndex = 14;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(458, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(87, 15);
            this.label4.TabIndex = 13;
            this.label4.Text = "Multiselección:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(229, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(92, 15);
            this.label3.TabIndex = 12;
            this.label3.Text = "Selección única:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(703, 471);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btn_eliminar);
            this.Controls.Add(this.btn_anyadir);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_elemento);
            this.Controls.Add(this.list_checkedListBox);
            this.Controls.Add(this.list_comboBox);
            this.Controls.Add(this.list_listBox);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rbt_checkedListBox;
        private System.Windows.Forms.RadioButton rbt_comboBox;
        private System.Windows.Forms.RadioButton rbt_listbox;
        private System.Windows.Forms.ListBox list_listBox;
        private System.Windows.Forms.ComboBox list_comboBox;
        private System.Windows.Forms.CheckedListBox list_checkedListBox;
        private System.Windows.Forms.TextBox txt_elemento;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_anyadir;
        private System.Windows.Forms.Button btn_eliminar;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lbl_checkedListBox;
        private System.Windows.Forms.Label lbl_comboBox;
        private System.Windows.Forms.Label lbl_listbox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox txt_seleccionados;
        private System.Windows.Forms.Button btn_mostrarSeleccionados;
        private System.Windows.Forms.ListBox list_multiseleccion;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
    }
}

