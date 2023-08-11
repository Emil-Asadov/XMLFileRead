using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace XMLFileRead
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnxmlRead_Click(object sender, EventArgs e)
        {
            var opf = new OpenFileDialog();
            opf.Title = "Fayl Seç";
            opf.Filter = "(*.xml)|*.xml";
            var clientId = string.Empty;
            var tagName = string.Empty;
            var lst = new List<ClassXMLFields>();
            try
            {
                if (opf.ShowDialog() == DialogResult.OK)
                {
                    var fileName = opf.SafeFileName.Substring(0, opf.SafeFileName.LastIndexOf("."));
                    var url = opf.FileName;
                    var cls = new ClassXMLFields();
                    var doc = new XmlDocument();
                    doc.Load(url);
                    var nodeList = doc.DocumentElement.SelectNodes("/AIFPayments/PAYMENT");
                    var fieldsType = typeof(ClassXMLFields);
                    PropertyInfo[] properties = fieldsType.GetProperties();
                    foreach (XmlNode node in nodeList)
                    {
                        clientId = node.SelectSingleNode("CLIENT_ID")?.InnerText;
                        cls = new ClassXMLFields()
                        {
                            pay_date = node.SelectSingleNode("PAY_DATE")?.InnerText,
                            full_name = node.SelectSingleNode("FULL_NAME")?.InnerText,
                            client_id = node.SelectSingleNode("CLIENT_ID")?.InnerText,
                            credit_id = node.SelectSingleNode("CREDIT_ID")?.InnerText,
                            cr = node.SelectSingleNode("CR")?.InnerText,
                            fond_int = node.SelectSingleNode("FOND_INT")?.InnerText,
                            bank_int = node.SelectSingleNode("BANK_INT")?.InnerText,
                            od_cr = node.SelectSingleNode("OD_CR")?.InnerText,
                            od_fond_int = node.SelectSingleNode("OD_FOND_INT")?.InnerText,
                            od_bank_int = node.SelectSingleNode("OD_BANK_INT")?.InnerText,
                            od_penalty_int = node.SelectSingleNode("OD_PENALTY_INT")?.InnerText,
                            pay_type = node.SelectSingleNode("PAY_TYPE")?.InnerText,
                            m_paym = node.SelectSingleNode("M_PAYM")?.InnerText,
                            maturity = node.SelectSingleNode("MATURITY")?.InnerText,
                            cr_bal = node.SelectSingleNode("CR_BAL")?.InnerText,
                            pay_id = node.SelectSingleNode("PAY_ID")?.InnerText,
                            next_m_paym = node.SelectSingleNode("NEXT_M_PAYM")?.InnerText,
                            next_m_fond_int = node.SelectSingleNode("NEXT_M_FOND_INT")?.InnerText,
                            next_m_bank_int = node.SelectSingleNode("NEXT_M_BANK_INT")?.InnerText,
                            fond_int_bal = node.SelectSingleNode("FOND_INT_BAL")?.InnerText,
                            bank_int_bal = node.SelectSingleNode("BANK_INT_BAL")?.InnerText,
                            od_fond_int_bal = node.SelectSingleNode("OD_FOND_INT_BAL")?.InnerText,
                            od_bank_int_bal = node.SelectSingleNode("OD_BANK_INT_BAL")?.InnerText,
                            od_penalty_int_bal = node.SelectSingleNode("OD_PENALTY_INT_BAL")?.InnerText,
                            od_credit_bal = node.SelectSingleNode("OD_CREDIT_BAL")?.InnerText,
                            cr_type = node.SelectSingleNode("CR_TYPE")?.InnerText,
                            if_bal = node.SelectSingleNode("IF_BAL")?.InnerText
                        };
                        foreach (PropertyInfo info in properties)
                        {
                            if (info.GetValue(cls) == null)
                            {
                                tagName = info.Name.ToUpper();
                                throw new ArgumentNullException();
                            }
                        }
                        lst.Add(cls);
                    }
                    dgvXMLRead.DataSource = lst;
                    lblRowsCount.Text = $"Rows count: {dgvXMLRead.Rows.Count}";
                }
            }
            catch (Exception ex)
            {
                dgvXMLRead.DataSource = null;
                lblRowsCount.Text = $"Rows count: 0";
                MessageBox.Show($"Client ID: {clientId}{(char)13}{(char)10}Tag name: {tagName}{(char)13}{(char)10}Exception: {ex.Message}", "Diqqət!");
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            dgvXMLRead.EnableHeadersVisualStyles = false;
            dgvXMLRead.ColumnHeadersDefaultCellStyle.BackColor = Color.PowderBlue;
        }
    }
}
