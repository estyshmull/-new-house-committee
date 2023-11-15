# -new-house-committee
תיאור הפרויקט:
מערכת ניהול ועד בית לבניין
באמצעות המערכת ניתן לנהל מערכת ועד בית של בניין
ישויות:
דייר:
שליפת רשימת הדיירים  GET https:// house_committee.co.il/tenant 
שליפת דייר לפי שם מזהה   GET https:// house_committee.co.il/tenant/1
הוספת דייר POST https:// house_committee.co.il/tenant/1
עדכון דייר ששילם PUT https:// house_committee.co.il/tenant/1
מחיקת דייר DELETE GET https:// house_committee.co.il/tenant/1
מאפיינים-דייר:
שם, טלפון, קומה, סוג דייר
חודש:
שליפת רשימת החודשים GET https:// house_committee.co.il/month
שליפת חודש לפי מזהה GET https:// house_committee.co.il/month/1
הוספת חודש  POST https:// house_committee.co.il/month
עידכון חודש שגובה בו התשלום  PUT https:// house_committee.co.il/month/1
מאפינים-חודש: 
שם מיסוג ENUM 
מזהה ,האם גובה או לא 
תשלומים:
שליפת רשימת התשלומים GET https:// house_committee.co.il/payment
שליפת תשלום לפי שם מזהה  GET https:// house_committee.co.il/payment/1
הוספת תשלום   POST https:// house_committee.co.il/payment/
עידכון תשלום ששולם כבר PUT https:// house_committee.co.il/payment/1
מאפינים:
סוג תשלום 
מטרה
סכום 
האם שולם-גובה או  לא

