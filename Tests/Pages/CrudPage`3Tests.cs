﻿using EMEHospitalWebApp.Domain;
using EMEHospitalWebApp.Domain.Party;
using EMEHospitalWebApp.Facade.Party;
using EMEHospitalWebApp.Infra;
using EMEHospitalWebApp.Infra.Party;
using EMEHospitalWebApp.Pages;
using Microsoft.AspNetCore.Mvc;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace EMEHospitalWebApp.Tests.Pages {
    [TestClass] public class CrudPageTests
        : AbstractClassTests<CrudPage<AppointmentView, Appointment, AppointmentsRepo>,
            BasePage<AppointmentView, Appointment, AppointmentsRepo>> {
        private class testClass : CrudPage<AppointmentView, Appointment, AppointmentsRepo> {
            public testClass(AppointmentsRepo r) : base(r) { }
            protected override AppointmentView ToView(Appointment? entity) 
                => throw new System.NotImplementedException();
            protected override Appointment ToObject(AppointmentView? item)
                => throw new System.NotImplementedException();
            protected override IActionResult redirectToIndex()
                => throw new System.NotImplementedException();
            protected override IActionResult redirectToEdit(AppointmentView v)
                => throw new System.NotImplementedException();
            protected override IActionResult redirectToDelete(string id)
                => throw new System.NotImplementedException();
            protected override void setAttributes(int idx, string? filter, string? order)
                => throw new System.NotImplementedException();
        }
        protected override CrudPage<AppointmentView, Appointment, AppointmentsRepo> createObj() {
            var db = GetRepo.Instance<HospitalWebAppDb>();
            return new testClass(new AppointmentsRepo(db));
        }
    }
}
