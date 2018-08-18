using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;

namespace ReadJson2
{
    class Program
    {
        static void Main(string[] args)
        {

            List<CSD> csds = new List<CSD>();
            int i = 0;
            int j = 0;

            string json = @"[
                {
                    'csd_uid': '1001101',
                    'csd_name': 'Division No.  1, Subd. V (N.L.)',
                    'csd_type': 'SNO',
                    'flag_cc_ir': 'F',
                    'cc_f_pop': '62',
                    'pc_a_pop': '65',
                    'flag_pc_a': 'F',
                    'flag_pc_ir': 'F',
                    'cc_pop_change': '-4.6',
                    'cc_dwell': '83',
                    'cc_dwell_ur': '28',
                    'cc_land': '894.1406',
                    'cc_density': '0.0693',
                    'cc_rank_nat': '4540',
                    'cc_rank_pr': '352'
                },
                {
                    'csd_uid': '1001105',
                    'csd_name': 'Portugal Cove South (N.L.)',
                    'csd_type': 'T',
                    'flag_cc_ir': 'F',
                    'cc_f_pop': '160',
                    'pc_a_pop': '222',
                    'flag_pc_a': 'F',
                    'flag_pc_ir': 'F',
                    'cc_pop_change': '-27.9',
                    'cc_dwell': '90',
                    'cc_dwell_ur': '69',
                    'cc_land': '1.1400',
                    'cc_density': '140.3509',
                    'cc_rank_nat': '4136',
                    'cc_rank_pr': '306'
                },
                {
                    'csd_uid': '1001113',
                    'csd_name': 'Trepassey (N.L.)',
                    'csd_type': 'T',
                    'flag_cc_ir': 'F',
                    'cc_f_pop': '570',
                    'pc_a_pop': '763',
                    'flag_pc_a': 'F',
                    'flag_pc_ir': 'F',
                    'cc_pop_change': '-25.3',
                    'cc_dwell': '335',
                    'cc_dwell_ur': '258',
                    'cc_land': '55.8094',
                    'cc_density': '10.2133',
                    'cc_rank_nat': '2833',
                    'cc_rank_pr': '144'
                },
                {
                    'csd_uid': '1001120',
                    'csd_name': 'St. Shott\'s (N.L.)',
                    'csd_type': 'T',
                    'flag_cc_ir': 'F',
                    'cc_f_pop': '81',
                    'pc_a_pop': '109',
                    'flag_pc_a': 'F',
                    'flag_pc_ir': 'F',
                    'cc_pop_change': '-25.7',
                    'cc_dwell': '44',
                    'cc_dwell_ur': '40',
                    'cc_land': '1.1359',
                    'cc_density': '71.3091',
                    'cc_rank_nat': '4454',
                    'cc_rank_pr': '348'
                }
            ]";

            JsonTextReader reader = new JsonTextReader(new StringReader(json));
            while (reader.Read())
            {
                switch (reader.TokenType.ToString())
                {
                    case "StartObject":
                        csds.Add(new CSD());
                        j = 0;
                        break;
                    case "PropertyName":
                        break;
                    case "String":
                        if (j == 0) csds[i].csd_uid = reader.Value.ToString();
                        if (j == 1) csds[i].csd_name = reader.Value.ToString();
                        if (j == 2) csds[i].csd_type = reader.Value.ToString();
                        if (j == 3) csds[i].flag_cc_ir = reader.Value.ToString();
                        if (j == 4) csds[i].cc_f_pop = reader.Value.ToString();
                        if (j == 5) csds[i].pc_a_pop = reader.Value.ToString();
                        if (j == 6) csds[i].flag_pc_a = reader.Value.ToString();
                        if (j == 7) csds[i].flag_pc_ir = reader.Value.ToString();
                        if (j == 8) csds[i].cc_pop_change = reader.Value.ToString();
                        if (j == 9) csds[i].cc_dwell = reader.Value.ToString();
                        if (j == 10) csds[i].cc_dwell_ur = reader.Value.ToString();
                        if (j == 11) csds[i].cc_land = reader.Value.ToString();
                        if (j == 12) csds[i].cc_density = reader.Value.ToString();
                        if (j == 13) csds[i].cc_rank_nat = reader.Value.ToString();
                        if (j == 14) csds[i].cc_rank_pr = reader.Value.ToString();
                        j++;
                        break;
                    case "EndObject":
                        i++;
                        break;
                }
            }


            OutputCSDs(csds);

            

        }

        static private void OutputCSDs(List<CSD> c)
        {
            for (var x = 0; x < c.Count; x++)
            {
                Console.WriteLine("csd_uid is {0} and csd_name is {1}", c[x].csd_uid, c[x].csd_name);
            }
        }

    }

}
