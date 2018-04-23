using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors.Repository;
using System.Reflection;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Filtering;
using DevExpress.Data.Filtering;
using DevExpress.Data.Filtering.Helpers;

namespace WindowsApplication197
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            InitData();
            gridControl1.DataSource = dv;

            DevExpress.XtraGrid.FilterEditor.ViewFilterColumnCollection columnCollection = new DevExpress.XtraGrid.FilterEditor.ViewFilterColumnCollection(gridView1);
            RepositoryItemPopupContainerEdit ri = new RepositoryItemPopupContainerEdit();
            ri.PopupControl = popupContainerControl1;
            ri.CloseOnOuterMouseClick = false;
            ri.QueryResultValue += new DevExpress.XtraEditors.Controls.QueryResultValueEventHandler(ri_QueryResultValue);
            ri.QueryPopUp += new CancelEventHandler(ri_QueryPopUp);
            columnCollection["Date"].SetColumnEditor(ri);
            columnCollection["ID"].SetColumnEditor(new RepositoryItemCalcEdit());
            filterControl1.SetFilterColumnsCollection(columnCollection);

        }

        void ri_QueryPopUp(object sender, CancelEventArgs e)
        {
            dateEdit1.EditValue = ((PopupContainerEdit)sender).EditValue;
        }

        void ri_QueryResultValue(object sender, DevExpress.XtraEditors.Controls.QueryResultValueEventArgs e)
        {
            e.Value = dateEdit1.EditValue;
            DateTime date = Convert.ToDateTime(e.Value);
            PropertyInfo pi = typeof(FilterControl).GetProperty("FocusInfo", BindingFlags.Instance| BindingFlags.NonPublic);
            FilterControlFocusInfo focus = (FilterControlFocusInfo)pi.GetValue(filterControl1, null);
            ClauseNode cnode = focus.Node as ClauseNode;
            if (cnode == null) return;
            if (cnode.Operation == ClauseType.Between)
            {
                if (focus.ElementIndex == 2)
                {
                    PatchOperator(cnode.AdditionalOperands[1] as OperandValue, date, comboBoxEdit1.Text, true);
                }
                else if (focus.ElementIndex == 3)
                {
                    PatchOperator(cnode.AdditionalOperands[0] as OperandValue, date, comboBoxEdit1.Text, false);
                }
                cnode.RecalcLabelInfo();
            }
        }

        void PatchOperator(OperandValue opr, DateTime date, string range, bool isFirst)
        {
            if (((object)opr) == null) return;
            switch (range)
            {
                case "Day": opr.Value = date.AddDays(isFirst ? 1 : -1); break;
                case "Week": opr.Value = date.AddDays(isFirst ? 7 : -7); break;
                case "Month": opr.Value = date.AddMonths(isFirst ? 1 : -1); break;
            }
        }

        private void InitData()
        {
            dt = new DataTable();
            dt.Columns.Add("ID", typeof(int));
            dt.Columns.Add("Date", typeof(DateTime));
            Random rnd= new Random();
            for (int i = 0; i < 1000; i++)
            {
                dt.Rows.Add(new object[] { i, DateTime.Now.Date.AddDays(rnd.Next(100)) });
            }
            dv = new DataView(dt);
        }

        DataTable dt;
        DataView dv;

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            filterControl1.ApplyFilter();
            gridView1.ActiveFilterCriteria = filterControl1.FilterCriteria;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}