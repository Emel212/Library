using Library.DataAccess.Abstract;
using Library.Entities.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.DataAccess.Concrete
{
    public class MemberRespository:IMemberRepository
    {
        protected ILibraryBase<Member> _memberRepository;
       
        public MemberRespository(ILibraryBase<Member> memberRepository)
        {
            _memberRepository= memberRepository;
            
        }

        public  Task Delete(int id)
        {
            return  _memberRepository.Delete(id);
        }

        public async Task<List<Member>> GetAll()
        {
            var list =await _memberRepository.GetAll();
            return list;
        }

        public async Task<Member> GetById(int id)
        {
            var list =await _memberRepository.GetById(id);
            return list;
        }

    
        public Task<bool> Insert(Member entity)
        {
            return _memberRepository.Insert(entity);
        }

        public Task<IEnumerable<Member>> Select()
        {
            return _memberRepository.Select();
        }

        public Task<bool> Update(Member entity)
        {
            return _memberRepository.Update(entity);
        }
        async Task<Member> IMemberRepository.GetByName(string name)
        {
            var ıd = Tools.Context.Members.First(x => x.Name ==name).Id;
            var list = await _memberRepository.GetById(ıd);
            return list;

        }
    }
}
