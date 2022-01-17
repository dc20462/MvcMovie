using Microsoft.AspNetCore.Mvc;
using System.Text.Encodings.Web;

namespace MvcMovie.Controllers
{
    // HelloWorld 컨트롤러
    public class HelloWorldController : Controller
    {
        // Index 작업 메서드 (무지정은 자동 Index)
        // ActionResult에서 파생된 클래스 또는 IActionResult를 반환
        // view 템플릿을 사용하도록 컨트롤러 변경함.
        // 동적 응답을 생성.컨트롤러에서 뷰로 적절한 데이터를 전달
        // GET: /HelloWorld/ 
        public IActionResult Index()
        {
            return View(); // 컨트롤러의 View 메서드 호출, 뷰 템플릿을 사용해 HTML 응답 생성
        }

        // 초기 Index 메서드 : 문자열 반환
        /* public string Index()
         {
             return "This is my default action...";
         }*/


        // Welcome 작업메서드
        // GET: /HelloWorld/Welcome/ 
        // Views/HelloWorld/Welcome.cshtml View 템플릿
        public IActionResult Welcome(string name, int numTimes = 1)
        {
            // Message 및 NumTimes 값을 ViewData 사전에 추가
            ViewData["Message"] = "Hello " + name;
            ViewData["NumTimes"] = numTimes;

            return View(); //ViewData 사전은 동적 개체로, 모든 형식을 사용할 수 있다
        }


        // MVC 모델 바인딩 시스템은 쿼리 문자열에서 메서드의 매개 변수를 자동매핑


        // 초기 Welcome 메서드
        // Requires using System.Text.Encodings.Web;
        // name 및 ID 매개 변수를 가져온 다음 값을 브라우저로 직접 출력
        /*public string Welcome(string name, int ID = 1)
        {
            return HtmlEncoder.Default.Encode($"Hello {name}, ID: {ID}");
            // HtmlEncoder.Default.Encode는 js 사용 등 악의적 입력으로부터 앱을 보호
        }
        */


    }
}