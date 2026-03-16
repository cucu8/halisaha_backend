using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace halisaha_backend.Migrations
{
    /// <inheritdoc />
    public partial class SeedCitiesAndDistrictsFromJson : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 1,
                column: "Name",
                value: "ADANA");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 2,
                column: "Name",
                value: "ADIYAMAN");

            migrationBuilder.InsertData(
                table: "Cities",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 3, "AFYONKARAHİSAR" },
                    { 4, "AĞRI" },
                    { 5, "AMASYA" },
                    { 6, "ANKARA" },
                    { 7, "ANTALYA" },
                    { 8, "ARTVİN" },
                    { 9, "AYDIN" },
                    { 10, "BALIKESİR" },
                    { 11, "BİLECİK" },
                    { 12, "BİNGÖL" },
                    { 13, "BİTLİS" },
                    { 14, "BOLU" },
                    { 15, "BURDUR" },
                    { 16, "BURSA" },
                    { 17, "ÇANAKKALE" },
                    { 18, "ÇANKIRI" },
                    { 19, "ÇORUM" },
                    { 20, "DENİZLİ" },
                    { 21, "DİYARBAKIR" },
                    { 22, "EDİRNE" },
                    { 23, "ELAZIĞ" },
                    { 24, "ERZİNCAN" },
                    { 25, "ERZURUM" },
                    { 26, "ESKİŞEHİR" },
                    { 27, "GAZİANTEP" },
                    { 28, "GİRESUN" },
                    { 29, "GÜMÜŞHANE" },
                    { 30, "HAKKARİ" },
                    { 31, "HATAY" },
                    { 32, "ISPARTA" },
                    { 33, "MERSİN" },
                    { 34, "İSTANBUL" },
                    { 35, "İZMİR" },
                    { 36, "KARS" },
                    { 37, "KASTAMONU" },
                    { 38, "KAYSERİ" },
                    { 39, "KIRKLARELİ" },
                    { 40, "KIRŞEHİR" },
                    { 41, "KOCAELİ" },
                    { 42, "KONYA" },
                    { 43, "KÜTAHYA" },
                    { 44, "MALATYA" },
                    { 45, "MANİSA" },
                    { 46, "KAHRAMANMARAŞ" },
                    { 47, "MARDİN" },
                    { 48, "MUĞLA" },
                    { 49, "MUŞ" },
                    { 50, "NEVŞEHİR" },
                    { 51, "NİĞDE" },
                    { 52, "ORDU" },
                    { 53, "RİZE" },
                    { 54, "SAKARYA" },
                    { 55, "SAMSUN" },
                    { 56, "SİİRT" },
                    { 57, "SİNOP" },
                    { 58, "SİVAS" },
                    { 59, "TEKİRDAĞ" },
                    { 60, "TOKAT" },
                    { 61, "TRABZON" },
                    { 62, "TUNCELİ" },
                    { 63, "ŞANLIURFA" },
                    { 64, "UŞAK" },
                    { 65, "VAN" },
                    { 66, "YOZGAT" },
                    { 67, "ZONGULDAK" },
                    { 68, "AKSARAY" },
                    { 69, "BAYBURT" },
                    { 70, "KARAMAN" },
                    { 71, "KIRIKKALE" },
                    { 72, "BATMAN" },
                    { 73, "ŞIRNAK" },
                    { 74, "BARTIN" },
                    { 75, "ARDAHAN" },
                    { 76, "IĞDIR" },
                    { 77, "YALOVA" },
                    { 78, "KARABÜK" },
                    { 79, "KİLİS" },
                    { 80, "OSMANİYE" },
                    { 81, "DÜZCE" }
                });

            migrationBuilder.InsertData(
                table: "Districts",
                columns: new[] { "Id", "CityId", "Name" },
                values: new object[,]
                {
                    { 1104, 1, "SEYHAN" },
                    { 1105, 2, "MERKEZ" },
                    { 1182, 2, "BESNİ" },
                    { 1219, 1, "CEYHAN" },
                    { 1246, 2, "ÇELİKHAN" },
                    { 1329, 1, "FEKE" },
                    { 1347, 2, "GERGER" },
                    { 1354, 2, "GÖLBAŞI" },
                    { 1425, 2, "KAHTA" },
                    { 1437, 1, "KARAİSALI" },
                    { 1443, 1, "KARATAŞ" },
                    { 1486, 1, "KOZAN" },
                    { 1580, 1, "POZANTI" },
                    { 1588, 1, "SAİMBEYLİ" },
                    { 1592, 2, "SAMSAT" },
                    { 1687, 1, "TUFANBEYLİ" },
                    { 1734, 1, "YUMURTALIK" },
                    { 1748, 1, "YÜREĞİR" },
                    { 1757, 1, "ALADAĞ" },
                    { 1806, 1, "İMAMOĞLU" },
                    { 1985, 2, "SİNCİK" },
                    { 1989, 2, "TUT" },
                    { 2032, 1, "SARIÇAM" },
                    { 2033, 1, "ÇUKUROVA" }
                });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                column: "PasswordHash",
                value: "$2a$11$POqdOdXjwFlwX7ZhOQxP2O0gUlGsH7sd7NgrEBxi/ad1HcMZCmU.6");

            migrationBuilder.InsertData(
                table: "Districts",
                columns: new[] { "Id", "CityId", "Name" },
                values: new object[,]
                {
                    { 1101, 37, "ABANA" },
                    { 1102, 20, "ACIPAYAM" },
                    { 1103, 34, "ADALAR" },
                    { 1106, 13, "ADİLCEVAZ" },
                    { 1107, 46, "AFŞİN" },
                    { 1108, 3, "MERKEZ" },
                    { 1109, 15, "AĞLASUN" },
                    { 1110, 23, "AĞIN" },
                    { 1111, 4, "MERKEZ" },
                    { 1112, 13, "AHLAT" },
                    { 1113, 61, "AKÇAABAT" },
                    { 1114, 44, "AKÇADAĞ" },
                    { 1115, 63, "AKÇAKALE" },
                    { 1116, 81, "AKÇAKOCA" },
                    { 1117, 66, "AKDAĞMADENİ" },
                    { 1118, 45, "AKHİSAR" },
                    { 1119, 52, "AKKUŞ" },
                    { 1120, 68, "MERKEZ" },
                    { 1121, 7, "AKSEKİ" },
                    { 1122, 42, "AKŞEHİR" },
                    { 1123, 54, "AKYAZI" },
                    { 1124, 19, "ALACA" },
                    { 1125, 55, "ALAÇAM" },
                    { 1126, 7, "ALANYA" },
                    { 1127, 45, "ALAŞEHİR" },
                    { 1128, 35, "ALİAĞA" },
                    { 1129, 60, "ALMUS" },
                    { 1130, 6, "ALTINDAĞ" },
                    { 1131, 31, "ALTINÖZÜ" },
                    { 1132, 43, "ALTINTAŞ" },
                    { 1133, 28, "ALUCRA" },
                    { 1134, 5, "MERKEZ" },
                    { 1135, 33, "ANAMUR" },
                    { 1136, 46, "ANDIRIN" },
                    { 1139, 27, "ARABAN" },
                    { 1140, 37, "ARAÇ" },
                    { 1141, 61, "ARAKLI" },
                    { 1142, 76, "ARALIK" },
                    { 1143, 44, "ARAPGİR" },
                    { 1144, 75, "MERKEZ" },
                    { 1145, 8, "ARDANUÇ" },
                    { 1146, 53, "ARDEŞEN" },
                    { 1147, 8, "ARHAVİ" },
                    { 1148, 44, "ARGUVAN" },
                    { 1149, 36, "ARPAÇAY" },
                    { 1150, 61, "ARSİN" },
                    { 1151, 60, "ARTOVA" },
                    { 1152, 8, "MERKEZ" },
                    { 1153, 25, "AŞKALE" },
                    { 1154, 32, "ATABEY" },
                    { 1155, 50, "AVANOS" },
                    { 1156, 57, "AYANCIK" },
                    { 1157, 6, "AYAŞ" },
                    { 1158, 52, "AYBASTI" },
                    { 1160, 17, "AYVACIK" },
                    { 1161, 10, "AYVALIK" },
                    { 1162, 37, "AZDAVAY" },
                    { 1163, 39, "BABAESKİ" },
                    { 1164, 55, "BAFRA" },
                    { 1165, 80, "BAHÇE" },
                    { 1166, 34, "BAKIRKÖY" },
                    { 1167, 6, "BALA" },
                    { 1169, 10, "BALYA" },
                    { 1170, 64, "BANAZ" },
                    { 1171, 10, "BANDIRMA" },
                    { 1172, 74, "MERKEZ" },
                    { 1173, 23, "BASKİL" },
                    { 1174, 72, "MERKEZ" },
                    { 1175, 65, "BAŞKALE" },
                    { 1176, 69, "MERKEZ" },
                    { 1177, 19, "BAYAT" },
                    { 1178, 35, "BAYINDIR" },
                    { 1179, 56, "BAYKAN" },
                    { 1180, 17, "BAYRAMİÇ" },
                    { 1181, 35, "BERGAMA" },
                    { 1183, 34, "BEŞİKTAŞ" },
                    { 1184, 72, "BEŞİRİ" },
                    { 1185, 34, "BEYKOZ" },
                    { 1186, 34, "BEYOĞLU" },
                    { 1187, 6, "BEYPAZARI" },
                    { 1188, 42, "BEYŞEHİR" },
                    { 1189, 73, "BEYTÜŞŞEBAP" },
                    { 1190, 17, "BİGA" },
                    { 1191, 10, "BİGADİÇ" },
                    { 1192, 11, "MERKEZ" },
                    { 1193, 12, "MERKEZ" },
                    { 1194, 63, "BİRECİK" },
                    { 1195, 21, "BİSMİL" },
                    { 1196, 13, "MERKEZ" },
                    { 1197, 48, "BODRUM" },
                    { 1198, 66, "BOĞAZLIYAN" },
                    { 1199, 14, "MERKEZ" },
                    { 1200, 3, "BOLVADİN" },
                    { 1201, 51, "BOR" },
                    { 1202, 8, "BORÇKA" },
                    { 1203, 35, "BORNOVA" },
                    { 1204, 57, "BOYABAT" },
                    { 1205, 17, "BOZCAADA" },
                    { 1206, 9, "BOZDOĞAN" },
                    { 1207, 42, "BOZKIR" },
                    { 1208, 37, "BOZKURT" },
                    { 1209, 63, "BOZOVA" },
                    { 1210, 11, "BOZÜYÜK" },
                    { 1211, 15, "BUCAK" },
                    { 1212, 28, "BULANCAK" },
                    { 1213, 49, "BULANIK" },
                    { 1214, 20, "BULDAN" },
                    { 1215, 15, "MERKEZ" },
                    { 1216, 10, "BURHANİYE" },
                    { 1218, 38, "BÜNYAN" },
                    { 1220, 63, "CEYLANPINAR" },
                    { 1221, 37, "CİDE" },
                    { 1222, 42, "CİHANBEYLİ" },
                    { 1223, 73, "CİZRE" },
                    { 1224, 20, "ÇAL" },
                    { 1225, 51, "ÇAMARDI" },
                    { 1226, 20, "ÇAMELİ" },
                    { 1227, 6, "ÇAMLIDERE" },
                    { 1228, 53, "ÇAMLIHEMŞİN" },
                    { 1229, 17, "ÇAN" },
                    { 1230, 17, "MERKEZ" },
                    { 1231, 6, "ÇANKAYA" },
                    { 1232, 18, "MERKEZ" },
                    { 1233, 20, "ÇARDAK" },
                    { 1234, 55, "ÇARŞAMBA" },
                    { 1235, 25, "ÇAT" },
                    { 1236, 65, "ÇATAK" },
                    { 1237, 34, "ÇATALCA" },
                    { 1238, 37, "ÇATALZEYTİN" },
                    { 1239, 3, "ÇAY" },
                    { 1240, 67, "ÇAYCUMA" },
                    { 1241, 53, "ÇAYELİ" },
                    { 1242, 66, "ÇAYIRALAN" },
                    { 1243, 24, "ÇAYIRLI" },
                    { 1244, 61, "ÇAYKARA" },
                    { 1245, 66, "ÇEKEREK" },
                    { 1247, 62, "ÇEMİŞGEZEK" },
                    { 1248, 18, "ÇERKEŞ" },
                    { 1249, 21, "ÇERMİK" },
                    { 1250, 59, "ÇERKEZKÖY" },
                    { 1251, 35, "ÇEŞME" },
                    { 1252, 75, "ÇILDIR" },
                    { 1253, 21, "ÇINAR" },
                    { 1254, 40, "ÇİÇEKDAĞI" },
                    { 1255, 26, "ÇİFTELER" },
                    { 1256, 9, "ÇİNE" },
                    { 1257, 20, "ÇİVRİL" },
                    { 1258, 59, "ÇORLU" },
                    { 1259, 19, "MERKEZ" },
                    { 1260, 6, "ÇUBUK" },
                    { 1261, 30, "ÇUKURCA" },
                    { 1262, 42, "ÇUMRA" },
                    { 1263, 21, "ÇÜNGÜŞ" },
                    { 1264, 37, "DADAY" },
                    { 1265, 44, "DARENDE" },
                    { 1266, 48, "DATÇA" },
                    { 1267, 3, "DAZKIRI" },
                    { 1268, 71, "DELİCE" },
                    { 1269, 45, "DEMİRCİ" },
                    { 1270, 39, "DEMİRKÖY" },
                    { 1272, 28, "DERELİ" },
                    { 1273, 47, "DERİK" },
                    { 1274, 50, "DERİNKUYU" },
                    { 1275, 38, "DEVELİ" },
                    { 1276, 67, "DEVREK" },
                    { 1277, 37, "DEVREKANİ" },
                    { 1278, 21, "DİCLE" },
                    { 1279, 36, "DİGOR" },
                    { 1280, 35, "DİKİLİ" },
                    { 1281, 3, "DİNAR" },
                    { 1282, 58, "DİVRİĞİ" },
                    { 1283, 4, "DİYADİN" },
                    { 1285, 42, "DOĞANHİSAR" },
                    { 1286, 44, "DOĞANŞEHİR" },
                    { 1287, 4, "DOĞUBAYAZIT" },
                    { 1288, 43, "DOMANİÇ" },
                    { 1289, 31, "DÖRTYOL" },
                    { 1290, 57, "DURAĞAN" },
                    { 1291, 10, "DURSUNBEY" },
                    { 1292, 81, "MERKEZ" },
                    { 1293, 17, "ECEABAT" },
                    { 1294, 10, "EDREMİT" },
                    { 1295, 22, "MERKEZ" },
                    { 1296, 78, "EFLANİ" },
                    { 1297, 32, "EĞİRDİR" },
                    { 1298, 23, "MERKEZ" },
                    { 1299, 46, "ELBİSTAN" },
                    { 1300, 18, "ELDİVAN" },
                    { 1301, 4, "ELEŞKİRT" },
                    { 1302, 6, "ELMADAĞ" },
                    { 1303, 7, "ELMALI" },
                    { 1304, 43, "EMET" },
                    { 1306, 3, "EMİRDAĞ" },
                    { 1307, 22, "ENEZ" },
                    { 1308, 60, "ERBAA" },
                    { 1309, 65, "ERCİŞ" },
                    { 1310, 10, "ERDEK" },
                    { 1311, 33, "ERDEMLİ" },
                    { 1312, 42, "EREĞLİ" },
                    { 1313, 67, "EREĞLİ" },
                    { 1314, 57, "ERFELEK" },
                    { 1315, 21, "ERGANİ" },
                    { 1316, 70, "ERMENEK" },
                    { 1317, 56, "ERUH" },
                    { 1318, 24, "MERKEZ" },
                    { 1320, 28, "ESPİYE" },
                    { 1321, 78, "ESKİPAZAR" },
                    { 1323, 64, "EŞME" },
                    { 1324, 28, "EYNESİL" },
                    { 1325, 34, "EYÜPSULTAN" },
                    { 1326, 17, "EZİNE" },
                    { 1327, 34, "FATİH" },
                    { 1328, 52, "FATSA" },
                    { 1330, 38, "FELAHİYE" },
                    { 1331, 48, "FETHİYE" },
                    { 1332, 53, "FINDIKLI" },
                    { 1333, 7, "FİNİKE" },
                    { 1334, 35, "FOÇA" },
                    { 1336, 34, "GAZİOSMANPAŞA" },
                    { 1337, 7, "GAZİPAŞA" },
                    { 1338, 41, "GEBZE" },
                    { 1339, 43, "GEDİZ" },
                    { 1340, 17, "GELİBOLU" },
                    { 1341, 32, "GELENDOST" },
                    { 1342, 58, "GEMEREK" },
                    { 1343, 16, "GEMLİK" },
                    { 1344, 12, "GENÇ" },
                    { 1345, 72, "GERCÜŞ" },
                    { 1346, 14, "GEREDE" },
                    { 1348, 9, "GERMENCİK" },
                    { 1349, 57, "GERZE" },
                    { 1350, 65, "GEVAŞ" },
                    { 1351, 54, "GEYVE" },
                    { 1352, 28, "MERKEZ" },
                    { 1353, 46, "GÖKSUN" },
                    { 1355, 41, "GÖLCÜK" },
                    { 1356, 75, "GÖLE" },
                    { 1357, 15, "GÖLHİSAR" },
                    { 1358, 52, "GÖLKÖY" },
                    { 1359, 11, "GÖLPAZARI" },
                    { 1360, 10, "GÖNEN" },
                    { 1361, 28, "GÖRELE" },
                    { 1362, 45, "GÖRDES" },
                    { 1363, 5, "GÖYNÜCEK" },
                    { 1364, 14, "GÖYNÜK" },
                    { 1365, 6, "GÜDÜL" },
                    { 1366, 33, "GÜLNAR" },
                    { 1367, 50, "GÜLŞEHİR" },
                    { 1368, 5, "GÜMÜŞHACIKÖY" },
                    { 1369, 29, "MERKEZ" },
                    { 1370, 7, "GÜNDOĞMUŞ" },
                    { 1371, 20, "GÜNEY" },
                    { 1372, 65, "GÜRPINAR" },
                    { 1373, 58, "GÜRÜN" },
                    { 1374, 50, "HACIBEKTAŞ" },
                    { 1375, 42, "HADİM" },
                    { 1376, 58, "HAFİK" },
                    { 1377, 30, "MERKEZ" },
                    { 1378, 63, "HALFETİ" },
                    { 1379, 4, "HAMUR" },
                    { 1380, 75, "HANAK" },
                    { 1381, 21, "HANİ" },
                    { 1382, 31, "HASSA" },
                    { 1384, 10, "HAVRAN" },
                    { 1385, 22, "HAVSA" },
                    { 1386, 55, "HAVZA" },
                    { 1387, 6, "HAYMANA" },
                    { 1388, 59, "HAYRABOLU" },
                    { 1389, 21, "HAZRO" },
                    { 1390, 44, "HEKİMHAN" },
                    { 1391, 54, "HENDEK" },
                    { 1392, 25, "HINIS" },
                    { 1393, 63, "HİLVAN" },
                    { 1394, 13, "HİZAN" },
                    { 1395, 8, "HOPA" },
                    { 1396, 25, "HORASAN" },
                    { 1397, 62, "HOZAT" },
                    { 1398, 76, "MERKEZ" },
                    { 1399, 18, "ILGAZ" },
                    { 1400, 42, "ILGIN" },
                    { 1401, 32, "MERKEZ" },
                    { 1403, 73, "İDİL" },
                    { 1404, 3, "İHSANİYE" },
                    { 1405, 53, "İKİZDERE" },
                    { 1406, 24, "İLİÇ" },
                    { 1407, 58, "İMRANLI" },
                    { 1408, 17, "GÖKÇEADA" },
                    { 1409, 38, "İNCESU" },
                    { 1410, 37, "İNEBOLU" },
                    { 1411, 16, "İNEGÖL" },
                    { 1412, 22, "İPSALA" },
                    { 1413, 31, "İSKENDERUN" },
                    { 1414, 19, "İSKİLİP" },
                    { 1415, 27, "İSLAHİYE" },
                    { 1416, 25, "İSPİR" },
                    { 1418, 10, "İVRİNDİ" },
                    { 1420, 16, "İZNİK" },
                    { 1421, 34, "KADIKÖY" },
                    { 1422, 42, "KADINHANI" },
                    { 1423, 80, "KADİRLİ" },
                    { 1424, 36, "KAĞIZMAN" },
                    { 1426, 20, "KALE" },
                    { 1427, 6, "KALECİK" },
                    { 1428, 53, "KALKANDERE" },
                    { 1429, 40, "KAMAN" },
                    { 1430, 41, "KANDIRA" },
                    { 1431, 58, "KANGAL" },
                    { 1432, 35, "KARABURUN" },
                    { 1433, 78, "MERKEZ" },
                    { 1434, 16, "KARACABEY" },
                    { 1435, 9, "KARACASU" },
                    { 1436, 64, "KARAHALLI" },
                    { 1438, 23, "KARAKOÇAN" },
                    { 1439, 70, "MERKEZ" },
                    { 1440, 41, "KARAMÜRSEL" },
                    { 1441, 42, "KARAPINAR" },
                    { 1442, 54, "KARASU" },
                    { 1444, 25, "KARAYAZI" },
                    { 1445, 19, "KARGI" },
                    { 1446, 12, "KARLIOVA" },
                    { 1447, 36, "MERKEZ" },
                    { 1448, 35, "KARŞIYAKA" },
                    { 1449, 34, "KARTAL" },
                    { 1450, 37, "MERKEZ" },
                    { 1451, 7, "KAŞ" },
                    { 1452, 55, "KAVAK" },
                    { 1453, 54, "KAYNARCA" },
                    { 1455, 23, "KEBAN" },
                    { 1456, 32, "KEÇİBORLU" },
                    { 1457, 16, "KELES" },
                    { 1458, 29, "KELKİT" },
                    { 1459, 24, "KEMAH" },
                    { 1460, 24, "KEMALİYE" },
                    { 1461, 35, "KEMALPAŞA" },
                    { 1462, 10, "KEPSUT" },
                    { 1463, 71, "KESKİN" },
                    { 1464, 22, "KEŞAN" },
                    { 1465, 28, "KEŞAP" },
                    { 1466, 14, "KIBRISCIK" },
                    { 1467, 35, "KINIK" },
                    { 1468, 31, "KIRIKHAN" },
                    { 1469, 71, "MERKEZ" },
                    { 1470, 45, "KIRKAĞAÇ" },
                    { 1471, 39, "MERKEZ" },
                    { 1472, 40, "MERKEZ" },
                    { 1473, 6, "KIZILCAHAMAM" },
                    { 1474, 47, "KIZILTEPE" },
                    { 1475, 12, "KİĞI" },
                    { 1476, 79, "MERKEZ" },
                    { 1477, 35, "KİRAZ" },
                    { 1479, 9, "KOÇARLI" },
                    { 1480, 39, "KOFÇAZ" },
                    { 1482, 52, "KORGAN" },
                    { 1483, 7, "KORKUTELİ" },
                    { 1484, 58, "KOYULHİSAR" },
                    { 1485, 50, "KOZAKLI" },
                    { 1487, 72, "KOZLUK" },
                    { 1488, 48, "KÖYCEĞİZ" },
                    { 1489, 45, "KULA" },
                    { 1490, 21, "KULP" },
                    { 1491, 42, "KULU" },
                    { 1492, 7, "KUMLUCA" },
                    { 1493, 52, "KUMRU" },
                    { 1494, 18, "KURŞUNLU" },
                    { 1495, 56, "KURTALAN" },
                    { 1496, 74, "KURUCAŞİLE" },
                    { 1497, 9, "KUŞADASI" },
                    { 1498, 9, "KUYUCAK" },
                    { 1499, 37, "KÜRE" },
                    { 1500, 43, "MERKEZ" },
                    { 1501, 55, "LADİK" },
                    { 1502, 22, "LALAPAŞA" },
                    { 1503, 17, "LAPSEKİ" },
                    { 1504, 21, "LİCE" },
                    { 1505, 39, "LÜLEBURGAZ" },
                    { 1506, 23, "MADEN" },
                    { 1507, 61, "MAÇKA" },
                    { 1508, 26, "MAHMUDİYE" },
                    { 1510, 49, "MALAZGİRT" },
                    { 1511, 59, "MALKARA" },
                    { 1512, 7, "MANAVGAT" },
                    { 1514, 10, "MANYAS" },
                    { 1517, 48, "MARMARİS" },
                    { 1518, 62, "MAZGİRT" },
                    { 1519, 47, "MAZIDAĞI" },
                    { 1520, 19, "MECİTÖZÜ" },
                    { 1521, 35, "MENEMEN" },
                    { 1522, 14, "MENGEN" },
                    { 1523, 22, "MERİÇ" },
                    { 1524, 5, "MERZİFON" },
                    { 1525, 52, "MESUDİYE" },
                    { 1526, 47, "MİDYAT" },
                    { 1527, 26, "MİHALIÇÇIK" },
                    { 1528, 48, "MİLAS" },
                    { 1529, 40, "MUCUR" },
                    { 1530, 16, "MUDANYA" },
                    { 1531, 14, "MUDURNU" },
                    { 1533, 65, "MURADİYE" },
                    { 1534, 49, "MERKEZ" },
                    { 1535, 16, "MUSTAFAKEMALPAŞA" },
                    { 1536, 33, "MUT" },
                    { 1537, 13, "MUTKİ" },
                    { 1538, 59, "MURATLI" },
                    { 1539, 6, "NALLIHAN" },
                    { 1540, 25, "NARMAN" },
                    { 1541, 62, "NAZIMİYE" },
                    { 1542, 9, "NAZİLLİ" },
                    { 1543, 50, "MERKEZ" },
                    { 1544, 51, "MERKEZ" },
                    { 1545, 60, "NİKSAR" },
                    { 1546, 27, "NİZİP" },
                    { 1547, 47, "NUSAYBİN" },
                    { 1548, 61, "OF" },
                    { 1549, 27, "OĞUZELİ" },
                    { 1550, 25, "OLTU" },
                    { 1551, 25, "OLUR" },
                    { 1553, 16, "ORHANELİ" },
                    { 1554, 16, "ORHANGAZİ" },
                    { 1555, 18, "ORTA" },
                    { 1556, 19, "ORTAKÖY" },
                    { 1557, 68, "ORTAKÖY" },
                    { 1558, 19, "OSMANCIK" },
                    { 1559, 11, "OSMANELİ" },
                    { 1560, 80, "MERKEZ" },
                    { 1561, 78, "OVACIK" },
                    { 1562, 62, "OVACIK" },
                    { 1563, 35, "ÖDEMİŞ" },
                    { 1564, 47, "ÖMERLİ" },
                    { 1565, 65, "ÖZALP" },
                    { 1566, 23, "PALU" },
                    { 1567, 25, "PASİNLER" },
                    { 1568, 4, "PATNOS" },
                    { 1569, 53, "PAZAR" },
                    { 1570, 46, "PAZARCIK" },
                    { 1571, 11, "PAZARYERİ" },
                    { 1572, 39, "PEHLİVANKÖY" },
                    { 1573, 52, "PERŞEMBE" },
                    { 1574, 62, "PERTEK" },
                    { 1575, 56, "PERVARİ" },
                    { 1576, 38, "PINARBAŞI" },
                    { 1577, 39, "PINARHİSAR" },
                    { 1578, 6, "POLATLI" },
                    { 1579, 75, "POSOF" },
                    { 1581, 62, "PÜLÜMÜR" },
                    { 1582, 44, "PÜTÜRGE" },
                    { 1583, 24, "REFAHİYE" },
                    { 1584, 60, "REŞADİYE" },
                    { 1585, 31, "REYHANLI" },
                    { 1586, 53, "MERKEZ" },
                    { 1587, 78, "SAFRANBOLU" },
                    { 1590, 45, "SALİHLİ" },
                    { 1591, 31, "SAMANDAĞ" },
                    { 1594, 3, "SANDIKLI" },
                    { 1595, 54, "SAPANCA" },
                    { 1596, 59, "SARAY" },
                    { 1597, 20, "SARAYKÖY" },
                    { 1598, 42, "SARAYÖNÜ" },
                    { 1599, 26, "SARICAKAYA" },
                    { 1600, 45, "SARIGÖL" },
                    { 1601, 36, "SARIKAMIŞ" },
                    { 1602, 66, "SARIKAYA" },
                    { 1603, 38, "SARIOĞLAN" },
                    { 1604, 34, "SARIYER" },
                    { 1605, 38, "SARIZ" },
                    { 1606, 45, "SARUHANLI" },
                    { 1607, 72, "SASON" },
                    { 1608, 10, "SAVAŞTEPE" },
                    { 1609, 47, "SAVUR" },
                    { 1610, 14, "SEBEN" },
                    { 1611, 35, "SEFERİHİSAR" },
                    { 1612, 35, "SELÇUK" },
                    { 1613, 45, "SELENDİ" },
                    { 1614, 36, "SELİM" },
                    { 1615, 32, "SENİRKENT" },
                    { 1616, 7, "SERİK" },
                    { 1617, 42, "SEYDİŞEHİR" },
                    { 1618, 26, "SEYİTGAZİ" },
                    { 1619, 10, "SINDIRGI" },
                    { 1620, 56, "MERKEZ" },
                    { 1621, 33, "SİLİFKE" },
                    { 1622, 34, "SİLİVRİ" },
                    { 1623, 73, "SİLOPİ" },
                    { 1624, 21, "SİLVAN" },
                    { 1625, 43, "SİMAV" },
                    { 1626, 3, "SİNANPAŞA" },
                    { 1627, 57, "MERKEZ" },
                    { 1628, 58, "MERKEZ" },
                    { 1629, 64, "SİVASLI" },
                    { 1630, 63, "SİVEREK" },
                    { 1631, 23, "SİVRİCE" },
                    { 1632, 26, "SİVRİHİSAR" },
                    { 1633, 12, "SOLHAN" },
                    { 1634, 45, "SOMA" },
                    { 1635, 66, "SORGUN" },
                    { 1636, 11, "SÖĞÜT" },
                    { 1637, 9, "SÖKE" },
                    { 1638, 71, "SULAKYURT" },
                    { 1639, 3, "SULTANDAĞI" },
                    { 1640, 9, "SULTANHİSAR" },
                    { 1641, 5, "SULUOVA" },
                    { 1642, 19, "SUNGURLU" },
                    { 1643, 63, "SURUÇ" },
                    { 1644, 10, "SUSURLUK" },
                    { 1645, 36, "SUSUZ" },
                    { 1646, 58, "SUŞEHRİ" },
                    { 1647, 61, "SÜRMENE" },
                    { 1648, 32, "SÜTÇÜLER" },
                    { 1649, 18, "ŞABANÖZÜ" },
                    { 1650, 58, "ŞARKIŞLA" },
                    { 1651, 32, "ŞARKİKARAAĞAÇ" },
                    { 1652, 59, "ŞARKÖY" },
                    { 1653, 8, "ŞAVŞAT" },
                    { 1654, 28, "ŞEBİNKARAHİSAR" },
                    { 1655, 66, "ŞEFAATLİ" },
                    { 1656, 30, "ŞEMDİNLİ" },
                    { 1657, 25, "ŞENKAYA" },
                    { 1658, 6, "ŞEREFLİKOÇHİSAR" },
                    { 1659, 34, "ŞİLE" },
                    { 1660, 29, "ŞİRAN" },
                    { 1661, 73, "MERKEZ" },
                    { 1662, 56, "ŞİRVAN" },
                    { 1663, 34, "ŞİŞLİ" },
                    { 1664, 3, "ŞUHUT" },
                    { 1665, 33, "TARSUS" },
                    { 1666, 37, "TAŞKÖPRÜ" },
                    { 1667, 4, "TAŞLIÇAY" },
                    { 1668, 5, "TAŞOVA" },
                    { 1669, 13, "TATVAN" },
                    { 1670, 20, "TAVAS" },
                    { 1671, 43, "TAVŞANLI" },
                    { 1672, 15, "TEFENNİ" },
                    { 1674, 25, "TEKMAN" },
                    { 1675, 24, "TERCAN" },
                    { 1676, 55, "TERME" },
                    { 1677, 35, "TİRE" },
                    { 1678, 28, "TİREBOLU" },
                    { 1679, 60, "MERKEZ" },
                    { 1680, 38, "TOMARZA" },
                    { 1681, 61, "TONYA" },
                    { 1682, 35, "TORBALI" },
                    { 1683, 25, "TORTUM" },
                    { 1684, 29, "TORUL" },
                    { 1685, 37, "TOSYA" },
                    { 1688, 62, "MERKEZ" },
                    { 1689, 45, "TURGUTLU" },
                    { 1690, 60, "TURHAL" },
                    { 1691, 4, "TUTAK" },
                    { 1692, 76, "TUZLUCA" },
                    { 1693, 57, "TÜRKELİ" },
                    { 1694, 46, "TÜRKOĞLU" },
                    { 1695, 48, "ULA" },
                    { 1696, 52, "ULUBEY" },
                    { 1697, 64, "ULUBEY" },
                    { 1698, 73, "ULUDERE" },
                    { 1699, 32, "ULUBORLU" },
                    { 1700, 51, "ULUKIŞLA" },
                    { 1701, 74, "ULUS" },
                    { 1703, 35, "URLA" },
                    { 1704, 64, "MERKEZ" },
                    { 1705, 22, "UZUNKÖPRÜ" },
                    { 1706, 52, "ÜNYE" },
                    { 1707, 50, "ÜRGÜP" },
                    { 1708, 34, "ÜSKÜDAR" },
                    { 1709, 61, "VAKFIKEBİR" },
                    { 1711, 49, "VARTO" },
                    { 1712, 55, "VEZİRKÖPRÜ" },
                    { 1713, 63, "VİRANŞEHİR" },
                    { 1714, 39, "VİZE" },
                    { 1715, 38, "YAHYALI" },
                    { 1716, 77, "MERKEZ" },
                    { 1717, 32, "YALVAÇ" },
                    { 1718, 18, "YAPRAKLI" },
                    { 1719, 48, "YATAĞAN" },
                    { 1720, 27, "YAVUZELİ" },
                    { 1721, 31, "YAYLADAĞI" },
                    { 1722, 17, "YENİCE" },
                    { 1723, 6, "YENİMAHALLE" },
                    { 1724, 9, "YENİPAZAR" },
                    { 1725, 16, "YENİŞEHİR" },
                    { 1726, 66, "YERKÖY" },
                    { 1727, 38, "YEŞİLHİSAR" },
                    { 1728, 15, "YEŞİLOVA" },
                    { 1729, 44, "YEŞİLYURT" },
                    { 1730, 81, "YIĞILCA" },
                    { 1731, 58, "YILDIZELİ" },
                    { 1732, 61, "YOMRA" },
                    { 1733, 66, "MERKEZ" },
                    { 1735, 42, "YUNAK" },
                    { 1736, 8, "YUSUFELİ" },
                    { 1737, 30, "YÜKSEKOVA" },
                    { 1738, 58, "ZARA" },
                    { 1739, 34, "ZEYTİNBURNU" },
                    { 1740, 60, "ZİLE" },
                    { 1741, 67, "MERKEZ" },
                    { 1742, 48, "DALAMAN" },
                    { 1743, 80, "DÜZİÇİ" },
                    { 1744, 6, "GÖLBAŞI" },
                    { 1745, 6, "KEÇİÖREN" },
                    { 1746, 6, "MAMAK" },
                    { 1747, 6, "SİNCAN" },
                    { 1749, 50, "ACIGÖL" },
                    { 1750, 12, "ADAKLI" },
                    { 1751, 45, "AHMETLİ" },
                    { 1752, 38, "AKKIŞLA" },
                    { 1753, 42, "AKÖREN" },
                    { 1754, 40, "AKPINAR" },
                    { 1755, 32, "AKSU" },
                    { 1756, 36, "AKYAKA" },
                    { 1758, 67, "ALAPLI" },
                    { 1759, 26, "ALPU" },
                    { 1760, 42, "ALTINEKİN" },
                    { 1761, 74, "AMASRA" },
                    { 1762, 23, "ARICAK" },
                    { 1763, 55, "ASARCIK" },
                    { 1764, 43, "ASLANAPA" },
                    { 1765, 18, "ATKARACALAR" },
                    { 1766, 33, "AYDINCIK" },
                    { 1767, 69, "AYDINTEPE" },
                    { 1768, 70, "AYRANCI" },
                    { 1769, 20, "BABADAĞ" },
                    { 1770, 65, "BAHÇESARAY" },
                    { 1771, 3, "BAŞMAKÇI" },
                    { 1772, 44, "BATTALGAZİ" },
                    { 1773, 3, "BAYAT" },
                    { 1774, 20, "BEKİLLİ" },
                    { 1775, 61, "BEŞİKDÜZÜ" },
                    { 1776, 35, "BEYDAĞ" },
                    { 1777, 26, "BEYLİKOVA" },
                    { 1778, 19, "BOĞAZKALE" },
                    { 1779, 33, "BOZYAZI" },
                    { 1780, 35, "BUCA" },
                    { 1781, 9, "BUHARKENT" },
                    { 1782, 34, "BÜYÜKÇEKMECE" },
                    { 1783, 16, "BÜYÜKORHAN" },
                    { 1784, 81, "CUMAYERİ" },
                    { 1785, 46, "ÇAĞLAYANCERİT" },
                    { 1786, 65, "ÇALDIRAN" },
                    { 1787, 47, "DARGEÇİT" },
                    { 1788, 69, "DEMİRÖZÜ" },
                    { 1789, 42, "DEREBUCAK" },
                    { 1790, 43, "DUMLUPINAR" },
                    { 1791, 21, "EĞİL" },
                    { 1792, 31, "ERZİN" },
                    { 1793, 45, "GÖLMARMARA" },
                    { 1794, 81, "GÖLYAKA" },
                    { 1795, 52, "GÜLYALI" },
                    { 1796, 53, "GÜNEYSU" },
                    { 1797, 52, "GÜRGENTEPE" },
                    { 1798, 13, "GÜROYMAK" },
                    { 1799, 16, "HARMANCIK" },
                    { 1800, 63, "HARRAN" },
                    { 1801, 49, "HASKÖY" },
                    { 1802, 43, "HİSARCIK" },
                    { 1803, 20, "HONAZ" },
                    { 1804, 42, "HÜYÜK" },
                    { 1805, 37, "İHSANGAZİ" },
                    { 1807, 9, "İNCİRLİOVA" },
                    { 1808, 26, "İNÖNÜ" },
                    { 1809, 3, "İSCEHİSAR" },
                    { 1810, 34, "KAĞITHANE" },
                    { 1811, 7, "DEMRE" },
                    { 1812, 25, "KARAÇOBAN" },
                    { 1813, 15, "KARAMANLI" },
                    { 1814, 42, "KARATAY" },
                    { 1815, 6, "KAHRAMANKAZAN" },
                    { 1816, 15, "KEMER" },
                    { 1817, 18, "KIZILIRMAK" },
                    { 1818, 54, "KOCAALİ" },
                    { 1819, 35, "KONAK" },
                    { 1820, 23, "KOVANCILAR" },
                    { 1821, 41, "KÖRFEZ" },
                    { 1822, 29, "KÖSE" },
                    { 1823, 34, "KÜÇÜKÇEKMECE" },
                    { 1824, 10, "MARMARA" },
                    { 1825, 59, "MARMARAEREĞLİSİ" },
                    { 1826, 35, "MENDERES" },
                    { 1827, 42, "MERAM" },
                    { 1828, 8, "MURGUL" },
                    { 1829, 16, "NİLÜFER" },
                    { 1830, 55, "19 MAYIS" },
                    { 1831, 48, "ORTACA" },
                    { 1832, 16, "OSMANGAZİ" },
                    { 1833, 54, "PAMUKOVA" },
                    { 1834, 60, "PAZAR" },
                    { 1835, 34, "PENDİK" },
                    { 1836, 37, "PINARBAŞI" },
                    { 1837, 28, "PİRAZİZ" },
                    { 1838, 55, "SALIPAZARI" },
                    { 1839, 42, "SELÇUKLU" },
                    { 1840, 20, "SERİNHİSAR" },
                    { 1841, 27, "ŞAHİNBEY" },
                    { 1842, 61, "ŞALPAZARI" },
                    { 1843, 43, "ŞAPHANE" },
                    { 1844, 27, "ŞEHİTKAMİL" },
                    { 1845, 37, "ŞENPAZAR" },
                    { 1846, 38, "TALAS" },
                    { 1847, 54, "TARAKLI" },
                    { 1848, 42, "TAŞKENT" },
                    { 1849, 55, "TEKKEKÖY" },
                    { 1850, 19, "UĞURLUDAĞ" },
                    { 1851, 25, "UZUNDERE" },
                    { 1852, 34, "ÜMRANİYE" },
                    { 1853, 24, "ÜZÜMLÜ" },
                    { 1854, 28, "YAĞLIDERE" },
                    { 1855, 12, "YAYLADERE" },
                    { 1856, 78, "YENİCE" },
                    { 1857, 11, "YENİPAZAR" },
                    { 1858, 60, "YEŞİLYURT" },
                    { 1859, 16, "YILDIRIM" },
                    { 1860, 68, "AĞAÇÖREN" },
                    { 1861, 68, "GÜZELYURT" },
                    { 1862, 70, "KAZIMKARABEKİR" },
                    { 1863, 38, "KOCASİNAN" },
                    { 1864, 38, "MELİKGAZİ" },
                    { 1865, 25, "PAZARYOLU" },
                    { 1866, 68, "SARIYAHŞİ" },
                    { 1867, 37, "AĞLI" },
                    { 1868, 42, "AHIRLI" },
                    { 1869, 40, "AKÇAKENT" },
                    { 1870, 58, "AKINCILAR" },
                    { 1871, 20, "PAMUKKALE" },
                    { 1872, 6, "AKYURT" },
                    { 1873, 23, "ALACAKAYA" },
                    { 1874, 15, "ALTINYAYLA" },
                    { 1875, 58, "ALTINYAYLA" },
                    { 1876, 51, "ALTUNHİSAR" },
                    { 1877, 66, "AYDINCIK" },
                    { 1878, 56, "TİLLO" },
                    { 1879, 55, "AYVACIK" },
                    { 1880, 71, "BAHŞILI" },
                    { 1881, 20, "BAKLAN" },
                    { 1882, 71, "BALIŞEYH" },
                    { 1883, 60, "BAŞÇİFTLİK" },
                    { 1884, 70, "BAŞYAYLA" },
                    { 1885, 18, "BAYRAMÖREN" },
                    { 1886, 34, "BAYRAMPAŞA" },
                    { 1887, 31, "BELEN" },
                    { 1888, 20, "BEYAĞAÇ" },
                    { 1889, 20, "BOZKURT" },
                    { 1890, 40, "BOZTEPE" },
                    { 1891, 52, "ÇAMAŞ" },
                    { 1892, 33, "ÇAMLIYAYLA" },
                    { 1893, 28, "ÇAMOLUK" },
                    { 1894, 28, "ÇANAKÇI" },
                    { 1895, 66, "ÇANDIR" },
                    { 1896, 61, "ÇARŞIBAŞI" },
                    { 1897, 52, "ÇATALPINAR" },
                    { 1898, 43, "ÇAVDARHİSAR" },
                    { 1899, 15, "ÇAVDIR" },
                    { 1900, 52, "ÇAYBAŞI" },
                    { 1901, 71, "ÇELEBİ" },
                    { 1902, 42, "ÇELTİK" },
                    { 1903, 15, "ÇELTİKÇİ" },
                    { 1904, 51, "ÇİFTLİK" },
                    { 1905, 81, "ÇİLİMLİ" },
                    { 1906, 3, "ÇOBANLAR" },
                    { 1907, 42, "DERBENT" },
                    { 1908, 53, "DEREPAZARI" },
                    { 1909, 61, "DERNEKPAZARI" },
                    { 1910, 57, "DİKMEN" },
                    { 1911, 19, "DODURGA" },
                    { 1912, 28, "DOĞANKENT" },
                    { 1913, 58, "DOĞANŞAR" },
                    { 1914, 44, "DOĞANYOL" },
                    { 1915, 37, "DOĞANYURT" },
                    { 1916, 14, "DÖRTDİVAN" },
                    { 1917, 61, "DÜZKÖY" },
                    { 1918, 65, "EDREMİT" },
                    { 1919, 46, "EKİNÖZÜ" },
                    { 1920, 42, "EMİRGAZİ" },
                    { 1921, 68, "ESKİL" },
                    { 1922, 6, "ETİMESGUT" },
                    { 1923, 3, "EVCİLER" },
                    { 1924, 6, "EVREN" },
                    { 1925, 54, "FERİZLİ" },
                    { 1926, 67, "GÖKÇEBEY" },
                    { 1927, 58, "GÖLOVA" },
                    { 1928, 10, "GÖMEÇ" },
                    { 1929, 32, "GÖNEN" },
                    { 1930, 28, "GÜCE" },
                    { 1931, 73, "GÜÇLÜKONAK" },
                    { 1932, 68, "GÜLAĞAÇ" },
                    { 1933, 42, "GÜNEYSINIR" },
                    { 1934, 26, "GÜNYÜZÜ" },
                    { 1935, 16, "GÜRSU" },
                    { 1936, 38, "HACILAR" },
                    { 1937, 42, "HALKAPINAR" },
                    { 1938, 5, "HAMAMÖZÜ" },
                    { 1939, 26, "HAN" },
                    { 1940, 37, "HANÖNÜ" },
                    { 1941, 72, "HASANKEYF" },
                    { 1942, 61, "HAYRAT" },
                    { 1943, 53, "HEMŞİN" },
                    { 1944, 3, "HOCALAR" },
                    { 1945, 25, "AZİZİYE" },
                    { 1946, 7, "İBRADI" },
                    { 1947, 52, "İKİZCE" },
                    { 1948, 11, "İNHİSAR" },
                    { 1949, 53, "İYİDERE" },
                    { 1950, 52, "KABADÜZ" },
                    { 1951, 52, "KABATAŞ" },
                    { 1952, 66, "KADIŞEHRİ" },
                    { 1953, 44, "KALE" },
                    { 1954, 71, "KARAKEÇİLİ" },
                    { 1955, 54, "KARAPÜRÇEK" },
                    { 1956, 27, "KARKAMIŞ" },
                    { 1957, 9, "KARPUZLU" },
                    { 1958, 48, "KAVAKLIDERE" },
                    { 1959, 7, "KEMER" },
                    { 1960, 16, "KESTEL" },
                    { 1961, 3, "KIZILÖREN" },
                    { 1962, 21, "KOCAKÖY" },
                    { 1963, 18, "KORGUN" },
                    { 1964, 49, "KORKUT" },
                    { 1965, 45, "KÖPRÜBAŞI" },
                    { 1966, 61, "KÖPRÜBAŞI" },
                    { 1967, 25, "KÖPRÜKÖY" },
                    { 1968, 9, "KÖŞK" },
                    { 1969, 44, "KULUNCAK" },
                    { 1970, 31, "KUMLU" },
                    { 1971, 29, "KÜRTÜN" },
                    { 1972, 19, "LAÇİN" },
                    { 1973, 26, "MİHALGAZİ" },
                    { 1974, 27, "NURDAĞI" },
                    { 1975, 46, "NURHAK" },
                    { 1976, 19, "OĞUZLAR" },
                    { 1977, 24, "OTLUKBELİ" },
                    { 1978, 38, "ÖZVATAN" },
                    { 1979, 43, "PAZARLAR" },
                    { 1980, 65, "SARAY" },
                    { 1981, 57, "SARAYDÜZÜ" },
                    { 1982, 66, "SARAYKENT" },
                    { 1983, 70, "SARIVELİLER" },
                    { 1984, 37, "SEYDİLER" },
                    { 1986, 54, "SÖĞÜTLÜ" },
                    { 1987, 60, "SULUSARAY" },
                    { 1988, 22, "SÜLOĞLU" },
                    { 1990, 42, "TUZLUKÇU" },
                    { 1991, 58, "ULAŞ" },
                    { 1992, 71, "YAHŞİHAN" },
                    { 1993, 55, "YAKAKENT" },
                    { 1994, 42, "YALIHÜYÜK" },
                    { 1995, 44, "YAZIHAN" },
                    { 1996, 12, "YEDİSU" },
                    { 1997, 14, "YENİÇAĞA" },
                    { 1998, 66, "YENİFAKILI" },
                    { 2000, 9, "DİDİM" },
                    { 2001, 32, "YENİŞARBADEMLİ" },
                    { 2002, 47, "YEŞİLLİ" },
                    { 2003, 34, "AVCILAR" },
                    { 2004, 34, "BAĞCILAR" },
                    { 2005, 34, "BAHÇELİEVLER" },
                    { 2006, 35, "BALÇOVA" },
                    { 2007, 35, "ÇİĞLİ" },
                    { 2008, 75, "DAMAL" },
                    { 2009, 35, "GAZİEMİR" },
                    { 2010, 34, "GÜNGÖREN" },
                    { 2011, 76, "KARAKOYUNLU" },
                    { 2012, 34, "MALTEPE" },
                    { 2013, 35, "NARLIDERE" },
                    { 2014, 34, "SULTANBEYLİ" },
                    { 2015, 34, "TUZLA" },
                    { 2016, 34, "ESENLER" },
                    { 2017, 81, "GÜMÜŞOVA" },
                    { 2018, 35, "GÜZELBAHÇE" },
                    { 2019, 77, "ALTINOVA" },
                    { 2020, 77, "ARMUTLU" },
                    { 2021, 77, "ÇINARCIK" },
                    { 2022, 77, "ÇİFTLİKKÖY" },
                    { 2023, 79, "ELBEYLİ" },
                    { 2024, 79, "MUSABEYLİ" },
                    { 2025, 79, "POLATELİ" },
                    { 2026, 77, "TERMAL" },
                    { 2027, 80, "HASANBEYLİ" },
                    { 2028, 80, "SUMBAS" },
                    { 2029, 80, "TOPRAKKALE" },
                    { 2030, 41, "DERİNCE" },
                    { 2031, 81, "KAYNAŞLI" },
                    { 2034, 6, "PURSAKLAR" },
                    { 2035, 7, "AKSU" },
                    { 2036, 7, "DÖŞEMEALTI" },
                    { 2037, 7, "KEPEZ" },
                    { 2038, 7, "KONYAALTI" },
                    { 2039, 7, "MURATPAŞA" },
                    { 2040, 21, "BAĞLAR" },
                    { 2041, 21, "KAYAPINAR" },
                    { 2042, 21, "SUR" },
                    { 2043, 21, "YENİŞEHİR" },
                    { 2044, 25, "PALANDÖKEN" },
                    { 2045, 25, "YAKUTİYE" },
                    { 2046, 26, "ODUNPAZARI" },
                    { 2047, 26, "TEPEBAŞI" },
                    { 2048, 34, "ARNAVUTKÖY" },
                    { 2049, 34, "ATAŞEHİR" },
                    { 2050, 34, "BAŞAKŞEHİR" },
                    { 2051, 34, "BEYLİKDÜZÜ" },
                    { 2052, 34, "ÇEKMEKÖY" },
                    { 2053, 34, "ESENYURT" },
                    { 2054, 34, "SANCAKTEPE" },
                    { 2055, 34, "SULTANGAZİ" },
                    { 2056, 35, "BAYRAKLI" },
                    { 2057, 35, "KARABAĞLAR" },
                    { 2058, 41, "BAŞİSKELE" },
                    { 2059, 41, "ÇAYIROVA" },
                    { 2060, 41, "DARICA" },
                    { 2061, 41, "DİLOVASI" },
                    { 2062, 41, "İZMİT" },
                    { 2063, 41, "KARTEPE" },
                    { 2064, 33, "AKDENİZ" },
                    { 2065, 33, "MEZİTLİ" },
                    { 2066, 33, "TOROSLAR" },
                    { 2067, 33, "YENİŞEHİR" },
                    { 2068, 54, "ADAPAZARI" },
                    { 2069, 54, "ARİFİYE" },
                    { 2070, 54, "ERENLER" },
                    { 2071, 54, "SERDİVAN" },
                    { 2072, 55, "ATAKUM" },
                    { 2073, 55, "CANİK" },
                    { 2074, 55, "İLKADIM" },
                    { 2076, 9, "EFELER" },
                    { 2077, 10, "ALTIEYLÜL" },
                    { 2078, 10, "KARESİ" },
                    { 2079, 20, "MERKEZEFENDİ" },
                    { 2080, 31, "ANTAKYA" },
                    { 2081, 31, "ARSUZ" },
                    { 2082, 31, "DEFNE" },
                    { 2083, 31, "PAYAS" },
                    { 2084, 46, "DULKADİROĞLU" },
                    { 2085, 46, "ONİKİŞUBAT" },
                    { 2086, 45, "ŞEHZADELER" },
                    { 2087, 45, "YUNUSEMRE" },
                    { 2088, 47, "ARTUKLU" },
                    { 2089, 48, "MENTEŞE" },
                    { 2090, 48, "SEYDİKEMER" },
                    { 2091, 63, "EYYÜBİYE" },
                    { 2092, 63, "HALİLİYE" },
                    { 2093, 63, "KARAKÖPRÜ" },
                    { 2094, 59, "ERGENE" },
                    { 2095, 59, "KAPAKLI" },
                    { 2096, 59, "SÜLEYMANPAŞA" },
                    { 2097, 61, "ORTAHİSAR" },
                    { 2098, 65, "İPEKYOLU" },
                    { 2099, 65, "TUŞBA" },
                    { 2100, 67, "KİLİMLİ" },
                    { 2101, 67, "KOZLU" },
                    { 2103, 52, "ALTINORDU" },
                    { 2105, 8, "KEMALPAŞA" },
                    { 2106, 68, "SULTANHANI" },
                    { 2107, 30, "DERECİK" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 1101);

            migrationBuilder.DeleteData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 1102);

            migrationBuilder.DeleteData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 1103);

            migrationBuilder.DeleteData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 1104);

            migrationBuilder.DeleteData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 1105);

            migrationBuilder.DeleteData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 1106);

            migrationBuilder.DeleteData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 1107);

            migrationBuilder.DeleteData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 1108);

            migrationBuilder.DeleteData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 1109);

            migrationBuilder.DeleteData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 1110);

            migrationBuilder.DeleteData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 1111);

            migrationBuilder.DeleteData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 1112);

            migrationBuilder.DeleteData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 1113);

            migrationBuilder.DeleteData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 1114);

            migrationBuilder.DeleteData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 1115);

            migrationBuilder.DeleteData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 1116);

            migrationBuilder.DeleteData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 1117);

            migrationBuilder.DeleteData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 1118);

            migrationBuilder.DeleteData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 1119);

            migrationBuilder.DeleteData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 1120);

            migrationBuilder.DeleteData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 1121);

            migrationBuilder.DeleteData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 1122);

            migrationBuilder.DeleteData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 1123);

            migrationBuilder.DeleteData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 1124);

            migrationBuilder.DeleteData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 1125);

            migrationBuilder.DeleteData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 1126);

            migrationBuilder.DeleteData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 1127);

            migrationBuilder.DeleteData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 1128);

            migrationBuilder.DeleteData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 1129);

            migrationBuilder.DeleteData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 1130);

            migrationBuilder.DeleteData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 1131);

            migrationBuilder.DeleteData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 1132);

            migrationBuilder.DeleteData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 1133);

            migrationBuilder.DeleteData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 1134);

            migrationBuilder.DeleteData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 1135);

            migrationBuilder.DeleteData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 1136);

            migrationBuilder.DeleteData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 1139);

            migrationBuilder.DeleteData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 1140);

            migrationBuilder.DeleteData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 1141);

            migrationBuilder.DeleteData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 1142);

            migrationBuilder.DeleteData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 1143);

            migrationBuilder.DeleteData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 1144);

            migrationBuilder.DeleteData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 1145);

            migrationBuilder.DeleteData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 1146);

            migrationBuilder.DeleteData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 1147);

            migrationBuilder.DeleteData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 1148);

            migrationBuilder.DeleteData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 1149);

            migrationBuilder.DeleteData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 1150);

            migrationBuilder.DeleteData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 1151);

            migrationBuilder.DeleteData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 1152);

            migrationBuilder.DeleteData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 1153);

            migrationBuilder.DeleteData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 1154);

            migrationBuilder.DeleteData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 1155);

            migrationBuilder.DeleteData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 1156);

            migrationBuilder.DeleteData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 1157);

            migrationBuilder.DeleteData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 1158);

            migrationBuilder.DeleteData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 1160);

            migrationBuilder.DeleteData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 1161);

            migrationBuilder.DeleteData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 1162);

            migrationBuilder.DeleteData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 1163);

            migrationBuilder.DeleteData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 1164);

            migrationBuilder.DeleteData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 1165);

            migrationBuilder.DeleteData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 1166);

            migrationBuilder.DeleteData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 1167);

            migrationBuilder.DeleteData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 1169);

            migrationBuilder.DeleteData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 1170);

            migrationBuilder.DeleteData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 1171);

            migrationBuilder.DeleteData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 1172);

            migrationBuilder.DeleteData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 1173);

            migrationBuilder.DeleteData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 1174);

            migrationBuilder.DeleteData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 1175);

            migrationBuilder.DeleteData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 1176);

            migrationBuilder.DeleteData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 1177);

            migrationBuilder.DeleteData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 1178);

            migrationBuilder.DeleteData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 1179);

            migrationBuilder.DeleteData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 1180);

            migrationBuilder.DeleteData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 1181);

            migrationBuilder.DeleteData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 1182);

            migrationBuilder.DeleteData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 1183);

            migrationBuilder.DeleteData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 1184);

            migrationBuilder.DeleteData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 1185);

            migrationBuilder.DeleteData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 1186);

            migrationBuilder.DeleteData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 1187);

            migrationBuilder.DeleteData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 1188);

            migrationBuilder.DeleteData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 1189);

            migrationBuilder.DeleteData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 1190);

            migrationBuilder.DeleteData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 1191);

            migrationBuilder.DeleteData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 1192);

            migrationBuilder.DeleteData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 1193);

            migrationBuilder.DeleteData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 1194);

            migrationBuilder.DeleteData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 1195);

            migrationBuilder.DeleteData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 1196);

            migrationBuilder.DeleteData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 1197);

            migrationBuilder.DeleteData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 1198);

            migrationBuilder.DeleteData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 1199);

            migrationBuilder.DeleteData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 1200);

            migrationBuilder.DeleteData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 1201);

            migrationBuilder.DeleteData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 1202);

            migrationBuilder.DeleteData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 1203);

            migrationBuilder.DeleteData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 1204);

            migrationBuilder.DeleteData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 1205);

            migrationBuilder.DeleteData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 1206);

            migrationBuilder.DeleteData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 1207);

            migrationBuilder.DeleteData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 1208);

            migrationBuilder.DeleteData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 1209);

            migrationBuilder.DeleteData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 1210);

            migrationBuilder.DeleteData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 1211);

            migrationBuilder.DeleteData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 1212);

            migrationBuilder.DeleteData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 1213);

            migrationBuilder.DeleteData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 1214);

            migrationBuilder.DeleteData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 1215);

            migrationBuilder.DeleteData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 1216);

            migrationBuilder.DeleteData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 1218);

            migrationBuilder.DeleteData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 1219);

            migrationBuilder.DeleteData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 1220);

            migrationBuilder.DeleteData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 1221);

            migrationBuilder.DeleteData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 1222);

            migrationBuilder.DeleteData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 1223);

            migrationBuilder.DeleteData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 1224);

            migrationBuilder.DeleteData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 1225);

            migrationBuilder.DeleteData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 1226);

            migrationBuilder.DeleteData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 1227);

            migrationBuilder.DeleteData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 1228);

            migrationBuilder.DeleteData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 1229);

            migrationBuilder.DeleteData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 1230);

            migrationBuilder.DeleteData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 1231);

            migrationBuilder.DeleteData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 1232);

            migrationBuilder.DeleteData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 1233);

            migrationBuilder.DeleteData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 1234);

            migrationBuilder.DeleteData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 1235);

            migrationBuilder.DeleteData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 1236);

            migrationBuilder.DeleteData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 1237);

            migrationBuilder.DeleteData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 1238);

            migrationBuilder.DeleteData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 1239);

            migrationBuilder.DeleteData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 1240);

            migrationBuilder.DeleteData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 1241);

            migrationBuilder.DeleteData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 1242);

            migrationBuilder.DeleteData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 1243);

            migrationBuilder.DeleteData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 1244);

            migrationBuilder.DeleteData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 1245);

            migrationBuilder.DeleteData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 1246);

            migrationBuilder.DeleteData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 1247);

            migrationBuilder.DeleteData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 1248);

            migrationBuilder.DeleteData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 1249);

            migrationBuilder.DeleteData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 1250);

            migrationBuilder.DeleteData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 1251);

            migrationBuilder.DeleteData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 1252);

            migrationBuilder.DeleteData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 1253);

            migrationBuilder.DeleteData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 1254);

            migrationBuilder.DeleteData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 1255);

            migrationBuilder.DeleteData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 1256);

            migrationBuilder.DeleteData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 1257);

            migrationBuilder.DeleteData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 1258);

            migrationBuilder.DeleteData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 1259);

            migrationBuilder.DeleteData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 1260);

            migrationBuilder.DeleteData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 1261);

            migrationBuilder.DeleteData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 1262);

            migrationBuilder.DeleteData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 1263);

            migrationBuilder.DeleteData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 1264);

            migrationBuilder.DeleteData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 1265);

            migrationBuilder.DeleteData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 1266);

            migrationBuilder.DeleteData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 1267);

            migrationBuilder.DeleteData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 1268);

            migrationBuilder.DeleteData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 1269);

            migrationBuilder.DeleteData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 1270);

            migrationBuilder.DeleteData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 1272);

            migrationBuilder.DeleteData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 1273);

            migrationBuilder.DeleteData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 1274);

            migrationBuilder.DeleteData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 1275);

            migrationBuilder.DeleteData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 1276);

            migrationBuilder.DeleteData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 1277);

            migrationBuilder.DeleteData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 1278);

            migrationBuilder.DeleteData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 1279);

            migrationBuilder.DeleteData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 1280);

            migrationBuilder.DeleteData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 1281);

            migrationBuilder.DeleteData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 1282);

            migrationBuilder.DeleteData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 1283);

            migrationBuilder.DeleteData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 1285);

            migrationBuilder.DeleteData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 1286);

            migrationBuilder.DeleteData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 1287);

            migrationBuilder.DeleteData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 1288);

            migrationBuilder.DeleteData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 1289);

            migrationBuilder.DeleteData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 1290);

            migrationBuilder.DeleteData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 1291);

            migrationBuilder.DeleteData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 1292);

            migrationBuilder.DeleteData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 1293);

            migrationBuilder.DeleteData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 1294);

            migrationBuilder.DeleteData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 1295);

            migrationBuilder.DeleteData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 1296);

            migrationBuilder.DeleteData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 1297);

            migrationBuilder.DeleteData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 1298);

            migrationBuilder.DeleteData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 1299);

            migrationBuilder.DeleteData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 1300);

            migrationBuilder.DeleteData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 1301);

            migrationBuilder.DeleteData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 1302);

            migrationBuilder.DeleteData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 1303);

            migrationBuilder.DeleteData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 1304);

            migrationBuilder.DeleteData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 1306);

            migrationBuilder.DeleteData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 1307);

            migrationBuilder.DeleteData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 1308);

            migrationBuilder.DeleteData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 1309);

            migrationBuilder.DeleteData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 1310);

            migrationBuilder.DeleteData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 1311);

            migrationBuilder.DeleteData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 1312);

            migrationBuilder.DeleteData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 1313);

            migrationBuilder.DeleteData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 1314);

            migrationBuilder.DeleteData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 1315);

            migrationBuilder.DeleteData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 1316);

            migrationBuilder.DeleteData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 1317);

            migrationBuilder.DeleteData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 1318);

            migrationBuilder.DeleteData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 1320);

            migrationBuilder.DeleteData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 1321);

            migrationBuilder.DeleteData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 1323);

            migrationBuilder.DeleteData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 1324);

            migrationBuilder.DeleteData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 1325);

            migrationBuilder.DeleteData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 1326);

            migrationBuilder.DeleteData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 1327);

            migrationBuilder.DeleteData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 1328);

            migrationBuilder.DeleteData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 1329);

            migrationBuilder.DeleteData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 1330);

            migrationBuilder.DeleteData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 1331);

            migrationBuilder.DeleteData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 1332);

            migrationBuilder.DeleteData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 1333);

            migrationBuilder.DeleteData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 1334);

            migrationBuilder.DeleteData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 1336);

            migrationBuilder.DeleteData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 1337);

            migrationBuilder.DeleteData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 1338);

            migrationBuilder.DeleteData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 1339);

            migrationBuilder.DeleteData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 1340);

            migrationBuilder.DeleteData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 1341);

            migrationBuilder.DeleteData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 1342);

            migrationBuilder.DeleteData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 1343);

            migrationBuilder.DeleteData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 1344);

            migrationBuilder.DeleteData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 1345);

            migrationBuilder.DeleteData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 1346);

            migrationBuilder.DeleteData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 1347);

            migrationBuilder.DeleteData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 1348);

            migrationBuilder.DeleteData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 1349);

            migrationBuilder.DeleteData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 1350);

            migrationBuilder.DeleteData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 1351);

            migrationBuilder.DeleteData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 1352);

            migrationBuilder.DeleteData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 1353);

            migrationBuilder.DeleteData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 1354);

            migrationBuilder.DeleteData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 1355);

            migrationBuilder.DeleteData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 1356);

            migrationBuilder.DeleteData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 1357);

            migrationBuilder.DeleteData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 1358);

            migrationBuilder.DeleteData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 1359);

            migrationBuilder.DeleteData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 1360);

            migrationBuilder.DeleteData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 1361);

            migrationBuilder.DeleteData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 1362);

            migrationBuilder.DeleteData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 1363);

            migrationBuilder.DeleteData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 1364);

            migrationBuilder.DeleteData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 1365);

            migrationBuilder.DeleteData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 1366);

            migrationBuilder.DeleteData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 1367);

            migrationBuilder.DeleteData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 1368);

            migrationBuilder.DeleteData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 1369);

            migrationBuilder.DeleteData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 1370);

            migrationBuilder.DeleteData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 1371);

            migrationBuilder.DeleteData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 1372);

            migrationBuilder.DeleteData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 1373);

            migrationBuilder.DeleteData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 1374);

            migrationBuilder.DeleteData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 1375);

            migrationBuilder.DeleteData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 1376);

            migrationBuilder.DeleteData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 1377);

            migrationBuilder.DeleteData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 1378);

            migrationBuilder.DeleteData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 1379);

            migrationBuilder.DeleteData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 1380);

            migrationBuilder.DeleteData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 1381);

            migrationBuilder.DeleteData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 1382);

            migrationBuilder.DeleteData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 1384);

            migrationBuilder.DeleteData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 1385);

            migrationBuilder.DeleteData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 1386);

            migrationBuilder.DeleteData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 1387);

            migrationBuilder.DeleteData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 1388);

            migrationBuilder.DeleteData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 1389);

            migrationBuilder.DeleteData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 1390);

            migrationBuilder.DeleteData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 1391);

            migrationBuilder.DeleteData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 1392);

            migrationBuilder.DeleteData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 1393);

            migrationBuilder.DeleteData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 1394);

            migrationBuilder.DeleteData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 1395);

            migrationBuilder.DeleteData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 1396);

            migrationBuilder.DeleteData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 1397);

            migrationBuilder.DeleteData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 1398);

            migrationBuilder.DeleteData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 1399);

            migrationBuilder.DeleteData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 1400);

            migrationBuilder.DeleteData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 1401);

            migrationBuilder.DeleteData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 1403);

            migrationBuilder.DeleteData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 1404);

            migrationBuilder.DeleteData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 1405);

            migrationBuilder.DeleteData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 1406);

            migrationBuilder.DeleteData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 1407);

            migrationBuilder.DeleteData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 1408);

            migrationBuilder.DeleteData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 1409);

            migrationBuilder.DeleteData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 1410);

            migrationBuilder.DeleteData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 1411);

            migrationBuilder.DeleteData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 1412);

            migrationBuilder.DeleteData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 1413);

            migrationBuilder.DeleteData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 1414);

            migrationBuilder.DeleteData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 1415);

            migrationBuilder.DeleteData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 1416);

            migrationBuilder.DeleteData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 1418);

            migrationBuilder.DeleteData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 1420);

            migrationBuilder.DeleteData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 1421);

            migrationBuilder.DeleteData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 1422);

            migrationBuilder.DeleteData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 1423);

            migrationBuilder.DeleteData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 1424);

            migrationBuilder.DeleteData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 1425);

            migrationBuilder.DeleteData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 1426);

            migrationBuilder.DeleteData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 1427);

            migrationBuilder.DeleteData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 1428);

            migrationBuilder.DeleteData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 1429);

            migrationBuilder.DeleteData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 1430);

            migrationBuilder.DeleteData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 1431);

            migrationBuilder.DeleteData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 1432);

            migrationBuilder.DeleteData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 1433);

            migrationBuilder.DeleteData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 1434);

            migrationBuilder.DeleteData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 1435);

            migrationBuilder.DeleteData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 1436);

            migrationBuilder.DeleteData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 1437);

            migrationBuilder.DeleteData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 1438);

            migrationBuilder.DeleteData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 1439);

            migrationBuilder.DeleteData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 1440);

            migrationBuilder.DeleteData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 1441);

            migrationBuilder.DeleteData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 1442);

            migrationBuilder.DeleteData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 1443);

            migrationBuilder.DeleteData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 1444);

            migrationBuilder.DeleteData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 1445);

            migrationBuilder.DeleteData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 1446);

            migrationBuilder.DeleteData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 1447);

            migrationBuilder.DeleteData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 1448);

            migrationBuilder.DeleteData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 1449);

            migrationBuilder.DeleteData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 1450);

            migrationBuilder.DeleteData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 1451);

            migrationBuilder.DeleteData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 1452);

            migrationBuilder.DeleteData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 1453);

            migrationBuilder.DeleteData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 1455);

            migrationBuilder.DeleteData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 1456);

            migrationBuilder.DeleteData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 1457);

            migrationBuilder.DeleteData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 1458);

            migrationBuilder.DeleteData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 1459);

            migrationBuilder.DeleteData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 1460);

            migrationBuilder.DeleteData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 1461);

            migrationBuilder.DeleteData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 1462);

            migrationBuilder.DeleteData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 1463);

            migrationBuilder.DeleteData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 1464);

            migrationBuilder.DeleteData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 1465);

            migrationBuilder.DeleteData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 1466);

            migrationBuilder.DeleteData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 1467);

            migrationBuilder.DeleteData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 1468);

            migrationBuilder.DeleteData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 1469);

            migrationBuilder.DeleteData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 1470);

            migrationBuilder.DeleteData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 1471);

            migrationBuilder.DeleteData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 1472);

            migrationBuilder.DeleteData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 1473);

            migrationBuilder.DeleteData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 1474);

            migrationBuilder.DeleteData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 1475);

            migrationBuilder.DeleteData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 1476);

            migrationBuilder.DeleteData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 1477);

            migrationBuilder.DeleteData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 1479);

            migrationBuilder.DeleteData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 1480);

            migrationBuilder.DeleteData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 1482);

            migrationBuilder.DeleteData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 1483);

            migrationBuilder.DeleteData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 1484);

            migrationBuilder.DeleteData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 1485);

            migrationBuilder.DeleteData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 1486);

            migrationBuilder.DeleteData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 1487);

            migrationBuilder.DeleteData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 1488);

            migrationBuilder.DeleteData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 1489);

            migrationBuilder.DeleteData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 1490);

            migrationBuilder.DeleteData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 1491);

            migrationBuilder.DeleteData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 1492);

            migrationBuilder.DeleteData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 1493);

            migrationBuilder.DeleteData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 1494);

            migrationBuilder.DeleteData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 1495);

            migrationBuilder.DeleteData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 1496);

            migrationBuilder.DeleteData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 1497);

            migrationBuilder.DeleteData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 1498);

            migrationBuilder.DeleteData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 1499);

            migrationBuilder.DeleteData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 1500);

            migrationBuilder.DeleteData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 1501);

            migrationBuilder.DeleteData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 1502);

            migrationBuilder.DeleteData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 1503);

            migrationBuilder.DeleteData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 1504);

            migrationBuilder.DeleteData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 1505);

            migrationBuilder.DeleteData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 1506);

            migrationBuilder.DeleteData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 1507);

            migrationBuilder.DeleteData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 1508);

            migrationBuilder.DeleteData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 1510);

            migrationBuilder.DeleteData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 1511);

            migrationBuilder.DeleteData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 1512);

            migrationBuilder.DeleteData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 1514);

            migrationBuilder.DeleteData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 1517);

            migrationBuilder.DeleteData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 1518);

            migrationBuilder.DeleteData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 1519);

            migrationBuilder.DeleteData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 1520);

            migrationBuilder.DeleteData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 1521);

            migrationBuilder.DeleteData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 1522);

            migrationBuilder.DeleteData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 1523);

            migrationBuilder.DeleteData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 1524);

            migrationBuilder.DeleteData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 1525);

            migrationBuilder.DeleteData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 1526);

            migrationBuilder.DeleteData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 1527);

            migrationBuilder.DeleteData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 1528);

            migrationBuilder.DeleteData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 1529);

            migrationBuilder.DeleteData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 1530);

            migrationBuilder.DeleteData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 1531);

            migrationBuilder.DeleteData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 1533);

            migrationBuilder.DeleteData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 1534);

            migrationBuilder.DeleteData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 1535);

            migrationBuilder.DeleteData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 1536);

            migrationBuilder.DeleteData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 1537);

            migrationBuilder.DeleteData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 1538);

            migrationBuilder.DeleteData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 1539);

            migrationBuilder.DeleteData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 1540);

            migrationBuilder.DeleteData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 1541);

            migrationBuilder.DeleteData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 1542);

            migrationBuilder.DeleteData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 1543);

            migrationBuilder.DeleteData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 1544);

            migrationBuilder.DeleteData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 1545);

            migrationBuilder.DeleteData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 1546);

            migrationBuilder.DeleteData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 1547);

            migrationBuilder.DeleteData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 1548);

            migrationBuilder.DeleteData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 1549);

            migrationBuilder.DeleteData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 1550);

            migrationBuilder.DeleteData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 1551);

            migrationBuilder.DeleteData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 1553);

            migrationBuilder.DeleteData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 1554);

            migrationBuilder.DeleteData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 1555);

            migrationBuilder.DeleteData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 1556);

            migrationBuilder.DeleteData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 1557);

            migrationBuilder.DeleteData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 1558);

            migrationBuilder.DeleteData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 1559);

            migrationBuilder.DeleteData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 1560);

            migrationBuilder.DeleteData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 1561);

            migrationBuilder.DeleteData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 1562);

            migrationBuilder.DeleteData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 1563);

            migrationBuilder.DeleteData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 1564);

            migrationBuilder.DeleteData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 1565);

            migrationBuilder.DeleteData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 1566);

            migrationBuilder.DeleteData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 1567);

            migrationBuilder.DeleteData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 1568);

            migrationBuilder.DeleteData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 1569);

            migrationBuilder.DeleteData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 1570);

            migrationBuilder.DeleteData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 1571);

            migrationBuilder.DeleteData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 1572);

            migrationBuilder.DeleteData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 1573);

            migrationBuilder.DeleteData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 1574);

            migrationBuilder.DeleteData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 1575);

            migrationBuilder.DeleteData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 1576);

            migrationBuilder.DeleteData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 1577);

            migrationBuilder.DeleteData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 1578);

            migrationBuilder.DeleteData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 1579);

            migrationBuilder.DeleteData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 1580);

            migrationBuilder.DeleteData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 1581);

            migrationBuilder.DeleteData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 1582);

            migrationBuilder.DeleteData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 1583);

            migrationBuilder.DeleteData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 1584);

            migrationBuilder.DeleteData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 1585);

            migrationBuilder.DeleteData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 1586);

            migrationBuilder.DeleteData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 1587);

            migrationBuilder.DeleteData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 1588);

            migrationBuilder.DeleteData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 1590);

            migrationBuilder.DeleteData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 1591);

            migrationBuilder.DeleteData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 1592);

            migrationBuilder.DeleteData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 1594);

            migrationBuilder.DeleteData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 1595);

            migrationBuilder.DeleteData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 1596);

            migrationBuilder.DeleteData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 1597);

            migrationBuilder.DeleteData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 1598);

            migrationBuilder.DeleteData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 1599);

            migrationBuilder.DeleteData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 1600);

            migrationBuilder.DeleteData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 1601);

            migrationBuilder.DeleteData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 1602);

            migrationBuilder.DeleteData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 1603);

            migrationBuilder.DeleteData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 1604);

            migrationBuilder.DeleteData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 1605);

            migrationBuilder.DeleteData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 1606);

            migrationBuilder.DeleteData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 1607);

            migrationBuilder.DeleteData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 1608);

            migrationBuilder.DeleteData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 1609);

            migrationBuilder.DeleteData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 1610);

            migrationBuilder.DeleteData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 1611);

            migrationBuilder.DeleteData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 1612);

            migrationBuilder.DeleteData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 1613);

            migrationBuilder.DeleteData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 1614);

            migrationBuilder.DeleteData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 1615);

            migrationBuilder.DeleteData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 1616);

            migrationBuilder.DeleteData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 1617);

            migrationBuilder.DeleteData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 1618);

            migrationBuilder.DeleteData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 1619);

            migrationBuilder.DeleteData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 1620);

            migrationBuilder.DeleteData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 1621);

            migrationBuilder.DeleteData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 1622);

            migrationBuilder.DeleteData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 1623);

            migrationBuilder.DeleteData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 1624);

            migrationBuilder.DeleteData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 1625);

            migrationBuilder.DeleteData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 1626);

            migrationBuilder.DeleteData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 1627);

            migrationBuilder.DeleteData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 1628);

            migrationBuilder.DeleteData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 1629);

            migrationBuilder.DeleteData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 1630);

            migrationBuilder.DeleteData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 1631);

            migrationBuilder.DeleteData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 1632);

            migrationBuilder.DeleteData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 1633);

            migrationBuilder.DeleteData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 1634);

            migrationBuilder.DeleteData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 1635);

            migrationBuilder.DeleteData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 1636);

            migrationBuilder.DeleteData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 1637);

            migrationBuilder.DeleteData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 1638);

            migrationBuilder.DeleteData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 1639);

            migrationBuilder.DeleteData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 1640);

            migrationBuilder.DeleteData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 1641);

            migrationBuilder.DeleteData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 1642);

            migrationBuilder.DeleteData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 1643);

            migrationBuilder.DeleteData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 1644);

            migrationBuilder.DeleteData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 1645);

            migrationBuilder.DeleteData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 1646);

            migrationBuilder.DeleteData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 1647);

            migrationBuilder.DeleteData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 1648);

            migrationBuilder.DeleteData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 1649);

            migrationBuilder.DeleteData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 1650);

            migrationBuilder.DeleteData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 1651);

            migrationBuilder.DeleteData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 1652);

            migrationBuilder.DeleteData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 1653);

            migrationBuilder.DeleteData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 1654);

            migrationBuilder.DeleteData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 1655);

            migrationBuilder.DeleteData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 1656);

            migrationBuilder.DeleteData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 1657);

            migrationBuilder.DeleteData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 1658);

            migrationBuilder.DeleteData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 1659);

            migrationBuilder.DeleteData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 1660);

            migrationBuilder.DeleteData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 1661);

            migrationBuilder.DeleteData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 1662);

            migrationBuilder.DeleteData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 1663);

            migrationBuilder.DeleteData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 1664);

            migrationBuilder.DeleteData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 1665);

            migrationBuilder.DeleteData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 1666);

            migrationBuilder.DeleteData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 1667);

            migrationBuilder.DeleteData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 1668);

            migrationBuilder.DeleteData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 1669);

            migrationBuilder.DeleteData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 1670);

            migrationBuilder.DeleteData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 1671);

            migrationBuilder.DeleteData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 1672);

            migrationBuilder.DeleteData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 1674);

            migrationBuilder.DeleteData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 1675);

            migrationBuilder.DeleteData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 1676);

            migrationBuilder.DeleteData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 1677);

            migrationBuilder.DeleteData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 1678);

            migrationBuilder.DeleteData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 1679);

            migrationBuilder.DeleteData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 1680);

            migrationBuilder.DeleteData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 1681);

            migrationBuilder.DeleteData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 1682);

            migrationBuilder.DeleteData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 1683);

            migrationBuilder.DeleteData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 1684);

            migrationBuilder.DeleteData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 1685);

            migrationBuilder.DeleteData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 1687);

            migrationBuilder.DeleteData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 1688);

            migrationBuilder.DeleteData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 1689);

            migrationBuilder.DeleteData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 1690);

            migrationBuilder.DeleteData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 1691);

            migrationBuilder.DeleteData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 1692);

            migrationBuilder.DeleteData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 1693);

            migrationBuilder.DeleteData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 1694);

            migrationBuilder.DeleteData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 1695);

            migrationBuilder.DeleteData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 1696);

            migrationBuilder.DeleteData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 1697);

            migrationBuilder.DeleteData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 1698);

            migrationBuilder.DeleteData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 1699);

            migrationBuilder.DeleteData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 1700);

            migrationBuilder.DeleteData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 1701);

            migrationBuilder.DeleteData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 1703);

            migrationBuilder.DeleteData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 1704);

            migrationBuilder.DeleteData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 1705);

            migrationBuilder.DeleteData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 1706);

            migrationBuilder.DeleteData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 1707);

            migrationBuilder.DeleteData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 1708);

            migrationBuilder.DeleteData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 1709);

            migrationBuilder.DeleteData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 1711);

            migrationBuilder.DeleteData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 1712);

            migrationBuilder.DeleteData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 1713);

            migrationBuilder.DeleteData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 1714);

            migrationBuilder.DeleteData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 1715);

            migrationBuilder.DeleteData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 1716);

            migrationBuilder.DeleteData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 1717);

            migrationBuilder.DeleteData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 1718);

            migrationBuilder.DeleteData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 1719);

            migrationBuilder.DeleteData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 1720);

            migrationBuilder.DeleteData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 1721);

            migrationBuilder.DeleteData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 1722);

            migrationBuilder.DeleteData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 1723);

            migrationBuilder.DeleteData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 1724);

            migrationBuilder.DeleteData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 1725);

            migrationBuilder.DeleteData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 1726);

            migrationBuilder.DeleteData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 1727);

            migrationBuilder.DeleteData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 1728);

            migrationBuilder.DeleteData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 1729);

            migrationBuilder.DeleteData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 1730);

            migrationBuilder.DeleteData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 1731);

            migrationBuilder.DeleteData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 1732);

            migrationBuilder.DeleteData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 1733);

            migrationBuilder.DeleteData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 1734);

            migrationBuilder.DeleteData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 1735);

            migrationBuilder.DeleteData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 1736);

            migrationBuilder.DeleteData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 1737);

            migrationBuilder.DeleteData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 1738);

            migrationBuilder.DeleteData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 1739);

            migrationBuilder.DeleteData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 1740);

            migrationBuilder.DeleteData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 1741);

            migrationBuilder.DeleteData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 1742);

            migrationBuilder.DeleteData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 1743);

            migrationBuilder.DeleteData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 1744);

            migrationBuilder.DeleteData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 1745);

            migrationBuilder.DeleteData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 1746);

            migrationBuilder.DeleteData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 1747);

            migrationBuilder.DeleteData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 1748);

            migrationBuilder.DeleteData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 1749);

            migrationBuilder.DeleteData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 1750);

            migrationBuilder.DeleteData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 1751);

            migrationBuilder.DeleteData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 1752);

            migrationBuilder.DeleteData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 1753);

            migrationBuilder.DeleteData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 1754);

            migrationBuilder.DeleteData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 1755);

            migrationBuilder.DeleteData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 1756);

            migrationBuilder.DeleteData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 1757);

            migrationBuilder.DeleteData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 1758);

            migrationBuilder.DeleteData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 1759);

            migrationBuilder.DeleteData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 1760);

            migrationBuilder.DeleteData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 1761);

            migrationBuilder.DeleteData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 1762);

            migrationBuilder.DeleteData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 1763);

            migrationBuilder.DeleteData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 1764);

            migrationBuilder.DeleteData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 1765);

            migrationBuilder.DeleteData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 1766);

            migrationBuilder.DeleteData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 1767);

            migrationBuilder.DeleteData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 1768);

            migrationBuilder.DeleteData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 1769);

            migrationBuilder.DeleteData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 1770);

            migrationBuilder.DeleteData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 1771);

            migrationBuilder.DeleteData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 1772);

            migrationBuilder.DeleteData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 1773);

            migrationBuilder.DeleteData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 1774);

            migrationBuilder.DeleteData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 1775);

            migrationBuilder.DeleteData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 1776);

            migrationBuilder.DeleteData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 1777);

            migrationBuilder.DeleteData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 1778);

            migrationBuilder.DeleteData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 1779);

            migrationBuilder.DeleteData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 1780);

            migrationBuilder.DeleteData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 1781);

            migrationBuilder.DeleteData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 1782);

            migrationBuilder.DeleteData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 1783);

            migrationBuilder.DeleteData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 1784);

            migrationBuilder.DeleteData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 1785);

            migrationBuilder.DeleteData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 1786);

            migrationBuilder.DeleteData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 1787);

            migrationBuilder.DeleteData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 1788);

            migrationBuilder.DeleteData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 1789);

            migrationBuilder.DeleteData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 1790);

            migrationBuilder.DeleteData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 1791);

            migrationBuilder.DeleteData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 1792);

            migrationBuilder.DeleteData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 1793);

            migrationBuilder.DeleteData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 1794);

            migrationBuilder.DeleteData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 1795);

            migrationBuilder.DeleteData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 1796);

            migrationBuilder.DeleteData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 1797);

            migrationBuilder.DeleteData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 1798);

            migrationBuilder.DeleteData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 1799);

            migrationBuilder.DeleteData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 1800);

            migrationBuilder.DeleteData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 1801);

            migrationBuilder.DeleteData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 1802);

            migrationBuilder.DeleteData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 1803);

            migrationBuilder.DeleteData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 1804);

            migrationBuilder.DeleteData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 1805);

            migrationBuilder.DeleteData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 1806);

            migrationBuilder.DeleteData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 1807);

            migrationBuilder.DeleteData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 1808);

            migrationBuilder.DeleteData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 1809);

            migrationBuilder.DeleteData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 1810);

            migrationBuilder.DeleteData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 1811);

            migrationBuilder.DeleteData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 1812);

            migrationBuilder.DeleteData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 1813);

            migrationBuilder.DeleteData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 1814);

            migrationBuilder.DeleteData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 1815);

            migrationBuilder.DeleteData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 1816);

            migrationBuilder.DeleteData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 1817);

            migrationBuilder.DeleteData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 1818);

            migrationBuilder.DeleteData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 1819);

            migrationBuilder.DeleteData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 1820);

            migrationBuilder.DeleteData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 1821);

            migrationBuilder.DeleteData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 1822);

            migrationBuilder.DeleteData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 1823);

            migrationBuilder.DeleteData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 1824);

            migrationBuilder.DeleteData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 1825);

            migrationBuilder.DeleteData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 1826);

            migrationBuilder.DeleteData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 1827);

            migrationBuilder.DeleteData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 1828);

            migrationBuilder.DeleteData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 1829);

            migrationBuilder.DeleteData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 1830);

            migrationBuilder.DeleteData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 1831);

            migrationBuilder.DeleteData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 1832);

            migrationBuilder.DeleteData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 1833);

            migrationBuilder.DeleteData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 1834);

            migrationBuilder.DeleteData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 1835);

            migrationBuilder.DeleteData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 1836);

            migrationBuilder.DeleteData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 1837);

            migrationBuilder.DeleteData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 1838);

            migrationBuilder.DeleteData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 1839);

            migrationBuilder.DeleteData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 1840);

            migrationBuilder.DeleteData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 1841);

            migrationBuilder.DeleteData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 1842);

            migrationBuilder.DeleteData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 1843);

            migrationBuilder.DeleteData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 1844);

            migrationBuilder.DeleteData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 1845);

            migrationBuilder.DeleteData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 1846);

            migrationBuilder.DeleteData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 1847);

            migrationBuilder.DeleteData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 1848);

            migrationBuilder.DeleteData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 1849);

            migrationBuilder.DeleteData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 1850);

            migrationBuilder.DeleteData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 1851);

            migrationBuilder.DeleteData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 1852);

            migrationBuilder.DeleteData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 1853);

            migrationBuilder.DeleteData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 1854);

            migrationBuilder.DeleteData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 1855);

            migrationBuilder.DeleteData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 1856);

            migrationBuilder.DeleteData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 1857);

            migrationBuilder.DeleteData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 1858);

            migrationBuilder.DeleteData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 1859);

            migrationBuilder.DeleteData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 1860);

            migrationBuilder.DeleteData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 1861);

            migrationBuilder.DeleteData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 1862);

            migrationBuilder.DeleteData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 1863);

            migrationBuilder.DeleteData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 1864);

            migrationBuilder.DeleteData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 1865);

            migrationBuilder.DeleteData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 1866);

            migrationBuilder.DeleteData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 1867);

            migrationBuilder.DeleteData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 1868);

            migrationBuilder.DeleteData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 1869);

            migrationBuilder.DeleteData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 1870);

            migrationBuilder.DeleteData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 1871);

            migrationBuilder.DeleteData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 1872);

            migrationBuilder.DeleteData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 1873);

            migrationBuilder.DeleteData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 1874);

            migrationBuilder.DeleteData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 1875);

            migrationBuilder.DeleteData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 1876);

            migrationBuilder.DeleteData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 1877);

            migrationBuilder.DeleteData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 1878);

            migrationBuilder.DeleteData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 1879);

            migrationBuilder.DeleteData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 1880);

            migrationBuilder.DeleteData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 1881);

            migrationBuilder.DeleteData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 1882);

            migrationBuilder.DeleteData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 1883);

            migrationBuilder.DeleteData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 1884);

            migrationBuilder.DeleteData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 1885);

            migrationBuilder.DeleteData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 1886);

            migrationBuilder.DeleteData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 1887);

            migrationBuilder.DeleteData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 1888);

            migrationBuilder.DeleteData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 1889);

            migrationBuilder.DeleteData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 1890);

            migrationBuilder.DeleteData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 1891);

            migrationBuilder.DeleteData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 1892);

            migrationBuilder.DeleteData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 1893);

            migrationBuilder.DeleteData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 1894);

            migrationBuilder.DeleteData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 1895);

            migrationBuilder.DeleteData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 1896);

            migrationBuilder.DeleteData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 1897);

            migrationBuilder.DeleteData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 1898);

            migrationBuilder.DeleteData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 1899);

            migrationBuilder.DeleteData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 1900);

            migrationBuilder.DeleteData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 1901);

            migrationBuilder.DeleteData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 1902);

            migrationBuilder.DeleteData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 1903);

            migrationBuilder.DeleteData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 1904);

            migrationBuilder.DeleteData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 1905);

            migrationBuilder.DeleteData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 1906);

            migrationBuilder.DeleteData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 1907);

            migrationBuilder.DeleteData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 1908);

            migrationBuilder.DeleteData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 1909);

            migrationBuilder.DeleteData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 1910);

            migrationBuilder.DeleteData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 1911);

            migrationBuilder.DeleteData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 1912);

            migrationBuilder.DeleteData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 1913);

            migrationBuilder.DeleteData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 1914);

            migrationBuilder.DeleteData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 1915);

            migrationBuilder.DeleteData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 1916);

            migrationBuilder.DeleteData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 1917);

            migrationBuilder.DeleteData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 1918);

            migrationBuilder.DeleteData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 1919);

            migrationBuilder.DeleteData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 1920);

            migrationBuilder.DeleteData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 1921);

            migrationBuilder.DeleteData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 1922);

            migrationBuilder.DeleteData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 1923);

            migrationBuilder.DeleteData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 1924);

            migrationBuilder.DeleteData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 1925);

            migrationBuilder.DeleteData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 1926);

            migrationBuilder.DeleteData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 1927);

            migrationBuilder.DeleteData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 1928);

            migrationBuilder.DeleteData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 1929);

            migrationBuilder.DeleteData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 1930);

            migrationBuilder.DeleteData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 1931);

            migrationBuilder.DeleteData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 1932);

            migrationBuilder.DeleteData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 1933);

            migrationBuilder.DeleteData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 1934);

            migrationBuilder.DeleteData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 1935);

            migrationBuilder.DeleteData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 1936);

            migrationBuilder.DeleteData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 1937);

            migrationBuilder.DeleteData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 1938);

            migrationBuilder.DeleteData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 1939);

            migrationBuilder.DeleteData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 1940);

            migrationBuilder.DeleteData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 1941);

            migrationBuilder.DeleteData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 1942);

            migrationBuilder.DeleteData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 1943);

            migrationBuilder.DeleteData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 1944);

            migrationBuilder.DeleteData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 1945);

            migrationBuilder.DeleteData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 1946);

            migrationBuilder.DeleteData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 1947);

            migrationBuilder.DeleteData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 1948);

            migrationBuilder.DeleteData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 1949);

            migrationBuilder.DeleteData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 1950);

            migrationBuilder.DeleteData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 1951);

            migrationBuilder.DeleteData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 1952);

            migrationBuilder.DeleteData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 1953);

            migrationBuilder.DeleteData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 1954);

            migrationBuilder.DeleteData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 1955);

            migrationBuilder.DeleteData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 1956);

            migrationBuilder.DeleteData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 1957);

            migrationBuilder.DeleteData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 1958);

            migrationBuilder.DeleteData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 1959);

            migrationBuilder.DeleteData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 1960);

            migrationBuilder.DeleteData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 1961);

            migrationBuilder.DeleteData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 1962);

            migrationBuilder.DeleteData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 1963);

            migrationBuilder.DeleteData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 1964);

            migrationBuilder.DeleteData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 1965);

            migrationBuilder.DeleteData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 1966);

            migrationBuilder.DeleteData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 1967);

            migrationBuilder.DeleteData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 1968);

            migrationBuilder.DeleteData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 1969);

            migrationBuilder.DeleteData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 1970);

            migrationBuilder.DeleteData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 1971);

            migrationBuilder.DeleteData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 1972);

            migrationBuilder.DeleteData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 1973);

            migrationBuilder.DeleteData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 1974);

            migrationBuilder.DeleteData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 1975);

            migrationBuilder.DeleteData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 1976);

            migrationBuilder.DeleteData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 1977);

            migrationBuilder.DeleteData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 1978);

            migrationBuilder.DeleteData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 1979);

            migrationBuilder.DeleteData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 1980);

            migrationBuilder.DeleteData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 1981);

            migrationBuilder.DeleteData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 1982);

            migrationBuilder.DeleteData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 1983);

            migrationBuilder.DeleteData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 1984);

            migrationBuilder.DeleteData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 1985);

            migrationBuilder.DeleteData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 1986);

            migrationBuilder.DeleteData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 1987);

            migrationBuilder.DeleteData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 1988);

            migrationBuilder.DeleteData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 1989);

            migrationBuilder.DeleteData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 1990);

            migrationBuilder.DeleteData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 1991);

            migrationBuilder.DeleteData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 1992);

            migrationBuilder.DeleteData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 1993);

            migrationBuilder.DeleteData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 1994);

            migrationBuilder.DeleteData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 1995);

            migrationBuilder.DeleteData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 1996);

            migrationBuilder.DeleteData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 1997);

            migrationBuilder.DeleteData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 1998);

            migrationBuilder.DeleteData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 2000);

            migrationBuilder.DeleteData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 2001);

            migrationBuilder.DeleteData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 2002);

            migrationBuilder.DeleteData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 2003);

            migrationBuilder.DeleteData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 2004);

            migrationBuilder.DeleteData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 2005);

            migrationBuilder.DeleteData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 2006);

            migrationBuilder.DeleteData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 2007);

            migrationBuilder.DeleteData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 2008);

            migrationBuilder.DeleteData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 2009);

            migrationBuilder.DeleteData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 2010);

            migrationBuilder.DeleteData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 2011);

            migrationBuilder.DeleteData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 2012);

            migrationBuilder.DeleteData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 2013);

            migrationBuilder.DeleteData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 2014);

            migrationBuilder.DeleteData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 2015);

            migrationBuilder.DeleteData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 2016);

            migrationBuilder.DeleteData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 2017);

            migrationBuilder.DeleteData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 2018);

            migrationBuilder.DeleteData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 2019);

            migrationBuilder.DeleteData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 2020);

            migrationBuilder.DeleteData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 2021);

            migrationBuilder.DeleteData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 2022);

            migrationBuilder.DeleteData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 2023);

            migrationBuilder.DeleteData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 2024);

            migrationBuilder.DeleteData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 2025);

            migrationBuilder.DeleteData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 2026);

            migrationBuilder.DeleteData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 2027);

            migrationBuilder.DeleteData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 2028);

            migrationBuilder.DeleteData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 2029);

            migrationBuilder.DeleteData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 2030);

            migrationBuilder.DeleteData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 2031);

            migrationBuilder.DeleteData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 2032);

            migrationBuilder.DeleteData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 2033);

            migrationBuilder.DeleteData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 2034);

            migrationBuilder.DeleteData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 2035);

            migrationBuilder.DeleteData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 2036);

            migrationBuilder.DeleteData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 2037);

            migrationBuilder.DeleteData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 2038);

            migrationBuilder.DeleteData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 2039);

            migrationBuilder.DeleteData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 2040);

            migrationBuilder.DeleteData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 2041);

            migrationBuilder.DeleteData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 2042);

            migrationBuilder.DeleteData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 2043);

            migrationBuilder.DeleteData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 2044);

            migrationBuilder.DeleteData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 2045);

            migrationBuilder.DeleteData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 2046);

            migrationBuilder.DeleteData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 2047);

            migrationBuilder.DeleteData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 2048);

            migrationBuilder.DeleteData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 2049);

            migrationBuilder.DeleteData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 2050);

            migrationBuilder.DeleteData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 2051);

            migrationBuilder.DeleteData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 2052);

            migrationBuilder.DeleteData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 2053);

            migrationBuilder.DeleteData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 2054);

            migrationBuilder.DeleteData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 2055);

            migrationBuilder.DeleteData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 2056);

            migrationBuilder.DeleteData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 2057);

            migrationBuilder.DeleteData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 2058);

            migrationBuilder.DeleteData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 2059);

            migrationBuilder.DeleteData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 2060);

            migrationBuilder.DeleteData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 2061);

            migrationBuilder.DeleteData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 2062);

            migrationBuilder.DeleteData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 2063);

            migrationBuilder.DeleteData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 2064);

            migrationBuilder.DeleteData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 2065);

            migrationBuilder.DeleteData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 2066);

            migrationBuilder.DeleteData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 2067);

            migrationBuilder.DeleteData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 2068);

            migrationBuilder.DeleteData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 2069);

            migrationBuilder.DeleteData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 2070);

            migrationBuilder.DeleteData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 2071);

            migrationBuilder.DeleteData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 2072);

            migrationBuilder.DeleteData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 2073);

            migrationBuilder.DeleteData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 2074);

            migrationBuilder.DeleteData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 2076);

            migrationBuilder.DeleteData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 2077);

            migrationBuilder.DeleteData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 2078);

            migrationBuilder.DeleteData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 2079);

            migrationBuilder.DeleteData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 2080);

            migrationBuilder.DeleteData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 2081);

            migrationBuilder.DeleteData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 2082);

            migrationBuilder.DeleteData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 2083);

            migrationBuilder.DeleteData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 2084);

            migrationBuilder.DeleteData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 2085);

            migrationBuilder.DeleteData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 2086);

            migrationBuilder.DeleteData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 2087);

            migrationBuilder.DeleteData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 2088);

            migrationBuilder.DeleteData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 2089);

            migrationBuilder.DeleteData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 2090);

            migrationBuilder.DeleteData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 2091);

            migrationBuilder.DeleteData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 2092);

            migrationBuilder.DeleteData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 2093);

            migrationBuilder.DeleteData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 2094);

            migrationBuilder.DeleteData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 2095);

            migrationBuilder.DeleteData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 2096);

            migrationBuilder.DeleteData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 2097);

            migrationBuilder.DeleteData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 2098);

            migrationBuilder.DeleteData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 2099);

            migrationBuilder.DeleteData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 2100);

            migrationBuilder.DeleteData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 2101);

            migrationBuilder.DeleteData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 2103);

            migrationBuilder.DeleteData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 2105);

            migrationBuilder.DeleteData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 2106);

            migrationBuilder.DeleteData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 2107);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 30);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 31);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 32);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 33);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 34);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 35);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 36);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 37);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 38);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 39);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 40);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 41);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 42);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 43);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 44);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 45);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 46);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 47);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 48);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 49);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 50);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 51);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 52);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 53);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 54);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 55);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 56);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 57);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 58);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 59);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 60);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 61);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 62);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 63);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 64);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 65);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 66);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 67);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 68);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 69);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 70);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 71);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 72);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 73);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 74);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 75);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 76);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 77);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 78);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 79);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 80);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 81);

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 1,
                column: "Name",
                value: "İstanbul");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 2,
                column: "Name",
                value: "Ankara");

            migrationBuilder.InsertData(
                table: "Districts",
                columns: new[] { "Id", "CityId", "Name" },
                values: new object[,]
                {
                    { 1, 1, "Kadıköy" },
                    { 2, 1, "Beşiktaş" },
                    { 3, 2, "Çankaya" },
                    { 4, 2, "Keçiören" }
                });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                column: "PasswordHash",
                value: "$2a$11$QYXDsLu5H0W0OG277.R5ceMBhVHNW6FzYEMDnF.bKqDoH6N3RuDIC");
        }
    }
}
