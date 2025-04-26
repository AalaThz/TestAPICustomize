//using Microsoft.AspNetCore.Http;
//using Microsoft.AspNetCore.Identity.UI.V4.Pages.Account.Manage.Internal;
//using Microsoft.AspNetCore.Mvc;
//using TestAPICustomize.Models;

//namespace TestAPICustomize.Controllers
//{
//    //[Route("api/[controller]")]
//    [Route("api/v1/[controller]")]
//    [ApiController]
//    public class AuthController : ControllerBase
//    {
//        /// <summary>  
//        /// ورود به سیستم و تولید کد jwt  
//        /// </summary>  
//        /// <param name="model">مدل حاوی نام کاربری و رمز عبور</param>  
//        /// <response code="200">ایجاد توکن موفقیت‌آمیز</response>  
//        /// <response code="400">در صورتی که اطلاعات ورودی صحیح نیستند</response>  
//        [HttpPost("token")]
//        public IActionResult GenerateToken([FromBody] LoginModel model)
//        {
//            // منطق احراز هویت و تولید توکن  
//            var response = new AuthResponse
//            {
//                Success = true,
//                Message = "Token generated successfully",
//                Data = new AuthData
//                {
//                    Token = "your_jwt_token",
//                    ExpireDate = DateTime.UtcNow.AddHours(1).ToString("o")
//                }
//            };
//            return Ok(response);
//        }

//        /// <summary>  
//        /// تغییر رمز عبور  
//        /// </summary>  
//        /// <param name="model">مدل حاوی رمز عبور فعلی و جدید</param>  
//        [HttpPost("ChangePassword")]
//        public IActionResult ChangePassword([FromBody] ChangePasswordModel model)
//        {
//            // منطق تغییر رمز عبور  
//            return Ok(new { Message = "Password changed successfully" });
//        }

//        /// <summary>  
//        /// نمایش روش‌های ارسال رمز عبور  
//        /// </summary>  
//        [HttpPost("ResetPasswordTypes")]
//        public IActionResult ResetPasswordTypes()
//        {
//            // منطق نمایش روش‌های ارسال رمز عبور  
//            return Ok(new { Message = "Reset password types" });
//        }
//    }
//}
