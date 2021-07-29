using Newtonsoft.Json;
using RestSharp;
using System;
using System.Data;
using System.Data.SqlClient;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            GetRegisteredAddress(@"Server=217.63.100.219\FASTBASE4;Database=TEMP_DB;User Id=sa;Password=!Qaz2wsx");
        }
        private static void GetRegisteredAddress(string connectionString)
        {
            try
            {
                DataTable dtResult = new DataTable();
                int page = 1, pageSize = 100;
                do
                {
                    string strQuery = "SELECT id," +
                        "url," +
                        "company_name," +
                        "Company_Number," +
                        "Status," +
                        "Jurisdiction," +
                        "Registered_Address," +
                        "Registry_Page," +
                        "registry_page_url," +
                        "address_title_1," +
                        "address_location_1," +
                        "registry_address_priority," +
                        "source," +
                        "source_url," +
                        "Company_Type," +
                        "Alternative_Names," +
                        "address_title_2," +
                        "address_title_3," +
                        "address_title_4," +
                        "address_location_2," +
                        "address_location_3," +
                        "address_location_4," +
                        "Previous_Names," +
                        "website," +
                        "Controlling_Company," +
                        "address_title_5," +
                        "address_title_6," +
                        "address_title_7," +
                        "address_title_8," +
                        "address_location_5," +
                        "address_location_6," +
                        "address_location_7," +
                        "address_location_8," +
                        "address_title_9," +
                        "address_title_10," +
                        "address_location_9," +
                        "address_location_10," +
                        "Incorporation_Date," +
                        "Agent_Name," +
                        "Agent_Address," +
                        "Directors_Officers," +
                        "Inactive_Directors_Officers," +
                        "Branch," +
                        "Dissolution_Date," +
                        "Expiry_Date," +
                        "Other_Identifiers," +
                        "Industry_Codes," +
                        "Annual_Return_Last_Made_Up_Date," +
                        "industry_codes_priority_1," +
                        "industry_codes_priority_2," +
                        "industry_codes_priority_3," +
                        "Latest_Accounts_Date," +
                        "industry_codes_priority_4," +
                        "industry_codes_priority_5," +
                        "industry_codes_priority_6," +
                        "corporate_grouping_url," +
                        "IDENTIFIER_SYSTEM_1," +
                        "IDENTIFIER_1," +
                        "CATEGORIES_1," +
                        "IDENTIFIER_SYSTEM_2," +
                        "IDENTIFIER_2," +
                        "CATEGORIES_2," +
                        "Ultimate_Beneficial_Owners," +
                        "industry_codes_priority_7," +
                        "industry_codes_priority_8," +
                        "industry_codes_priority_9," +
                        "industry_codes_priority_10," +
                        "industry_codes_priority_11," +
                        "industry_codes_priority_12," +
                        "Business_Number," +
                        "Number_Of_Employees," +
                        "industry_codes_priority_13," +
                        "industry_codes_priority_14," +
                        "industry_codes_priority_15," +
                        "industry_codes_priority_16," +
                        "industry_codes_priority_17," +
                        "industry_codes_priority_18," +
                        "industry_codes_priority_19," +
                        "Governing_Legislation," +
                        "Native_Company_Number," +
                        "Business_Classification_Text," +
                        "industry_codes_priority_20," +
                        "industry_codes_priority_21," +
                        "industry_codes_priority_22," +
                        "industry_codes_priority_23," +
                        "industry_codes_priority_24," +
                        "industry_codes_priority_25," +
                        "industry_codes_priority_26," +
                        "industry_codes_priority_27," +
                        "industry_codes_priority_28," +
                        "industry_codes_priority_29," +
                        "industry_codes_priority_30," +
                        "industry_codes_priority_31," +
                        "industry_codes_priority_32," +
                        "industry_codes_priority_33," +
                        "industry_codes_priority_34," +
                        "industry_codes_priority_35," +
                        "industry_codes_priority_36," +
                        "industry_codes_priority_37," +
                        "industry_codes_priority_38," +
                        "industry_codes_priority_39," +
                        "industry_codes_priority_40," +
                        "industry_codes_priority_41," +
                        "industry_codes_priority_42," +
                        "industry_codes_priority_43," +
                        "industry_codes_priority_44," +
                        "industry_codes_priority_45," +
                        "industry_codes_priority_46," +
                        "industry_codes_priority_47," +
                        "industry_codes_priority_48," +
                        "industry_codes_priority_49," +
                        "industry_codes_priority_50," +
                        "industry_codes_priority_51," +
                        "industry_codes_priority_52," +
                        "industry_codes_priority_53," +
                        "industry_codes_priority_54," +
                        "industry_codes_priority_55," +
                        "industry_codes_priority_56," +
                        "industry_codes_priority_57," +
                        "industry_codes_priority_58," +
                        "industry_codes_priority_59," +
                        "industry_codes_priority_60," +
                        "industry_codes_priority_61," +
                        "industry_codes_priority_62," +
                        "industry_codes_priority_63," +
                        "industry_codes_priority_64," +
                        "industry_codes_priority_65," +
                        "industry_codes_priority_66," +
                        "industry_codes_priority_67," +
                        "industry_codes_priority_68," +
                        "industry_codes_priority_69," +
                        "industry_codes_priority_70," +
                        "industry_codes_priority_71," +
                        "industry_codes_priority_72," +
                        "industry_codes_priority_73," +
                        "industry_codes_priority_74," +
                        "industry_codes_priority_75," +
                        "industry_codes_priority_76," +
                        "industry_codes_priority_77," +
                        "industry_codes_priority_78," +
                        "industry_codes_priority_79," +
                        "industry_codes_priority_80," +
                        "industry_codes_priority_81," +
                        "industry_codes_priority_82," +
                        "industry_codes_priority_83," +
                        "industry_codes_priority_84," +
                        "industry_codes_priority_85," +
                        "industry_codes_priority_86," +
                        "industry_codes_priority_87," +
                        "industry_codes_priority_88," +
                        "industry_codes_priority_89," +
                        "industry_codes_priority_90," +
                        "industry_codes_priority_91," +
                        "industry_codes_priority_92," +
                        "industry_codes_priority_93," +
                        "IDENTIFIER_SYSTEM_3," +
                        "IDENTIFIER_SYSTEM_4," +
                        "IDENTIFIER_3," +
                        "IDENTIFIER_4," +
                        "CATEGORIES_3," +
                        "CATEGORIES_4," +
                        "Previous_Company_Numbers," +
                        "Merged_Into" +
                        " FROM [dbo].[219_06_opencorporates_com_1_main_t1] ORDER BY [Registered_Address]  OFFSET " + page + " *(" + page + " - 1) ROWS   FETCH NEXT " + pageSize + " ROWS ONLY OPTION(RECOMPILE); ";
                    //Console.WriteLine("Query - {0}", strQuery);
                    SqlCommand cmd = new SqlCommand(strQuery);
                    dtResult = GetData(cmd, connectionString);
                    foreach (DataRow row in dtResult.Rows)
                    {
                        string address = row[6].ToString();
                        if (address != "Sorry, you need to be logged in to see this address" && address != "")
                        {
                            var client = new RestClient("https://maps.googleapis.com/");
                            var request = new RestRequest(string.Format("maps/api/geocode/json?address={0}&key=AIzaSyBiuKahbGG6lruf5S6Eirxmyr_6VpfpqSk", address), Method.GET);
                            IRestResponse response = client.Execute(request);
                            if (response.StatusCode == System.Net.HttpStatusCode.OK)
                            {
                                GoogleFormattedAddress googleFormattedAddress = JsonConvert.DeserializeObject<GoogleFormattedAddress>(response.Content);
                                string strQuery1;
                                SqlCommand cmd1;
                                //strQuery1 = "update into [dbo].[219_06_ms_company_basics_Global1] ([state_province], [postal_code],[city],[country_code]) values('" + GetState(googleFormattedAddress) + "', '" + GetPostalCode(googleFormattedAddress) + "' ,'" + GetCity(googleFormattedAddress) + "','" + GetCountryCode(googleFormattedAddress) + "' Where [id]=" + row[0].ToString() + ")";
                                Console.WriteLine("Insert Query begin");
                                strQuery1 = "insert into [dbo].[219_06_ms_company_basics_Global1](company_id," +
                                                "company_name_1," +
                                                "corporation_type," +
                                                "postal_code," +
                                                "state_province," +
                                                "city," +
                                                "country_code," +
                                                "datasource," +
                                                "status_level," +
                                                "intTurnover," +
                                                "turnoverRange," +
                                                "id," +
                                                "url," +
                                                "company_name," +
                                                "Company_Number," +
                                                "Status," +
                                                "Jurisdiction," +
                                                "Registered_Address," +
                                                "Registry_Page," +
                                                "registry_page_url," +
                                                "address_title_1," +
                                                "address_location_1," +
                                                "registry_address_priority," +
                                                "source," +
                                                "source_url," +
                                                "Company_Type," +
                                                "Alternative_Names," +
                                                "address_title_2," +
                                                "address_title_3," +
                                                "address_title_4," +
                                                "address_location_2," +
                                                "address_location_3," +
                                                "address_location_4," +
                                                "Previous_Names," +
                                                "website," +
                                                "Controlling_Company," +
                                                "address_title_5," +
                                                "address_title_6," +
                                                "address_title_7," +
                                                "address_title_8," +
                                                "address_location_5," +
                                                "address_location_6," +
                                                "address_location_7," +
                                                "address_location_8," +
                                                "address_title_9," +
                                                "address_title_10," +
                                                "address_location_9," +
                                                "address_location_10," +
                                                "Incorporation_Date," +
                                                "Agent_Name," +
                                                "Agent_Address," +
                                                "Directors_Officers," +
                                                "Inactive_Directors_Officers," +
                                                "Branch," +
                                                "Dissolution_Date," +
                                                "Expiry_Date," +
                                                "Other_Identifiers," +
                                                "Industry_Codes," +
                                                "Annual_Return_Last_Made_Up_Date," +
                                                "industry_codes_priority_1," +
                                                "industry_codes_priority_2," +
                                                "industry_codes_priority_3," +
                                                "Latest_Accounts_Date," +
                                                "industry_codes_priority_4," +
                                                "industry_codes_priority_5," +
                                                "industry_codes_priority_6," +
                                                "corporate_grouping_url," +
                                                "IDENTIFIER_SYSTEM_1," +
                                                "IDENTIFIER_1," +
                                                "CATEGORIES_1," +
                                                "IDENTIFIER_SYSTEM_2," +
                                                "IDENTIFIER_2," +
                                                "CATEGORIES_2," +
                                                "Ultimate_Beneficial_Owners," +
                                                "industry_codes_priority_7," +
                                                "industry_codes_priority_8," +
                                                "industry_codes_priority_9," +
                                                "industry_codes_priority_10," +
                                                "industry_codes_priority_11," +
                                                "industry_codes_priority_12," +
                                                "Business_Number," +
                                                "Number_Of_Employees," +
                                                "industry_codes_priority_13," +
                                                "industry_codes_priority_14," +
                                                "industry_codes_priority_15," +
                                                "industry_codes_priority_16," +
                                                "industry_codes_priority_17," +
                                                "industry_codes_priority_18," +
                                                "industry_codes_priority_19," +
                                                "Governing_Legislation," +
                                                "Native_Company_Number," +
                                                "Business_Classification_Text," +
                                                "industry_codes_priority_20," +
                                                "industry_codes_priority_21," +
                                                "industry_codes_priority_22," +
                                                "industry_codes_priority_23," +
                                                "industry_codes_priority_24," +
                                                "industry_codes_priority_25," +
                                                "industry_codes_priority_26," +
                                                "industry_codes_priority_27," +
                                                "industry_codes_priority_28," +
                                                "industry_codes_priority_29," +
                                                "industry_codes_priority_30," +
                                                "industry_codes_priority_31," +
                                                "industry_codes_priority_32," +
                                                "industry_codes_priority_33," +
                                                "industry_codes_priority_34," +
                                                "industry_codes_priority_35," +
                                                "industry_codes_priority_36," +
                                                "industry_codes_priority_37," +
                                                "industry_codes_priority_38," +
                                                "industry_codes_priority_39," +
                                                "industry_codes_priority_40," +
                                                "industry_codes_priority_41," +
                                                "industry_codes_priority_42," +
                                                "industry_codes_priority_43," +
                                                "industry_codes_priority_44," +
                                                "industry_codes_priority_45," +
                                                "industry_codes_priority_46," +
                                                "industry_codes_priority_47," +
                                                "industry_codes_priority_48," +
                                                "industry_codes_priority_49," +
                                                "industry_codes_priority_50," +
                                                "industry_codes_priority_51," +
                                                "industry_codes_priority_52," +
                                                "industry_codes_priority_53," +
                                                "industry_codes_priority_54," +
                                                "industry_codes_priority_55," +
                                                "industry_codes_priority_56," +
                                                "industry_codes_priority_57," +
                                                "industry_codes_priority_58," +
                                                "industry_codes_priority_59," +
                                                "industry_codes_priority_60," +
                                                "industry_codes_priority_61," +
                                                "industry_codes_priority_62," +
                                                "industry_codes_priority_63," +
                                                "industry_codes_priority_64," +
                                                "industry_codes_priority_65," +
                                                "industry_codes_priority_66," +
                                                "industry_codes_priority_67," +
                                                "industry_codes_priority_68," +
                                                "industry_codes_priority_69," +
                                                "industry_codes_priority_70," +
                                                "industry_codes_priority_71," +
                                                "industry_codes_priority_72," +
                                                "industry_codes_priority_73," +
                                                "industry_codes_priority_74," +
                                                "industry_codes_priority_75," +
                                                "industry_codes_priority_76," +
                                                "industry_codes_priority_77," +
                                                "industry_codes_priority_78," +
                                                "industry_codes_priority_79," +
                                                "industry_codes_priority_80," +
                                                "industry_codes_priority_81," +
                                                "industry_codes_priority_82," +
                                                "industry_codes_priority_83," +
                                                "industry_codes_priority_84," +
                                                "industry_codes_priority_85," +
                                                "industry_codes_priority_86," +
                                                "industry_codes_priority_87," +
                                                "industry_codes_priority_88," +
                                                "industry_codes_priority_89," +
                                                "industry_codes_priority_90," +
                                                "industry_codes_priority_91," +
                                                "industry_codes_priority_92," +
                                                "industry_codes_priority_93," +
                                                "IDENTIFIER_SYSTEM_3," +
                                                "IDENTIFIER_SYSTEM_4," +
                                                "IDENTIFIER_3," +
                                                "IDENTIFIER_4," +
                                                "CATEGORIES_3," +
                                                "CATEGORIES_4," +
                                                "Previous_Company_Numbers," +
                                                "Merged_Into," +
                                                "LastUpdatedOn," +
                                                "LastUpdatedBy" + ")" + " values(0,'','','" + GetPostalCode(googleFormattedAddress) + "', '" + GetState(googleFormattedAddress) + "','" + GetCity(googleFormattedAddress) + "','" + GetCountryCode(googleFormattedAddress) + "','','',0,0," +
                                                "'" + row[0].ToString() + "'," +
                                                "'" + row[1].ToString() + "'," +
                                                "'" + row[2].ToString() + "'," +
                                                "'" + row[3].ToString() + "'," +
                                                "'" + row[4].ToString() + "'," +
                                                "'" + row[5].ToString() + "'," +
                                                "'" + row[6].ToString() + "'," +
                                                "'" + row[7].ToString() + "'," +
                                                "'" + row[8].ToString() + "'," +
                                                "'" + row[9].ToString() + "'," +
                                                "'" + row[10].ToString() + "'," +
                                                "'" + row[11].ToString() + "'," +
                                                "'" + row[12].ToString() + "'," +
                                                "'" + row[13].ToString() + "'," +
                                                "'" + row[14].ToString() + "'," +
                                                "'" + row[15].ToString() + "'," +
                                                "'" + row[16].ToString() + "'," +
                                                "'" + row[17].ToString() + "'," +
                                                "'" + row[18].ToString() + "'," +
                                                "'" + row[19].ToString() + "'," +
                                                "'" + row[20].ToString() + "'," +
                                                "'" + row[21].ToString() + "'," +
                                                "'" + row[22].ToString() + "'," +
                                                "'" + row[23].ToString() + "'," +
                                                "'" + row[24].ToString() + "'," +
                                                "'" + row[25].ToString() + "'," +
                                                "'" + row[26].ToString() + "'," +
                                                "'" + row[27].ToString() + "'," +
                                                "'" + row[28].ToString() + "'," +
                                                "'" + row[29].ToString() + "'," +
                                                "'" + row[30].ToString() + "'," +
                                                "'" + row[31].ToString() + "'," +
                                                "'" + row[32].ToString() + "'," +
                                                "'" + row[33].ToString() + "'," +
                                                "'" + row[34].ToString() + "'," +
                                                "'" + row[35].ToString() + "'," +
                                                "'" + row[36].ToString() + "'," +
                                                "'" + row[37].ToString() + "'," +
                                                "'" + row[38].ToString() + "'," +
                                                "'" + row[39].ToString() + "'," +
                                                "'" + row[40].ToString() + "'," +
                                                "'" + row[41].ToString() + "'," +
                                                "'" + row[42].ToString() + "'," +
                                                "'" + row[43].ToString() + "'," +
                                                "'" + row[44].ToString() + "'," +
                                                "'" + row[45].ToString() + "'," +
                                                "'" + row[46].ToString() + "'," +
                                                "'" + row[47].ToString() + "'," +
                                                "'" + row[48].ToString() + "'," +
                                                "'" + row[49].ToString() + "'," +
                                                "'" + row[50].ToString() + "'," +
                                                "'" + row[51].ToString() + "'," +
                                                "'" + row[52].ToString() + "'," +
                                                "'" + row[53].ToString() + "'," +
                                                "'" + row[54].ToString() + "'," +
                                                "'" + row[55].ToString() + "'," +
                                                "'" + row[56].ToString() + "'," +
                                                "'" + row[57].ToString() + "'," +
                                                "'" + row[58].ToString() + "'," +
                                                "'" + row[59].ToString() + "'," +
                                                "'" + row[60].ToString() + "'," +
                                                "'" + row[61].ToString() + "'," +
                                                "'" + row[62].ToString() + "'," +
                                                "'" + row[63].ToString() + "'," +
                                                "'" + row[64].ToString() + "'," +
                                                "'" + row[65].ToString() + "'," +
                                                "'" + row[66].ToString() + "'," +
                                                "'" + row[67].ToString() + "'," +
                                                "'" + row[68].ToString() + "'," +
                                                "'" + row[69].ToString() + "'," +
                                                "'" + row[70].ToString() + "'," +
                                                "'" + row[71].ToString() + "'," +
                                                "'" + row[72].ToString() + "'," +
                                                "'" + row[73].ToString() + "'," +
                                                "'" + row[74].ToString() + "'," +
                                                "'" + row[75].ToString() + "'," +
                                                "'" + row[76].ToString() + "'," +
                                                "'" + row[77].ToString() + "'," +
                                                "'" + row[78].ToString() + "'," +
                                                "'" + row[79].ToString() + "'," +
                                                "'" + row[80].ToString() + "'," +
                                                "'" + row[81].ToString() + "'," +
                                                "'" + row[82].ToString() + "'," +
                                                "'" + row[83].ToString() + "'," +
                                                "'" + row[84].ToString() + "'," +
                                                "'" + row[85].ToString() + "'," +
                                                "'" + row[86].ToString() + "'," +
                                                "'" + row[87].ToString() + "'," +
                                                "'" + row[88].ToString() + "'," +
                                                "'" + row[89].ToString() + "'," +
                                                "'" + row[90].ToString() + "'," +
                                                "'" + row[91].ToString() + "'," +
                                                "'" + row[92].ToString() + "'," +
                                                "'" + row[93].ToString() + "'," +
                                                "'" + row[94].ToString() + "'," +
                                                "'" + row[95].ToString() + "'," +
                                                "'" + row[96].ToString() + "'," +
                                                "'" + row[97].ToString() + "'," +
                                                "'" + row[98].ToString() + "'," +
                                                "'" + row[99].ToString() + "'," +
                                                "'" + row[100].ToString() + "'," +
                                                "'" + row[101].ToString() + "'," +
                                                "'" + row[102].ToString() + "'," +
                                                "'" + row[103].ToString() + "'," +
                                                "'" + row[104].ToString() + "'," +
                                                "'" + row[105].ToString() + "'," +
                                                "'" + row[106].ToString() + "'," +
                                                "'" + row[107].ToString() + "'," +
                                                "'" + row[108].ToString() + "'," +
                                                "'" + row[109].ToString() + "'," +
                                                "'" + row[110].ToString() + "'," +
                                                "'" + row[111].ToString() + "'," +
                                                "'" + row[112].ToString() + "'," +
                                                "'" + row[113].ToString() + "'," +
                                                "'" + row[114].ToString() + "'," +
                                                "'" + row[115].ToString() + "'," +
                                                "'" + row[116].ToString() + "'," +
                                                "'" + row[117].ToString() + "'," +
                                                "'" + row[118].ToString() + "'," +
                                                "'" + row[119].ToString() + "'," +
                                                "'" + row[120].ToString() + "'," +
                                                "'" + row[121].ToString() + "'," +
                                                "'" + row[122].ToString() + "'," +
                                                "'" + row[123].ToString() + "'," +
                                                "'" + row[124].ToString() + "'," +
                                                "'" + row[125].ToString() + "'," +
                                                "'" + row[126].ToString() + "'," +
                                                "'" + row[127].ToString() + "'," +
                                                "'" + row[128].ToString() + "'," +
                                                "'" + row[129].ToString() + "'," +
                                                "'" + row[130].ToString() + "'," +
                                                "'" + row[131].ToString() + "'," +
                                                "'" + row[132].ToString() + "'," +
                                                "'" + row[133].ToString() + "'," +
                                                "'" + row[134].ToString() + "'," +
                                                "'" + row[135].ToString() + "'," +
                                                "'" + row[136].ToString() + "'," +
                                                "'" + row[137].ToString() + "'," +
                                                "'" + row[138].ToString() + "'," +
                                                "'" + row[139].ToString() + "'," +
                                                "'" + row[140].ToString() + "'," +
                                                "'" + row[141].ToString() + "'," +
                                                "'" + row[142].ToString() + "'," +
                                                "'" + row[143].ToString() + "'," +
                                                "'" + row[144].ToString() + "'," +
                                                "'" + row[145].ToString() + "'," +
                                                "'" + row[146].ToString() + "'," +
                                                "'" + row[147].ToString() + "'," +
                                                "'" + row[148].ToString() + "'," +
                                                "'" + row[149].ToString() + "'," +
                                                "'" + row[150].ToString() + "'," +
                                                "'" + row[151].ToString() + "'," +
                                                "'" + row[152].ToString() + "'," +
                                                "'" + row[153].ToString() + "'," +
                                                "'" + row[154].ToString() + "'," +
                                                "'" + row[155].ToString() + "'," +
                                                "'" + row[156].ToString() + "'," +
                                                "'" + row[157].ToString() + "'," +
                                                "'" + row[158].ToString() + "'," +
                                                "'" + row[159].ToString() + "'," +
                                                "'" + row[160].ToString() + "'," +
                                                "'" + row[161].ToString() + "'," +
                                                "'" + row[162].ToString() + "'," +
                                                "'" + System.DateTime.Now + "'," +
                                                "'Mohd Vaseem'" + ")";
                                Console.WriteLine("Query 1 - {0}", strQuery1);
                                cmd1 = new SqlCommand(strQuery1);
                                InsertUpdateData(cmd1, connectionString);
                            }
                        }
                    }
                    page++;
                } while (dtResult.Rows.Count > 0);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Exception : " + ex.Message);
            }
            Console.ReadLine();
        }

        private static string GetCountryCode(GoogleFormattedAddress googleFormattedAddress)
        {
            string country = string.Empty;
            foreach (var item in googleFormattedAddress.Results[0].AddressComponents)
            {
                foreach (var typ in item.Types)
                {
                    if (typ == "country")
                    {
                        country = item.ShortName;
                        break;
                    }
                }
                if (!string.IsNullOrEmpty(country))
                {
                    break;
                }
            }

            return country;
        }

        private static string GetCity(GoogleFormattedAddress googleFormattedAddress)
        {
            string city = string.Empty;
            foreach (var item in googleFormattedAddress.Results[0].AddressComponents)
            {
                foreach (var typ in item.Types)
                {
                    if (typ == "locality")
                    {
                        city = item.ShortName;
                        break;
                    }
                }
                if (!string.IsNullOrEmpty(city))
                {
                    break;
                }
            }

            return city;
        }

        private static string GetPostalCode(GoogleFormattedAddress googleFormattedAddress)
        {
            string postalCode = string.Empty;
            foreach (var item in googleFormattedAddress.Results[0].AddressComponents)
            {
                foreach (var typ in item.Types)
                {
                    if (typ == "postal_code")
                    {
                        postalCode = item.ShortName;
                        break;
                    }
                }
                if (!string.IsNullOrEmpty(postalCode))
                {
                    break;
                }
            }

            return postalCode;
        }

        private static string GetState(GoogleFormattedAddress googleFormattedAddress)
        {
            string state = string.Empty;
            foreach (var item in googleFormattedAddress.Results[0].AddressComponents)
            {
                foreach (var typ in item.Types)
                {
                    if (typ == "administrative_area_level_1")
                    {
                        state = item.LongName;
                        break;
                    }
                }
                if (!string.IsNullOrEmpty(state))
                {
                    break;
                }
            }

            return state;
        }

        private static DataTable GetData(SqlCommand cmd, string connectionString)
        {
            DataTable dt = new DataTable();
            String strConnString = connectionString;
            SqlConnection con = new SqlConnection(strConnString);
            SqlDataAdapter sda = new SqlDataAdapter();

            cmd.CommandType = CommandType.Text;
            cmd.Connection = con;
            try
            {
                Console.WriteLine("GetData - going to open connection");
                con.Open();
                Console.WriteLine("GetData - connection opened");
                sda.SelectCommand = cmd;
                sda.Fill(dt);
                return dt;
            }

            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return null;
            }
            finally
            {
                con.Close();
                sda.Dispose();
                con.Dispose();
            }
        }

        private static Boolean InsertUpdateData(SqlCommand cmd, string connectionString)
        {
            Console.WriteLine("5");
            String strConnString = connectionString;
            SqlConnection con = new SqlConnection(strConnString);
            cmd.CommandType = CommandType.Text;
            cmd.Connection = con;
            Console.WriteLine("6");
            try
            {
                con.Open();
                Console.WriteLine("7");
                cmd.ExecuteNonQuery();
                Console.WriteLine("8");
                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
                return false;
            }
            finally
            {
                con.Close();
                con.Dispose();
            }
        }
    }
}
