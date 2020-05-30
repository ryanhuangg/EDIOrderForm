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



namespace EDIForm
{
    public partial class Input : Form
    {
        public int tabNum = 1;
        public String poNum = "";
        public Input(String s)
        {
            InitializeComponent();
            PODate.Text = DateTime.Now.ToString("yyyyMMdd");
            POLine.Text = "1";
            poNum = s;
            PODisplay.Text = s;
            gasFill.SelectedItem = "Argon";
            spacer.SelectedItem = "Black Warm Edge";
            shapeNum.Text = "0";
            L1Treat.SelectedItem = "Annealed";
            L2Treat.SelectedItem = "Annealed";
            L1Coat.SelectedItem = "Clear";
            L2Coat.SelectedItem = "LoE";
            L1Thick.SelectedItem = "3";
            L2Thick.SelectedItem = "3";
            shipDate.Value = DateTime.Today;
            shipDate.Text = shipDate.Value.ToString();

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
                Font f = null;
                f = this.inputTabs.TabPages[0].Controls[0].Font;
                


                this.inputTabs.TabPages.Insert(lastIndex, n);
                this.inputTabs.SelectedIndex = lastIndex;

                // TODO on desktop
                String wid = this.inputTabs.TabPages[lastIndex - 1].Controls["baseLeg"].Text.Split(' ')[0];
                String hei = this.inputTabs.TabPages[lastIndex - 1].Controls["leftLeg"].Text.Split(' ')[0];
                int l1t = Int32.Parse(this.inputTabs.TabPages[lastIndex - 1].Controls["L1Thick"].Text);
                int l2t = Int32.Parse(this.inputTabs.TabPages[lastIndex - 1].Controls["L2Thick"].Text);
                double width = 0;
                double height = 0;
                if (wid != "")
                {
                    width = Int32.Parse(wid);
                }

                if (hei != "")
                {
                    height = Int32.Parse(hei);
                }


                if ((width * height / 144) > 40 || width >= 96 || height >= 96)
                {
                    if (l1t < 6 || l2t < 6)
                    {
                        MessageBox.Show("The glass thickness should be at least 6mm on the previous tab. (POLine " + lastIndex.ToString() + ")");
                    }
                }
                else if ((width * height / 144) > 30 || (width <= 96 && width > 92) || (height <= 96 && height > 92))
                {
                    if (l1t < 5 || l2t < 5)
                    {
                        MessageBox.Show("The glass thickness should be at least 5mm on the previous tab. (POLine " + lastIndex.ToString() + ")");
                    }
                }
                else if ((width * height / 144) > 18 || (width <= 92 && width > 70) || (height <= 92 && height > 70))
                {
                    if (l1t < 4 || l2t < 4)
                    {
                        MessageBox.Show("The glass thickness should be at least 4mm on the previous tab. (POLine " + lastIndex.ToString() + ")");
                    }
                }



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
                        cb.Font = f;
                        cb.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
                        ccc = cb;
                        
                    }


                    ccc.TabIndex = cc[j].TabIndex;

                    ccc.Name = cc[j].Name;

                    ccc.Location = cc[j].Location;

                    ccc.Font = f;

                    ccc.Size = cc[j].Size;

                    if (ccc.Name == "shipDate")
                    {
                        DateTimePicker a = new DateTimePicker();
                        a.CustomFormat = "yyyyMMdd";
                        a.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
                        a.Value = DateTime.Today;
                        a.Location = cc[j].Location;
                        a.Text = DateTime.Today.ToString();
                        a.Name = cc[j].Name;
                        a.Font = cc[j].Font;
                        a.TabIndex = cc[j].TabIndex;
                        ccc = a;
                    }
                    else
                    {
                        ccc.Text = cc[j].Text;
                    }

                    ccc.BackColor = cc[j].BackColor;

                    ccc.ForeColor = cc[j].ForeColor;

                    ccc.Width = cc[j].Width;


                    if (ccc.Name == "gasFill")
                    {
                        ComboBox gas = (ComboBox) ccc;
                        gas.SelectedValue = "Argon";
                        ccc = gas;
                    }
                    else if (ccc.Name == "spacer")
                    {
                        ComboBox edge = (ComboBox)ccc;
                        edge.SelectedValue = "Black Warm Edge";
                        ccc = edge;
                    }
                    else if (ccc.Name == "shapeNum")
                    {
                        TextBox a = (TextBox) ccc;
                        a.ReadOnly = true;
                        a.Text = "0";
                        ccc = a;
                        
                    }
                    else if (ccc.Name == "L1Treat")
                    {
                        ccc.Text = "Annealed";
                    }
                    else if (ccc.Name == "L2Treat")
                    {
                        ccc.Text = "Annealed";
                    }
                    else if (ccc.Name == "L1Coat")
                    {
                        ccc.Text = "Clear";
                    }
                    else if (ccc.Name == "L2Coat")
                    {
                        ccc.Text = "Loe";
                    }
                    else if (ccc.Name == "L1Thick")
                    {
                        ccc.Text = "3";
                    }
                    else if (ccc.Name == "L2Thick")
                    {
                        ccc.Text = "1";
                    }
                    else if (ccc.Name == "overallThick")
                    {
                        ccc.Text = this.inputTabs.TabPages[0].Controls["overallThick"].Text;
                    }

                    




                    n.Controls.Add(ccc);

                }
                
                foreach (Control c in inputTabs.TabPages[lastIndex].Controls)
                {
                    if (c.GetType().ToString() != "System.Windows.Forms.Label" && c.Name != "shipDate" && c.Name != "gasFill" && c.Name != "spacer" && c.Name != "shapeNum" && c.Name != "L1Treat" && c.Name != "L2Treat"
                        && c.Name != "L1Coat" && c.Name != "L2Coat" && c.Name != "L1Thick" && c.Name != "L2Thick" && c.Name != "shipDate" && c.Name != "overallThick")
                    {
                        c.Text = "";
                    }
                }


                n.Controls["POLine"].Text = (tabNum).ToString();
                

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
            Boolean problem = false;
            for (int i = 0; i < inputTabs.TabCount - 1; i++)
            {
                if (inputTabs.TabPages[i].Controls["POLine"].Text != (i + 1).ToString())
                {
                    problem = true;
                }
            }
            if (!problem)
            {
                this.CreateXML();
                MessageBox.Show("Order has been transfered to XML File");
            }
            else
            {
                MessageBox.Show("Please resequence before exporting");
            }
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
            XmlTextWriter xmlTextWriter = new XmlTextWriter("c:\\Ultraseal\\" + po + ".xml", encoding);
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
            DateTimePicker pick = new DateTimePicker();
            writer.WriteStartElement("Items");
            for (int i = 0; i < inputTabs.TabCount - 1; i++)
            {
                writer.WriteStartElement("Item");
                writer.WriteStartElement("POLineNumber");
                textBox = (TextBox)inputTabs.TabPages[i].Controls["POLine"];
                if (string.IsNullOrEmpty(textBox.Text))
                {
                    textBox.Text = "";
                }
                writer.WriteString(textBox.Text);
                writer.WriteEndElement();

                writer.WriteStartElement("ShipDate");
                pick = (DateTimePicker)inputTabs.TabPages[i].Controls["shipDate"];
                if (string.IsNullOrEmpty(pick.Text))
                {
                    pick.Text = "";
                }
                writer.WriteString(pick.Text);
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
                String writeCoat1 = "";
                if (comboBox.Text == "Clear")
                {
                    writeCoat1 = "CL";
                }
                else if (comboBox.Text == "LoE")
                {
                    writeCoat1 = "LoE";
                }
                else if (comboBox.Text == "Frosted")
                {
                    writeCoat1 = "Pinhead";
                }
                writer.WriteString(writeCoat1);
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
                String writeCoat2 = "";
                if (comboBox.Text == "Clear")
                {
                    writeCoat2 = "CL";
                }
                else if (comboBox.Text == "LoE")
                {
                    writeCoat2 = "LoE";
                }
                else if (comboBox.Text == "Frosted")
                {
                    writeCoat2 = "Pinhead";
                }
                writer.WriteString(writeCoat2);
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
                String writeCoat3 = "";
                if (comboBox.Text == "Clear")
                {
                    writeCoat3 = "CL";
                }
                else if (comboBox.Text == "LoE")
                {
                    writeCoat3 = "LoE";
                }
                else if (comboBox.Text == "Frosted")
                {
                    writeCoat3 = "Pinhead";
                }
                writer.WriteString(writeCoat3);
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
                writer.WriteEndElement();

                writer.WriteStartElement("TopLeg");
                writer.WriteEndElement();

                writer.WriteStartElement("S1Leg");
                writer.WriteEndElement();

                writer.WriteStartElement("S2Leg");
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
                comboBox = (ComboBox)inputTabs.TabPages[i].Controls["gasFill"];
                if (string.IsNullOrEmpty(comboBox.Text))
                {
                    comboBox.Text = "";
                }
                writer.WriteString(comboBox.Text);
                writer.WriteEndElement();

                writer.WriteStartElement("SpacerType");
                comboBox = (ComboBox)inputTabs.TabPages[i].Controls["spacer"];
                if (string.IsNullOrEmpty(comboBox.Text))
                {
                    comboBox.Text = "";
                }
                String textWri = comboBox.Text + " Spacer";
                writer.WriteString(textWri);
                writer.WriteEndElement();

                writer.WriteStartElement("SpacerSizeAir1");
                writer.WriteEndElement();

                writer.WriteStartElement("SpacerSizeAir2");
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
                writer.WriteEndElement();

                writer.WriteStartElement("DrawingNumber");
                writer.WriteEndElement();


                writer.WriteStartElement("GridStyle");
                comboBox = (ComboBox)inputTabs.TabPages[i].Controls["gridStyle"];
                String styleWrite = "";
                if (string.IsNullOrEmpty(comboBox.Text))
                {
                    comboBox.Text = "";
                }
                if (comboBox.Text == "Colonial")
                {
                    styleWrite = "100";
                }
                else if (comboBox.Text == "Prairie")
                {
                    styleWrite = "110";
                }
                writer.WriteString(styleWrite);
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
                textBox = (TextBox)inputTabs.TabPages[i].Controls["MCode"];
                if (string.IsNullOrEmpty(textBox.Text))
                {
                    textBox.Text = "";
                }
                writer.WriteString(textBox.Text);
                writer.WriteEndElement();


                writer.WriteStartElement("MCodeHorizAir1");
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
                writer.WriteEndElement();

                writer.WriteStartElement("HorizontalNotch2");
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
                writer.WriteEndElement();

                writer.WriteStartElement("VerticalNotch2");
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

        private void L3Coat_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void PictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void resequence_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < inputTabs.TabCount - 1; i++)
            {
                this.inputTabs.TabPages[i].Controls["POLine"].Text = (i + 1).ToString();
                this.inputTabs.TabPages[i].Text = "POLine " + (i + 1).ToString();
            }
        }
    }
}
