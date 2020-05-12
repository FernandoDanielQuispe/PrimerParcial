using Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.Design;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Quispe.Fernando
{
    public partial class FrmAltaAula : Form
    {

        List<Aula> aulas = new List<Aula>();

        public FrmAltaAula()
        {
            InitializeComponent();           

        }        
             
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            switch (ComboBoxColor.Text)
            {
                case "Naranja":
                    BackColor = Color.Orange;
                    break;
                case "Rojo":
                    BackColor = Color.Red;
                    break;
                case "Amarillo":
                    BackColor = Color.Yellow;
                    break;
                case "Verde":
                    BackColor = Color.Green;
                    break;
                default:
                    break;
            }
        }

        private void FrmAltaAula_Load(object sender, EventArgs e)
        {
            ingresarColores();
            ingresarTurno();

            listBoxSinAula.Items.Add("Fernando Daniel Q");
            listBoxSinAula.Items.Add("Juan Lopez");
            listBoxSinAula.Items.Add("Fernando Rivera");

            #region APLICAR DRAGDROP
            //listBoxSinAula.AllowDrop = true;
            //listBoxEnSala.AllowDrop = true;

            //txtBoxSinAula.DragEnter += new DragEventHandler(txtBoxEnSala_DragEnter);
            //txtBoxSinAula.MouseDown += new MouseEventHandler(txtBoxEnSala_MouseDown);
            //txtBoxSinAula.DragDrop += new DragEventHandler(txtBoxEnSala_DragDrop);
            #endregion

        }

        #region APLICAR DRAGDROP
        ////USO DRAGDROP ver mas adelante
        //public class DragItem
        //{
        //    public ListBox Client;
        //    public int Index;
        //    public object Item;

        //    public DragItem(ListBox client, int index, object item)
        //    {
        //        Client = client;
        //        Index = index;
        //        Item = item;
        //    }
        //}
        //private void lst_MouseDown(object sender, MouseEventArgs e)
        //{
        //    ListBox lst = sender as ListBox;

        //    // Only use the right mouse button.
        //    if (e.Button != MouseButtons.Right) return;

        //    // Find the item under the mouse.
        //    int index = lst.IndexFromPoint(e.Location);
        //    lst.SelectedIndex = index;
        //    if (index < 0) return;

        //    // Drag the item.
        //    DragItem drag_item = new DragItem(lst, index, lst.Items[index]);
        //    lst.DoDragDrop(drag_item, DragDropEffects.Move);
        //}
        //private void lst_DragEnter(object sender, DragEventArgs e)
        //{
        //    ListBox lst = sender as ListBox;

        //    // Allow a Move for DragItem objects that are
        //    // dragged to the control that started the drag.
        //    if (!e.Data.GetDataPresent(typeof(DragItem)))
        //    {
        //        // Not a DragItem. Don't allow it.
        //        e.Effect = DragDropEffects.None;
        //    }
        //    else if ((e.AllowedEffect & DragDropEffects.Move) == 0)
        //    {
        //        // Not a Move. Do not allow it.
        //        e.Effect = DragDropEffects.None;
        //    }
        //    else
        //    {
        //        // Get the DragItem.
        //        DragItem drag_item = (DragItem)e.Data.GetData(typeof(DragItem));

        //        // Verify that this is the control that started the drag.
        //        if (drag_item.Client != lst)
        //        {
        //            // Not the congtrol that started the drag. Do not allow it.
        //            e.Effect = DragDropEffects.None;
        //        }
        //        else
        //        {
        //            // Allow it.
        //            e.Effect = DragDropEffects.Move;
        //        }
        //    }
        //}

        //private void lst_DragDrop(object sender, DragEventArgs e)
        //{
        //    ListBox lst = sender as ListBox;

        //    // Get the ListBox item data.
        //    DragItem drag_item = (DragItem)e.Data.GetData(typeof(DragItem));

        //    // Get the index of the item at this position.
        //    int new_index =
        //        lst.IndexFromPoint(new Point(e.X, e.Y));
        //    //lst.IndexFromScreenPoint(new Point(e.X, e.Y));

        //    // If the item was dropped after all
        //    // of the items, move it to the end.
        //    if (new_index == -1) new_index = lst.Items.Count - 1;

        //    // Remove the item from its original position.
        //    lst.Items.RemoveAt(drag_item.Index);

        //    // Insert the item in its new position.
        //    lst.Items.Insert(new_index, drag_item.Item);

        //    // Select the item.
        //    lst.SelectedIndex = new_index;
        //}

        //fin
        #endregion



        private void ingresarColores()
        {
            ComboBoxColor.Items.Clear();
            foreach (EColores item in Enum.GetValues(typeof(EColores)))
            {
                ComboBoxColor.Items.Add(item);          
            }            
        }


        private void ingresarTurno()
        {
            ComboBoxTurno.Items.Clear();
            foreach (ETurno item in Enum.GetValues(typeof(ETurno)))
            {
                ComboBoxTurno.Items.Add(item);
            }
        }

        private void lblColor_Click(object sender, EventArgs e)
        {
            
        }

        private void lblTurno_Click(object sender, EventArgs e)
        {

        }

        private void ComboBoxTurno_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void listBoxSinAula_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        #region APLICAR DRAGDROP
        //private void listBoxEnSala_MouseDown(object sender, MouseEventArgs e)
        //{
        //    //ListBox tb = (ListBox)sender;
        //    //tb.SelectAll();
        //    //tb.DoDragDrop(tb.Text, DragDropEffects.Copy);
        //    listBoxEnSala.SelectAll();
        //    listBoxSinAula.DoDragDrop(listBoxEnSala, DragDropEffects.Copy);

        //}

        //private void listBoxEnSala_DragEnter(object sender, DragEventArgs e)
        //{
        //    if (e.Data.GetDataPresent(DataFormats.Text))
        //    {
        //        e.Effect = DragDropEffects.Copy;
        //    }
        //    else
        //    {
        //        e.Effect = DragDropEffects.None;
        //    }
        //}

        //private void listBoxEnSala_DragDrop(object sender, DragEventArgs e)
        //{
        //    //ListBox tb = (ListBox)sender;
        //    //tb.Text = (string)e.Data.GetData(DataFormats.Text);

        //    listBoxEnSala.Text = (string)e.Data.GetData(DataFormats.Text);
        //    listBoxSinAula.Clear();

        //}

        //private void listBoxEnSala_TextChanged(object sender, EventArgs e)
        //{

        //}

        //private void listBoxSinAula_MouseDown(object sender, MouseEventArgs e)
        //{
        //    listBoxSinAula.SelectAll();
        //    listBoxEnSala.DoDragDrop(listBoxEnSala.SelectedText, DragDropEffects.Copy);
        //}

        //private void listBoxSinAula_DragEnter(object sender, DragEventArgs e)
        //{
        //    if (e.Data.GetDataPresent(DataFormats.Text))
        //    {
        //        e.Effect = DragDropEffects.Copy;
        //    }
        //    else
        //    {
        //        e.Effect = DragDropEffects.None;
        //    }
        //}

        //private void listBoxSinAula_DragDrop(object sender, DragEventArgs e)
        //{
        //    listBoxSinAula.Text = (string)e.Data.GetData(DataFormats.Text);
        //    listBoxEnSala.Clear();
        //}


        //private void listBoxSinAula_TextChanged(object sender, EventArgs e)
        //{

        //}
        #endregion
    }
}
