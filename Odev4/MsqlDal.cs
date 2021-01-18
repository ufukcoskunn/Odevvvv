using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.Sql;
using System.Data.SqlClient;
using System.Windows.Forms;
using Odev4;

namespace Odev4
{
    class MsqlDal
    {
        string Connection;
        SqlDataReader rdr;
        SqlCommand cmd;
        SqlConnection con;
        List<Student> students;

        public MsqlDal(string connection)
        {
            Connection = connection;
        }

        public List<Student> GetAll() 
        {
             
            try
            {
                con = new SqlConnection(Connection);
                cmd = new SqlCommand();
                con.Open();
                cmd.Connection = con;
                cmd.CommandText = "Select * from Ogrenciler";
                rdr = cmd.ExecuteReader();
                students = new List<Student>();
                while (rdr.Read())
                {
                    Student student = new Student
                    {
                        Ad = rdr["Ad"].ToString(),
                        Soyad = rdr["Soyad"].ToString(),
                        Tc = rdr["Tc"].ToString(),
                        Email = rdr["email"].ToString(),
                        Gsm = rdr["gsm"].ToString(),
                        Cinsiyet = Convert.ToByte(rdr["Cinsiyet"]),
                        DogumTarihi = Convert.ToDateTime(rdr["DogumTarihi"]),
                        SubeId = Convert.ToInt32(rdr["SubeId"]),



                    };
                    students.Add(student);
                }
                
                
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
            finally
            {
                rdr.Close();
                con.Close();
                
            }
            return students;
        }
        public int GetSubeId(int sinif,char sube)
        {
            int SubeId = 0;
            int SinifId = 0;
            try
            {
                con = new SqlConnection(Connection);
                cmd = new SqlCommand();
                con.Open();
                cmd.Connection = con;
                cmd.CommandText = "Select * from Sinif where Sinif ='"+sinif+"' ";
                rdr = cmd.ExecuteReader();
                while (rdr.Read())
                {
                    SinifId = Convert.ToInt32(rdr["Id"]);
                }
                cmd.CommandText = "select * from Sube where SinifId ='" + SinifId + "' and Sube = '"+sube+"' ";
                rdr.Close();
                rdr = cmd.ExecuteReader();
                
                while (rdr.Read())
                {
                    SubeId = Convert.ToInt32(rdr["Id"]);
                }
            }
            catch (Exception ex)

            {

                MessageBox.Show(ex.Message);
            }
            finally
            {
                rdr.Close();
                con.Close();
            }
            return SubeId;
        }
        public void Add(Student student)
        {
            try
            {
                con = new SqlConnection(Connection);
                cmd = new SqlCommand();
                con.Open();
                cmd.Connection = con;
                cmd.CommandText = "INSERT INTO Ogrenciler(Ad,Soyad,Tc,email,gsm,Cinsiyet,DogumTarihi,SubeId) VALUES('"+student.Ad+ "','"+student.Soyad+ "','"+student.Tc+ "','"+student.Email+ "','"+student.Gsm+ "','"+student.Cinsiyet+ "',@Date,'"+student.SubeId+"')";
                cmd.Parameters.Add("@Date",System.Data.SqlDbType.SmallDateTime).Value=student.DogumTarihi;
                cmd.ExecuteNonQuery();
                MessageBox.Show("Başarıyla Eklendi");
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
            finally
            {
                con.Close();
            }
        }
  
    }




}




class MsqlDal1
{
    string Connection;
    SqlDataReader rdr;
    SqlCommand cmd;
    SqlConnection con;
    List<Teacher> teachers;
    private object teacher;

    public MsqlDal1(string connection)
    {
        Connection = connection;
    }

    public List<Teacher> GetAll()
    {

        try
        {
            con = new SqlConnection(Connection);
            cmd = new SqlCommand();
            con.Open();
            cmd.Connection = con;
            cmd.CommandText = "Select * from Ogretmenler";
            rdr = cmd.ExecuteReader();
            teachers = new List<Teacher>();
            while (rdr.Read())
            {
                Teacher teachers = new Teacher
                {
                    Ad = rdr["Ad"].ToString(),
                    Soyad = rdr["Soyad"].ToString(),
                    Tc = rdr["Tc"].ToString(),
                    Email = rdr["email"].ToString(),
                    Gsm = rdr["gsm"].ToString(),
                    Cinsiyet = Convert.ToByte(rdr["Cinsiyet"]),
                    DogumTarihi = Convert.ToDateTime(rdr["DogumTarihi"]),
                    SubeId = Convert.ToInt32(rdr["SubeId"]),



                };
                teachers.Add(teacher);
            }


        }
        catch (Exception ex)
        {

            MessageBox.Show(ex.Message);
        }
        finally
        {
            rdr.Close();
            con.Close();

        }
        return teachers;
    }
    public int GetSubeId(int sinif, char sube)
    {
        int SubeId = 0;
        int SinifId = 0;
        try
        {
            con = new SqlConnection(Connection);
            cmd = new SqlCommand();
            con.Open();
            cmd.Connection = con;
            cmd.CommandText = "Select * from Sinif where Sinif ='" + sinif + "' ";
            rdr = cmd.ExecuteReader();
            while (rdr.Read())
            {
                SinifId = Convert.ToInt32(rdr["Id"]);
            }
            cmd.CommandText = "select * from Sube where SinifId ='" + SinifId + "' and Sube = '" + sube + "' ";
            rdr.Close();
            rdr = cmd.ExecuteReader();

            while (rdr.Read())
            {
                SubeId = Convert.ToInt32(rdr["Id"]);
            }
        }
        catch (Exception ex)

        {

            MessageBox.Show(ex.Message);
        }
        finally
        {
            rdr.Close();
            con.Close();
        }
        return SubeId;
    }
    public void Add(Teacher teacher)
    {
        try
        {
            con = new SqlConnection(Connection);
            cmd = new SqlCommand();
            con.Open();
            cmd.Connection = con;
            string v = "INSERT INTO Ogrenciler(Ad,Soyad,Tc,email,gsm,Cinsiyet,DogumTarihi,SubeId) VALUES('" + teacher.Ad + "','" + teacher.Soyad + "','" + teacher.Tc + "','" + teacher.Email + "','" + teacher.Gsm + "','" + teacher.Cinsiyet + "',@Date,'" + teacher.SubeId + "')";
            cmd.CommandText = v;
            cmd.Parameters.Add("@Date", System.Data.SqlDbType.SmallDateTime).Value = teacher.DogumTarihi;
            cmd.ExecuteNonQuery();
            MessageBox.Show("Başarıyla Eklendi");
        }
        catch (Exception ex)
        {

            MessageBox.Show(ex.Message);
        }
        finally
        {
            con.Close();
        }
    }

    internal void Add(object teacher)
    {
        throw new NotImplementedException();
    }
}





