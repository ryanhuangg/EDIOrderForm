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
        public Input()
        {
            InitializeComponent();
            PODate.Text = DateTime.Now.ToString("MMMM dd, yyyy");
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
                    

                    n.Controls.Add(ccc);

                }
                
                foreach (Control c in inputTabs.TabPages[lastIndex].Controls)
                {
                    if (c.GetType().ToString() != "System.Windows.Forms.Label")
                    {
                        c.Text = "";
                    }
                }
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
            MessageBox.Show("Order has been transfered to XML File");
        }

        private void CreateXML()
        {
            Encoding encoding = Encoding.GetEncoding("ISO-8859-1");
            TextBox textBox = new TextBox();
            XmlTextWriter xmlTextWriter = new XmlTextWriter("c:\\cardinal\\EDI_Order.xml", encoding);
            xmlTextWriter.WriteStartDocument(true);
            xmlTextWriter.Formatting = Formatting.Indented;
            xmlTextWriter.Indentation = 2;
            this.createNode(xmlTextWriter);
            xmlTextWriter.WriteEndDocument();
            xmlTextWriter.Close();
        }

        private void createNode(XmlTextWriter writer)
        {
            writer.WriteStartElement("Order");
            writer.WriteStartElement("PONumber");
            if (!string.IsNullOrEmpty(this.PONum.Text))
            {
                writer.WriteString(this.PONum.Text);
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

                writer.WriteStartElement("Lite1CoatingSurface");
                writer.WriteEndElement();
                writer.WriteStartElement("Lite1Pattern");
                writer.WriteEndElement();
                writer.WriteStartElement("Lite1PatternSurface");
                writer.WriteEndElement();
                writer.WriteStartElement("Lite1ColorSurface");
                writer.WriteEndElement();
                writer.WriteStartElement("Lite1SpecialtyGlass");
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

                writer.WriteStartElement("Lite2CoatingSurface");
                writer.WriteEndElement();
                writer.WriteStartElement("Lite2Pattern");
                writer.WriteEndElement();
                writer.WriteStartElement("Lite2PatternSurface");
                writer.WriteEndElement();
                writer.WriteStartElement("Lite2ColorSurface");
                writer.WriteEndElement();
                writer.WriteStartElement("Lite2SpecialtyGlass");
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

                writer.WriteStartElement("Lite3CoatingSurface");
                writer.WriteEndElement();
                writer.WriteStartElement("Lite3Pattern");
                writer.WriteEndElement();
                writer.WriteStartElement("Lite3PatternSurface");
                writer.WriteEndElement();
                writer.WriteStartElement("Lite3ColorSurface");
                writer.WriteEndElement();
                writer.WriteStartElement("Lite3SpecialtyGlass");
                writer.WriteEndElement();
                //end of glass

                writer.WriteStartElement("BaseLeg");
                textBox = (TextBox)inputTabs.TabPages[i].Controls["baseLeg"];
                if (string.IsNullOrEmpty(textBox.Text))
                {
                    textBox.Text = "";
                }
                writer.WriteString(textBox.Text);
                writer.WriteEndElement();

                writer.WriteStartElement("LeftLeg");
                textBox = (TextBox)inputTabs.TabPages[i].Controls["leftLeg"];
                if (string.IsNullOrEmpty(textBox.Text))
                {
                    textBox.Text = "";
                }
                writer.WriteString(textBox.Text);
                writer.WriteEndElement();

                writer.WriteStartElement("RightLeg");
                textBox = (TextBox)inputTabs.TabPages[i].Controls["RightLeg"];
                if (string.IsNullOrEmpty(textBox.Text))
                {
                    textBox.Text = "";
                }
                writer.WriteString(textBox.Text);
                writer.WriteEndElement();

                writer.WriteStartElement("TopLeg");
                textBox = (TextBox)inputTabs.TabPages[i].Controls["TopLeg"];
                if (string.IsNullOrEmpty(textBox.Text))
                {
                    textBox.Text = "";
                }
                writer.WriteString(textBox.Text);
                writer.WriteEndElement();

                writer.WriteStartElement("S1Leg");
                textBox = (TextBox)inputTabs.TabPages[i].Controls["S1Leg"];
                if (string.IsNullOrEmpty(textBox.Text))
                {
                    textBox.Text = "";
                }
                writer.WriteString(textBox.Text);
                writer.WriteEndElement();

                writer.WriteStartElement("S2Leg");
                textBox = (TextBox)inputTabs.TabPages[i].Controls["S2Leg"];
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

                writer.WriteStartElement("CapillaryTubes");
                writer.WriteEndElement();
                writer.WriteStartElement("GasMixture");
                writer.WriteString("Argon");
                writer.WriteEndElement();
                writer.WriteStartElement("SpacerType");
                writer.WriteEndElement();
                writer.WriteStartElement("SpacerSizeAir1");
                writer.WriteEndElement();
                writer.WriteStartElement("SpacerSizeAir2");
                writer.WriteString(" ");
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

                writer.WriteStartElement("DrawingNumber");
                textBox = (TextBox)inputTabs.TabPages[i].Controls["drawingNum"];
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

                writer.WriteStartElement("SubGridStyle");
                writer.WriteEndElement();
                writer.WriteStartElement("BarIntersection");
                writer.WriteEndElement();
                writer.WriteStartElement("PrairieVerticalOffset");
                writer.WriteEndElement();
                writer.WriteStartElement("PrairieHorizontalOffset");
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

                writer.WriteStartElement("MCodeVertAir2");
                writer.WriteEndElement();
                writer.WriteStartElement("MCodeHorizAir2");
                writer.WriteEndElement();
                writer.WriteStartElement("BumpOn");
                writer.WriteEndElement();
                writer.WriteStartElement("NumberOfBumpOns");
                writer.WriteEndElement();
                writer.WriteStartElement("BumpOnConfig");
                writer.WriteEndElement();

                writer.WriteStartElement("HorizontalNotch1");
                textBox = (TextBox)inputTabs.TabPages[i].Controls["HNotch1"];
                if (string.IsNullOrEmpty(textBox.Text))
                {
                    textBox.Text = "";
                }
                writer.WriteString(textBox.Text);
                writer.WriteEndElement();

                writer.WriteStartElement("HorizontalNotch2");
                textBox = (TextBox)inputTabs.TabPages[i].Controls["HNotch2"];
                if (string.IsNullOrEmpty(textBox.Text))
                {
                    textBox.Text = "";
                }
                writer.WriteString(textBox.Text);
                writer.WriteEndElement();

                writer.WriteStartElement("HorizontalNotch3");
                writer.WriteEndElement();
                writer.WriteStartElement("HorizontalNotch4");
                writer.WriteEndElement();
                writer.WriteStartElement("HorizontalNotch5");
                writer.WriteEndElement();
                writer.WriteStartElement("HorizontalNotch6");
                writer.WriteEndElement();
                writer.WriteStartElement("HorizontalNotch7");
                writer.WriteEndElement();
                writer.WriteStartElement("HorizontalNotch8");
                writer.WriteEndElement();
                writer.WriteStartElement("HorizontalNotch9");
                writer.WriteEndElement();
                writer.WriteStartElement("HorizontalNotch10");
                writer.WriteEndElement();
                writer.WriteStartElement("HorizontalNotch11");
                writer.WriteEndElement();
                writer.WriteStartElement("HorizontalNotch12");
                writer.WriteEndElement();
                writer.WriteStartElement("HorizontalNotch13");
                writer.WriteEndElement();
                writer.WriteStartElement("HorizontalNotch14");
                writer.WriteEndElement();
                writer.WriteStartElement("HorizontalNotch15");
                writer.WriteEndElement();
                writer.WriteStartElement("HorizontalNotch16");
                writer.WriteEndElement();
                writer.WriteStartElement("HorizontalNotch17");
                writer.WriteEndElement();
                writer.WriteStartElement("HorizontalNotch18");
                writer.WriteEndElement();
                writer.WriteStartElement("HorizontalNotch19");
                writer.WriteEndElement();
                writer.WriteStartElement("HorizontalNotch20");
                writer.WriteEndElement();

                writer.WriteStartElement("VerticalNotch1");
                textBox = (TextBox)inputTabs.TabPages[i].Controls["VNotch1"];
                if (string.IsNullOrEmpty(textBox.Text))
                {
                    textBox.Text = "";
                }
                writer.WriteString(textBox.Text);
                writer.WriteEndElement();

                writer.WriteStartElement("VerticalNotch2");
                textBox = (TextBox)inputTabs.TabPages[i].Controls["VNotch2"];
                if (string.IsNullOrEmpty(textBox.Text))
                {
                    textBox.Text = "";
                }
                writer.WriteString(textBox.Text);
                writer.WriteEndElement();

                writer.WriteStartElement("VerticalNotch3");
                writer.WriteEndElement();
                writer.WriteStartElement("VerticalNotch4");
                writer.WriteEndElement();
                writer.WriteStartElement("VerticalNotch5");
                writer.WriteEndElement();
                writer.WriteStartElement("VerticalNotch6");
                writer.WriteEndElement();
                writer.WriteStartElement("VerticalNotch7");
                writer.WriteEndElement();
                writer.WriteStartElement("VerticalNotch8");
                writer.WriteEndElement();
                writer.WriteStartElement("VerticalNotch9");
                writer.WriteEndElement();
                writer.WriteStartElement("VerticalNotch10");
                writer.WriteEndElement();
                writer.WriteStartElement("VerticalNotch11");
                writer.WriteEndElement();
                writer.WriteStartElement("VerticalNotch12");
                writer.WriteEndElement();
                writer.WriteStartElement("VerticalNotch13");
                writer.WriteEndElement();
                writer.WriteStartElement("VerticalNotch14");
                writer.WriteEndElement();
                writer.WriteStartElement("VerticalNotch15");
                writer.WriteEndElement();
                writer.WriteStartElement("VerticalNotch16");
                writer.WriteEndElement();
                writer.WriteStartElement("VerticalNotch17");
                writer.WriteEndElement();
                writer.WriteStartElement("VerticalNotch18");
                writer.WriteEndElement();
                writer.WriteStartElement("VerticalNotch19");
                writer.WriteEndElement();
                writer.WriteStartElement("VerticalNotch20");
                writer.WriteEndElement();
                writer.WriteStartElement("PreserveInfo");
                writer.WriteEndElement();
                writer.WriteStartElement("PreserveSurface");
                writer.WriteEndElement();
                writer.WriteStartElement("PreserveColorExterior");
                writer.WriteEndElement();
                writer.WriteStartElement("PreserveColorInterior");
                writer.WriteEndElement();
                writer.WriteStartElement("PreserveCutbackSizeExterior");
                writer.WriteEndElement();
                writer.WriteStartElement("PreserveCutbackSizeInterior");
                writer.WriteEndElement();
                writer.WriteStartElement("ScoringInfo");
                writer.WriteEndElement();
                writer.WriteStartElement("ScoringSurface");
                writer.WriteEndElement();
                writer.WriteStartElement("ScoringSizeExterior");
                writer.WriteEndElement();
                writer.WriteStartElement("ScoringSizeInterior");
                writer.WriteEndElement();
                writer.WriteStartElement("OverlayBar");
                writer.WriteEndElement();
                writer.WriteStartElement("ANSILogo");
                writer.WriteEndElement();
                writer.WriteStartElement("ANSILogoXOffset");
                writer.WriteEndElement();
                writer.WriteStartElement("ANSILogoYOffset");
                writer.WriteEndElement();
                writer.WriteStartElement("NFRCLogo");
                writer.WriteEndElement();
                writer.WriteStartElement("IGLogo");
                writer.WriteEndElement();
                writer.WriteStartElement("IGLogoXOffset");
                writer.WriteEndElement();
                writer.WriteStartElement("IGLogoYOffset");
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
                writer.WriteStartElement("PartNumber2");
                writer.WriteEndElement();
                writer.WriteStartElement("PartNumber3");
                writer.WriteEndElement();

                writer.WriteStartElement("CustomerPrice");
                textBox = (TextBox)inputTabs.TabPages[i].Controls["customerPrice"];
                if (string.IsNullOrEmpty(textBox.Text))
                {
                    textBox.Text = "";
                }
                writer.WriteString(textBox.Text);
                writer.WriteEndElement();

                writer.WriteStartElement("AddOnPrice");
                writer.WriteEndElement();

                writer.WriteEndElement();
            }
            writer.WriteEndElement();
            writer.WriteEndElement();
            
        }

        private void RemoveNum_Click(object sender, EventArgs e)
        {
            
            bool isNumeric = Regex.IsMatch(Controls["removeTabNum"].Text, @"^\d+$");
            if ((Controls["removeTabNum"].Text != "") && isNumeric)
            {
                int toRemove = int.Parse(Controls["removeTabNum"].Text);
                if (inputTabs.TabCount > 2)
                {
                    if (toRemove != (inputTabs.TabCount - 1))
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
                MessageBox.Show("Tab # entered was empty or was not a number");
            }
        }
    }
}
