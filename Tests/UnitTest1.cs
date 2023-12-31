using Desktop;
using System.Threading;

namespace Tests
{
    [TestClass]
    public class ViewTest
    {
        [TestMethod]
        public void TestMainVindow()
        {
            Thread t = new( () =>
            {
                MainWindow mainWindow = new();
                Assert.IsNotNull(mainWindow, "new MainWindow is not null");
            });
            t.SetApartmentState(ApartmentState.STA);
            t.Start();            
        }
    }
}
/* ���������� (��������)
 * ������ - ������� ��������, ��� �� ����������������, �� �� ����� ���������
 * �� ���� ���� �����, ����, ��������
 * ��� ���������� ����������� ������� ����� (����. ����, ���������, MSTest), 
 * ���� ��������� ������� (����� � ������) �������� �� �������� ���������
 * ��������� ������ (�� ���������� "����")
 * ϳ��� ��������� ��������� ������ ��� ��'����� ���� � ��������
 *  ��� Dependencies -- Add Project Reference  -- [mark] Desktop
 * �� ������ � ������ �������� ����� ��������� ������ 
 * �� �������� ������� �������� - ������������ �� � ��������� ������
 *  ���� � ��������� �� ���������� ������� (�������) - � ������������ ������
 *  
 * ���� ��������� ����� - � �������� "�������� �������" (tests coverage) 
 * �������� � �������� ��� ������� ���� ������� ������� - ���� ������ � 
 * ����������. ��������� ������� - 100 %
 * ������� ��������� ���������� ����������� �� ���� 70-80%
 * 
 */
