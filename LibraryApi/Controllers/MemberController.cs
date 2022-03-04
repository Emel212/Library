using Library.DataAccess;
using Library.DataAccess.Abstract;
using Library.Entities.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LibraryApi.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class MemberController : ControllerBase
    {

        private ILibraryBase<Member> _memberService;
        private IMemberRepository _memberRepository;
        public MemberController(ILibraryBase<Member> memberService,IMemberRepository memberRepository)
        {
            _memberService = memberService;
            _memberRepository = memberRepository;
        }
        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var result= await _memberService.GetAll();
            if (result != null)
                return Ok(result);
            return BadRequest("no record found");
        }
        [HttpGet("{id:int}")]
        public async Task<IActionResult> GetById(int id)
        {
            var result= await _memberService.GetById(id);
            if (result != null)
                return Ok(result);
            return BadRequest("no record found");

        }
        public async Task<IActionResult> GetByName(string name)
        {
            var result = await _memberRepository.GetByName(name);
            if (result != null)
                return Ok(result);
            return BadRequest("no record found");

        }

    }
}
