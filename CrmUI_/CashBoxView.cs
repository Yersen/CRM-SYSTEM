using CrmBl_.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CrmUI_
{
    public class CashBoxView
    {
        CashDesk cashDesk;
        public Label CashDeskName { get; set; }
        public NumericUpDown Price { get; set; }
        public ProgressBar QueueLenght { get; set; }
        public Label LeaveCustomersCount { get; set; }
        public CashBoxView(CashDesk cashDesk, int number, int x, int y)
        {
            this.cashDesk = cashDesk;
            CashDeskName = new Label();
            Price = new NumericUpDown();
            QueueLenght = new ProgressBar();
            LeaveCustomersCount = new Label();
            CashDeskName.AutoSize = true;
            CashDeskName.Location = new System.Drawing.Point(x, y+ 10);
            CashDeskName.Name = "label" + number;
            CashDeskName.Size = new System.Drawing.Size(46, 17);
            CashDeskName.TabIndex = number;
            CashDeskName.Text = cashDesk.ToString();

 
            Price.Location = new System.Drawing.Point(x + 60, y + 10);
            Price.Name = "numericUpDown " + number;
            Price.Size = new System.Drawing.Size(120, 22);
            Price.TabIndex = number;
            Price.Maximum = 1000000000000;


            QueueLenght.Location = new System.Drawing.Point(x+190, y + 10);
            QueueLenght.Maximum = cashDesk.MaxQueueLenght;
            QueueLenght.Name = "progressBar " + number;
            QueueLenght.Size = new System.Drawing.Size(100, 23);
            QueueLenght.TabIndex = number;
            QueueLenght.Value = 0;

            LeaveCustomersCount.AutoSize = true;
            LeaveCustomersCount.Location = new System.Drawing.Point(x+300, y + 10);
            LeaveCustomersCount.Name = "label2" + number;
            LeaveCustomersCount.Size = new System.Drawing.Size(46, 17);
            LeaveCustomersCount.TabIndex = number;
            LeaveCustomersCount.Text = "";

            cashDesk.checkClosed += CashDesk_checkClosed;
        }

        private void CashDesk_checkClosed(object sender, Check e)
        {
            Price.Invoke((Action)delegate 
            {
                Price.Value += e.Price;
                QueueLenght.Value = cashDesk.Count;
                LeaveCustomersCount.Text = cashDesk.ExitCustomer.ToString();
            }
            );
        }
    }
}
