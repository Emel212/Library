
using Library.Entities.Models;
using LibraryApi.Controllers;
using Newtonsoft.Json;
using System;
using System.Net.Http;
using System.Net.Http.Json;
using System.Text;
using System.Windows.Forms;


namespace WinFormsApp1
{
    public partial class Main : Form
    {
        public  Main()
        {
            InitializeComponent();
        }
     
    
        private async void Form1_Load(object sender, EventArgs e)
        {

           
           bool result=await LibraryManagerWinForm.Helpers.ServiceTools.IsServiceAvailable<Category>("Category", "GetAll", "param");
            if(result)
            {
                var list = await LibraryManagerWinForm.Helpers.ServiceTools.ServiceGetByName<Category>("Category", "GetAll", "param");

                foreach (var item in list)
                {
                    _cmbCategory.Items.Add(item.Name.ToString());
                }
              
            }
            else { Message.Text = "Couldn't connect to server"; }
        }
      
        private async void button1_Click(object sender, EventArgs e)
        {
            LibraryManagerWinForm.Helpers.FormTools.ClearAllText(groupBox2);
            LibraryManagerWinForm.Helpers.FormTools.ClearAllText(_statusPanel);
            bool result =await LibraryManagerWinForm.Helpers.ServiceTools.IsServiceAvailable<Book>("Library", "BookByName", _bookName.Text.Trim());
     
            if(result)
            {
                var list = await LibraryManagerWinForm.Helpers.ServiceTools.ServiceGetByName<Book>("Library", "BookByName", _bookName.Text.Trim());
                Message.Text = "";

                dataGridView1.Rows.Clear();
                foreach (var item in list)
                {
                    dataGridView1.Rows.Add(item.Name, item.Description, item.Author, item.PublisherId, item.CategoryId, item.Id);

                }
              
            }
            else { Message.Text = "No matching records found"; }         
        }

        private async void button5_Click(object sender, EventArgs e)
        {
            LibraryManagerWinForm.Helpers.FormTools.ClearAllText(groupBox2);
            LibraryManagerWinForm.Helpers.FormTools.ClearAllText(_statusPanel);
            bool result = await LibraryManagerWinForm.Helpers.ServiceTools.IsServiceAvailable<Book>("Library", "BookByAuthor", _author.Text.Trim());
            if (result)
            {
                var list = await LibraryManagerWinForm.Helpers.ServiceTools.ServiceGetByName<Book>("Library", "BookByAuthor", _author.Text.Trim());
                dataGridView1.Rows.Clear();
                foreach (var item in list)
                {
                    dataGridView1.Rows.Add(item.Name, item.Description, item.Author, item.PublisherId, item.CategoryId, item.Id);
                }
             
            }
            else { Message.Text = "No matching records found"; }
        }
        
      
        private async void button6_Click(object sender, EventArgs e)
        {
            LibraryManagerWinForm.Helpers.FormTools.ClearAllText(groupBox2);
            LibraryManagerWinForm.Helpers.FormTools.ClearAllText(_statusPanel);

            var list =await LibraryManagerWinForm.Helpers.ServiceTools.ServiceGetByName<Book>("Library", "BookByCategory", _cmbCategory.Text.Trim());
            dataGridView1.Rows.Clear();

            foreach (var item in list)
            {
                dataGridView1.Rows.Add(item.Name, item.Description, item.Author, item.PublisherId, item.CategoryId,item.Id);
            }
            
        }
        int id;
        int bookStatusID;
        private async void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            LibraryManagerWinForm.Helpers.FormTools.ClearAllText(groupBox2);
            LibraryManagerWinForm.Helpers.FormTools.ClearAllText(_statusPanel);
             id =(int)dataGridView1.Rows[e.RowIndex].Cells["Id"].Value;
         
                var bookStatus = await LibraryManagerWinForm.Helpers.ServiceTools.ServiceGetById<BookStatus>("BookStatus", "GetByBookId", id,string.Empty);
            bookStatusID = bookStatus.Id;
                     if(bookStatus.Id>0)
            {

                if (bookStatus.IsAvailable.Value == true)
                    currentStatus.Text = "Available";
                if (bookStatus.IsBorrowed.Value == true)
                    currentStatus.Text = "Borrowed";
                if (bookStatus.IsOnHold.Value == true)
                    currentStatus.Text = "Is On Hold";
                _loanStart.Text = bookStatus.DateTime.ToString();
                dateTimePicker2.Text = bookStatus.LoanPeriod.ToString();
                int memberId = (int)bookStatus.MemberId;

                var member = await LibraryManagerWinForm.Helpers.ServiceTools.ServiceGetById<Member>("Member", "GetById", memberId, string.Empty);
                _name.Text = member.Name;
                _phone.Text = member.Phone;
                _lastName.Text = member.LastName;
                _adress.Text = member.Adress;
            }
            Message.Text = LibraryManagerWinForm.Helpers.ServiceTools.responseMessage.ToString();
        
        
        }

        private async void _cmbCategory_Click(object sender, EventArgs e)
        {
            bool result = await LibraryManagerWinForm.Helpers.ServiceTools.IsServiceAvailable<Category>("Category", "GetAll", "param");
            if (result)
            {
                var list = await LibraryManagerWinForm.Helpers.ServiceTools.ServiceGetByName<Category>("Category", "GetAll", "param");
                _cmbCategory.Items.Clear();
                foreach (var item in list)
                {
                    _cmbCategory.Items.Add(item.Name.ToString());

                }
            }
            else { Message.Text = "Could not connect to server. please try again"; }
        }

      

       
        private void button3_Click(object sender, EventArgs e)
        {
            /*BookStatus status = new BookStatus();


            /*if (bookstatus == "Borrowed")
                status.IsBorrowed = true;
            if (bookstatus == "Available")
                status.IsAvailable = true;
            if (bookstatus == "On hold")
                status.IsOnHold = true;
            status.Id = 1;
            status.IsAvailable = true;
            status.IsBorrowed = false;
                
            HttpClientHandler clientHandler = new HttpClientHandler();
            clientHandler.ServerCertificateCustomValidationCallback = (sender, cert, chain, sslPolicyError) => { return true; };
            HttpClient client = new HttpClient(clientHandler);
            client.BaseAddress = new Uri("https://localhost:5001");

            var serializebook = JsonConvert.SerializeObject(status);
             var content = new StringContent(serializebook,Encoding.UTF8,"application/json");

             var result = await client.PutAsJsonAsync("/api/BookStatus/UpdateStatus",content);


            Message.Text = result.StatusCode.ToString();*/
           

        }

        private async void findMemberBtn_Click(object sender, EventArgs e)
        {
            if(_memberName.Text != string.Empty)
            {
                bool result = await LibraryManagerWinForm.Helpers.ServiceTools.IsServiceAvailable<Category>("Category", "GetAll", "param");
                if (result)
                {
                    dataGridView1.Rows.Clear();
                    LibraryManagerWinForm.Helpers.FormTools.ClearAllText(groupBox2);
                    LibraryManagerWinForm.Helpers.FormTools.ClearAllText(_statusPanel);
                    var list = await LibraryManagerWinForm.Helpers.ServiceTools.ServiceGetById<Member>("Member", "GetByName", 1, _memberName.Text.Trim());
                    _name.Text = list.Name;
                    _lastName.Text = list.LastName;
                    _phone.Text = list.Phone;
                    _adress.Text = list.Adress;
                    int id = list.Id;

                    var bookStatus = await LibraryManagerWinForm.Helpers.ServiceTools.ServiceGetById<BookStatus>("BookStatus", "GetByMemberId", id, string.Empty);
                    if (bookStatus.Id > 0)
                    {

                        if (bookStatus.IsAvailable.Value == true)
                            currentStatus.Text = "Available";
                        if (bookStatus.IsBorrowed.Value == true)
                            currentStatus.Text = "Borrowed";
                        if (bookStatus.IsOnHold.Value == true)
                            currentStatus.Text = "Is On Hold";
                        _loanStart.Text = bookStatus.DateTime.ToString();
                        dateTimePicker2.Text = bookStatus.LoanPeriod.ToString();
                        int bookId = (int)bookStatus.BookId;

                        var book = await LibraryManagerWinForm.Helpers.ServiceTools.ServiceGetById<Book>("Library", "GetById", bookId, string.Empty);

                        dataGridView1.Rows.Clear();
                        if (book.Id > 0)
                            dataGridView1.Rows.Add(book.Name, book.Description, book.Author, book.PublisherId, book.CategoryId, book.Id);
                    }
                    Message.Text = LibraryManagerWinForm.Helpers.ServiceTools.responseMessage.ToString();
                }
            
                
            }

        }

     
    }
}
