using System.Collections.Generic;
using dotnetCore_WebAPI_ActuallyBrandNew.BusinessLogics;
using dotnetCore_WebAPI_ActuallyBrandNew.Models;
using Microsoft.AspNetCore.Mvc;

namespace dotnetCore_WebAPI_ActuallyBrandNew.Controllers
{
    [Route("/api/[controller]")]
    [ApiController]
    public class MemberController : ControllerBase
    {
        private IMemberHandler _memberHandler;

        public MemberController(IMemberHandler memberHandler)
        {
            _memberHandler = memberHandler;
        }

        [Route("/api/member/memberByGender/{gender}")]
        public List<Member> FilterMemberByGender(string gender)
        {
            return _memberHandler.FilterMemberByGender(gender[0]);
        }

        [Route("/api/member/oldestMember")]
        public Member GetOldestMember() 
        {
            return _memberHandler.GetOldestMember();
        }

        [Route("/api/member/fullNameList")]
        public List<string> GetFullNamesOnlyList() 
        {
            return _memberHandler.GetFullNamesOnlyList();
        }

        [Route("/api/member/memberByBirthYearLessThan/{year}")]
        public List<Member> FilterMembersWithBirthYearLessThan(int year) 
        {
            return _memberHandler.FilterMembersWithBirthYearLessThan(year);
        }

        [Route("/api/member/memberByBirthYearIn/{year}")]
        public List<Member> FilterMembersWithBirthYearIn(int year) 
        {
            return _memberHandler.FilterMembersWithBirthYearIn(year);
        }

        [Route("/api/member/memberByBirthYearGreaterThan/{year}")]
        public List<Member> FilterMembersWithBirthYearGreaterThan(int year) 
        {
            return _memberHandler.FilterMembersWithBirthYearGreaterThan(year);
        }

        [Route("/api/member/memberByBirthPlace/{birthPlace}")]
        public List<Member> FilterMembersByBirthPlace(string birthPlace) 
        {
            return _memberHandler.FilterMembersByBirthPlace(birthPlace);
        }

        [HttpPost]
        [Route("/api/member")]
        public List<Member> AddNewMember(Member member)
        {
            return _memberHandler.AddNewMember(member);
        }

    }
}