using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace FinalProject
{

    public class Student
    {
        //string lastName = "";
        //string firstName = "";
        //string englishName = "";
        //DateTime dob;
        //string gender = "";
        //string email = "";
        //DateTime arrivalDate;
        //TimeSpan arrivalTime;
        //string airline = "";
        //string flightNum;
        //bool transport = false;
        //bool housing = false;
        //string housingAddress = "";
        //string comments = "";

        public Student()
        {
        }

        public Student(string lastName, string firstName, string englishName, DateTime dob, string gender, string email, DateTime arrivalDate, TimeSpan arrivalTime, string airline, string flightNum, bool transport, bool housing, string housingAddress, string comments)
        {
            LastName = lastName;
            FirstName = firstName;
            EnglishName = englishName;
            Dob = dob.Date;
            Gender = gender;
            Email = email;
            ArrivalDate = arrivalDate.Date;
            ArrivalTime = arrivalTime.Subtract(arrivalTime);
            Airline = airline;
            FlightNum = flightNum;
            Transport = transport;
            Housing = housing;
            HousingAddress = housingAddress;
            Comments = comments;
        }

        public string LastName { get; set; }
        public string FirstName { get; set; }
        public string EnglishName { get; set; }
        public DateTime Dob { get; set; }
        public string Gender { get; set; }
        public string Email { get; set; }
        public DateTime ArrivalDate { get; set; }
        public TimeSpan ArrivalTime { get; set; }
        public string Airline { get; set; }
        public string FlightNum { get; set; }
        public bool Transport { get; set; }
        public bool Housing { get; set; }
        public string HousingAddress { get; set; }
        public string Comments { get; set; }

        public void SaveData()
        {
            try
            {
                SqlConnection cn = new SqlConnection();
                SqlCommand cmd = new SqlCommand();
                cn.ConnectionString = (@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""C:\Users\chadk\Dropbox\7 - Spring 2016\CIS-465\Unit 2\CIS465FinalProject\FinalProject\FinalProject\StudentDatabase.mdf"";Integrated Security=True");
                cn.Open();
                cmd.Connection = cn;
                cmd.CommandText = "INSERT INTO Student(LastName, FirstName, EnglishName, Email, DateOfBirth, Gender, Airline, ArrivalDate, ArrivalTime, FlightNumber, AirportTransportation, NeedTempHousing, Comments, TempHousingAddress) VALUES (@LastName, @FirstName, @EnglishName, @Dob, @Gender, @Email, @Airline, @ArrivalDate, @ArrivalTime, @FlightNum, @Transport, @Housing, @Comments, @HousingAddress);";
                cmd.Parameters.Add("@LastName", SqlDbType.Text).Value = LastName;
                cmd.Parameters.Add("@FirstName", SqlDbType.Text).Value = FirstName;
                cmd.Parameters.Add("@EnglishName", SqlDbType.Text).Value = EnglishName;
                cmd.Parameters.Add("@Email", SqlDbType.Text).Value = Email;
                cmd.Parameters.Add("@Dob", SqlDbType.Date).Value = Dob.Date;
                cmd.Parameters.Add("@Gender", SqlDbType.Text).Value = Gender;
                cmd.Parameters.Add("@Airline", SqlDbType.Text).Value = Airline;
                cmd.Parameters.Add("@ArrivalDate", SqlDbType.Date).Value = ArrivalDate;
                cmd.Parameters.Add("@ArrivalTime", SqlDbType.Time).Value = ArrivalTime;
                cmd.Parameters.Add("@FlightNum", SqlDbType.Text).Value = FlightNum;
                cmd.Parameters.Add("@Transport", SqlDbType.Bit).Value = Transport;
                cmd.Parameters.Add("@Housing", SqlDbType.Bit).Value = Housing;
                cmd.Parameters.Add("@Comments", SqlDbType.Text).Value = Comments;
                cmd.Parameters.Add("@HousingAddress", SqlDbType.Text).Value = HousingAddress;
                Console.WriteLine(cmd.CommandText);
                cmd.ExecuteNonQuery();
                cn.Close();
            }

            catch (SqlException x)
            {
                MessageBox.Show("Error #" + x.Number + "\n"
                    + x.Errors + "\n"
                    + x.Message + "\n"
                    + x.Source + " \n" 
                    + x.GetType().ToString());
                throw;
            }

            catch (Exception x)
            {
                Console.WriteLine(x.Message);
                throw;
            }
            

            //SqlConnection sc = new SqlConnection();
            //SqlCommand com = new SqlCommand();
            //sc.ConnectionString = (@"Data Source=localhost; Initial Catalog=Login Screen; Integrated Security = true");
            //sc.Open();
            //com.Connection = sc;
            ////revise SQL query
            //com.CommandText = ("INSERT INTO");
            //com.ExecuteNonQuery();
            //sc.Close();

        }
    }
}