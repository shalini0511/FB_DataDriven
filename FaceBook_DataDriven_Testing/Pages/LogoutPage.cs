using System;
using System.Collections.Generic;
using System.Text;
using OpenQA.Selenium;
using SeleniumExtras.PageObjects;

namespace FaceBook_DataDriven_Testing.Pages
{
    public class LogoutPage:BaseClass.BaseClass1
    {
        //Using page factory for initialization of Page objects
        public LogoutPage(IWebDriver driver)
        {
            PageFactory.InitElements(driver, this);
        }
        //using FindsBy locating the element
        [FindsBy(How = How.CssSelector, Using = "body._6s5d._71pn._-kb.segoe:nth-child(2) div.rq0escxv.l9j0dhe7.du4w35lb div.ehxjyohh.kr520xx4.poy2od1o.b3onmgus.hv4rvrfc.n7fi1qx3:nth-child(4) div.du4w35lb.l9j0dhe7.byvelhso.rl25f0pe.j83agx80.bp9cbjyn:nth-child(1) span.tojvnm2t.a6sixzi8.abs2jz4q.a8s20v7p.t1p8iaqh.k5wvi7nf.q3lfd5jv.pk4s997a.bipmatt0.cebpdrjk.qowsmv63.owwhemhu.dp1hu0rb.dhp61c6y.iyyx5f41:nth-child(1) div.j83agx80.l9j0dhe7 > div.oajrlxb2.tdjehn4e.qu0x051f.esr5mh6w.e9989ue4.r7d6kgcz.rq0escxv.nhd2j8a9.j83agx80.p7hjln8o.kvgmc6g5.cxmmr5t8.oygrvhab.hcukyx3x.jb3vyjys.rz4wbd8a.qt6c0cv9.a8nywdso.i1ao9s8h.esuyzwwr.f1sip0of.lzcic4wl.s45kfl79.emlxlaya.bkmhp75w.spb7xbtv.l9j0dhe7.abiwlrkh.p8dawk7l.bp9cbjyn.rt8b4zig.n8ej3o3l.agehan2d.sk4xxmp2.taijpn5t.qypqp5cg.q676j6op:nth-child(1)")]
        [CacheLookup]
        public IWebElement arrowBtn;

        [FindsBy(How = How.XPath, Using = "//span[contains(text(),'Log Out')]")]
        [CacheLookup]
        public IWebElement logoutBtn;
    }
}
