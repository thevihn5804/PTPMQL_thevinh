namespace DEMOMVC.Models
{
    public class AutoGenerateCode
    {
        public string GenerateCode(string id)
        {

            if (string.IsNullOrEmpty(id))// Trả về mã được sinh ra dựa trên tham số đầu vào
            {
                return "PS001";
            }           
            string prefix = id.Substring(0, 2);//{ tách phần chữ và phần số từ id
            string numberPart = id.Substring(2);// }            
            int number = int.Parse(numberPart);// Tách chuyển phần text là số sag kiểu int  
            number += 1;// Tăng lên 1 đơn vị
            string newID = prefix + number.ToString("D3");// Ghép lại chữ và số 
            return newID; // trả về mã mới
        }
    }
}