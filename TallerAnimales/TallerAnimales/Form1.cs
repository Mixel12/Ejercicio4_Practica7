using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BCAnimales;

namespace TallerAnimales
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            InitializeComboBoxTipo();
        }

        private void InitializeComboBoxTipo()
        {
            comboBoxtipo.Items.Add(Animal.Tipo.granja);
            comboBoxtipo.Items.Add(Animal.Tipo.selva);
            comboBoxtipo.Items.Add("");
        }

        private void listBoxAnimal_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Animal.Tipo tip = Animal.Tipo.granja;

            string t1 = tip.ToString();


            //Animal A1 = new Animal("Cerdo");
            Animal A2 = new Animal(Animal.Tipo.selva, "Leon");
            Animal A3 = new Animal(Animal.Tipo.granja, "Vaca");
            Animal A4 = new Animal(Animal.Tipo.selva, "Tigre");
            Animal A5 = new Animal(Animal.Tipo.selva, "Hipopotamo");
            Animal A6 = new Animal(Animal.Tipo.granja, "Oveja");
            Perro P1 = new Perro("Tomas", "Golden", Animal.Tipo.granja);
            Leon L1 = new Leon("Desertica", "Yena", Animal.Tipo.selva);


            //listBoxAnimal.Items.Add(A1);
            listBoxAnimal.Items.Add(A2);
            listBoxAnimal.Items.Add(A3);
            listBoxAnimal.Items.Add(A4);
            listBoxAnimal.Items.Add(A5);
            listBoxAnimal.Items.Add(A6);
            listBoxAnimal.Items.Add(P1);
            listBoxAnimal.Items.Add(L1);


            listBoxAnimal.SelectedIndex = 0;

            //
            btnGuardar.Enabled = false;
            txtNombre.Enabled = false;
            comboBoxtipo.Enabled = false;
            txtDuenio.Enabled = false;
            txtHabitad.Enabled = false;
            //
            
        }

        private void comboBoxtipo_SelectedIndexChanged(object sender, EventArgs e)
        {
           // comboBoxtipo.DropDownStyle = DropDownList;
            if (comboBoxtipo.SelectedIndex == 0) {
                txtDuenio.Enabled = true;
                txtHabitad.Enabled = false;
            }
            else if (comboBoxtipo.SelectedIndex == 1)
            {
                txtHabitad.Enabled = true; ;
                txtDuenio.Enabled = false;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int aux = listBoxAnimal.SelectedIndex;
            listBoxAnimal.Items.RemoveAt(aux);
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            button2.Enabled = false;
            btnGuardar.Enabled = true;
            txtNombre.Enabled = true;
            comboBoxtipo.Enabled = true;
            btnAgregar.Enabled = false;
               
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (comboBoxtipo.SelectedIndex == 0)
            {
                //listBoxAnimal.Items.Add(new Animal(Animal.Tipo.granja, txtNombre.Text));
                listBoxAnimal.Items.Add(new Perro(txtDuenio.Text,txtNombre.Text,Animal.Tipo.granja));
            }
            else if (comboBoxtipo.SelectedIndex == 1)
            {
                //listBoxAnimal.Items.Add(new Animal(Animal.Tipo.selva, txtNombre.Text));
                listBoxAnimal.Items.Add(new Perro(txtHabitad.Text, txtNombre.Text, Animal.Tipo.selva));
            }
            else if (comboBoxtipo.SelectedIndex == 2)
            {
                string message = "Debe seleccionar un tipo de animal";
                string title = "Aviso";
                MessageBoxButtons boton = MessageBoxButtons.OK;
                DialogResult result = MessageBox.Show(message, title, boton);
            }
            limpiar();
            btnGuardar.Enabled = false;
            button2.Enabled = true;
            txtNombre.Enabled = false;
            comboBoxtipo.Enabled = false;
            btnAgregar.Enabled = true;
            txtHabitad.Enabled = false;
            txtDuenio.Enabled = false;
            


        }

        private void limpiar()
        {
            txtNombre.Text = "";
            comboBoxtipo.SelectedIndex =2;
            txtDuenio.Text = "";
            txtHabitad.Text = "";
            
        }

        private void comboBoxtipo_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }


    }
}
