using ADOPrac.BusinessLogicLayer.IRepository;
using ADOPrac.BusinessLogicLayer.Models;
using Microsoft.AspNetCore.Mvc;

namespace ADOPrac.PresentationLayer.Controllers
{
    public class StateController : Controller
    {
        private readonly IStateRepository _stateRepository;
        private readonly ICountryRepository _countryRepository;

        public StateController(IStateRepository stateRepository , ICountryRepository countryRepository)
        {
            _stateRepository = stateRepository;
            _countryRepository = countryRepository;
        }
        public IActionResult State(int flag = 0)
        {
            ViewData["Countries"] = _countryRepository.GetCountriesList();
            var stateList = _stateRepository.GetStatesList();

            if(flag == 1)
            {
                stateList = stateList.Where(state => state.isActive == 1).ToList();
            }else if (flag == 2)
            {
                stateList = stateList.Where(state => state.isActive == 0).ToList();
            }
            return View(stateList);
        }

        public IActionResult Delete(int id)
        {
            _stateRepository.Delete(id);
            return RedirectToAction("State");
        }

        public IActionResult ActiveChange(int id, int flag)
        {
            _stateRepository.ChangeIsActive(id, flag);
            return RedirectToAction("State");
        }

        public IActionResult Update(int id)
        {
            var state = _stateRepository.GetStateById(id);
            ViewData["Countries"] = _countryRepository.GetCountriesList();

            return View(state);
        }

        [HttpPost]
        public IActionResult Update(State state)
        {
            _stateRepository.Update(state);
            return RedirectToAction("State");
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(State state)
        {
            _stateRepository.Create(state);
            return RedirectToAction("State");
        }

        public IActionResult CountryOptions()
        {
            
            return View();
        }
    }
}
