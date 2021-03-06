BUNDLE_VERSION=$(VERSION)
MAC_APP_DIR=MonoDevelop.app
MACOS=$(MAC_APP_DIR)/Contents/MacOS
MAC_APP_LIB_DIR=$(MACOS)/lib/monodevelop
ADDINS=$(MACOS)/lib/monodevelop/AddIns
EXTRAS=$(top_srcdir)/../extras
ARTIFACTS=$(top_srcdir)/../../artifacts

CLEANFILES = MonoDevelop.dmg MonoDevelop.app
#DISTCLEANFILES = 
EXTRA_DIST = dmg-bg.png DS_Store Info.plist.in make-dmg-bundle.sh mdtool monodevelop 

all: MonoDevelop.app

MonoDevelop.dmg: MonoDevelop.app
	./make-dmg-bundle.sh

clean-local:
	rm -rf MonoDevelop.app
	rm -f MonoDevelop.dmg
	rm -f MonoDevelop.app.zip

MonoDevelop.app: 
	mkdir -p $(MAC_APP_DIR)/Contents/{MacOS,Resources}
	mkdir -p $(MAC_APP_DIR)/Contents/MacOS/{lib,share}
	mkdir -p $(MAC_APP_LIB_DIR)
	cp -pR ../AddIns $(MAC_APP_LIB_DIR)
	cp -pR ../data $(MAC_APP_LIB_DIR)
	cp -pR ../bin $(MAC_APP_LIB_DIR)
	cp -pR ../locale $(MAC_APP_DIR)/Contents/MacOS/share
	
	mkdir -p $(MAC_APP_DIR)/Contents/MacOS/share/monodevelop
	cp ../../COPYING $(MAC_APP_DIR)/Contents/MacOS/share/monodevelop/COPYING.LGPL2.1
	
	sed -e "s/@BUNDLE_VERSION@/$(BUNDLE_VERSION)/" -e "s/@ASSEMBLY_VERSION@/$(ASSEMBLY_VERSION)/" Info.plist.in > $(MAC_APP_DIR)/Contents/Info.plist
	cp ../../theme-icons/Mac/*.icns $(MAC_APP_DIR)/Contents/Resources/
	cp monodevelop $(MACOS)/monodevelop
	cp mono-version-check $(MACOS)/mono-version-check
	cp mdtool $(MACOS)/mdtool
	
# copy monodevelop.pc and mono-addins.pc to Contents/MacOS/lib/pkgconfig
	mkdir -p $(MACOS)/lib/pkgconfig
	cp ../../*.pc $(MACOS)/lib/pkgconfig
	
# Copy main/monodevelop.xml to MonoDevelop.app/Contents/MacOS/share/mime/packages
	mkdir -p $(MACOS)/share/{applications,mime,icons,locale,man}
	mkdir -p $(MACOS)/share/mime/packages
	cp ../../monodevelop.xml $(MACOS)/share/mime/packages
	cp ../../monodevelop.desktop $(MACOS)/share/applications
	
# Remove addins that don't work on OSX
	rm -rf  $(ADDINS)/GnomePlatform* \
	  $(ADDINS)/WindowsPlatform* \
	  $(ADDINS)/MonoDevelop.Gettext/*
	
# remove stuff we don't need
	rm -rf $(MACOS)/lib/monodevelop/bin/UnitTests.dll* \
	  $(MACOS)/lib/monodevelop/bin/TestResult.xml \
	  $(MACOS)/lib/monodevelop/bin/addin-db* \
	  $(MACOS)/lib/monodevelop/bin/local \
	  $(MACOS)/lib/monodevelop/bin/repository-cache* \
	  $(MACOS)/lib/monodevelop/AddIns/MonoDevelop.TextTemplating/Mono.TextTemplating.Tests*

# add extras known to work on Mac, if they exist
	mkdir -p $(MAC_APP_LIB_DIR)/AddIns/MonoDevelop.{IPhone,MonoMac,Database}
	cp -pR $(EXTRAS)/MonoDevelop.IPhone/build/* $(MAC_APP_LIB_DIR)/AddIns/MonoDevelop.IPhone/
	cp -pR $(EXTRAS)/MonoDevelop.MonoMac/build/* $(MAC_APP_LIB_DIR)/AddIns/MonoDevelop.MonoMac/
	cp -pR $(EXTRAS)/MonoDevelop.Database/build/* $(MAC_APP_LIB_DIR)/AddIns/MonoDevelop.Database/

# add the binary artifacts if they exist
	mkdir -p $(MACOS)/lib/{moonlight,pkgconfig}
	mkdir -p $(MACOS)/MonoDoc.app/
	cp -pR $(ARTIFACTS)/MoonSDK/* $(MACOS)/lib/moonlight/
	cp -pR $(ARTIFACTS)/system.web.mvc.pc $(MACOS)/lib/pkgconfig/
	cp -pR $(ARTIFACTS)/MonoDoc.app/* $(MACOS)/MonoDoc.app/

# update revision in updateinfo
	if test -d ../../../.git/svn; then svn_info="git log --no-color --first-parent -n1 --grep=git-svn-id: --pretty=format:%b | sed -n -e 's,git-svn-id: \(.*\)@\(.*\) .*,URL: \1 Revision: \2,p'"; fi; \
	if test -d ../../../.svn; then svn_info='svn info'; fi; \
	if test -n "$$svn_info"; then \
		version=$$(cd ../../..; \
			LANG=C; export LANG; \
			eval $$svn_info | sed -n -e '/Last Changed Rev/ s/.*: //p'; \
		); \
		echo "a3140c14-ef90-4019-ae6c-9d93804d6611 $$version" > "$(MACOS)/updateinfo"; \
	fi;

# touch the directory so that update dependencies work
	touch MonoDevelop.app

MonoDevelop.app.zip: MonoDevelop.app
	zip -r9uq MonoDevelop.app.zip MonoDevelop.app

.PHONY: MonoDevelop.app
