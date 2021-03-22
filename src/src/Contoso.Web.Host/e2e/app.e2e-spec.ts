import { ContosoTemplatePage } from './app.po';

describe('Contoso App', function() {
  let page: ContosoTemplatePage;

  beforeEach(() => {
    page = new ContosoTemplatePage();
  });

  it('should display message saying app works', () => {
    page.navigateTo();
    expect(page.getParagraphText()).toEqual('app works!');
  });
});
