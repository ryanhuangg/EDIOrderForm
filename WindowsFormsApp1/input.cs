using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;



namespace WindowsFormsApp1
{
    public partial class Input : Form
    {
        public int tabNum = 1;
        public String poNum = "";
        public Input(String s)
        {
            InitializeComponent();
            PODate.Text = DateTime.Now.ToString("MMMM dd, yyyy");
            POLine.Text = s + "-1";
            poNum = s;
            PODisplay.Text = s;

        }

        private void ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void TabPage1_Click(object sender, EventArgs e)
        {

        }

        private void inputTabs_MouseDown(object sender, MouseEventArgs e)
        {
            var lastIndex = this.inputTabs.TabCount - 1;
            if (this.inputTabs.GetTabRect(lastIndex).Contains(e.Location))
            {
                TabPage n = new TabPage("POLine" + (tabNum + 1).ToString());
                tabNum++;
                n.Width = 1107;
                n.Height = 465;
                n.BackColor = POLine1.BackColor;

                this.inputTabs.TabPages.Insert(lastIndex, n);
                this.inputTabs.SelectedIndex = lastIndex;

         
                Control.ControlCollection cc = this.inputTabs.TabPages[0].Controls;

                for (int j = 0; j < cc.Count; j++)

                {

                    Type type = cc[j].GetType();


                    Control ccc = (Control)Activator.CreateInstance(type);


                    if (type.ToString() == "System.Windows.Forms.ComboBox")
                    {
                        ComboBox cb = new ComboBox();
                        ComboBox b = (System.Windows.Forms.ComboBox)cc[j];
                        for (int i = 0; i < b.Items.Count; i++)
                        {
                        
                            cb.Items.Add(b.Items[i]);
                        }
                        cb.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
                        ccc = cb;
                    }
                    

                    ccc.Name = cc[j].Name;

                    ccc.Location = cc[j].Location;

                    ccc.Text = cc[j].Text;

                    ccc.BackColor = cc[j].BackColor;

                    ccc.ForeColor = cc[j].ForeColor;

                    ccc.Width = cc[j].Width;

                    if (ccc.Name == "shipDate")
                    {
                        ccc.Text = cc[j].Text;
                    }

                    n.Controls.Add(ccc);

                }
                
                foreach (Control c in inputTabs.TabPages[lastIndex].Controls)
                {
                    if (c.GetType().ToString() != "System.Windows.Forms.Label" && c.Name != "shipDate")
                    {
                        c.Text = "";
                    }
                    

                }

                n.Controls["POLine"].Text = poNum + "-" + (tabNum).ToString();

                
            }
        }





        private void Remove_Click(object sender, EventArgs e)
        {
            int lastIndex = inputTabs.TabCount;
            if (inputTabs.TabCount > 2)
            {
                inputTabs.TabPages.Remove(inputTabs.TabPages[lastIndex - 2]);
            }
            else
            {
                MessageBox.Show("Can't remove last tab");
            }
        }

        private void ExportButton_Click(object sender, EventArgs e)
        {
            this.CreateXML();
            this.CreateSimpleXML();
            MessageBox.Show("Order has been transfered to XML File");
        }


        private void CreateXML()
        {
            Encoding encoding = Encoding.GetEncoding("ISO-8859-1");
            TextBox textBox = new TextBox();
            String po;
            if (poNum != "")
            {
                po = poNum;
            }
            else
            {
                po = "default_po";
            }
            XmlTextWriter xmlTextWriter = new XmlTextWriter("c:\\cardinal\\" + po + ".xml", encoding);
            xmlTextWriter.WriteStartDocument(true);
            xmlTextWriter.Formatting = Formatting.Indented;
            xmlTextWriter.Indentation = 2;
            this.createNode(xmlTextWriter);
            xmlTextWriter.WriteEndDocument();
            xmlTextWriter.Close();
        }

        private void CreateSimpleXML()
        {
            Encoding encoding = Encoding.GetEncoding("ISO-8859-1");
            TextBox textBox = new TextBox();
            String po;
            if (poNum != "")
            {
                po = poNum;
            }
            else
            {
                po = "default_po";
            }
            XmlTextWriter xmlTextWriter = new XmlTextWriter("c:\\cardinal\\" + po + "_o.xml", encoding);
            xmlTextWriter.WriteStartDocument(true);
            xmlTextWriter.Formatting = Formatting.Indented;
            xmlTextWriter.Indentation = 2;
            this.createSimpleNode(xmlTextWriter);
            xmlTextWriter.WriteEndDocument();
            xmlTextWriter.Close();
        }
        
        private void createSimpleNode(XmlTextWriter writer)
        {
            writer.WriteStartElement("Order");
            writer.WriteStartElement("Items");
            TextBox textBox = new TextBox();
            ComboBox comboBox = new ComboBox();
            String material = "";
            for (int i = 0; i < inputTabs.TabCount - 1; i++)
            {
                if (!inputTabs.TabPages[i].Controls["L1Thick"].Text.Equals("") && !inputTabs.TabPages[i].Controls["L1Treat"].Text.Equals("") && !inputTabs.TabPages[i].Controls["L1Coat"].Text.Equals(""))
                {

                    writer.WriteStartElement("Item");

                    writer.WriteStartElement("XDimension");
                    textBox = (TextBox)inputTabs.TabPages[i].Controls["baseLeg"];
                    if (string.IsNullOrEmpty(textBox.Text))
                    {
                        textBox.Text = "";
                    }
                    writer.WriteString(textBox.Text);
                    writer.WriteEndElement();

                    writer.WriteStartElement("YDimension");
                    textBox = (TextBox)inputTabs.TabPages[i].Controls["leftLeg"];
                    if (string.IsNullOrEmpty(textBox.Text))
                    {
                        textBox.Text = "";
                    }
                    writer.WriteString(textBox.Text);
                    writer.WriteEndElement();

                    writer.WriteStartElement("Quantity");
                    textBox = (TextBox)inputTabs.TabPages[i].Controls["quantity"];
                    if (string.IsNullOrEmpty(textBox.Text))
                    {
                        textBox.Text = "";
                    }
                    writer.WriteString(textBox.Text);
                    writer.WriteEndElement();

                    writer.WriteStartElement("Material");
                    material = getMaterial(inputTabs.TabPages[i].Controls["L1Thick"].Text, inputTabs.TabPages[i].Controls["L1Treat"].Text, inputTabs.TabPages[i].Controls["L1Coat"].Text);
                    writer.WriteString(material);
                    writer.WriteEndElement();

                    writer.WriteStartElement("Thickness");
                    comboBox = (ComboBox)inputTabs.TabPages[i].Controls["L1Thick"];
                    writer.WriteString(comboBox.Text);
                    writer.WriteEndElement();

                    writer.WriteStartElement("Treatment");
                    comboBox = (ComboBox)inputTabs.TabPages[i].Controls["L1Treat"];
                    writer.WriteString(comboBox.Text);
                    writer.WriteEndElement();

                    writer.WriteStartElement("Coating");
                    comboBox = (ComboBox)inputTabs.TabPages[i].Controls["L1Coat"];
                    writer.WriteString(comboBox.Text);
                    writer.WriteEndElement();

                    writer.WriteStartElement("LiteNum");
                    writer.WriteString("1");
                    writer.WriteEndElement();

                    writer.WriteStartElement("POLine");
                    textBox = (TextBox)inputTabs.TabPages[i].Controls["POLine"];
                    writer.WriteString(textBox.Text);
                    writer.WriteEndElement();

                    writer.WriteEndElement();
                }

                if (!inputTabs.TabPages[i].Controls["L2Thick"].Text.Equals("") && !inputTabs.TabPages[i].Controls["L2Treat"].Text.Equals("") && !inputTabs.TabPages[i].Controls["L2Coat"].Text.Equals(""))
                {
                    writer.WriteStartElement("Item");

                    writer.WriteStartElement("XDimension");
                    textBox = (TextBox)inputTabs.TabPages[i].Controls["baseLeg"];
                    if (string.IsNullOrEmpty(textBox.Text))
                    {
                        textBox.Text = "";
                    }
                    writer.WriteString(textBox.Text);
                    writer.WriteEndElement();

                    writer.WriteStartElement("YDimension");
                    textBox = (TextBox)inputTabs.TabPages[i].Controls["leftLeg"];
                    if (string.IsNullOrEmpty(textBox.Text))
                    {
                        textBox.Text = "";
                    }
                    writer.WriteString(textBox.Text);
                    writer.WriteEndElement();

                    writer.WriteStartElement("Quantity");
                    textBox = (TextBox)inputTabs.TabPages[i].Controls["quantity"];
                    if (string.IsNullOrEmpty(textBox.Text))
                    {
                        textBox.Text = "";
                    }
                    writer.WriteString(textBox.Text);
                    writer.WriteEndElement();

                    writer.WriteStartElement("Material");
                    material = getMaterial(inputTabs.TabPages[i].Controls["L2Thick"].Text, inputTabs.TabPages[i].Controls["L2Treat"].Text, inputTabs.TabPages[i].Controls["L2Coat"].Text);
                    writer.WriteString(material);
                    writer.WriteEndElement();

                    writer.WriteStartElement("Thickness");
                    comboBox = (ComboBox)inputTabs.TabPages[i].Controls["L2Thick"];
                    writer.WriteString(comboBox.Text);
                    writer.WriteEndElement();

                    writer.WriteStartElement("Treatment");
                    comboBox = (ComboBox)inputTabs.TabPages[i].Controls["L2Treat"];
                    writer.WriteString(comboBox.Text);
                    writer.WriteEndElement();

                    writer.WriteStartElement("Coating");
                    comboBox = (ComboBox)inputTabs.TabPages[i].Controls["L2Coat"];
                    writer.WriteString(comboBox.Text);
                    writer.WriteEndElement();

                    writer.WriteStartElement("LiteNum");
                    writer.WriteString("2");
                    writer.WriteEndElement();

                    writer.WriteStartElement("POLine");
                    textBox = (TextBox)inputTabs.TabPages[i].Controls["POLine"];
                    writer.WriteString(textBox.Text);
                    writer.WriteEndElement();

                    writer.WriteEndElement();
                }

                if (!inputTabs.TabPages[i].Controls["L3Thick"].Text.Equals("") && !inputTabs.TabPages[i].Controls["L3Treat"].Text.Equals("") && !inputTabs.TabPages[i].Controls["L3Coat"].Text.Equals(""))
                {
                    writer.WriteStartElement("Item");

                    writer.WriteStartElement("XDimension");
                    textBox = (TextBox)inputTabs.TabPages[i].Controls["baseLeg"];
                    if (string.IsNullOrEmpty(textBox.Text))
                    {
                        textBox.Text = "";
                    }
                    writer.WriteString(textBox.Text);
                    writer.WriteEndElement();

                    writer.WriteStartElement("YDimension");
                    textBox = (TextBox)inputTabs.TabPages[i].Controls["leftLeg"];
                    if (string.IsNullOrEmpty(textBox.Text))
                    {
                        textBox.Text = "";
                    }
                    writer.WriteString(textBox.Text);
                    writer.WriteEndElement();

                    writer.WriteStartElement("Quantity");
                    textBox = (TextBox)inputTabs.TabPages[i].Controls["quantity"];
                    if (string.IsNullOrEmpty(textBox.Text))
                    {
                        textBox.Text = "";
                    }
                    writer.WriteString(textBox.Text);
                    writer.WriteEndElement();

                    writer.WriteStartElement("Material");
                    material = getMaterial(inputTabs.TabPages[i].Controls["L3Thick"].Text, inputTabs.TabPages[i].Controls["L3Treat"].Text, inputTabs.TabPages[i].Controls["L3Coat"].Text);
                    writer.WriteString(material);
                    writer.WriteEndElement();

                    writer.WriteStartElement("Thickness");
                    comboBox = (ComboBox)inputTabs.TabPages[i].Controls["L3Thick"];
                    writer.WriteString(comboBox.Text);
                    writer.WriteEndElement();

                    writer.WriteStartElement("Treatment");
                    comboBox = (ComboBox)inputTabs.TabPages[i].Controls["L3Treat"];
                    writer.WriteString(comboBox.Text);
                    writer.WriteEndElement();

                    writer.WriteStartElement("Coating");
                    comboBox = (ComboBox)inputTabs.TabPages[i].Controls["L3Coat"];
                    writer.WriteString(comboBox.Text);
                    writer.WriteEndElement();

                    writer.WriteStartElement("LiteNum");
                    writer.WriteString("3");
                    writer.WriteEndElement();

                    writer.WriteStartElement("POLine");
                    textBox = (TextBox)inputTabs.TabPages[i].Controls["POLine"];
                    writer.WriteString(textBox.Text);
                    writer.WriteEndElement();

                    writer.WriteEndElement();
                }
            }
            writer.WriteEndElement();
            writer.WriteEndElement();
        }

        private void createNode(XmlTextWriter writer)
        {
            writer.WriteStartElement("Order");
            writer.WriteStartElement("PONumber");
            if (!string.IsNullOrEmpty(poNum))
            {
                writer.WriteString(poNum);
            }
            writer.WriteEndElement();
            writer.WriteStartElement("PODate");
            if (!string.IsNullOrEmpty(this.PODate.Text))
            {
                writer.WriteString(this.PODate.Text);
            }
            writer.WriteEndElement();
            TextBox textBox = new TextBox();
            ComboBox comboBox = new ComboBox();
            writer.WriteStartElement("Items");
            for (int i = 0; i < inputTabs.TabCount - 1; i++)
            {
                writer.WriteStartElement("Item");
                writer.WriteStartElement("PONumber");
                textBox = (TextBox)inputTabs.TabPages[i].Controls["POLine"];
                if (string.IsNullOrEmpty(textBox.Text))
                {
                    textBox.Text = "";
                }
                writer.WriteString(textBox.Text);
                writer.WriteEndElement();

                writer.WriteStartElement("ShipDate");
                textBox = (TextBox)inputTabs.TabPages[i].Controls["shipDate"];
                if (string.IsNullOrEmpty(textBox.Text))
                {
                    textBox.Text = "";
                }
                writer.WriteString(textBox.Text);
                writer.WriteEndElement();

                writer.WriteStartElement("Quantity");
                textBox = (TextBox)inputTabs.TabPages[i].Controls["quantity"];
                if (string.IsNullOrEmpty(textBox.Text))
                {
                    textBox.Text = "";
                }
                writer.WriteString(textBox.Text);
                writer.WriteEndElement();

                writer.WriteStartElement("OverallThickness");
                textBox = (TextBox)inputTabs.TabPages[i].Controls["overallThick"];
                if (string.IsNullOrEmpty(textBox.Text))
                {
                    textBox.Text = "";
                }
                writer.WriteString(textBox.Text);
                writer.WriteEndElement();

                // lite 1

                writer.WriteStartElement("Lite1Thickness");
                comboBox = (ComboBox)inputTabs.TabPages[i].Controls["L1Thick"];
                if (string.IsNullOrEmpty(comboBox.Text))
                {
                    comboBox.Text = "";
                }
                writer.WriteString(comboBox.Text);
                writer.WriteEndElement();

                writer.WriteStartElement("Lite1Treatment");
                comboBox = (ComboBox)inputTabs.TabPages[i].Controls["L1Treat"];
                if (string.IsNullOrEmpty(comboBox.Text))
                {
                    comboBox.Text = "";
                }
                writer.WriteString(comboBox.Text);
                writer.WriteEndElement();

                writer.WriteStartElement("Lite1Coating");
                comboBox = (ComboBox)inputTabs.TabPages[i].Controls["L1Coat"];
                if (string.IsNullOrEmpty(comboBox.Text))
                {
                    comboBox.Text = "";
                }
                writer.WriteString(comboBox.Text);
                writer.WriteEndElement();


                //lite 2
                writer.WriteStartElement("Lite2Thickness");
                comboBox = (ComboBox)inputTabs.TabPages[i].Controls["L2Thick"];
                if (string.IsNullOrEmpty(comboBox.Text))
                {
                    comboBox.Text = "";
                }
                writer.WriteString(comboBox.Text);
                writer.WriteEndElement();

                writer.WriteStartElement("Lite2Treatment");
                comboBox = (ComboBox)inputTabs.TabPages[i].Controls["L2Treat"];
                if (string.IsNullOrEmpty(comboBox.Text))
                {
                    comboBox.Text = "";
                }
                writer.WriteString(comboBox.Text);
                writer.WriteEndElement();

                writer.WriteStartElement("Lite2Coating");
                comboBox = (ComboBox)inputTabs.TabPages[i].Controls["L2Coat"];
                if (string.IsNullOrEmpty(comboBox.Text))
                {
                    comboBox.Text = "";
                }
                writer.WriteString(comboBox.Text);
                writer.WriteEndElement();

                //lite 3
                writer.WriteStartElement("Lite3Thickness");
                comboBox = (ComboBox)inputTabs.TabPages[i].Controls["L3Thick"];
                if (string.IsNullOrEmpty(comboBox.Text))
                {
                    comboBox.Text = "";
                }
                writer.WriteString(comboBox.Text);
                writer.WriteEndElement();

                writer.WriteStartElement("Lite3Treatment");
                comboBox = (ComboBox)inputTabs.TabPages[i].Controls["L3Treat"];
                if (string.IsNullOrEmpty(comboBox.Text))
                {
                    comboBox.Text = "";
                }
                writer.WriteString(comboBox.Text);
                writer.WriteEndElement();

                writer.WriteStartElement("Lite3Coating");
                comboBox = (ComboBox)inputTabs.TabPages[i].Controls["L3Coat"];
                if (string.IsNullOrEmpty(comboBox.Text))
                {
                    comboBox.Text = "";
                }
                writer.WriteString(comboBox.Text);
                writer.WriteEndElement();

                //end of glass

                writer.WriteStartElement("Width");
                textBox = (TextBox)inputTabs.TabPages[i].Controls["baseLeg"];
                if (string.IsNullOrEmpty(textBox.Text))
                {
                    textBox.Text = "";
                }
                writer.WriteString(textBox.Text);
                writer.WriteEndElement();

                writer.WriteStartElement("Height");
                textBox = (TextBox)inputTabs.TabPages[i].Controls["leftLeg"];
                if (string.IsNullOrEmpty(textBox.Text))
                {
                    textBox.Text = "";
                }
                writer.WriteString(textBox.Text);
                writer.WriteEndElement();

                

                writer.WriteStartElement("ShapeNumber");
                textBox = (TextBox)inputTabs.TabPages[i].Controls["shapeNum"];
                if (string.IsNullOrEmpty(textBox.Text))
                {
                    textBox.Text = "";
                }
                writer.WriteString(textBox.Text);
                writer.WriteEndElement();

                writer.WriteStartElement("GasMixture");
                writer.WriteString("Argon");
                writer.WriteEndElement();


                writer.WriteStartElement("OpeningsWide");
                textBox = (TextBox)inputTabs.TabPages[i].Controls["openingsWide"];
                if (string.IsNullOrEmpty(textBox.Text))
                {
                    textBox.Text = "";
                }
                writer.WriteString(textBox.Text);
                writer.WriteEndElement();

                writer.WriteStartElement("OpeningsHigh");
                textBox = (TextBox)inputTabs.TabPages[i].Controls["openingsHigh"];
                if (string.IsNullOrEmpty(textBox.Text))
                {
                    textBox.Text = "";
                }
                writer.WriteString(textBox.Text);
                writer.WriteEndElement();

                writer.WriteStartElement("OddOpenings");
                textBox = (TextBox)inputTabs.TabPages[i].Controls["oddOpenings"];
                if (string.IsNullOrEmpty(textBox.Text))
                {
                    textBox.Text = "";
                }
                writer.WriteString(textBox.Text);
                writer.WriteEndElement();

                writer.WriteStartElement("GridStyle");
                textBox = (TextBox)inputTabs.TabPages[i].Controls["gridStyle"];
                if (string.IsNullOrEmpty(textBox.Text))
                {
                    textBox.Text = "";
                }
                writer.WriteString(textBox.Text);
                writer.WriteEndElement();

                writer.WriteStartElement("MCodeVertAir1");
                textBox = (TextBox)inputTabs.TabPages[i].Controls["MCodeVertAir1"];
                if (string.IsNullOrEmpty(textBox.Text))
                {
                    textBox.Text = "";
                }
                writer.WriteString(textBox.Text);
                writer.WriteEndElement();

                writer.WriteStartElement("MCodeHorizAir1");
                textBox = (TextBox)inputTabs.TabPages[i].Controls["MCodeHorizAir1"];
                if (string.IsNullOrEmpty(textBox.Text))
                {
                    textBox.Text = "";
                }
                writer.WriteString(textBox.Text);
                writer.WriteEndElement();


                writer.WriteStartElement("BatchSequenceNumber");
                textBox = (TextBox)inputTabs.TabPages[i].Controls["SQNum"];
                if (string.IsNullOrEmpty(textBox.Text))
                {
                    textBox.Text = "";
                }
                writer.WriteString(textBox.Text);
                writer.WriteEndElement();

                writer.WriteStartElement("ProductType");
                writer.WriteEndElement();

                writer.WriteStartElement("PartNumber1");
                textBox = (TextBox)inputTabs.TabPages[i].Controls["partNum1"];
                if (string.IsNullOrEmpty(textBox.Text))
                {
                    textBox.Text = "";
                }
                writer.WriteString(textBox.Text);
                writer.WriteEndElement();


                writer.WriteEndElement();
            }
            writer.WriteEndElement();
            writer.WriteEndElement();
            
        }

        private void RemoveNum_Click(object sender, EventArgs e)
        {
            int toRemove;
            bool isNumeric = Regex.IsMatch(Controls["removeTabNum"].Text, @"^\d+$");
            if (isNumeric)
            {
                toRemove = int.Parse(Controls["removeTabNum"].Text);
            }
            else
            {
                toRemove = 0;
            }
            if ((Controls["removeTabNum"].Text != "") && isNumeric && (toRemove < inputTabs.TabCount) && (toRemove > 0))
            {
                
                if (inputTabs.TabCount > 2)
                {
                    if (toRemove != (inputTabs.TabCount))
                    {
                        inputTabs.TabPages.Remove(inputTabs.TabPages[toRemove - 1]);
                    }
                    else
                    {
                        MessageBox.Show("Can't remove add tab button");
                    }
                }
                else
                {
                    MessageBox.Show("Can't remove last tab");
                }
            }
            else
            {
                MessageBox.Show("Tab # entered was empty or was not a valid number");
            }
        }


        private String getMaterial(String thick, String treat, String coat)
        {
            String material = "";
            if (thick == "3")
            {
                if (treat == "Annealed")
                {
                    if (coat == "Clear")
                    {
                        material = "X3CA";
                    }
                    else if (coat == "Loe187")
                    {
                        material = "X3L1A";
                    }
                    else if (coat == "Loe180")
                    {
                        material = "X3L2A";
                    }
                }
                else
                {
                    if (coat == "Clear")
                    {
                        material = "X3CT";
                    }
                    else if (coat == "Loe187")
                    {
                        material = "X3L1T";
                    }
                    else if (coat == "Loe180")
                    {
                        material = "X3L2T";
                    }
                }
            }
            else if (thick == "4")
            {
                if (treat == "Annealed")
                {
                    if (coat == "Clear")
                    {
                        material = "X4CA";
                    }
                    else if (coat == "Loe187")
                    {
                        material = "X4L1A";
                    }
                    else if (coat == "Loe180")
                    {
                        material = "X4L2A";
                    }
                }
                else
                {
                    if (coat == "Clear")
                    {
                        material = "X4CT";
                    }
                    else if (coat == "Loe187")
                    {
                        material = "X4L1T";
                    }
                    else if (coat == "Loe180")
                    {
                        material = "X4L2T";
                    }
                }
            }
            else if (thick == "5")
            {
                if (treat == "Annealed")
                {
                    if (coat == "Clear")
                    {
                        material = "X5CA";
                    }
                    else if (coat == "Loe187")
                    {
                        material = "X5L1A";
                    }
                    else if (coat == "Loe180")
                    {
                        material = "X5L2A";
                    }
                }
                else
                {
                    if (coat == "Clear")
                    {
                        material = "X5CT";
                    }
                    else if (coat == "Loe187")
                    {
                        material = "X5L1T";
                    }
                    else if (coat == "Loe180")
                    {
                        material = "X5L2T";
                    }
                }
            }
            return material;
        }


    }
}
