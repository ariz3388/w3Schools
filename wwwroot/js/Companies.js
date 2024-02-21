function openModal(id) {
    if (id === 'aps') {
        let aps = 'window.open("https://aps.com");';
        $('#posModalTitle').html('APS IT Solutions Analyst III');
        $('#posModalBody').html('<ul><li>Design and manage new features for <a onclick="' + aps + '" href="#">aps.com</a> website.</li><li>Oversee projects as technical lead.</li><li>Build and maintain relationships with business partners and other IT teams.</li><li>Identify and solve unanticipated challenges during project development.</li><li>Keep project manager and relevant team members up to date with current status of tasks.</li><li>Create and maintain documentation such as Design, Prod Support References and Security Review.</li><li>Compile and ensure maintenance of team Web API documentation and request updates/revisions for documentation of other teams that is found to be outdated.</li></ul> ');
        $('#positionModal').modal('show');
    }

    if (id === 'stingray') {
        let stingray = '"openWin(2);", "_blank")';
        let header = 'Stingray was acquired from Maximum Processing by <a href="#" onclick="openWin(1);">Sapiens</a> in 2016.';
        $('#posModalTitle').html('Stingray');
        $('#posModalBody').html('<h4>' + header + '</h4><hr /><p>This was a uniquely challenging project to work on. Initially, the challenge was to learn the platform when there was virtually no online references (other than press releases). It used a language (Pascal) for scripting I had not used since 1995, and reliev heavily on SQL Server 2008 for business logic.</p><p>Click <a href="#" onclick="openWin(2);">here</a> to look at this case study in more detail.</p>');
        $('#positionModal').modal('show');
    }
    
}

function openWin(e) {
    if (e === 1) {
        window.open('https://iireporter.com/sapiens-acquires-maximum-processingstingray-system/', '_blank');
    }
    if (e === 2) {
        window.open($('#csStingray').prop('href'), '_blank');
    }
}

function closeModal(id) {
    $('#positionModal').modal('hide');
}

function toggleCarat(id) {
    let idu = '#' + id + 'u';
    let idd = '#' + id + 'd';

    $(idu).toggle();
    $(idd).toggle();
}