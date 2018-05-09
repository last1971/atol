using FirebirdSql.Data.FirebirdClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;

using System.Windows.Forms;

namespace CSharpEx
{
    public class connection
    {
        public static string connectionString()
        {
            return "User=SYSDBA;" +
                      "Password=641767;" + File.ReadAllText("dbconnect");
                   /*  @"Database=c:\backup\BASE.FDB;" +
                      "DataSource=localhost;" +
                      "Port=3050;" +
                      //"Dialect=3;" 
                      "Charset=NONE;" +
                      "Role=;" +
                      "Packet Size=8192;" +
                      "ServerType=0";*/
        }
    }
    public class user
    {
        public string shortname { get; set; }
        public string fullname { get; set; }
        public string inn { get; set; }
        public user() { }
        public user(string pass)
        {
            if (pass.Length>3)
            try
            {
                FbConnection fb = new FbConnection(connection.connectionString());
                fb.Open();
                FbTransaction fbt = fb.BeginTransaction(); //стартуем транзакцию; стартовать транзакцию можно только для открытой базы (т.е. мутод Open() уже был вызван ранее, иначе ошибка)
                FbCommand SelectSQL = new FbCommand();
                SelectSQL.CommandText = "select c.fullname, (c.fam || ' ' || c.im || ' ' || c.otch ) as fn, c.inn from passwords a, passwords_to_staff b, staff c where c.id = b.staff_id and a.username = b.username and a.userpass = @pass"; //задаем запрос на выборку
                SelectSQL.Parameters.Add("@pass", pass);

                SelectSQL.Connection = fb;
                SelectSQL.Transaction = fbt;
                FbDataReader reader = SelectSQL.ExecuteReader(); //для запросов, которые возвращают результат в виде набора данных надо использоваться метод ExecuteReader()
                try
                {
                    if (reader.Read()) //пока не прочли все данные выполняем...
                    {
                        this.shortname = reader.GetString(0);
                        this.fullname = reader.GetString(1);
                        this.inn = reader.GetString(2);
                    }

                }
                finally
                {
                    //всегда необходимо вызывать метод Close(), когда чтение данных завершено
                    reader.Close();
                    fb.Close(); //закрываем соединение, т.к. оно нам больше не нужно
                }
                SelectSQL.Dispose();
            }
            catch
            {

            }
        }

    }
    public class strokavozvrata
    {
        public string name { get; set; }
        public int qnt { get; set; }
        public double price { get; set; }
        public string prodavec { get; set; }
        public Boolean selected { get; set; }
        public strokavozvrata() { }
        public strokavozvrata(string name, int qnt, double price,string prodavec)
        {
            this.name = name;
            this.qnt = qnt;
            this.price = price;
            this.prodavec = prodavec;
            selected = false;
        }
    }


    public class stroka
    {
        public string name { get; set; }
        public int qnt { get; set; }
        public double price { get; set; }
        public double roznprice { get; set; }

        public stroka() { }
        public stroka(string name, int qnt, double price,double roznprice)
        {
            this.name = name;
            this.qnt = qnt;
            this.price = price;
            this.roznprice =  roznprice;
            
        }
    }

    public class backs:BindingList<strokavozvrata>
    {
        public backs()
        {
             get();
        }
        public void get()
        {
            this.Clear();
            try
            {
                FbConnection fb = new FbConnection(connection.connectionString());
                fb.Open();
                FbTransaction fbt = fb.BeginTransaction(); //стартуем транзакцию; стартовать транзакцию можно только для открытой базы (т.е. мутод Open() уже был вызван ранее, иначе ошибка)
                FbCommand SelectSQL = new FbCommand();
                SelectSQL.CommandText = "select d.name,a.price,a.quanshop, a.usernameback from backshop a, goods b, name d where a.goodscode=b.goodscode and b.namecode=d.namecode  and a.datatimeback>@datetime"; //задаем запрос на выборку
                SelectSQL.Parameters.Add("@datetime", DateTime.Now.Date);

                SelectSQL.Connection = fb;
                SelectSQL.Transaction = fbt; //необходимо проинициализить транзакцию для объекта SelectSQL
                FbDataReader reader = SelectSQL.ExecuteReader(); //для запросов, которые возвращают результат в виде набора данных надо использоваться метод ExecuteReader()
                try
                {
                    while (reader.Read()) //пока не прочли все данные выполняем...
                    {
                        var nch = new strokavozvrata(reader.GetString(0), reader.GetInt16(2), reader.GetDouble(1), reader.GetString(3));
                        this.Add(nch);
                    }

                }

                finally
                {
                    //всегда необходимо вызывать метод Close(), когда чтение данных завершено
                    reader.Close();
                    fb.Close(); //закрываем соединение, т.к. оно нам больше не нужно
                }
                SelectSQL.Dispose();
                
            }
            catch (Exception e)
            {
                
            }
        }
    }
    
    public class check  
    {
        public DateTime date { get; set; }
        public string prodavec { get; set; }
        public string prodavec_fio { get; set; }
        public string pokupat { get; set; }
        public string inn { get;set; }
        public double sum { get; set; }
        public int prodavecCode { get; set; }
        public check(DateTime date,string prodavec, string pokupat,double sum,int prodavecCode,string inn,string prodavec_fio )
        {
            this.date = date;
            this.prodavec = prodavec;
            this.sum = sum;
            this.pokupat = pokupat;
            this.prodavecCode = prodavecCode;
            this.inn = inn;
            this.prodavec_fio = prodavec_fio;
        }
    }
    public class checks: BindingList<check>
    {
        public checks()
        {
            this.get();
        }
        public Boolean delete(DateTime date1,string prodavec)
        {
            try
            {
                check deletingCheck = this.Where(x => x.date == date1 && x.prodavec == prodavec).FirstOrDefault();
                if (deletingCheck == null) return false;
                FbConnection fb = new FbConnection(connection.connectionString());
                fb.Open();
                FbTransaction fbt = fb.BeginTransaction(); //стартуем транзакцию; стартовать транзакцию можно только для открытой базы (т.е. мутод Open() уже был вызван ранее, иначе ошибка)
                FbCommand SelectSQL = new FbCommand();
                SelectSQL.CommandText = "update shopheads set closed=1 where saledate=@datetime and saler=@prodavec";
                SelectSQL.Parameters.Add("@datetime", date1);
                SelectSQL.Parameters.Add("@prodavec", deletingCheck.prodavecCode);
                SelectSQL.Connection = fb;
                SelectSQL.Transaction = fbt;
                SelectSQL.ExecuteNonQuery();
                fbt.Commit();
                fb.Close();
                SelectSQL.Dispose(); //в документации написано, что ОЧЕНЬ рекомендуется убивать объекты этого типа, если они больше не нужны
                fbt.Dispose();
                fb.Dispose();
                this.Remove(deletingCheck);
                return true;
            }
            catch (Exception e)
            {
                return false;
            }
        }
        public void get()
        {
            try
            { 
            FbConnection fb = new FbConnection(connection.connectionString());
            fb.Open();
            FbTransaction fbt = fb.BeginTransaction(); //стартуем транзакцию; стартовать транзакцию можно только для открытой базы (т.е. мутод Open() уже был вызван ранее, иначе ошибка)
            FbCommand SelectSQL = new FbCommand();
            SelectSQL.CommandText = "select a.saledate,c.fullname,d.shortname,coalesce((select sum(b.price * b.quanshop) as summ from shoplog b where b.datatime = a.saledate and b.staff_id = a.saler group by datatime, staff_id),0) as summ, a.saler,a.closed,c.inn,(c.fam || ' ' || c.im || ' ' || c.otch ) as fn FROM shopheads a join staff c on c.id = a.saler left join pokupat d  on a.pokupatid = d.pokupatcode where a.saledate > @datetime"; //задаем запрос на выборку
            SelectSQL.Parameters.Add("@datetime", DateTime.Now.Date);
            SelectSQL.Connection = fb;
            SelectSQL.Transaction = fbt; //необходимо проинициализить транзакцию для объекта SelectSQL
            FbDataReader reader = SelectSQL.ExecuteReader(); //для запросов, которые возвращают результат в виде набора данных надо использоваться метод ExecuteReader()
            
                try
                {
                    while (reader.Read()) //пока не прочли все данные выполняем...
                    {
                        var d1 = reader.GetDateTime(0);
                        var d2 = reader.GetString(1);
                        var d3 = reader.GetString(2);
                        var d4 = reader.GetDouble(3);                       
                        var d5 = reader.GetInt16(4);
                        var d6 = reader.GetString(6);
                        var d7 = reader.GetString(7);
                        var nch = new check(d1,d2,d3,d4,d5,d6,d7);
                        var j= reader.GetInt16(5);
                        if (reader.GetInt16(5) == 0)
                        {
                            if (this.Where(x => x.date == nch.date && x.prodavec == nch.prodavec).Count() == 0)
                                this.Add(nch);
                        }
                        else
                        {
                            var dch = this.Where(x => x.date == nch.date && x.prodavec == nch.prodavec).FirstOrDefault();
                            if (dch != null)
                                this.Remove(dch);
                        }
                    }
                }
                finally
                {
                //всегда необходимо вызывать метод Close(), когда чтение данных завершено
                    reader.Close();
                    fbt.Commit();
                    fb.Close(); //закрываем соединение, т.к. оно нам больше не нужно
                }
                SelectSQL.Dispose(); //в документации написано, что ОЧЕНЬ рекомендуется убивать объекты этого типа, если они больше не нужны
                fbt.Dispose();
                fb.Dispose();
                
            }
            catch (Exception e){ }
        }
    }
}
