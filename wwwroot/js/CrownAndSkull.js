var opt = {
    "desc": "",
    "name": "",
    "val": 0
}

var genericObj = {
    Id: 0,
    Name: "",
    Desc: "",
    Points: 0
}

$(document).ready(function () {
    populateDropDowns();
}) 

function addSkill(id) {
    getSelectedOption(id, $(id).val()); // Populates the opt object
    let selSkill = new genericObj;
    skillObj.Name = opt.name;
    skillObj.Desc = opt.desc;
    skillObj.Id = opt.val;
    skillObj.Points = 3;
}

function getSelectedSkill() {
    genericObj.Id = $('#ddlSkills').val();
    genericObj.Name = $('#ddlSkills').find('');
}

function populateDropDowns() {
    let ddlLineageOptions = '';

    $.get("/api/options/GetLineage/-1", null, function (e) {
        $('#ddlLineage').html(e);
    });

    $.get("/api/options/GetSkills/-1", null, function (e) {
        $('#ddlSkills').html(e);
    });

    $.get("/api/options/GetPurposeOptions/-1", null, function (e) {
        $('#ddlNowI').html(e);
    });

    $.get("/api/options/GetPastOptions/-1", null, function (e) {
        $('#ddlMyPast').html(e);
    });
}

function calcHeroPoints(id) {
    let currentHP = parseInt($('#HeroPoints').val());
    let prevCoreAbility = $('#PreviousCoreAbility').val();
    let selCoreAbility = $(id).val();
    let t = id + ' option[value="' + selCoreAbility + '"]';
    let selCoreDesc = $(t).prop('title');

    if (selCoreAbility === "-1") {
        currentHP += 15;
        $('#PreviousCoreAbility').val("-1");
    } else if (selCoreAbility === "R") {

        selCoreAbility = Math.floor((Math.random() * 12) + 1);
        if (prevCoreAbility === "-1") {
            currentHP -= 15;
        }

        $('#PreviousCoreAbility').val(selCoreAbility);
        $(id).val(selCoreAbility);
        t = id + ' option[value="' + selCoreAbility + '"]';
        selCoreDesc = $(t).prop('title');
    } else {
        $('#PreviousCoreAbility').val(selCoreAbility);
        if (prevCoreAbility === "-1") {
            currentHP -= 15;
        }

        if (prevCoreAbility === "3" && selCoreAbility !== "3") {
            removeDruidSkills();
        }

        if (prevCoreAbility === "4" && selCoreAbility !== "4") {
            removeEmpathSkills();
        }

        if (prevCoreAbility === "6" && selCoreAbility !== "6") {
            removeMountaineerSkills();
        }
    }

    if (selCoreAbility === "3") {
        $('#ddlSkills').val(12);
        addSkill('#ddlSkills');
        $('#skillPoints_12').val(9);
        $('#dspSP_12').html('9<span style="color:white;">0</span>');
        $('#minSP_12').val(9);
        $('#maxSP_12').val(18);

        $('#ddlSkills').val(41);
        addSkill('#ddlSkills');
        $('#skillPoints_41').val(9);
        $('#dspSP_41').html('9<span style="color:white;">0</span>');
        $('#maxSP_41').val(18);
        $('#minSP_41').val(9);
    } else if (selCoreAbility === "4") {
        $('#ddlSkills').val(13);
        addSkill('#ddlSkills');
        $('#skillPoints_13').val(7);
        $('#dspSP_13').html('7<span style="color:white;">0</span>');
        $('#minSP_13').val(7);
        $('#maxSP_13').val(18);

        $('#ddlSkills').val(23);
        addSkill('#ddlSkills');
        $('#skillPoints_23').val(7);
        $('#dspSP_23').html('7<span style="color:white;">0</span>');
        $('#maxSP_23').val(18);
        $('#minSP_23').val(7);

        $('#ddlSkills').val(37);
        addSkill('#ddlSkills');
        $('#skillPoints_37').val(7);
        $('#dspSP_37').html('7<span style="color:white;">0</span>');
        $('#maxSP_37').val(18);
        $('#minSP_37').val(7);
    } else if (selCoreAbility === "6") {
        $('#ddlSkills').val(5);
        addSkill('#ddlSkills');
        $('#skillPoints_5').val(10);
        $('#dspSP_5').html('10');
        $('#maxSP_5').val('18');
        $('#minSP_5').val('10');

        $('#ddlSkills').val(4);
        addSkill('#ddlSkills');
        $('#skillPoints_4').val(10);
        $('#dspSP_4').html('10');
        $('#maxSP_4').val('18');
        $('#minSP_4').val('10');

        let origSkillhtml = $('#ddlSkills').html();

        let skillhtml = origSkillhtml + "<option value='43' title='In mountains or underground, you have a Scout skill of 15.'>Mountaineer Scout</option>";
        $('#ddlSkills').html(skillhtml);
        $('#ddlSkills').val(43);
        addSkill('#ddlSkills');
        $('#skillPoints_43').val(15);
        $('#dspSP_43').html('15');
        $('#maxSP_43').val('18');
        $('#minSP_43').val('15');
        $('#ddlSkills').html(origSkillhtml);
    }

    $('#HeroPoints').val(currentHP);
    $('#dspHeroPoints').html(currentHP);
    $('#dspCoreAbility').html(selCoreDesc);
}

function rndLineage(id) {
    let curSel = $(id).val();
    if (curSel === "R") {
        curSel = Math.floor((Math.random() * 20) + 1);
        $(id).val(curSel);
    }
}

function rndEquipment(id) {
    let curSel = $(id).val();
    if (curSel === "R") {
        curSel = Math.floor((Math.random() * 20) + 1);
        $(id).val(curSel);
    }
}

function rndMyPast(id) {
    let curSel = $(id).val();
    if (curSel === "R") {
        curSel = Math.floor((Math.random() * 20) + 1);
        $(id).val(curSel);
    }
}

function rndNowI(id) {
    let curSel = $(id).val();
    if (curSel === "R") {
        curSel = Math.floor((Math.random() * 20) + 1);
        $(id).val(curSel);
    }
}

function addSkill(id) {
    // check to see if skill is already added
    let maxSkills = parseInt($('#MaxSkills').val());
    let currentSkillCount = parseInt($('#CurrentSkillCount').val());

    let t = id + ' option[value="' + $(id).val() + '"]';
    let currentHP = parseInt($('#HeroPoints').val());

    if ($(id).val() !== "-1") { 

        if (!isSelectedOption(id, $(id).val()) && currentSkillCount < maxSkills) {
            let html = $('#selSkills').html();
            getSelectedOption(id, $(id).val());

            if (currentHP > 2) {
                html += '<tr><td class="skillCol1 sl_' + opt.val + '"><input type="hidden" id="maxSP_' + opt.val + '" value="18" /><input type="hidden" id="minSP_' + opt.val + '" value="3" /><span style="font-weight:bold;">' + opt.name + ':</span><input type="hidden" value="' + $(id).val() + '" /></td><td class="skillCol2 sm_' + opt.val + '">' + opt.desc + '</td><td class="skillCol3  sr_' + opt.val + '"><button type="button" onclick="removeSkill(' + opt.val + ');" class="btn btn-sm btn-danger" style="display:inline;height:31px;">X</button>&nbsp;<input id="skillPoints_' + opt.val + '" type="hidden" value="3" /><button type="button" class="btn btn-sm btn-secondary" onclick="addSkillPoint(' + opt.val + ');">+</button>&nbsp;<span id="dspSP_' + opt.val + '">3</span><span style="color:white;">0</span><button type="button" class="btn btn-sm btn-secondary" onclick="subSkillPoint(' + opt.val + ');">-</button></td></tr>';
                $('#selSkills').html(html);
                currentHP -= 3;
                $('#HeroPoints').val(currentHP);
                $('#dspHeroPoints').html(currentHP);
                currentSkillCount++;
                $('#CurrentSkillCount').val(currentSkillCount);
            } else {
                // show error modal
            }
        }

        let txt = '(S)' + $(t).html();
        $(t).html(txt).prop('disabled', true);
    }

    $(id).val("-1");
}

function removeDruidSkills() {
    let currentHP = parseInt($('#HeroPoints').val());

    let currentSkillPoints = parseInt($('#skillPoints_12').val());
    currentSkillPoints -= 9;
    currentHP += currentSkillPoints;
    $('#selSkills input[value="12"]').parent().parent().remove();
    let opthtml = $('#ddlSkills option[value="12"]').html();
    if (opthtml.substring(0, 3) === "(S)") {
        $('#ddlSkills option[value="12"]').html(opthtml.substring(3, opthtml.length));
        $('#ddlSkills option[value="12"]').prop('disabled', false);
    }

    currentSkillPoints = parseInt($('#skillPoints_41').val());
    currentSkillPoints -= 9;
    currentHP += currentSkillPoints;
    $('#selSkills input[value="41"]').parent().parent().remove();
    opthtml = $('#ddlSkills option[value="41"]').html();
    if (opthtml.substring(0, 3) === "(S)") {
        $('#ddlSkills option[value="41"]').html(opthtml.substring(3, opthtml.length));
        $('#ddlSkills option[value="41"]').prop('disabled', false);
    }

    $('#HeroPoints').val(currentHP);
    $('#dspHeroPoints').html(currentHP);
}

function removeEmpathSkills() {
    let currentHP = parseInt($('#HeroPoints').val());

    let currentSkillPoints = parseInt($('#skillPoints_13').val());
    currentSkillPoints -= 7;
    currentHP += currentSkillPoints;
    $('#selSkills input[value="13"]').parent().parent().remove();
    let opthtml = $('#ddlSkills option[value="13"]').html();
    if (opthtml.substring(0, 3) === "(S)") {
        $('#ddlSkills option[value="13"]').html(opthtml.substring(3, opthtml.length));
        $('#ddlSkills option[value="13"]').prop('disabled', false);
    }

    currentSkillPoints = parseInt($('#skillPoints_23').val());
    currentSkillPoints -= 7;
    currentHP += currentSkillPoints;
    $('#selSkills input[value="23"]').parent().parent().remove();
    opthtml = $('#ddlSkills option[value="23"]').html();
    if (opthtml.substring(0, 3) === "(S)") {
        $('#ddlSkills option[value="23"]').html(opthtml.substring(3, opthtml.length));
        $('#ddlSkills option[value="23"]').prop('disabled', false);
    }

    currentSkillPoints = parseInt($('#skillPoints_37').val());
    currentSkillPoints -= 7;
    currentHP += currentSkillPoints;
    $('#selSkills input[value="37"]').parent().parent().remove();
    opthtml = $('#ddlSkills option[value="37"]').html();
    if (opthtml.substring(0, 3) === "(S)") {
        $('#ddlSkills option[value="37"]').html(opthtml.substring(3, opthtml.length));
        $('#ddlSkills option[value="37"]').prop('disabled', false);
    }

    $('#HeroPoints').val(currentHP);
    $('#dspHeroPoints').html(currentHP);
}

function removeMountaineerSkills() {
    // 5, 4, 43
    let currentHP = parseInt($('#HeroPoints').val());

    // Remove Breakfall
    let currentSkillPoints = parseInt($('#skillPoints_4').val());
    currentSkillPoints -= 10;
    currentHP += currentSkillPoints;
    $('#selSkills input[value="4"]').parent().parent().remove();
    let opthtml = $('#ddlSkills option[value="4"]').html();
    if (opthtml.substring(0, 3) === "(S)") {
        $('#ddlSkills option[value="4"]').html(opthtml.substring(3, opthtml.length));
        $('#ddlSkills option[value="4"]').prop('disabled', false);
    }

    // Remove Climber
    currentSkillPoints = parseInt($('#skillPoints_5').val());
    currentSkillPoints -= 10;
    currentHP += currentSkillPoints;
    $('#selSkills input[value="5"]').parent().parent().remove();
    opthtml = $('#ddlSkills option[value="5"]').html();
    if (opthtml.substring(0, 3) === "(S)") {
        $('#ddlSkills option[value="5"]').html(opthtml.substring(3, opthtml.length));
        $('#ddlSkills option[value="5"]').prop('disabled', false);
    }

    // Remove Special Mountaineer
    currentSkillPoints = parseInt($('#skillPoints_43').val());
    currentSkillPoints -= 15;
    currentHP += currentSkillPoints;
    $('#selSkills input[value="43"]').parent().parent().remove();
    
    $('#HeroPoints').val(currentHP);
    $('#dspHeroPoints').html(currentHP);
}

function removeSkill(val) {

    let currentHP = parseInt($('#HeroPoints').val());
    let copt = '#ddlSkills option[value="' + val + '"]';
    let selOpt = '#selSkills input[value="' + val + '"]';
    let valId = '#skillPoints_' + val;
    let currentSkillPoints = parseInt($(valId).val());
    let minId = '#minSP_' + val;
    let idClass = '.s_' + val;
    let currentSkillCount = $('#CurrentSkillCount').val();

    if ($('#ddlCoreAbility').val() === "3") {
        let idClassHuntingLeft = '.sl_12';
        let idClassHuntingMid = '.sm_12';
        let idClassHuntingRight = '.sr_12';
        let idClassTrackingLeft = '.sl_41';
        let idClassTrackingMid = '.sm_41';
        let idClassTrackingRight = '.sr_41';

        $(idClassHuntingLeft).addClass('redBorderLeft');
        $(idClassHuntingMid).addClass('redBorderMid');
        $(idClassHuntingRight).addClass('redBorderRight');

        $(idClassTrackingLeft).addClass('redBorderLeft');
        $(idClassTrackingMid).addClass('redBorderMid');
        $(idClassTrackingRight).addClass('redBorderRight');

        $('#skillModalMsg').html('You cannot remove Hunting and/or Tracking skills unless you change your core ability away from Druid.');
        $('#skillErrorModal').show();
    } else if ($('#ddlCoreAbility').val() === "4") {

        let idClassInvestigateLeft = '.sl_13';
        let idClassInvestigateMid = '.sm_13';
        let idClassInvestigateRight = '.sr_13';
        let idClassOratoryLeft = '.sl_23';
        let idClassOratoryMid = '.sm_23';
        let idClassOratoryRight = '.sr_23';
        let idClassStreetwiseLeft = '.sl_37';
        let idClassStreetwiseMid = '.sm_37';
        let idClassStreetwiseRight = '.sr_37'

        $(idClassInvestigateLeft).addClass('redBorderLeft');
        $(idClassInvestigateMid).addClass('redBorderMid');
        $(idClassInvestigateRight).addClass('redBorderRight');

        $(idClassOratoryLeft).addClass('redBorderLeft');
        $(idClassOratoryMid).addClass('redBorderMid');
        $(idClassOratoryRight).addClass('redBorderRight');

        $(idClassStreetwiseLeft).addClass('redBorderLeft');
        $(idClassStreetwiseMid).addClass('redBorderMid');
        $(idClassStreetwiseRight).addClass('redBorderRight');

        $('#skillModalMsg').html('You cannot remove Investigate, Oratory, nor Streetwise skills unless you change your core ability away from Empath.');
        $('#skillErrorModal').show();
    } else if ($('#ddlCoreAbility').val() === "6") {
        let breakfallLeft = '.sl_4';
        let breakfallMid = '.sm_4';
        let breakfallRight = '.sr_4';
        $(breakfallLeft).addClass('redBorderLeft');
        $(breakfallMid).addClass('redBorderMin');
        $(breakfallRight).addClass('redBorderRight');

        let climberLeft = '.sl_5';
        let climberMid = '.sm_5';
        let climberRight = '.sr_5';
        $(climberLeft).addClass('redBorderLeft');
        $(climberMid).addClass('redBorderMid');
        $(climberRight).addClass('redBorderRight');

        let mountaineerLeft = '.sl_43';
        let mountaineerMid = '.sm_43';
        let mountaineerRight = '.sr_43';
        $(mountaineerLeft).addClass('redBorderLeft');
        $(mountaineerMid).addClass('redBorderMid');
        $(mountaineerRight).addClass('redBorderRight');

        $('#skillModalMsg').html('You cannot remove Breakfall, Climber, nor Mountaineer Scout skills unless you change your core ability away from Mountaineer.');
        $('#skillErrorModal').show();
    }
    else {
        currentHP += currentSkillPoints;
        $(selOpt).parent().parent().remove();
        currentSkillCount--;

        let opthtml = $(copt).html();
        if (opthtml.substring(0, 3) === "(S)") {
            $(copt).html(opthtml.substring(3, opthtml.length));
            $(copt).prop('disabled', false);
        }

        $('#CurrentSkillCount').val(currentSkillCount);
        $('#HeroPoints').val(currentHP);
        $('#dspHeroPoints').html(currentHP);
    }  
}

function isSelectedOption(id, value) {
    let output = false;

    if (id === '#ddlSkills') {
        $('#selSkills').find('input').each(function (index, element) {
            if (element.value === value) output = true;
        });
    }

    return output;
}

function getSelectedOption(id) {
    opt.val = $(id).val();
    $(id).find('option').each(function (index, element) {
        if (element.value === opt.val) {
            opt.name = element.label;
            opt.desc = element.title;
        }
    });
}

function addSkillPoint(id) {
    let output = '#dspSP_' + id;
    let html = '';
    let maxId = '#maxSP_' + id;
    id = '#skillPoints_' + id;
    let test = $(id).val();
    let currentVal = parseInt($(id).val());
    let currentHP = parseInt($('#HeroPoints').val());
    let maxSP = parseInt($(maxId).val());

    if (currentVal < maxSP ) { 
        currentHP -= 1;
        currentVal += 1;

        if (currentVal < 10) html = currentVal + '<span style="color:white;">0</span>';
        else html = currentVal;

        $('#HeroPoints').val(currentHP);
        $('#dspHeroPoints').html(currentHP);
        $(id).val(currentVal);
        $(output).html(html);
    }
}

function subSkillPoint(id) {
    let output = '#dspSP_' + id;
    let minId = '#minSP_' + id;
    id = '#skillPoints_' + id;
    let html = '';
    let currentVal = parseInt($(id).val());
    let currentHP = parseInt($('#HeroPoints').val());
    let minSP = parseInt($(minId).val());

    if (currentVal > minSP) { 
        currentHP += 1;
        currentVal -= 1;

        if (currentVal < 10) html = currentVal + '<span style="color:white;">0</span>';
        else html = currentVal;

        $('#HeroPoints').val(currentHP);
        $('#dspHeroPoints').html(currentHP);
        $(id).val(currentVal);
        $(output).html(html);
    }
}

function toggleFlaw(id) {
    let totalFlaws = parseInt(($('#FlawCount').val()));
    let heroPoints = parseInt(($('#HeroPoints').val()));

    if (totalFlaws === 0 || totalFlaws === 1 || totalFlaws ===2) {
        if ($(id).prop('checked') === true) {
            heroPoints += 5;
            totalFlaws++;
        } else {
            heroPoints -= 5;
            totalFlaws--;
        }        
    }

    let counter = 0;

    $('#Flaws').find('input:checkbox').each(function () {
        if (this.checked && $(this).val() === "2") $('#MaxEquipment').val(5);
    });

    if (totalFlaws === 2) {
        disableAllFlaws();
        $('#Flaws').find('input:checkbox').each(function () {
            if (this.checked) {
                if (counter === 0) {
                    counter++;
                    let txt = "<table><tr><td style='vertical-align:top;width:130px;'><b>" + $(this).parent().find("span").text() + ":</b></td><td>" + $(this).parent().prop('title') + "</td></tr></table>";
                    $('#selFlaw1').html(txt);
                } else if (counter === 1) {
                    counter++;
                    let txt = "<table><tr><td style='vertical-align:top;width:130px;'><b>" + $(this).parent().find("span").text() + ":</b></td><td>" + $(this).parent().prop('title') + "</td></tr></table>";
                    $('#selFlaw2').html(txt);
                }
            }
        });

    } else {
        enableAllFlaws();
        $('#Flaws').find('input:checkbox').each(function () {
            if (this.checked) {
                let txt = "<table><tr><td style='vertical-align:top;width:130px;'><b>" + $(this).parent().find("span").text() + ":</b></td><td>" + $(this).parent().prop('title') + "</td></tr></table>";
                $('#selFlaw1').html(txt);
                $('#selFlaw2').html('');
            }
        });
        
    }

    $('#FlawCount').val(totalFlaws);
    $('#HeroPoints').val(heroPoints);
    $('#dspHeroPoints').html(heroPoints);

    if (totalFlaws > 0) {
        $('#SelFlaws').show();
    } else {
        $('#SelFlaws').hide();
    }
}
function disableAllFlaws() {
    if ($('#cbxAddict').is(':checked') === false) $('#cbxAddict').prop('disabled', true);
    if ($('#cbxAescetic').is(':checked') === false) $('#cbxAescetic').prop('disabled', true);
    if ($('#cbxAncient').is(':checked') === false) $('#cbxAncient').prop('disabled', true);
    if ($('#cbxBadRep').is(':checked') === false) $('#cbxBadRep').prop('disabled', true);
    if ($('#cbxCrazy').is(':checked') === false) $('#cbxCrazy').prop('disabled', true);
    if ($('#cbxDisorganized').is(':checked') === false) $('#cbxDisorganized').prop('disabled', true);
    if ($('#cbxDrunkard').is(':checked') === false) $('#cbxDrunkard').prop('disabled', true);
    if ($('#cbxEmployed').is(':checked') === false) $('#cbxEmployed').prop('disabled', true);
    if ($('#cbxGreedy').is(':checked') === false) $('#cbxGreedy').prop('disabled', true);
    if ($('#cbxGrudge').is(':checked') === false) $('#cbxGrudge').prop('disabled', true);
    if ($('#cbxImpetuous').is(':checked') === false) $('#cbxImpetuous').prop('disabled', true);
    if ($('#cbxInjured').is(':checked') === false) $('#cbxInjured').prop('disabled', true);
    if ($('#cbxKid').is(':checked') === false) $('#cbxKid').prop('disabled', true);
    if ($('#cbxParanoid').is(':checked') === false) $('#cbxParanoid').prop('disabled', true);
    if ($('#cbxPhobia').is(':checked') === false) $('#cbxPhobia').prop('disabled', true);
    if ($('#cbxPursued').is(':checked') === false) $('#cbxPursued').prop('disabled', true);
    if ($('#cbxSickly').is(':checked') === false) $('#cbxSickly').prop('disabled', true);
    if ($('#cbxStubborn').is(':checked') === false) $('#cbxStubborn').prop('disabled', true);
    if ($('#cbxTimid').is(':checked') === false) $('#cbxTimid').prop('disabled', true);
    if ($('#cbxUnlucky').is(':checked') === false) $('#cbxUnlucky').prop('disabled', true);
}

function enableAllFlaws() {
    $('#cbxAddict').prop('disabled', false);
    $('#cbxAescetic').prop('disabled', false);
    $('#cbxAncient').prop('disabled', false);
    $('#cbxBadRep').prop('disabled', false);
    $('#cbxCrazy').prop('disabled', false);
    $('#cbxDisorganized').prop('disabled', false);
    $('#cbxDrunkard').prop('disabled', false);
    $('#cbxEmployed').prop('disabled', false);
    $('#cbxGreedy').prop('disabled', false);
    $('#cbxGrudge').prop('disabled', false);
    $('#cbxImpetuous').prop('disabled', false);
    $('#cbxInjured').prop('disabled', false);
    $('#cbxKid').prop('disabled', false);
    $('#cbxParanoid').prop('disabled', false);
    $('#cbxPhobia').prop('disabled', false);
    $('#cbxPursued').prop('disabled', false);
    $('#cbxSickly').prop('disabled', false);
    $('#cbxStubborn').prop('disabled', false);
    $('#cbxTimid').prop('disabled', false);
    $('#cbxUnlucky').prop('disabled', false);
}