function numDays(month, year){

    let daysInMonth = new Date(year, month, 0).getDate();

    return daysInMonth;
}
