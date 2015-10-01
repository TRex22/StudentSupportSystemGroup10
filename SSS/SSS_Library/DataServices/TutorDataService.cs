using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SSS_Library.DataServices
{
    public class TutorDataService
    {
        public IS2G10_DBSSSDataSet.TUTORDataTable TutorTable;
        private readonly IS2G10_DBSSSDataSet _sssDb;
        private readonly IS2G10_DBSSSDataSetTableAdapters.TUTORTableAdapter _tutorTableAdapter;

        public TutorDataService()
        {
            TutorTable = new IS2G10_DBSSSDataSet.TUTORDataTable();
            _sssDb = new IS2G10_DBSSSDataSet();
            _tutorTableAdapter = new IS2G10_DBSSSDataSetTableAdapters.TUTORTableAdapter();
            GetTutorData();
        }

        public IS2G10_DBSSSDataSet.TUTORDataTable GetTutorData()
        {
            _tutorTableAdapter.Fill(TutorTable);
            return TutorTable;
        }

        public string AddTutorRow(int tutor_id, string tutor_firstname, string tutor_lastname, string tutor_id_passport,
            DateTime tutor_dateofbirth, string tutor_emailaddress, string tutor_cellnumber, bool tutor_trainingstatus)
        {
            try
            {
                _tutorTableAdapter.Insert(tutor_id, tutor_firstname, tutor_lastname, tutor_id_passport,
                    tutor_dateofbirth, tutor_emailaddress, tutor_cellnumber, tutor_trainingstatus);
                    //cannot update without an id. M$ Docs are wrong. 
                _sssDb.AcceptChanges();
                return "added to genre.";
            }
            catch (Exception e)
            {
                return e + "";
            }
        }

        /*public string UpdateTutorRow(int genreId, string genreName)
        {
            try
            {
                var genreRow = TutorTable.FindByGenre_ID(genreId);
                genreRow.Genre_Name = genreName;
                _sssDb.GENRE.Rows.Add(genreRow);
                _tutorTableAdapter.Update(_sssDb.GENRE);
                _sssDb.AcceptChanges();
                return "Update successful.";
            }
            catch (Exception e)
            {
                return e + "";
            }
        }

        public string DeleteGenreRow(int genreId)
        {
            try
            {
                var genreRow = TutorTable.FindByGenre_ID(genreId);
                _sssDb.GENRE.Rows.Remove(genreRow);
                _tutorTableAdapter.Update(_sssDb.GENRE);
                _sssDb.AcceptChanges();
                return "deleted from genre.";
            }
            catch (Exception e)
            {
                return e + "";
            }
        }*/
    }
}
