### SI-1 — Policy and Procedures (Control)

This requirement is about ensuring the organisation has clear, written rules for protecting the accuracy and reliability (integrity) of its systems and information, along with practical instructions for how to follow those rules. Without this, people may not know what is expected, different departments may work in different ways, and important updates after security incidents, audits, major system upgrades, or changes in law may be missed—leaving data and day-to-day operations vulnerable to unauthorised changes, mistakes, or failure to meet legal and regulatory requirements.

The organisation must create and document an organisation-wide integrity policy. This policy must explain its purpose, what it covers, who is responsible for what, leadership commitment, how different parts of the organisation work together, and how compliance will be achieved. It must also align with relevant laws, directives, regulations, and internal standards.

The Chief Information Security Officer must manage producing, documenting, and sharing the policy and procedures with the Chief Information Security Officer and the Security Governance Board, and distributing the policy to all employees, contractors, and privileged users who have access to Confidential or Classified systems. The procedures must also be provided to system owners, operational technology/industrial control systems (OT/ICS) engineers, privacy officers, and all staff with security responsibilities.

The policy and procedures must be reviewed and updated at least every year, and also after security incidents or breaches, audit findings, major system changes, or changes to applicable laws and directives.

##### CISO-owned integrity policy & procedures pack with controlled updates

- Category: Manual
- Priority: Critical

###### WHAT
Create and maintain an organisation-level **system and information integrity policy** and supporting **system and information integrity procedures**. These must cover the **security controls** for system and information integrity that the organisation has put in place. The policy and procedures must be **consistent with all relevant laws, directions, regulations, internal policies, standards, and guidance**, and must be kept up to date.

###### WHY (control requirement)
SI-1 requires that **system and information integrity policy and procedures** exist and are **more than just a repeat of the controls**. Guidance also requires that the **security and privacy programmes work together**, that the **risk management approach** informs the policy, and that updates happen **at least every year and after specific events** (for example: incidents, audit findings, major system changes, and changes to relevant laws or directions).

###### HOW (specific steps/approach)
1. **Set clear ownership and collaboration**: The **Chief Information Security Officer (CISO)** is responsible for the integrity policy and procedures throughout their life cycle. The **Security Governance Board** provides approval and oversight. The **Security** and **Privacy** programmes co-author or formally review the content.
2. **Publish an organisation-level policy (single source of truth)** under document control. At a minimum, it must include: purpose, scope (which systems and data are covered), management commitment, roles and responsibilities, coordination between security, privacy, information technology (IT), and operational technology (OT) where relevant, the compliance approach (including how exceptions are handled), and references to applicable laws, directions, regulations, and standards.
3. **Create practical procedures** that explain **how the policy is carried out** (work instructions). Include: how system owners apply integrity requirements to system security and privacy plans; what evidence is needed for assurance and audits; how incidents, audit findings, and major changes trigger a review of the procedures and policy; and how exceptions are requested and approved.
4. **Set distribution lists and evidence requirements** based on the organisation’s defined rules:
   - Share the **policy** with **all employees, contractors, and privileged users** who have access to **Confidential or Classified systems**.
   - Share the **procedures** with **system owners**, **operational technology (OT) / industrial control systems (ICS) engineers**, **privacy officers**, and all staff with security responsibilities.
   - Use controlled distribution, with version-aware acknowledgement or attestation records.
5. **Define when reviews and updates must happen**:
   - Review and update the **policy** at least **annually** and after events such as security incidents or breaches, audit findings, major system changes, and changes to relevant laws or directions.
   - Review and update the **procedures** at least **annually** and after the same event set.
   - Keep a change register that links each trigger to the decision (update or no update) and records the approval.

###### WHO
- **Chief Information Security Officer (CISO)**: owner/manager of the integrity policy and procedures life cycle, including drafting, submitting for approval, and distributing them.
- **Security Governance Board**: provides governance approval and oversight.
- **Security programme + Privacy programme**: work together to develop and review content so security and privacy assurance are aligned.
- **System owners / OT/ICS engineers / privacy officers**: recipients of the procedures and contributors for system-specific implementation guidance.

###### Acceptance criteria
- An organisation-level integrity **policy document** exists, is under document control, is approved by the Security Governance Board, and clearly aligns with applicable laws, directions, regulations, internal policies, standards, and guidance.
- Integrity **procedures** exist and provide implementation guidance (not just a repeat of the system and information integrity controls). They must include evidence expectations and explain how review and update triggers are handled.
- Distribution can be demonstrated through records showing the correct document versions were provided to:
  - all employees, contractors, and privileged users with access to **Confidential or Classified systems** (policy), and
  - system owners, OT-ICS engineers, privacy officers, and staff with security responsibilities (procedures).
- Review and update activity can be demonstrated:
  - at least **annual** review for both the policy and the procedures, and
  - event-driven reviews after incidents or breaches, audit findings, major system changes, and legal or direction changes, with documented decisions and approvals.

###### Actions Required for Compliance

- [ ] Appoint the Chief Information Security Officer (CISO) as the official owner of the system and information integrity policy and procedures, including managing their full lifecycle.
- [ ] Co-develop the organisation-wide integrity policy with the Privacy programme and align it with relevant laws, directives, regulations, and internal standards.
- [ ] Write integrity procedures as step-by-step implementation guides (including what proof is expected and how to handle exceptions) rather than repeating the security information and event management (SIEM) controls.
- [ ] Publish the policy and procedures under document control, with version numbers, an approval workflow, and a defined retention period.
- [ ] Share the policy with all employees, contractors, and privileged users who have access to confidential or classified systems, and record their acknowledgement.
- [ ] Share the procedures with system owners, operational technology (OT) and industrial control systems (ICS) engineers, privacy officers, and all staff with security responsibilities, and record their acknowledgement.
- [ ] Set up a review and update timetable (at least every year) and trigger reviews when events happen (incidents, audit findings, major system changes, and changes to laws or official directives). Record all changes in a documented change log.


---

### SI-2 — Flaw Remediation (Control)

This requirement is about fixing known security weaknesses quickly and safely, rather than leaving systems exposed or installing updates without proper checks. Without it, attackers could take advantage of weaknesses before the organisation applies fixes, and updates that have not been tested could accidentally disrupt important services or reduce performance.

The organisation must identify security-relevant software and firmware weaknesses, report them to the appropriate internal teams responsible for security and privacy, and then fix them using approved solutions. Any software or firmware update used to address a weakness must be tested first to confirm it actually resolves the problem and does not cause harmful side effects. The test results must be kept as evidence.

Security-relevant software and firmware updates must be installed within 14 days of release. Updates must come only from authorised sources, and the organisation must verify the update is genuine before downloading or installing it.

All fixes for weaknesses must be included in the organisation’s change and configuration tracking process, so that actions taken, approvals given, and test evidence can be traced and checked.

##### 14-day flaw remediation with tested, tracked patch/firmware releases

- Category: Software
- Priority: Critical

###### WHAT must be done
Implement a controlled process to fix security weaknesses in software and firmware that: (1) finds and reports security-relevant flaws to the designated information security and privacy responsibilities, (2) fixes them by installing security-relevant updates within the organisation-defined time period of **14 days** after the vendor release, (3) checks that updates come from authorised sources and are genuine, (4) tests the fixes to confirm they work and do not cause unwanted side effects, and (5) records the work and supporting evidence through configuration management and change control.

###### WHY (control requirement)
SI-2 requires organisations to fix system flaws by identifying affected systems, reporting to designated security and privacy personnel, and correcting flaws using security-relevant updates. It also requires controlled patching for mission-critical systems, testing the fixes for effectiveness and side effects, verifying updates come from authorised sources, and recording the remediation in configuration management so actions can be tracked and verified. The organisation-defined parameter sets a **time period of 14 days** to install security-relevant software updates after release.

###### HOW (specific steps/approach)
1. **Create a remediation workflow linked to vulnerability information**: bring in flaw findings from scanning, continuous monitoring, assessments, and incident response; match each flaw to the affected application parts and hosting assets using the official asset inventory (including separation between production, test, and disaster recovery environments).
2. **Assign clear responsibility and reporting**: for each security-relevant flaw, create a remediation record/work order and route it to the designated information security and privacy responsibilities (and the accountable application or infrastructure owner), including required details (CVE/advisory, affected systems, severity, and the deadline).
3. **Apply the 14-day service level agreement (SLA) in the workflow**: start the countdown from the vendor release date; automatically flag items nearing the deadline; allow documented and approved exceptions only when testing or availability constraints make testing not necessary or not practical (for example, updates that change malicious code signatures), in line with the control guidance.
4. **Use a controlled patching environment and authorised update sources**: download updates only from vendor portals or internal repositories that require digital signature checks (or equivalent proof of authenticity such as cryptographic hashes where signatures are not available). Block unsigned or untrusted files.
5. **Require testing before installation, with evidence kept**: for each update type, run a test plan that confirms (a) the fix works (for example, the corrected version/build is deployed and the flaw is no longer present where it can be measured) and (b) there are no harmful side effects (for example, basic “smoke tests”, performance/latency checks, and regression checks appropriate to the change). Store the test results as audit evidence linked to the remediation record.
6. **Roll out updates in stages for mission-critical systems**: move updates through pilot → wider → full deployment stages to confirm they work correctly in the application environment while maintaining availability. Set clear rollback/mitigation criteria for each type of update.
7. **Record remediation through configuration management and change control**: ensure the remediation record, approvals, test evidence, proof of where the update came from (authorised source plus authenticity verification), deployment logs, and the resulting software/firmware versions are stored in the configuration management database (CMDB) and the change management system, with traceability from flaw → work order → deployed versions.

###### WHO (role responsible)
- **Cybersecurity Vulnerability Management Lead**: responsible for mapping flaws to assets, enforcing the SLA, and reporting to the designated information security and privacy responsibilities.
- **Application Owner / Service Owner**: approves the remediation approach and the testing scope for the enterprise business application.
- **Infrastructure/Platform Engineering (IT/Operational Technology where applicable)**: runs the controlled patching environment, maintains authorised update repositories, and manages the staged deployment process.
- **Change Manager / Configuration Manager**: ensures configuration management and change control traceability and that evidence is retained.

###### Acceptance criteria
- For security-relevant software/firmware flaws, affected systems are identified and remediation records are created with assigned owners and reporting to the designated information security and privacy responsibilities.
- Security-relevant updates are installed **within 14 days** of vendor release for applicable items, with documented and approved exceptions where testing is not necessary or not practical.
- All update files are obtained from **authorised sources**, and authenticity is verified before downloading/installing.
- Testing evidence exists for each remediation item before installation (confirming both effectiveness and side effects), and deployment logs confirm the intended fixed versions/builds.
- Remediation actions (flaw → work order → approvals → test evidence → deployment → resulting versions) are traceable in configuration management and change control for audit.

###### Actions Required for Compliance

- [ ] Set up a process that links each software vulnerability to the affected assets, and then creates repair (remediation) tasks with service-level agreement (SLA) deadlines based on the vendor’s release dates.
- [ ] Set up an authorised update repository and make sure authenticity is verified (for example, by checking a digital signature or using an equivalent cryptographic check) before any update is downloaded and installed.
- [ ] Create separate test plans for each type of update, and collect evidence showing the update works as intended and does not cause unwanted side effects before deploying it to the live production environment.
- [ ] Set up staged deployment “rings” (pilot first, then wider rollout, then full rollout) for mission-critical application components, and record the results of each deployment and any rollback actions.
- [ ] Link remediation records with change management and configuration management so that approvals, test evidence, the origin of each artefact, and the resulting versions can be traced.
- [ ] Assign each security-related flaw remediation record to the appropriate information security and privacy responsibilities, with a named person accountable for completing the remediation.


---

#### SI-2.2 — Automated Flaw Remediation Status (Enhancement)

This requirement is about making sure your organisation checks every week whether the software and firmware on its systems are up to date for known security problems, and can show the current status of the fix for each issue. If this is not done, outdated parts could leave weaknesses that criminals can exploit, potentially leading to data loss, service disruption, or expensive incident response.

To meet this expectation, the organisation must use automated checks. These checks should use an up-to-date record of what software and firmware is installed on each system component, then compare what is installed against relevant vendor security notices to identify which updates apply. For each component, the organisation must decide whether the needed security updates are already installed or whether a fix is still required, and store the results in a central location for review.

The organisation must also keep evidence of the weekly results, including what was scanned, the remediation status, and the vendor notice references used.

##### Weekly automated remediation status from SBOM/CMDB + vendor advisories

- Category: Software
- Priority: Critical

###### WHAT
Set up an automated process that runs at least once a week to check whether each system component has the relevant security-related software and firmware updates installed. The process must produce a record of the update position that can be audited (for example: **up to date / patch available / not compliant**), linked to the relevant software and firmware vendor security notices.

###### WHY (control requirement)
The National Institute of Standards and Technology (NIST) SI-2(2) enhancement requires the organisation to **check whether system components have applicable security-related software and firmware updates installed**, using the agreed settings for **automated mechanisms** and **frequency**. The guidance expects automated checks that can track and determine the status of known security issues for system components.

###### HOW (specific approach)
1. **Define the official inventory inputs**: use a **software bill of materials (SBOM)** and/or the **configuration management database (CMDB)** as the source of truth for installed software and firmware for each component. This must include component identifiers, product and vendor, version/build, and environment.
2. **Clean and standardise data for matching**: add a data standardisation step (for example, consistent vendor and product naming, version parsing, and mapping to the same identifiers used by scanners and security notices) to reduce incorrect mismatch results.
3. **Automate the mapping to vendor notices**: connect a vulnerability and patch compliance capability that can match the installed product and version information to **vendor security notices** (or vendor bulletin feeds) and determine which notices have fixes that apply.
4. **Work out update status for each component**: for each applicable notice or known security issue, determine whether the installed version is already fixed. Record the update status as a structured field (for example: `status=up_to_date|patch_available|not_compliant|unknown`) and include the notice identifiers plus references to where the fix is included (for example, “fixed in / update required to”).
5. **Run at the agreed frequency (weekly)**: schedule the process to run at least weekly for all in-scope components, including production and other managed environments (such as test, development, and disaster recovery), as defined in scope.
6. **Store and keep evidence centrally**: save the weekly results in a controlled repository or dashboard with unchangeable run details (scan date and time, component list, inventory source version, security notice mapping version, and the update status results) so that audit evidence can be retrieved.

###### WHO
- **Security Engineering / Vulnerability Management Lead**: responsible for the logic that maps vendor notices to components, the definitions used for update status, and configuration of the scanning and compliance platform.
- **Asset/Configuration Management (CMDB) Owner**: ensures component identity and inventory feeds are complete and accurate.
- **Platform/Cloud and Infrastructure Engineers**: build and run the scheduled process and the integrations (SBOM/CMDB extraction, standardisation, and storage).
- **Information Security Governance / Compliance**: checks that evidence is retained correctly and that weekly runs cover the agreed scope.

###### Acceptance criteria
- Automated checks run at least **weekly** for all in-scope components.
- For each component, the process outputs an update status showing whether **applicable security-related software and firmware updates** are installed.
- Results include **vendor security notice references** (identifiers) and clear “fixed in / update required to” information sufficient to support the stated update status.
- Weekly evidence is kept and can be retrieved, including run details (timestamp, component identifiers, inventory snapshot/version, security notice mapping version, and update status outputs).
- Matching is shown to be consistent (for example, standardisation reduces the proportion of **unknown** or unmatched results to an agreed level, or any exceptions are clearly flagged for investigation).

###### Actions Required for Compliance

- [ ] Choose and set up an automated system that checks for security weaknesses and applies patches, and that can link vendor security alerts to the affected items and show the repair (remediation) status.
- [ ] Make the software bill of materials (SBOM) and configuration management database (CMDB) the official source of records for all installed software and firmware, tracked by component, including the product and supplier (vendor) and the version and build details.
- [ ] Implement inventory normalisation (using standard vendor, product, and version names) to improve the accuracy of advisory matching.
- [ ] Set up an automated weekly process that pulls the inventory list, matches it to vendor security advisories, and calculates the repair status for each component.
- [ ] Store weekly remediation status reports and run details in a central, access-controlled repository with write-once (immutable) retention.
- [ ] Link remediation status updates to the ticketing and workflow system so that components are flagged for follow-up when a patch is available or when they are not compliant.


---

#### SI-2.3 — Time to Remediate Flaws and Benchmarks for Corrective Actions (Enhancement)

This requirement is about making sure the organisation fixes identified problems quickly and can prove it. If weaknesses are found but not corrected fast enough, they can be used to disrupt services, steal or damage information, or cause costly downtime and reputational harm.

To meet this expectation, the organisation must measure how long each identified problem takes to fix—from the time it is identified until it is fully resolved. It must keep clear records of the dates and times so the total elapsed time can be calculated and checked.

The organisation must also set clear target timeframes for corrective action based on severity: **Critical within 15 days, High within 30 days, Medium within 60 days, and Low within 90 days**. These targets should be used to guide prioritisation and planning.

Finally, the organisation should be able to show that it monitors performance against these targets and, for each problem, whether the time taken met the relevant timeframe.

##### Measure flaw-to-remediation time and enforce severity benchmarks

- Category: Software
- Priority: Critical

###### WHAT
Set up an auditable “flaw case” process that records:
- the date and time when a flaw is identified, and
- the date and time when the fix is fully verified,

then calculates how long it took and compares it with the organisation’s agreed corrective-action targets by severity (Critical: 15 days, High: 30 days, Medium: 60 days, Low: 90 days).

###### WHY (control requirement)
The SI-2(3) enhancement guidance requires the organisation to:
- work out the average time to fix system flaws after they are identified, and
- set time targets (benchmarks) for corrective actions, potentially based on severity.

The organisation must be able to show evidence that fixes meet the relevant target.

###### HOW (specific steps/approach)
1. **Create a standard flaw-case record** in the enterprise ticketing/workflow system (for example, ServiceNow or Jira). Required fields must include: *severity*, *affected asset(s)*, *flaw identification date/time*, *remediation completion date/time*, *verification evidence type*, and *final outcome* (for example, Verified Remediated / Exception).
2. **Automatically create cases from findings** (from scanners, endpoint detection and response, cloud security, or software-as-a-service security advisories) so the *identification date/time* is filled in from the finding or first validated confirmation time, following the organisation’s procedure. Do not rely on manual free-text entry.
3. **Set and enforce severity assignment rules** at the point of intake. These rules must translate the finding’s risk/severity into the organisation’s four target bands (Critical/High/Medium/Low). Store the rule in the workflow configuration and require it to be selected or derived automatically.
4. **Define what “fully verified” means** as a workflow checkpoint. Verification must use one of the organisation-approved evidence types (for example, patch deployment confirmation, configuration drift remediation confirmation, confirmation of signed artefact deployment, or re-scan validation). Record the *remediation completion date/time* from the authoritative system/change record used for verification.
5. **Calculate elapsed time and target compliance**: calculate `remediation_completion_timestamp − identification_timestamp` in days, compare it to the configured targets (15/30/60/90), and automatically flag cases that miss the target for escalation and documented exception handling.
6. **Provide management evidence and monitoring**: produce dashboards/key performance indicators by severity (for example, % completed within target, average/median elapsed time, and number of exceptions) and keep management review records linked to the reporting period.

###### WHO
- **Application Owner / Security Engineering Lead**: owns the flaw-case process definition, severity mapping rules, and remediation verification requirements.
- **Security Operations Centre (SOC) / Vulnerability Management Team**: ensures findings are correctly imported and cases are created and triaged.
- **Service Management (ITSM) Administrator / Workflow Engineer**: builds the workflow fields, automation, and reporting.
- **Chief Information Security Officer (CISO) / Security Governance (or delegate)**: reviews the KPI outputs and approves exception handling where needed.

###### Acceptance criteria
- For a sample of active and closed flaw cases, the organisation can show **(a)** the identification date/time, **(b)** the remediation verification date/time, and **(c)** the calculated elapsed time for each case.
- For each severity band, the organisation can show that cases are **flagged** when elapsed time exceeds the configured target (Critical 15 days, High 30 days, Medium 60 days, Low 90 days) and that exceptions are documented.
- Management reporting is in place showing trends in target compliance and includes evidence of review for the reporting period.
- Severity assignment follows the configured mapping rule and is not changed manually without an auditable justification.

###### Actions Required for Compliance

- [ ] Set up the flaw-case workflow fields in the IT service management (ITSM) system: **severity**, **identification time and date**, **remediation verification checkpoint**, **remediation completion time and date**, and **final status**.
- [ ] Set up automated intake to create “flaw cases” from vulnerability, endpoint detection and response (EDR), and cloud findings, using identification dates and times taken from the most reliable (authoritative) sources.
- [ ] Set up rules that map each case to a severity level (Critical, High, Medium, or Low) in a consistent way.
- [ ] Set the types of evidence required to verify remediation, and require workflow sign-off to record the remediation completion time using the authoritative verification record.
- [ ] Calculate how long each item has taken and automatically compare it against 15, 30, 60 and 90 day targets, escalating any cases that fall outside the targets.
- [ ] Create key performance indicator (KPI) dashboards and keep records of management reviews linked to each reporting period to support benchmark compliance monitoring.


---

#### SI-2.4 — Automated Patch Management Tools (Enhancement)

This requirement is about automatically keeping software and devices up to date, so known security weaknesses are fixed quickly. If updates are slow or incomplete, attackers can take advantage of weaknesses in operating systems, web browsers, application software, and network devices. This could result in data loss, disruption to services, or unauthorised access.  

To meet this expectation, the organisation must use automated patch management tools that can identify and apply security fixes to all required types of components, including enabling automatic software and firmware updates. The organisation must also clearly document how updates and security flaw fixes are handled, what settings are used for automatic updates, which types of weaknesses the updates are intended to address, and how the system is set up to support this process.  

The organisation must keep records of recent security-related updates that were automatically installed and maintain audit records showing patch activity. It must also assign named responsibilities to the relevant staff and include these expectations in its overall security plan and procedures.

##### Automated patch tooling for OS, browsers, apps and network devices

- Category: Software
- Priority: Critical

###### WHAT
Deploy and run automated patch management tools that find missing security updates and help fix security issues for the defined system components: **operating systems, web browsers, application software, and network devices**.

###### WHY (control requirement)
NIST SI-2(4) (Enhancement) requires the organisation to **use automated patch management tools** to help fix security issues for the specified component types. Automated tools support **patching that is timely and complete**.

###### HOW (specific approach)
1. **Choose and connect an enterprise patch automation platform** (agent-based or agentless where appropriate) and link it to the organisation’s official asset inventory, so the tool only targets in-scope components.
2. **Set patch automation rules** to cover:
   - **Operating systems**: detect security updates and apply fixes (for example, security-only updates where supported; severity thresholds).
   - **Web browsers**: enable enterprise browser update channels and automatic update features where supported, or manage updates through the patch platform.
   - **Application software**: automate updates using vendor-supported methods (signed repositories, update feeds, package management integrations) and ensure only authorised update sources are used.
   - **Network devices**: automate firmware/software patch processes using vendor-supported methods and application programming interfaces (APIs), or orchestration playbooks where available.
3. **Turn on automatic installation** for supported update categories (for example, low/medium risk security updates) and use centrally agreed maintenance windows and reboot handling rules for higher-impact updates.
4. **Use security issue information to drive fixes** by linking vulnerability/advisory information (for example, vendor advisories and Common Vulnerabilities and Exposures (CVEs)) to asset groups, and ensuring the patch tool’s “which systems apply” logic matches the in-scope component types.
5. **Create audit-ready proof** by exporting patch compliance and installation records (what was installed, when, and on which assets) into the organisation’s logging system and security information and event management (SIEM), and keeping records of automatically installed security updates.

###### WHO
- **Infrastructure/Platform Engineering Lead**: responsible for selecting the tool, integrating it, and setting the patch rules.
- **Cybersecurity Vulnerability Management Lead**: responsible for linking security issues to patch applicability and for update prioritisation logic.
- **IT Operations / Network Engineering**: checks that network device patch processes work correctly and that maintenance windows are followed.
- **Information Security / Compliance**: checks that audit evidence is kept and that the control is effective.

###### Acceptance criteria
- The automated patch tool is working and **covers all defined component types**: operating systems, web browsers, application software, and network devices.
- For each component type, the tool can **identify missing security updates** and **support remediation** (automatic or approved-by-policy installation) based on the configured automation rules.
- Patch automation produces **auditable records** showing which security updates were installed and the dates/times, kept according to organisational requirements.
- Patch applicability is clearly linked to **relevant security issue information** (for example, advisory/CVE mapping) for in-scope asset groups.
- Network device patching is carried out through an **automated workflow** (vendor-supported method/API/orchestrated playbook), with evidence captured for audit.

###### Actions Required for Compliance

- [ ] Choose and install an enterprise patch management system that is linked to the official record of all assets.
- [ ] Set up automated patching rules to cover operating systems, web browsers, application software, and network devices.
- [ ] Set up automatic installation for supported types of security updates, and define when maintenance can run (maintenance windows) and the rules for restarting computers (reboot rules).
- [ ] Integrate vulnerability and advisory information to match relevant security weaknesses to the asset groups that are included in scope, and to determine which patches apply.
- [ ] Set up automated processes to update network device firmware and software using vendor-supported application programming interfaces (APIs) or pre-built automation scripts (orchestration playbooks).
- [ ] Export and keep records of patch installation activity (what was installed, when it was installed, and where it was installed) in the security information and event management (SIEM) system or the central logging system to provide audit evidence.


---

#### SI-2.5 — Automatic Software and Firmware Updates (Enhancement)

This requirement is about making sure important software and device updates are installed automatically, so known security weaknesses do not remain unaddressed. If updates are not automatic, attackers can take advantage of weaknesses soon after they are discovered. Delays can leave production systems, computers, network protection devices, and industrial control equipment exposed. Updates that are applied at the wrong time can also disrupt operations, so the approach must protect both system safety and day-to-day availability.

The organisation must set up every production server, end user device, network security device, operational technology (OT) gateway, and industrial control system controller to automatically install security-related software and firmware updates from approved vendors, aiming to install them as soon as possible after release. It must use an update method that reduces the risk of disrupting services, such as rolling updates in stages rather than all at once. The organisation must also document its update and flaw-fixing approach, keep configuration details, and retain records and audit evidence showing which updates were installed automatically and when.

##### Automatic security update installation with staggered rollout

- Category: Software
- Priority: Critical

###### WHAT
Automatically install **security-relevant software and firmware updates** (operating system, hypervisor, end-user devices, network equipment, and security tools) from **approved suppliers** onto specific **production system parts** (production servers, end-user devices, network security devices, operational technology gateways, and industrial control system controllers). Use an update method that balances speed with managing configuration changes and limiting disruption (for example, **staggered roll-outs**).

###### WHY (control requirement)
NIST SP 800-53 SI-2(5) (Enhancement) requires: **“Install {{ param, si-02.05_odp.01 }} automatically to {{ param, si-02.05_odp.02 }}.”**
The guidance also requires considering **system trustworthiness and system availability**, and balancing installing as quickly as possible with **business/operational impact**, commonly through **staggered deployment**.

###### HOW (specific approach)
Set up an organisation-wide update co-ordination capability that enforces automatic installation for the defined scope and uses ring-based scheduling to reduce the risk of outages.

1. **Define and enforce what is in scope**
   - Keep an authoritative list of assets (asset register) that labels each eligible component as belonging to {{ param, si-02.05_odp.02 }} and states which update types it supports (operating system, hypervisor, end-user device, network security device, operational technology gateway/controller).
   - Keep an authoritative allow-list of updateable items and approved supplier sources for {{ param, si-02.05_odp.01 }}.

2. **Set up automatic installation (not just notifications)**
   - For each eligible component type, configure the update process to **automatically install** security-relevant updates from the approved sources.
   - Ensure the policy clearly blocks non-approved sources and prevents installation of unknown items.

3. **Use staggered roll-outs (rings) to protect availability**
   - Use ring-based roll-out (for example: trial/internal ring → business-critical ring → remaining production) with defined time windows.
   - Apply operational safeguards for each component type (for example: coordinating reboots for servers and end-user devices; using maintenance windows; health checks; checking service dependencies; and doing pre- and post-update validation).

4. **Ensure trust, traceability, and readiness to reverse changes**
   - Require signed update packages and/or checksum checks where supported.
   - Record the supplier, product, version, and package identifiers for every update installed automatically.
   - Keep rollback and mitigation plans aligned to the update process (where supported by the supplier) and document the conditions needed before rollback.

5. **Produce evidence suitable for audit**
   - Generate automated reports showing: which updates were installed automatically, on which components, and the installation times (by ring).
   - Keep logs detailed enough to prove compliance with automatic installation and the staggered approach.

###### WHO
- **Infrastructure/Platform Engineering Lead**: owns the update co-ordination configuration and ring strategy.
- **Security Operations / Vulnerability Management Lead**: owns the approved supplier/source list and the criteria for selecting security-relevant updates.
- **OT/ICS Engineering Lead (where applicable)**: confirms safe limits for automation for operational technology gateways/controllers and approves component-specific roll-out safeguards.
- **System Administrators / Device Management Team**: runs the update platform and monitors roll-out health.

###### Acceptance criteria
- For all assets labelled as {{ param, si-02.05_odp.02 }}, security-relevant updates from approved suppliers {{ param, si-02.05_odp.01 }} are **installed automatically** (no manual approval is required for installation).
- Roll-outs use a **staggered/ring-based** approach with defined scheduling and operational safeguards.
- The system provides audit evidence showing **update supplier/source, update identifiers, target component, and installation time** for automatically installed updates.
- Integrity controls prevent installation of unapproved, unsigned, or unknown items (as supported by the update process).
- If a roll-out fails, defined remediation/rollback actions are triggered, and it does not lead to uncontrolled simultaneous deployment across all production components.

###### Actions Required for Compliance

- [ ] Create and maintain an up-to-date master list that maps each production component to the updateable categories in **si-02.05_odp.02**.
- [ ] Set up an approved list of trusted vendors and sources for security-relevant software and firmware updates in **SI-02.05 ODP.01**.
- [ ] Set up the update management system to automatically install security-related updates for the agreed scope (turn off “notify only” and manual approval for that scope).
- [ ] Set up ring-based phased release schedules for production targets, and define planned maintenance periods and health-check approval points.
- [ ] Enable integrity checks for update files (for example, signed packages and checksum validation) and block any unapproved or unknown update files.
- [ ] Set up automatic reporting and secure storage of logs so you can record the update vendor and version, the affected component, and the installation date and time as audit evidence.
- [ ] Define and test rollback and mitigation procedures for each type of component, so that you can respond if automatic updates fail or cause problems.


---

#### SI-2.6 — Removal of Previous Versions of Software and Firmware (Enhancement)

This requirement is about making sure that when your organisation updates software and device settings, it also removes the older versions that have been replaced. If older versions are left in place, they can sometimes be used as a “back door”, allowing criminals to take advantage of weaknesses that have already been fixed in the newer update.

To meet this expectation, the organisation must identify every item that has been updated across the operating system, business applications, device drivers, and device firmware, and then remove the previous version(s) after the new version has been installed. This includes making sure there is no remaining option to roll back to, or reuse, the older versions.

The organisation should have clear, documented procedures for how the removal is carried out, assign named staff responsible for doing it, and keep reliable records showing what was removed and when. These records should be supported by system logs or other audit evidence that can be checked later.

##### Purge prior software/firmware versions post-update with audit evidence

- Category: Software
- Priority: Critical

###### WHAT
After updated software and firmware parts are installed, remove the older versions from the information system so they are no longer present or available for misuse (including any rollback or recovery leftovers where this is possible).

###### WHY (control requirement)
The requirement **NIST security control SI-2(6)** says: **"Remove previous versions of {{ insert: param, si-02.06_odp }} after updated versions have been installed."** The guidance explains that **if older versions are not removed after updates, they may be misused**, and that **some products automatically remove older versions**. Therefore, the organisation must both remove them and check that this has happened.

###### HOW (specific approach)
Set up an **"update + purge"** process that is built into the organisation’s endpoint, patch, and firmware management tools and into the change and release process.

1. **Set the official list of what counts** as SI-02.06_odp ("software and firmware components") for each environment (production, test, disaster recovery) and for each device or application group. This includes the operating system, applications, drivers, and device firmware.
2. **Run updates using managed release instructions (manifests)** that state the target version and the expected removal actions. For example: uninstall older packages that have been replaced, remove older driver packages from the driver store, clear old boot or rollback entries where supported, and remove any vendor update staging or recovery images where applicable.
3. **Add a removal step after installation**, and run it only after the updated version is confirmed to have installed successfully. For example: check package results, confirm service health, verify the active driver version, and confirm firmware update completion.
4. **Check that older versions are gone** using system checks that match the type of component:
   - **Operating systems and applications:** confirm only the target version is installed; remove old installers or cached packages and any side-by-side versions unless an exception is explicitly approved.
   - **Drivers:** confirm the active driver version matches the release instructions and that older driver packages are not kept in the managed driver store.
   - **Firmware:** confirm the device reports the updated firmware version; remove any temporary recovery bundles or older firmware items created or kept by the update process where the vendor tools support this.
5. **Reduce or remove rollback and reuse options where possible** as part of the removal checks. For example: remove old boot entries or images where allowed by platform policy; ensure the update tools do not leave a selectable previous version.
6. **Keep audit-ready proof for each update**, including: the change ticket or reference, component name, the previous version(s) found, the updated version installed, the removal actions carried out, and the results of the checks (including logs from the management platform and the post-removal state checks).
7. **Treat vendor “auto-removal” as something to verify**, not something to assume. Even if the vendor claims older versions are automatically removed, the process must still confirm they are not present.

###### WHO (roles responsible)
- **Infrastructure/Endpoint Management Lead:** owns the update + purge process setup and the verification logic.
- **Change Manager / Release Manager:** ensures the removal step is included in the approved change or release package.
- **System Owner / Application Owner:** approves any exceptions (for example, where a platform cannot remove certain items) and ensures the documented compensating controls are in place.
- **Security/Compliance Analyst:** checks that the audit evidence is complete against the SI-2(6) requirements.

###### Acceptance criteria
- For every managed update of a component within the SI-02.06_odp scope, the system state after the update shows **only the updated version** (or otherwise confirms that no older version items remain or are available), as verified by automated checks.
- For each update event, evidence exists showing: **which previous version(s) were identified**, **the updated version installed**, **which removal actions were carried out**, and **the verification results**.
- If a vendor automatically removes older versions, the process still produces evidence showing that previous versions are absent.
- If a specific item cannot be removed, this is either confirmed as not applicable (verified as absent) or handled through a formal exception process with documented compensating controls (outside the scope of this control item).

###### Actions Required for Compliance

- [ ] Define the scope mapping for **SI-02.06** for each environment and each device or application group, covering **operating systems (OS)**, **applications**, **device drivers**, and **device firmware**.
- [ ] Create update release manifests that list the target versions and the expected purge actions for each component type.
- [ ] Add an automated clean-up step after installation in the patch and firmware deployment process. This step should run only after the update has been confirmed as successful.
- [ ] Add verification checks to confirm that older versions are not present. This includes checking the installed version, checking the driver storage area, reporting the firmware version, and removing any update “staging” or recovery files where this is supported.
- [ ] As part of the purge checks, configure the rollback and reuse paths to be removed or turned off where this is practical.
- [ ] For each update event, capture and keep audit-ready evidence in the management platform logs and change records, including the previous versions identified, any purge actions carried out, and the verification results.


---

#### SI-2.7 — Root Cause Analysis (Enhancement)

This requirement is about understanding the real reason something went wrong, fixing it properly, and then showing that the fix worked. If problems are only recorded based on what was noticed at the time, the same issue can happen again, leading to repeated disruption, wasted effort, and avoidable harm to customers, staff, or day-to-day business operations.

To meet this expectation, the organisation must carry out a structured review for every significant problem or failure. The review must identify the underlying cause, not just the immediate trigger. The organisation must also decide how quickly the review is completed based on how serious the problem is.

The review should include:
- a clear timeline
- the key decisions made
- any warning signs that were missed
- gaps and contributing factors
- what safeguards were already in place

The organisation must then:
- plan corrective actions
- assign responsibility and target dates
- implement the changes
- monitor results to confirm they are effective
- document the findings and outcomes
- update relevant policies, procedures, and improvement activities

This ensures lessons learned are built into everyday practice.

##### Automated incident-to-RCA workflow with corrective actions and effectiveness checks

- Category: Software
- Priority: Critical

###### WHAT must be done
For every major system problem or failure, carry out a structured root cause analysis (RCA) and create a complete RCA record. Then put in place corrective actions that address the real underlying causes, and confirm they worked using supporting evidence. Finally, use the lessons learned to update any relevant organisational policies, procedures, and system improvement activities.

###### WHY (control requirement)
SI-2(7) enhancement requires that the root cause analysis includes, at minimum: a timeline, any missed warning signs (where applicable), key decisions, gaps, mitigations, and confirmation that the actions were effective (with evidence). It also requires that actions identified to fix the source are carried out and built into any relevant organisational policy, procedures, and control implementation.

###### HOW (specific steps/approach)
Set up an “incident-to-improvement” process in the organisation’s IT service management (ITSM) or ticketing system, and link it to change and configuration management and to the collection of monitoring evidence:
1. **Define what triggers an RCA and how fast it must be completed**: configure rules to flag events that qualify (for example, production outages, repeated failures, failures that affect security, or incidents that meet severity thresholds). Set a service level agreement (SLA) for completing the RCA based on severity.
2. **Use a structured RCA template**: require the RCA record to include mandatory information: timeline, missed warning signs (where applicable), key decisions, gaps or contributing factors, existing mitigations, and the explicit underlying cause(s) (not just the symptoms). Require selection of an RCA method suitable for the severity (for example, “5 Whys”, fishbone/Ishikawa, or causal factor analysis).
3. **Link underlying causes to corrective actions**: for each underlying cause, require one or more corrective action tasks, each with an owner, target date, description of what will be done, and an **effectiveness measure/evidence plan** (what will be measured and where the evidence will be stored).
4. **Connect to controlled change management**: automatically link corrective actions that require code, configuration, or design changes to the organisation’s change management records (and configuration management where applicable). Do not allow the RCA to be closed until the required change approvals are completed.
5. **Check effectiveness and close the loop**: schedule a monitoring period after the changes are made, and require evidence that the effectiveness measure was met (for example, a lower recurrence rate, improved error budget/service level objectives, or no recurrence of the specific failure). Record the results in the RCA.
6. **Embed lessons learned into improvements**: require that the RCA outcome is reviewed by the relevant governance forum (for example, application security or engineering governance). Ensure any needed updates to runbooks, hardening standards, detection rules, or control implementation are created and tracked.

###### WHO (role responsible)
- **Incident Manager / Service Owner**: ensures the RCA is triggered and completed within the severity-based SLA.
- **RCA Lead (Engineering/Architecture)**: completes the structured RCA template and the underlying cause analysis.
- **Change Manager / Configuration Manager**: ensures corrective actions are delivered through controlled change and configuration processes.
- **Security/Monitoring Owner**: checks the effectiveness evidence and updates detections or controls where needed.
- **Governance Forum (for example, Application Security Steering Group)**: approves updates to policy, procedures, and control implementation.

###### Acceptance criteria
- For each qualifying major event, there is an RCA record with all required elements completed: timeline, missed warning signs (where applicable), key decisions, gaps/contributing factors, existing mitigations, and underlying cause(s).
- Corrective actions are created for each underlying cause, and each action includes an owner, target date, and effectiveness measure/evidence plan.
- Corrective actions that require changes are implemented through controlled change management and are traceably linked back to the RCA.
- Effectiveness verification evidence is recorded after implementation within the defined monitoring window, and the RCA is not closed until verification is complete.
- Lessons learned are incorporated into tracked updates to the relevant policies, procedures, runbooks, and control implementation (or a clear documented reason is recorded for why no update was needed).

###### Actions Required for Compliance

- [ ] Set up IT service management (ITSM) workflow rules so that root cause analysis (RCA) is started for significant events that meet the criteria, and define completion timeframes for RCA based on event severity.
- [ ] Create a root cause analysis (RCA) template that requires the following information: the timeline, any missed warning signs (where applicable), the key decisions made, the gaps and contributing factors, the existing measures already in place to reduce the risk, and the underlying cause(s).
- [ ] Within the root cause analysis (RCA) workflow, enforce selecting and recording the root cause analysis (RCA) method that is appropriate for the incident severity.
- [ ] Set up automated tracking that links each underlying cause to the corrective action tasks, including the responsible owner, the target completion date, and a plan for how effectiveness will be measured (with the evidence to be collected).
- [ ] Integrate corrective actions into controlled change management and configuration management, and link each change back to the root cause analysis (RCA) that identified the issue.
- [ ] Set up a schedule to check whether changes worked after they are made, and collect supporting evidence before closing the root cause analysis (RCA).
- [ ] Send the root cause analysis (RCA) findings to the appropriate governance forum, and create tracked updates to the runbooks, policies, procedures, and control implementation where the lessons learned should be applied.


---

### SI-3 — Malicious Code Protection (Control)

This requirement is about preventing harmful software from entering your systems and removing it quickly once it is found, wherever files come into or leave your organisation. Without it, viruses, spyware and other malicious code could enter through email, websites or portable devices, take advantage of weaknesses, disrupt services, steal information, or make systems unavailable.

To meet this expectation, the organisation must use both traditional detection methods and behaviour-based detection at key points where data enters or leaves, such as workstations, servers, email and web services, remote access, proxy services, notebooks and mobile devices. When a threat is detected, it must be blocked or moved into quarantine.

The protection tools must update automatically whenever new updates are available, following the organisation’s change-management rules. They must run daily full scans and also scan files from external sources in real time as they are downloaded, opened or run, in line with policy.

When detections occur, alerts must be sent to the security operations centre (SOC) incident response team lead and the information system security officer. The organisation must also manage false alarms while minimising any impact on service availability.

##### Layered malicious code protection for endpoints and network entry/exit

- Category: Software
- Priority: Critical

###### WHAT
Put malicious code protection in place at every defined point where systems receive or send data (endpoints and network), using both **signature-based** and **non-signature-based** detection. Run **daily scheduled scans** and also scan files in **real time** when they are received from external sources. Set detections to **block** or **quarantine** malicious code, and to trigger **security operations centre (SOC) incident response** notifications.

###### WHY (control requirement)
Security control SI-3 requires malicious code protection at system entry and exit points. This must cover common ways software can be delivered or introduced (email, web, and portable storage) and attacks that take advantage of software weaknesses. The guidance specifically requires both **signature-based** and **non-signature-based** technologies, including **heuristics/artificial intelligence (AI)** and **reputation-based** methods, along with **daily scans** and **real-time scanning** for files from external sources. It also requires clear actions when detections occur (for example, block/quarantine and SOC notification) and appropriate handling when detections are not effective.

###### HOW (specific steps/approach)
1. **Define and enforce coverage** for the application’s relevant entry and exit points: workstations, notebooks, mobile devices, remote access servers, email servers, web servers, proxy/security web gateway (SWG), and any other points that bring in or send out external content.
2. **Deploy endpoint malicious code protection** (endpoint detection and response (EDR) and next-generation anti-virus (NGAV)) on all in-scope endpoints, with:
   - **signature-based scanning** enabled
   - **non-signature-based detection** enabled (heuristics/behavioural/AI and reputation where supported)
   - **real-time protection** configured to scan files on **download/open/execute**
   - archive/container inspection enabled (for example, zip/rar/7z) where supported
3. **Configure network entry/exit scanning** at the email gateway and web/proxy layer to scan email attachments and web downloads, ensuring the same **block/quarantine** outcomes are applied consistently with endpoint policy.
4. **Set scan frequency** to **daily** for periodic full scans (endpoints and relevant gateway components), and ensure scan results and detections are logged centrally.
5. **Configure detection actions** to:
   - **block** or **quarantine** malicious code (quarantine is preferred where it reduces impact on availability)
   - automatically **start incident response procedures** and notify the **SOC incident response team lead** and the **information system security officer (ISSO)** for investigation
6. **Enable automatic updates** for both signature and non-signature components, using the organisation’s configuration management and change management process (for example, staged rollout with rollback), and keep evidence of updates that can be audited.
7. **Manage false positives** using an approved workflow (for example, allowlisting/exception handling with a security review) to minimise impact on availability while keeping protection effective.

###### WHO
- **Information System Security Officer (ISSO)**: owns policy alignment, the criteria for detection actions, and governance for exceptions/false positives.
- **SOC Incident Response Team Lead**: receives alerts, assesses detections, and coordinates investigation and containment.
- **Endpoint/Network Security Engineering**: implements and maintains endpoint and gateway configurations.
- **Configuration Management/Change Manager**: ensures updates are rolled out using approved change and configuration procedures.

###### Acceptance criteria (evidence-based)
- A central inventory shows malicious code protection is deployed and enabled on all in-scope **endpoint** and **network entry/exit** categories.
- Configuration evidence shows **signature-based** and **non-signature-based** detection are enabled.
- Operational evidence shows **daily** periodic scans are completed successfully (for endpoints and relevant gateways).
- Operational evidence shows real-time scanning triggers on externally sourced file events (download/open/execute) and that detections result in **block** or **quarantine**.
- **Security information and event management (SIEM)**/**security orchestration, automation and response (SOAR)** or alerting evidence shows detections generate alerts to the **SOC incident response team lead** and **ISSO** with enough detail for investigation.
- Update evidence shows malicious code protection components update automatically and are rolled out under configuration management with auditable logs.
- A false-positive handling workflow exists and is used for exceptions, including security review and documented outcomes.

###### Actions Required for Compliance

- [ ] Identify and document all system entry and exit points that are in scope for the application, including endpoints, email, web, proxy secure web gateway (proxy/SWG), and remote access.
- [ ] Enable signature-based detection and non-signature-based detection (heuristics and artificial intelligence, plus reputation checks) on all in-scope endpoint agents.
- [ ] Set up real-time scanning to check files when they are downloaded, opened, or run, and to also scan common compressed archive formats.
- [ ] Set up the email gateway and web or proxy malware scanning to consistently block or quarantine any detected malicious content, in line with the endpoint policy.
- [ ] Arrange and confirm daily full scans of endpoint devices and the relevant network scanning components, and store the scan results in a central logging system.
- [ ] Integrate detection alerts into security information and event management (SIEM) and security orchestration, automation and response (SOAR) so that the security operations centre (SOC) incident response team lead and the information system security officer (ISSO) are notified with the investigation context.
- [ ] Set up automatic updates for the malicious code protection components through configuration management, and put in place an approved process for handling false positives and exceptions.


---

#### SI-3.4 — Updates Only by Privileged Users (Enhancement)

This requirement is about ensuring that software updates that help protect your systems from harmful software are only started by trusted, authorised people. The real-world risk it addresses is that if someone without the right authority could start these updates, a malicious actor could potentially introduce harmful changes or interfere with the protection, leaving your organisation exposed without you noticing.

To meet this expectation, the organisation must:
- keep an up-to-date list of the privileged users who are allowed to start these updates
- configure the system so updates can only be started when a user from that list initiates them
- document the update process and the rule in its integrity and security planning documents

It must also clearly state which protection tools are covered, and keep reliable records and audit logs for every update. These records must show when the update happened, what was updated, and which authorised person started it, so compliance can be checked later.

##### Privileged-only initiation of malicious code protection updates

- Category: Software
- Priority: Critical

###### WHAT
Make sure updates to malicious code protection tools can only be started when a user who is explicitly authorised as a privileged user tells the system to begin the update.

###### WHY (control requirement)
SI-3(4) (enhancement) requires that malicious code protection tools are updated only when a privileged user directs the update. This stops unauthorised users from making security-relevant changes that could weaken defences.

###### HOW (specific approach)
1. **Create an approved list of privileged users who can authorise updates** in the enterprise identity and access management (IAM) system / identity provider (IdP) (for example, a dedicated role such as “Malicious Code Protection Update Approver”). Review and keep membership up to date.
2. **Enforce privileged-only update direction using technical controls** by limiting access to the *update start interface* (security console/management portal/endpoint management job runner) to that role only.
3. **Use strong authentication and require extra approval (step-up) for update actions** (for example, phishing-resistant multi-factor authentication (MFA) and conditional access/step-up) so the privileged user who starts the update is clearly identified at the time they direct it.
4. **Set up the update process to record who initiated it** (not just a service account) and to capture update evidence (time, what systems were targeted, and what was updated—such as signatures/engine/components) in the update record/audit trail.
5. **Centralise and keep audit evidence** by sending update-direction events to the security information and event management (SIEM) system, with tamper-resistant retention. Make sure audit records can be searched by initiating user and time.
6. **Document the process and coverage**: keep a written update procedure that states who may direct updates, how the privileged-only rule is enforced, and which malicious code protection tools/products are covered; include the rule in the system security plan and integrity/security documentation.

###### WHO
- **IAM/IdP Administrator**: creates and maintains the privileged update approver role and reviews role membership.
- **Endpoint/Security Platform Owner (for example, endpoint detection and response (EDR)/anti-virus (AV) management team)**: sets permissions for the update start interface and ensures update records capture the initiating user.
- **Security Operations / security operations centre (SOC)**: checks that audit logs are sent to the SIEM, retained correctly, and helps with evidence requests.
- **System Owner / Information Security Officer**: ensures the process and coverage are documented and referenced in the system security plan.

###### Acceptance criteria
- Only users in the authorised privileged role can start “update now” (or an equivalent) action for the malicious code protection tools covered by this requirement.
- Audit logs show the **identity of the initiating privileged user**, the date/time, and enough update detail to identify what changed.
- Audit logs are kept according to organisational requirements and are available for compliance review.
- The documented process and coverage clearly state that updates are initiated only by privileged users and match the technical enforcement in place.

###### Actions Required for Compliance

- [ ] Create an identity and access management (IAM) / identity provider (IdP) role for people authorised to approve updates for malicious code protection, and carry out regular reviews of who is in that role.
- [ ] Limit access to the malicious code protection update start screen to only the update approver role.
- [ ] Require phishing-resistant multi-factor authentication (MFA) and additional checks (step-up or conditional access) before allowing updates to be initiated
- [ ] Set up the update process so the person who starts the update is recorded in the update and audit record.
- [ ] Send audit events about update direction to the security information and event management (SIEM) system, and set tamper-resistant retention so compliance evidence is protected.
- [ ] Publish and keep up to date an update process and a list of what is covered for the malicious code protection measures that are in scope, and include the “privileged users only” rule in the system security plan.


---

#### SI-3.6 — Testing and Verification (Enhancement)

This requirement is about proving, every month, that your system’s defences against harmful code can spot something suspicious and respond in the way you expect. Without this check, a protection tool could be set up incorrectly, be out of date, or not be working properly. In that case, real malware could go undetected, and warning signs might not be raised to the right people in time.

To meet this expectation, the organisation must run an approved piece of harmless test code through the system at least once every month. The test must be designed to check the harmful-code protection.

The organisation must then confirm that:
- the system detected the test code, and
- the detection triggered the organisation’s incident reporting process.

A record must be kept showing that the test was run, that the detection happened, and that the related incident was created or updated.

##### Monthly benign canary test to verify malicious-code protection and incident flow

- Category: Software
- Priority: Critical

###### WHAT
Set up an automated, organisation-approved monthly test that runs known harmless “canary” code through the organisation’s malicious-code protection tools, checks that the protection detects it, and confirms that the resulting incident is created or updated in the organisation’s incident reporting system. The test must also produce auditable proof.

###### WHY (control requirement)
SI-3(6) (Enhancement) requires that the malicious-code protection tools are actively and repeatedly **tested and verified** at a defined frequency (an organisation setting). This is done by running approved harmless test code, proving detection works, and showing that detection triggers the incident reporting process with records kept.

###### HOW (specific steps/approach)
1. **Create and approve harmless test files/scripts**: create a signed, repeatable harmless file/script/container with a unique identifier (for example, `BENIGN-MCP-YYYYMM`). It must have no harmful behaviour (no persistence, no lateral movement, no data exfiltration). Store it in a controlled repository.
2. **Define what will be tested and how it will be introduced**: choose a representative set of targets covered by the malicious-code protection tools (for example, endpoints managed by endpoint detection and response/anti-virus, server anti-virus scan paths, and workload protection for cloud workloads). Use an environment-appropriate method so the test is processed through the same detection routes used for real threats.
3. **Run the test automatically every month**: schedule a job to run **at least once every month** (per `si-03.06_odp` frequency = monthly) within a controlled time window. The job must record the start and end time, the target identifiers, and the harmless artefact identifier.
4. **Check that detection happened**: review the security tools’ telemetry and log exports (for example, endpoint detection and response/anti-virus alerts, and cloud workload protection findings). Confirm that a matching detection event occurs within a defined correlation window, linked to the harmless identifier and the target.
5. **Confirm incident reporting**: connect the test runner to the organisation’s incident or ticket workflow (IT service management/security operations centre case tool). The automation must verify that an incident or ticket was created or updated, referencing the detection event and the harmless identifier, and that at least one status update or escalation step occurred.
6. **Create an evidence package**: store an unchangeable, audit-ready record linking **test execution → detection evidence → incident reference(s)**. This must include timestamps, the target list, the artefact identifier, detection identifiers, and incident/ticket identifiers.

###### WHO
- **Cybersecurity Operations (security operations centre/detection engineering)**: owns detection verification logic, correlation rules, and checks that incidents flow correctly.
- **Security Engineering / Platform Team**: builds and maintains the automated monthly test runner and evidence packaging.
- **IT service management/incident management owner**: ensures the incident workflow supports automated checks (create/update and status changes).
- **System/Infrastructure owners**: approve the test targets and the way the test is introduced for their environments.

###### Acceptance criteria
- The monthly job runs **at least once per month** and successfully introduces the approved harmless artefact into the defined malicious-code protection routes.
- For each run, the detection telemetry includes a matching event for the harmless identifier on each targeted asset or workload within the correlation window.
- For each detection, the incident or ticket system shows an incident that was created or updated with the harmless identifier and the detection reference, and at least one status update or escalation is recorded.
- An audit-ready evidence package exists for each monthly run and can be provided on request, showing the full chain: execution → detection → incident reference(s).

###### Actions Required for Compliance

- [ ] Approve and sign a harmless “canary” file that is the same every time, using a unique identifier for each month
- [ ] Choose and record the specific target areas that are covered by the malicious-code protection measures.
- [ ] Set up a monthly scheduled test that runs automatically, inserts the artefact, and records details about each run (execution metadata).
- [ ] Set up matching rules to confirm that the system’s detection event for the harmless identifier occurs within a specified time window.
- [ ] Connect the test runner to the incident or ticket system to confirm that incidents are created or updated correctly and that status changes are recorded properly.
- [ ] Store an unchangeable evidence package that links test execution details, detection identifiers, and the incident or ticket reference identifiers.


---

#### SI-3.8 — Detect Unauthorized Commands (Enhancement)

This requirement is about stopping and recording dangerous attempts to run highly privileged operating system actions on your most important Linux servers. Without this, a malicious or careless process could load or remove low-level system components, change how the system starts, force a restart or shutdown, change how file systems are attached, or interfere with how processes are viewed and controlled. This could potentially disrupt mission and security services or hide wrongdoing.

To meet this expectation, the organisation must monitor production on-premises Linux servers that host mission and security services for attempts to run the specific unauthorised commands **insmod**, **rmmod**, **modprobe**, **kexec_load**, **reboot**, **halt**, **poweroff**, **mount**, **umount**, **setns**, and **ptrace** through the operating system’s internal kernel interface.

If any of these attempts are detected, the system must either prevent the command from running and/or record an audit trail of the attempt, in line with the organisation’s configured response. Warning messages and audit records must clearly show what was attempted, when it was attempted, and who attempted it.

##### eBPF deny+audit for unauthorised kernel-interface commands

- Category: Software
- Priority: Critical

###### WHAT
Put in place detection (and, where configured, prevention) on in-scope production on-premises Linux servers to stop unauthorised attempts to run operating system commands through the kernel interface. The unauthorised commands to watch for are: **insmod, rmmod, modprobe, kexec_load, reboot, halt, poweroff, mount, umount, setns, ptrace**. When any of these are detected, the system must either **block the action** and/or **record it for audit** in line with the organisation’s defined response.

###### WHY (control requirement)
The SI-3(8) enhancement guidance requires detecting unauthorised operating system commands used against important interfaces beyond kernel-based interfaces, including privileged applications and actions that interact directly with the kernel. The organisation defines which commands are malicious and what response to take (block and/or audit). This approach provides detection at the kernel boundary and creates audit evidence suitable for the security operations centre (SOC) / security operations (SecOps).

###### HOW (specific steps/approach)
1. **Link each command to the kernel action it triggers** when run (for example: loading/unloading modules, loading kexec, rebooting/powering off/halt, mounting/unmounting, namespace actions for setns, and process tracing for ptrace). Create a translation table to drive the rules.
2. **Deploy an eBPF-based enforcement and monitoring capability** on the in-scope production Linux servers that host mission and security services.
3. Set up a **policy “deny list”** for the mapped kernel actions that correspond to the organisation-defined unauthorised commands.
4. For each mapped kernel action, set the **response mode** based on the organisation’s settings: **deny (block execution)** and/or **audit (record an audit event)**. Make sure the deny action results in an appropriate “access denied” outcome at the kernel boundary.
5. Ensure every audit record includes **command name, time of the attempt, initiating identity (user ID (UID)/username where it can be identified), process ID (PID), and process context** (for example: parent process/service and container/namespace identifiers where relevant) so the SOC can link attempts to the actor and the service involved.
6. **Send audit events to the organisation’s security information and event management (SIEM)** and create alert rules for high-risk command attempts (especially module loading/unloading, kexec_load, reboot/halt/poweroff, mount/umount, setns, ptrace).
7. **Test and confirm** in a staging environment using realistic workloads and controlled attempts for each command to verify that: (a) detection works reliably, (b) blocking happens when configured, and (c) audit records are produced with the required details.

###### WHO
- **Platform/Infrastructure Security Engineer**: designs the eBPF rules, builds the mapping table, and configures enforcement.
- **Linux System Administrator**: coordinates deployment to the in-scope production servers and checks operational impact.
- **SOC/SecOps Analyst**: checks that alerts and audit records are useful for investigations.

###### Acceptance criteria
- On an in-scope production Linux server, attempts to run any of the unauthorised commands (**insmod, rmmod, modprobe, kexec_load, reboot, halt, poweroff, mount, umount, setns, ptrace**) through the kernel interface are **detected**.
- For each command where the organisation’s response is set to **prevent execution**, the attempt is **blocked** (the command fails with an access-denied style outcome) and there are **no unintended side effects**.
- For each detected attempt where the organisation’s response includes **audit**, an **audit event** is sent to the configured logging pipeline/SIEM and includes at least: command name, timestamp, initiating identity (UID/username where it can be identified), PID, and process context (parent/service and namespace/container identifiers where applicable).
- Audit events are **searchable and linkable** in the SIEM, so the organisation can identify who attempted the command and when.
- The solution is deployed and active on **production on-premises Linux servers hosting mission and security services**, and it is managed through change control with versioned policy updates.

###### Actions Required for Compliance

- [ ] Create a table that maps each command to the corresponding action it triggers in the operating system kernel for: `insmod`, `rmmod`, `modprobe`, `kexec_load`, `reboot`, `halt`, `poweroff`, `mount`, `umount`, `setns`, and `ptrace`.
- [ ] Install an extended Berkeley Packet Filter (eBPF)-based agent for monitoring and enforcement on all in-scope production on-premises Linux servers that host mission and security services.
- [ ] Set up a “policy-as-code” block list that prevents the mapped kernel operations linked to the organisation’s unauthorised commands.
- [ ] Set the response mode for each command so that it either blocks the command from running and/or records (audits) that it ran, as required by **SI-03.08 ODP.03**.
- [ ] Standardise the audit event details (command name, time of the event, who started it, process ID, parent/service, and the namespace/container context) and send them to the security information and event management (SIEM) system.
- [ ] Run staging validation tests for every unauthorised command to confirm that it is detected, blocked (where blocking is enabled), and that an audit record is created.


---

#### SI-3.10 — Malicious Code Analysis (Enhancement)

This requirement is about understanding what suspicious code actually does before it causes harm. If an organisation simply accepts or runs unknown code, it could secretly steal information, damage systems, or create a way for criminals to take over. It could also lead to a slow response or to fixing the wrong issue.

To prevent this, the organisation must analyse suspected malicious code using three complementary approaches:  
- reviewing the code without running it, such as by breaking it down into its underlying form;  
- running it in a controlled test environment to see what it tries to do; and  
- observing and recording its behaviour while it runs.

The organisation must then use what it learns from these analyses to improve:  
- its incident response work, so investigations and clean-up actions are better informed; and  
- its flaw remediation work, so fixes are selected correctly and applied with the right level of urgency.

##### Automated malicious code analysis pipeline feeding IR and remediation

- Category: Software
- Priority: Critical

###### WHAT
Set up a repeatable capability to analyse suspected malicious code. For each suspected sample, it should carry out **static analysis**, **dynamic sandbox execution**, and **behavioural monitoring**. It then uses the collected evidence to support both **incident response** actions and **flaw remediation** decisions.

###### WHY (control requirement)
SI-3(10) enhancement guidance requires organisations to use malicious code analysis tools to better understand an attacker’s methods and what the malicious code is designed to do. It specifically supports analysing malicious code through **reverse engineering (static analysis)** and/or by **monitoring what the code does when it runs (dynamic/behavioural monitoring)**. The guidance also requires using what is learned to improve **organisational responses**.

###### HOW (specific approach)
1. **Define analysis methods and required tool/technique coverage** for the three complementary approaches (static, dynamic, behavioural monitoring) in an organisation-approved standard. Use the organisation-defined parameter **“tools and techniques”** to specify: **static analysis (disassembly/decompilation), dynamic sandbox execution, and behavioural monitoring of executing code**.
2. **Create an analysis workflow** that takes suspected samples from enterprise sources (for example, email quarantine, endpoint detection and response (EDR)/extended detection and response (XDR) detections, proxy/domain name system (DNS) detections, and threat intelligence) and sends them to an analysis queue with controlled access and audit logging.
3. **Carry out static analysis** on each sample without running it on production systems. Extract evidence such as hashes, strings, and embedded URLs/domains, perform disassembly/decompilation for key routines, and store the results as evidence in a case record.
4. **Carry out dynamic sandbox execution** in an isolated environment with deny-by-default/allowlisted outbound connections, time-limited execution, and snapshot/rollback. Capture execution information relevant to malicious behaviour, including process trees, file/registry changes, persistence mechanisms, scheduled tasks/services, and network attempts.
5. **Carry out behavioural monitoring** during execution and convert the results into a consistent format (for example, indicators, observed actions, and potential persistence/command-and-control (C2) behaviours). Link findings to internal asset context and detection logic.
6. **Use the results for incident response** by automatically attaching analysis evidence to security operations centre (SOC) cases and triggering or tailoring containment and investigation steps (for example, blocking indicators, isolating endpoints, revoking sessions, and running hunting queries).
7. **Use the results for flaw remediation** by turning analysis evidence into remediation work items with verification steps (for example, identify affected components/versions, recommend patches/mitigations/configuration changes, and trigger targeted verification scans).
8. **Keep audit-ready evidence** (analysis reports, sandbox execution information, artefact hashes, and the link between findings and incident response (IR)/remediation actions) to support governance and periodic review.

###### WHO
- **Cybersecurity/SOC Lead**: owns incident response integration and ensures analysis outputs are used in investigations.
- **Application Security Lead**: owns the mapping to flaw remediation and the verification criteria.
- **Security Engineering/Platform Team**: builds the analysis pipeline, implements sandboxing, captures telemetry, and maintains the evidence format.
- **Change/Configuration Management**: ensures updates to analysis standards and tooling follow approved change processes.

###### Acceptance criteria
- For each submitted suspected sample, the pipeline produces **(a)** static analysis evidence, **(b)** dynamic sandbox execution evidence, and **(c)** behavioural telemetry evidence, all stored in an auditable case record.
- Analysis outputs are clearly linked to **incident response actions** (for example, containment/hunting steps are parameterised or evidenced) and to **flaw remediation work items** (for example, patch/mitigation/configuration recommendations include evidence and verification steps).
- Sandbox execution is isolated with controlled outbound connections and time-limited execution; execution telemetry includes, at minimum, process/file/registry/persistence and network attempt indicators.
- Evidence retention supports audit (hashes, reports, telemetry, and action linkage can be retrieved for review).

###### Actions Required for Compliance

- [ ] Document and get approval for the malicious code analysis standard. This standard should cover: static code checking, running the code in a controlled sandbox environment, and monitoring its behaviour. It should be aligned with the approved tools and techniques.
- [ ] Set up a managed process for receiving samples so that any suspected samples are sent to an analysis queue, with audit records and restricted access controls.
- [ ] Set up static analysis to break down and reconstruct the code, and record the required evidence materials in a case evidence record.
- [ ] Set up an isolated test environment that blocks all outbound connections by default (only approved destinations are allowed), runs for a limited time, and records activity to monitor processes, persistence mechanisms, changes to files and the Windows registry, and any network connection attempts.
- [ ] Put analysis results into a consistent format and automatically link the findings to security operations centre (SOC) case records.
- [ ] Use the analysis results to update incident response playbooks and automatically create flaw remediation tickets, including prioritising actions based on evidence and adding verification steps.
- [ ] Set up rules for how long evidence is kept and review it regularly, so that analysis reports and the links to actions are ready for audit.


---

### SI-4 — System Monitoring (Control)

This expectation is about keeping a close watch on your systems so you can spot problems early. That includes signs of break-ins, harmful software, unusual login behaviour, attempts to gain higher access, and suspicious movement between systems. It also includes any unauthorised connections coming from inside the organisation, across the network, or from remote locations. Without this, attackers could enter unnoticed, misuse accounts, steal data, or disrupt operations before anyone realises what is happening.

To meet this, the organisation must continuously monitor systems using the right information sources, such as activity records, alerts from intrusion detection and prevention tools, alerts from endpoint devices, unusual patterns in network traffic, and unusual access patterns. It must put monitoring in the right strategic locations, and add extra monitoring in specific, ad hoc areas for transactions of interest. It must then review every event and unusual finding, increase or reduce monitoring when risk changes, and get legal advice before carrying out monitoring.

Finally, it must provide clear, practical monitoring reports to the Security Operations Centre analysts at least quarterly.

##### Centralised SIEM monitoring with IDS/EDR/network telemetry and SOC reports

- Category: Software
- Priority: Critical

###### WHAT
Set up system monitoring that gives both **external** and **internal** visibility across the application’s main interfaces and internal sections. Use a central monitoring pipeline—**security information and event management (SIEM)** feeding a **security operations centre (SOC)**—using data from:
- **Audit log monitoring** (internal events)
- **Intrusion detection and prevention systems (IDS/IPS) and network monitoring** (external interfaces and internal traffic)
- **Endpoint detections** (malware activity, privilege escalation, unusual access)
- **Network flow and access pattern analysis** (unusual access patterns and movement between internal systems)

Provide **useful, practical monitoring information** for **SOC analysts** at least **quarterly**, based on agreed monitoring objectives.

###### WHY (control requirement)
SI-4 requires the organisation to:
- Monitor for **events happening at both external and internal interfaces**
- Use monitoring objectives to decide **which events to watch**
- Achieve monitoring using tools and methods such as **IDS/IPS, malicious code protection, scanning and audit record monitoring, and network monitoring**
- Use monitoring results as **input to continuous monitoring and incident response**
- Make sure monitoring information is **shared with the right people/roles** (SOC analysts) at a defined **frequency** (quarterly)

###### HOW (specific steps/approach)
1. **Define monitoring objectives and what events to cover** for the application, using the organisation’s agreed parameters:
   - Detect **intrusion attempts, malware activity, unusual logins, privilege escalation, and suspicious movement between internal systems**.
   - Use methods such as **audit log monitoring, IDS/IPS alerts, endpoint detections, network flow anomalies, and unusual access patterns**.
2. **Set up and connect external and internal monitoring sources** to the SIEM:
   - External interfaces: enable IDS/IPS and network monitoring at the **perimeter** and at **managed interfaces** that support the application.
   - Internal: enable audit log forwarding from application components and servers; enable endpoint detection and response (EDR) and extended detection and response (XDR) data from endpoints and servers running application components.
   - Network analytics: collect network flow logs (for example, NetFlow, sFlow, or similar telemetry) to support detection of **unusual access patterns** and **movement between internal systems**.
3. **Build correlation and detection rules in the SIEM** to identify the required transaction/event types and signs of attack, including:
   - Unusual login patterns (from identity and audit sources)
   - Privilege escalation chains (from endpoint and/or server audit sources)
   - Malware activity (from EDR/XDR detections)
   - Signs of movement between internal systems (from network flow anomalies and cross-segment access patterns)
4. **Place and fine-tune monitoring in the right locations** to control performance impact, based on the security design:
   - Put monitoring sensors at **selected perimeter locations** and close to key servers/server areas that support critical application functions.
   - Check that monitoring does not cause unacceptable delays at key points; adjust placement if needed.
5. **Make sure the SOC can use the information**:
   - Set up alert routing to **SOC analysts**.
   - Ensure every alert/case includes enough extra detail for analysis (identity context, endpoint/server context, and network context).
6. **Produce practical monitoring reports at least quarterly**:
   - At least quarterly, publish a report summarising detected events, trends (for example, unusual login behaviour and privilege escalation attempts), monitoring coverage status, and notable gaps or recurring false positives.
   - Use the report findings to improve incident response and continuous monitoring, including tuning.

###### WHO
- **Security Operations Centre (SOC) Lead / SIEM Engineer**: implements SIEM connections, correlation rules, alert routing, and report automation.
- **Application Owner / Infrastructure Security Engineer**: ensures audit log and telemetry sources are enabled and correctly scoped for production and critical areas.
- **Information Security Manager**: approves monitoring objective coverage and the content of quarterly reports.

###### Acceptance criteria
- The SIEM receives and correlates at least the following telemetry for the application: **audit logs**, **IDS/IPS alerts**, **endpoint detections**, and **network flow/access pattern data**.
- Detection rules generate alerts for the defined indicators: **intrusion attempts, malware activity, unusual logins, privilege escalation, and suspicious movement between internal systems**.
- Monitoring is deployed at the **perimeter and near key application server locations** (evidence: sensor placement and configuration records).
- **SOC analysts** receive monitoring information and can show how they triage and analyse alerts.
- Quarterly reports are produced and show: summaries of detected events, trends, and evidence of tuning actions or improvements to coverage.

###### Actions Required for Compliance

- [ ] Define the monitoring goals for SI-4 and link each goal to the specific event signals the application must produce for: intrusion, malware, unusual logins, privilege escalation, and lateral movement.
- [ ] Add application and server audit logs, intrusion detection and prevention system (IDS/IPS) alerts, endpoint detection and response (EDR) and extended detection and response (XDR) alerts, and network traffic and access pattern information into the security information and event management (SIEM) system.
- [ ] Set up security information and event management (SIEM) monitoring rules to identify the agreed indicators and any unauthorised connection or use patterns, using the organisation’s approved methods.
- [ ] Place and check monitoring sensors at the site perimeter and close to the main application server locations. Adjust the settings as needed to control processing delays (throughput latency).
- [ ] Set up alert routing and additional context so security operations centre (SOC) analysts receive useful monitoring information they can quickly review and investigate.
- [ ] Automate quarterly reporting for security operations centre (SOC) analysts and keep records showing what tuning changes were made, based on the report findings.


---

#### SI-4.1 — System-wide Intrusion Detection System (Enhancement)

This requirement is about making sure every tool your organisation uses to spot suspicious behaviour sends its findings into one shared, organisation-wide system, rather than working on its own. Without this, important warning signs could be missed, repeated, or not combined—making it harder to recognise patterns that only become clear when information from multiple sources is viewed together.

To meet this expectation, the organisation must:
- keep an up-to-date list of the specific detection tools it uses;
- connect each tool to the single organisation-wide setup; and
- configure each tool so its alerts and detection results are actively sent to the central receiving system for shared analysis.

The organisation must also:
- document how the tools are linked and how monitoring works;
- record the relevant configuration settings;
- ensure audit records capture detection activity;
- include this approach in its security planning; and
- follow defined operating procedures.

Named staff must be responsible for installing, configuring, monitoring, and managing the system. The organisation must ensure the integrated setup is implemented exactly as documented.

##### Integrate all IDS tools into a central system-wide detection platform

- Category: Software
- Priority: Critical

###### WHAT
Link and set up each individual intrusion detection tool (for example: host-based intrusion detection system (HIDS), network-based intrusion detection system (NIDS), cloud intrusion detection system (cloud IDS), web application firewall (WAF)/next-generation firewall (NGFW) threat logs, and any operational technology (OT)-relevant monitoring where applicable) so its detections and alerts are sent into one organisation-wide intrusion detection system. This enables shared analysis and combined detection across tools.

###### WHY (control requirement)
SI-4(1) Enhancement requires that individual intrusion detection tools are **connected and configured into a system-wide intrusion detection system**, so detections can be shared across the organisation and used together for stronger detection.

###### HOW (specific approach)
Set up a central intrusion detection system (IDS) hub (often a security information and event management (SIEM) system with correlation capability) as the single receiving point, and connect each IDS tool using standard, repeatable ways of sending data.

1. **Create and maintain an authoritative IDS tool inventory**: list every IDS tool that must be included, including tool type, environment (production (prod)/test/disaster recovery (DR)), data owner, and the intended integration method.
2. **Standardise how events are mapped**: agree a common structure for key information (sensor/tool identifier, source asset, rule/signature ID, severity, timestamps, action/outcome, and environment/tenant identifiers) so events from different tools can be linked together.
3. **Connect each IDS tool to the central hub**: configure forwarding and ingestion for each tool (for example: syslog/CEF/LEEF, vendor connectors, application programming interface (API) ingestion, or log shipping via collectors) using mutual transport layer security (TLS) and service accounts with the minimum required permissions. Make sure forwarding is enabled for real detections (not test-only).
4. **Set up system-wide correlation and shared views**: implement correlation rules/detection logic that uses the originating tool/source identifier, and produces combined alerts and dashboards for security operations centre (SOC) triage and incident response.
5. **Record integration configuration parameters**: export and store the exact configuration used for each tool-to-hub connection (endpoints, ports, protocols, how credentials are handled, filtering rules, parsing/normalisation settings, and retention/queue settings).
6. **Document the system-wide monitoring design and include it in security planning**: keep architecture diagrams (data flow, trust boundaries, collectors/ingestion zones), monitoring procedures, and ensure the integration is referenced in the organisation’s security plan.
7. **Ensure detection activity is auditable and responsibilities are named**: confirm that the central platform and ingestion process produce audit records for detection ingestion and administrative changes. Assign named roles for installation/configuration and for ongoing monitoring and management.

###### WHO
- **SOC/Detection Engineering Lead**: owns correlation logic, the normalised event structure, and the lifecycle for detection logic (detection-as-code/correlation rules).
- **Security Operations Manager**: ensures monitoring procedures and triage workflows match the system-wide IDS.
- **Platform/Integration Engineer (SIEM/Logging)**: builds and maintains tool integrations and provides configuration exports.
- **System Owner / chief information security officer (CISO) delegate**: ensures the integration is included in security planning and that named responsibilities are formally assigned.

###### Acceptance criteria (verifiable)
- Every IDS tool in the authoritative inventory has an active, production-enabled integration to the central organisation-wide IDS hub.
- For each integrated tool, detections and alerts are sent into the hub with consistent source identifiers and mapped fields according to the normalised schema.
- System-wide correlation produces combined alerts and dashboards that bring together detections across multiple IDS tools (not only separate, tool-specific views).
- For each tool integration, configuration parameters (connection details, parsing/normalisation settings, and forwarding filters) are documented and stored as evidence.
- The security plan and monitoring documentation reference the system-wide IDS integration, and audit records exist for ingestion/detection activity and administrative changes.

###### Actions Required for Compliance

- [ ] Create and get approval for an official list of all intrusion detection system (IDS) tools that must be connected to the organisation-wide intrusion detection system (IDS) hub.
- [ ] Define and publish a standardised event mapping for intrusion detection system (IDS) alerts, including the tool or sensor identifier, the rule or signature identifier, severity level, timestamps, and the related asset and environment context.
- [ ] Set up each intrusion detection system (IDS) tool to send only genuine detection alerts to the central IDS hub using an approved method (for example, syslog/Common Event Format (CEF)/Log Event Extended Format (LEEF), a vendor connector, an application programming interface (API), or a collector). Use mutual Transport Layer Security (TLS) and service accounts with the minimum required permissions (least privilege).
- [ ] Set up organisation-wide detection rules and shared dashboards that bring together alerts from multiple intrusion detection systems (IDS) into one view, using standardised data fields.
- [ ] Export and securely store the exact integration settings for each intrusion detection system (IDS) tool connection to the hub, including the connection addresses (endpoints), communication methods (protocols), data formatting and normalisation settings, and the rules that control what information is forwarded (forwarding filters).
- [ ] Update the system design and monitoring documentation, and point to the intrusion detection system (IDS) integration in the security plan. Include the trust boundaries and the day-to-day operational procedures.
- [ ] Check that audit logs are in place for intrusion detection system (IDS) activity related to importing data and detecting threats, and for any administrative changes. Also assign named roles to manage the integration and to carry out ongoing monitoring.


---

#### SI-4.2 — Automated Tools and Mechanisms for Real-time Analysis (Enhancement)

This requirement is about using automated tools to identify suspicious activity quickly, so issues are noticed in near real time rather than through slow, manual checks. Without this, important warning signs could be missed or acted on too late, increasing the risk of harm to the organisation and its customers, staff, or partners.

The organisation is expected to set up automated monitoring and analysis that can review events from its devices, network connections, data transfers, and stored records. It must use an alert-and-analysis system (or an equivalent automated approach) to turn those events into timely notifications. The organisation must document how monitoring and alert analysis work, keep records of the system design, settings, and audit trails, and ensure this approach is included in its security and privacy plans.

Because automated monitoring can accidentally create privacy risks—particularly if it connects to external or unrelated systems or links records—the organisation must assess and document those risks, record how it plans to manage them, and ensure those decisions align with its privacy programme plan.

##### SIEM near-real-time event analysis with detection-as-code and privacy checks

- Category: Software
- Priority: Critical

###### WHAT
Set up an automated monitoring and analysis capability (security information and event management (SIEM), or a SIEM-equivalent) that collects security-relevant events from at least one of: computer host, network, communication/transport, or storage sources. It should automatically look for patterns and relationships in those events, and produce near real-time alerts and notifications.

###### WHY (control requirement)
SI-4(2) enhancement requires the organisation to **use automated tools and methods to support near real-time analysis of events**. It also requires that any automated monitoring that connects to external or otherwise unrelated systems (or that matches and links records) is assessed and documented in a **privacy impact assessment (PIA)**, with conclusions aligned to the **privacy programme plan**.

###### HOW (specific steps/approach)
1. **Define and document “near real time”** as a measurable target (for example, an alert is visible within **≤5 minutes** of the event occurring). Include this target in monitoring procedures and the system security plan.
2. **Cover the right event sources** for the application environment by configuring SIEM ingestion for relevant sources, at minimum including one or more of:
   - **Host-based**: endpoint/operating system security logs, endpoint detection and response (EDR) alerts, privileged access logs
   - **Network-based**: firewall, proxy, domain name system (DNS), and virtual private network (VPN) remote access logs
   - **Transport/application-based**: authentication events, application programming interface (API) gateway logs, message/email security logs
   - (Optionally) **Storage-based**: audit repositories/log stores, if available
3. **Use reliable, time-synchronised log collection**: make sure log pipelines can buffer and retry, and ensure time is synchronised (for example, using network time protocol (NTP) or chrony) so event and alert times are trustworthy for near real-time analysis.
4. **Write detection logic as “detection-as-code”** for correlation rules, parsing, and enrichment: keep rule packs in version control, require peer review, run automated checks (for example, syntax/logic and sample-event validation), and release changes through controlled processes (for example, staged rollouts).
5. **Set up automated alert actions** so that when SIEM rules match, they trigger useful notifications (for example, creating tickets/incidents and starting security orchestration, automation and response (SOAR) playbooks). Include required details such as rule identifier, affected asset/user, event time, alert time, and severity.
6. **Make changes traceable and auditable**: ensure the SIEM records administrative actions and configuration changes (for example, enabling/disabling rules, changing parsing/enrichment, and access to dashboards/rules) and keeps audit logs in line with the organisation’s retention requirements.
7. **Carry out and document a privacy risk assessment** for SIEM integrations and any enrichment or record matching/linking (including third-party threat intelligence, identity providers, or cross-system correlation). Update the **PIA** and privacy risk management documentation with mitigations (for example, data minimisation, limiting use to the stated purpose, restricting fields, and controlled sharing). Confirm the conclusions align with the **privacy programme plan**.

###### WHO (role responsible)
- **Cybersecurity/security operations centre (SOC) Engineering Lead**: responsible for SIEM use-case design, rule packs, alert workflows, and day-to-day tuning.
- **SIEM/Platform Engineer**: implements ingestion pipelines, time synchronisation, and configuration management.
- **Privacy Officer / Data Protection Lead**: responsible for updating the privacy impact assessment and approving privacy risk conclusions.
- **System Owner / Authorising Official (or equivalent)**: ensures the approach is included in the system security plan and approved for operation.

###### Acceptance criteria
- SIEM (or a SIEM-equivalent) is configured to ingest and analyse security-relevant events from at least one of the required source categories (host/network/transport/storage) for the application environment.
- Automated correlation generates alerts/notifications that meet the documented near real-time target (for example, **≤5 minutes** from event time to alert visibility) during testing.
- Detection rules/parsers/enrichment are managed as detection-as-code with version control, peer review, and changes that can be traced from development to deployment.
- SIEM audit logs show that rule/configuration changes and administrative actions are recorded and can be retrieved.
- A completed or updated privacy impact assessment documents any enrichment and record matching/linking risks from SIEM integrations, including mitigations and conclusions aligned to the privacy programme plan.

###### Actions Required for Compliance

- [ ] Define and document the organisation’s measurable “near real time” target for how quickly alerts must be visible, and include this target in the monitoring procedures and the system security plan.
- [ ] Set up security information and event management (SIEM) data collection pipelines to capture at least one required type of event source—such as computers (host), network activity (network), data transfer details (transport), or storage activity (storage)—that is relevant to the application environment.
- [ ] Set up time synchronisation and reliable log collection (temporary buffering, automatic retry, and load control) to keep the timing between events and alerts accurate.
- [ ] Create detection-as-code rule packs (parsing, correlation, and enrichment) with version control, peer review, automated test cases, and staged deployment.
- [ ] Set up automated alert workflows to create time-stamped notifications or tickets, including the required details: rule identifier, affected asset or user, event time, and alert time.
- [ ] Enable and check security information and event management (SIEM) audit logging for changes to rules and configurations, and for administrative access. Also confirm that audit logs are kept for at least as long as your organisation requires.
- [ ] Update the privacy impact assessment for security information and event management (SIEM) integrations, data enrichment, and record matching, and document the mitigations in line with the privacy programme plan.


---

#### SI-4.3 — Automated Tool and Mechanism Integration (Enhancement)

This requirement is about ensuring suspicious activity is not only noticed, but also dealt with automatically by changing system access and how network traffic is handled. Without this, an attacker could continue trying even after detection, because someone would need to review alerts and manually update access permissions or traffic handling rules. That would slow the response and increase the damage.

The organisation is expected to use automated tools that connect its intrusion-detection alerts to both:
- access decisions (who is allowed to do what), and
- flow decisions (how sessions or traffic move).

This way, when an attack or suspicious behaviour is detected, the system can quickly adjust these protections to isolate the threat and help eliminate it.

The organisation must be able to demonstrate that the end-to-end integration is fully automated, covers both access and traffic handling, and is documented and auditable. It must keep records that clearly link each alert to the automated action that was taken.

##### Automate IDS-driven access and flow reconfiguration via policy engine

- Category: Software
- Priority: Critical

###### WHAT
Set up an automated mechanism that takes intrusion detection alerts and automatically updates **access control** and **flow control** measures to isolate and remove attacks.

###### WHY (control requirement)
NIST SP 800-53 **SI-4(3)** enhancement requires using **automated tools and mechanisms** to connect **intrusion detection tools** to both **access control** and **flow control** measures. This allows fast changes to isolate and eliminate attacks.

###### HOW (specific steps/approach)
1. **Define an alert-to-response agreement**: Standardise IDS alert details (for example: alert type/category, source/destination, affected identity/account, protocol/service, confidence/severity, timestamp, and a unique correlation/incident identifier) so the automation can reliably decide what to change.
2. **Create a policy-as-code layer for access and flow**: Turn access and traffic/session rules into versioned, testable policies (for example: web application firewall (WAF)/next-generation firewall (NGFW)/zero trust network access (ZTNA)/identity provider (IdP) conditional access for access; edge firewall rules, reverse-proxy (and WAF) actions, session termination/rate limiting for flow). Make sure policies allow limited actions (for example: block only the offending source, revoke only the affected session/account, apply time-limited restrictions).
3. **Link IDS alerts to an orchestration workflow**: Build an automation workflow (security orchestration, automation and response (SOAR)/orchestration service) that takes IDS alerts, checks them against approved response mappings, and calls the policy engine interfaces to apply the matching access and flow changes automatically.
4. **Add guardrails to limit impact**: Include delays (cooldowns), maximum scope limits (for example: per source Internet Protocol (IP) address, per account, or per application), time-limited enforcement, and explicit allowlists for critical services/users to prevent unsafe or overly broad changes.
5. **Ensure complete auditing and traceability**: Configure the automation to store evidence linking **(a)** the IDS alert correlation identifier to **(b)** the exact policy version/change reference and **(c)** the resulting access/flow enforcement action. Ensure the automation component is clearly identified as the initiator in logs.
6. **Test and confirm in a controlled environment**: Run repeatable tests in a staging (or non-production) environment that produce realistic intrusion detections, and verify that access and flow changes happen automatically within the agreed response window and are correctly limited in scope.

###### WHO (role responsible)
- **Cybersecurity Detection Engineering Lead**: defines alert categories and response mappings.
- **Security Automation/Platform Engineer**: builds orchestration, integrates policy-as-code, and implements guardrails.
- **Network/Identity Engineering Lead**: implements and maintains the enforcement points (access and flow control interfaces).
- **Security Operations Centre (SOC) Analyst (with approval authority for mappings)**: checks that automated actions are appropriate and safe for the defined alert categories.

###### Acceptance criteria
- For each defined IDS alert category, an automated workflow exists that **automatically** applies both an **access control** change and a **flow control** change (or a documented exception where only one is practical) within the agreed response window.
- Automated actions are **limited in scope** (for example: specific source/account/session/application) and **time-limited**, with cooldowns and limits enforced.
- Audit evidence exists showing an unbroken chain from **IDS alert correlation identifier → automation initiator → policy version/change reference → enforcement outcome** for both access and flow actions.
- End-to-end tests show that the system isolates the detected threat without unintended disruption to allowlisted services/users.

###### Actions Required for Compliance

- [ ] Standardise intrusion detection system (IDS) alert messages so they include a unique reference number (correlation identifier) and all the information needed to make consistent, repeatable access and traffic flow decisions.
- [ ] Set up “policy-as-code” so that both access rules and traffic/session rules are automatically enforced at the points where enforcement happens (for example, the web application firewall (WAF), next-generation firewall (NGFW), zero trust network access (ZTNA), identity provider (IdP), and the edge and session control systems).
- [ ] Create an automated workflow that reads intrusion detection system (IDS) alerts and automatically sends the relevant, approved actions to the policy engine.
- [ ] Add safeguards including blast-radius limits (to limit potential impact), cooldown periods (to slow repeated actions), time-limited enforcement (so controls apply only for a set period), and allowlists for critical services and users.
- [ ] Set up end-to-end logging so every automated action records: the intrusion detection system (IDS) correlation ID, who started the automation, and the exact policy version or change reference.
- [ ] Run staged end-to-end tests for representative intrusion detections, and verify that access is automatically updated correctly within the intended scope and that traffic routing is automatically reconfigured as expected.


---

#### SI-4.4 — Inbound and Outbound Communications Traffic (Enhancement)

This requirement is about closely monitoring the messages and connections that enter and leave your systems, so suspicious activity is detected quickly. Without it, attackers could introduce harmful software, use stolen or valid login details inappropriately, spread harmful activity from one part of your organisation to another, secretly communicate with outside servers, or send sensitive information out without permission.

To meet this expectation, the organisation must set clear rules for what counts as unusual or unauthorised incoming and outgoing network behaviour. These rules must cover indicators of malicious software, unauthorised use of legitimate software or credentials, suspicious spreading of activity, unauthorised external signalling, and unauthorised export of data. The organisation must then continuously monitor incoming and outgoing communications and raise alerts in near real time (within 5 minutes) when the rules are met. This includes unexpected incoming connections, command-and-control style communication patterns, attempts to misuse credentials, delivery of malware or movement to other systems within the organisation, unauthorised external destinations, patterns that suggest data is being exported, suspicious hidden routes for traffic, and malware “beaconing” or attempts to spread.

##### Continuous inbound/outbound traffic monitoring with ≤5 min alerts

- Category: Software
- Priority: Critical

###### WHAT
Set up **continuous monitoring of inbound and outbound communication traffic** to spot **unusual or unauthorised activity or conditions**. When the organisation’s agreed warning signs are detected, create **near real-time alerts within 5 minutes**.

###### WHY (control requirement)
SI-4(4) enhancement requires that unusual or unauthorised inbound and outbound traffic—covering **malicious code indicators**, **unauthorised use of legitimate code or credentials**, **suspicious spreading**, **unauthorised external signals**, and **unauthorised exporting of information**—is identified using evidence from communication traffic. Monitoring must run at the organisation-defined frequency, and alerts must be raised in near real time.

###### HOW (specific steps/approach)
1. **Create a detection criteria catalogue** that turns the organisation’s warning signs into clear, measurable checks for both directions:
   - Inbound: unexpected inbound connections, command-and-control behaviour patterns, attempts to misuse credentials, malware delivery, or lateral movement.
   - Outbound: unauthorised external destinations, data theft (exfiltration) patterns, suspicious “tunnelling” of network traffic, malware “beaconing” or spreading attempts.
2. **Set up data collection (telemetry) to cover both directions** across the application’s network routes:
   - Perimeter and internal firewalls, reverse proxies / secure web gateways, load balancers, DNS security logs, and cloud virtual private cloud (VPC) or flow logs.
   - Where available, include endpoint network activity from enterprise endpoint detection and response (EDR) for the application servers to improve detection of credential misuse and malware delivery.
3. **Implement detection logic in the security information and event management (SIEM) system** (including rule version control, peer review, and controlled changes) so alerts are triggered when the catalogue conditions are met—rather than relying on one-off, ad-hoc searches.
4. **Meet the ≤5 minute alert expectation** by configuring the alert process:
   - Make sure log arrival speed and rule checking timing support alert visibility within 5 minutes.
   - Add an automated check that compares the time an event occurred with the time an alert is produced for each type of rule, and reports any breaches.
5. **Add supporting context and authorised destination checks** so that “unauthorised external destinations” and “unauthorised data export” are assessed against approved business rules, approved outbound (egress) policy, and service ownership.
6. **Operational technology (OT) / legacy system adaptation (if applicable)**: use low-impact, passive data sources (for example, network flow, DNS, and gateway logs). Adjust detections against OT protocol norms and planned maintenance/change periods to reduce false alarms while still detecting spreading and external signalling.

###### WHO
- **Cybersecurity Detection Engineer**: builds the detection rules and maintains the detection criteria catalogue.
- **Security information and event management (SIEM) / security orchestration, automation and response (SOAR) Platform Owner**: ensures log ingestion, rule timing, and alert delivery service level agreements (SLAs) are met (≤5 minutes).
- **Application/Infrastructure Owner**: provides the approved list of assets and services, and the authorised destination/outbound context.
- **Security operations centre (SOC) Analyst (Tier 1/2)**: checks alert quality and confirms triage (initial investigation) processes work as intended.

###### Acceptance criteria
- For both inbound and outbound rule types, alerts are generated when the detection criteria catalogue indicators occur (for example: unexpected inbound connections, command-and-control patterns, credential misuse attempts, unauthorised external destinations, data theft patterns, tunnelling, malware beaconing).
- For each detection rule type, the measured **time from event to alert is ≤5 minutes** for at least 95% of test events (and there are no consistent delays in the alert pipeline).
- Audit evidence is available, including the detection criteria catalogue, SIEM rule versions, enrichment/authorised destination sources, and alert timing measurement reports.
- Alerts are generated for internal spreading and external signalling/export scenarios, not only for perimeter events.

###### Actions Required for Compliance

- [ ] Define and document the criteria for detecting inbound and outbound activity that is “unusual or unauthorised”, and link those criteria to the organisation’s defined indicators.
- [ ] Connect the required sources of system activity data—firewalls, proxies or gateways, Domain Name System (DNS), load balancers, network flow logs, and any available endpoint network events—to the security information and event management (SIEM) system.
- [ ] Set up detection-as-code security information and event management (SIEM) rules for each criteria item, with version control and peer review as part of change management.
- [ ] Set up security information and event management (SIEM) to collect events and run alert rules so that alerts are issued within 5 minutes of the event that triggers them, and measure how long it takes from an event occurring to an alert being raised.
- [ ] Add enrichment using trusted asset and service records, and authorised destination or network-exit (egress) rules, to reduce false alarms and support “unauthorised” decisions.
- [ ] Test and confirm the detections using test cases for: unexpected incoming connections, command-and-control activity, and credential misuse; and for unauthorised outgoing destinations, data exfiltration, tunnelling, and beaconing.


---

#### SI-4.5 — System-generated Alerts (Enhancement)

This expectation is about making sure your systems automatically warn the right people immediately when there are clear signs of something seriously wrong, such as malicious software being detected, suspicious break-in activity, repeated failed log-in attempts, attempts to get higher access than they should, unusual patterns that suggest data may be leaving your network, or network protection devices blocking traffic. Without these fast alerts, harmful activity could go unnoticed for too long, allowing attackers to steal information, disrupt services, or quietly take control.

To meet this requirement, your organisation must keep an up-to-date list of the five alert recipients (the system security officer, the system owner, the information system owner, the incident response lead, and the senior agency information security officer). Your system must automatically send them alerts whenever any of the warning signs listed above occur, using supported methods such as phone, email, or text.

You must also be able to show, using records and system logs, that alerts were created and delivered. You must document how monitoring identifies these issues and how alerting is set up, including how privacy considerations are handled in your plans.

##### Automated SI-4(5) alerting via SIEM/SOAR with role-based recipients

- Category: Software
- Priority: Critical

###### WHAT
Set up an automated, system-generated alerting capability that sends notifications when the system detects the agreed “signs of compromise”, namely: **malware detection, intrusion detection/prevention alerts, repeated authentication failures, privilege escalation attempts, suspicious data exfiltration patterns, and boundary device deny/block events**. Alerts must be sent to the agreed personnel and roles.

###### WHY (control requirement)
The National Institute of Standards and Technology (NIST) **security and system protection control SI-4(5)** requires the system to **generate alerts** when the specified **system-generated signs of compromise or possible compromise** occur, and to send those alerts to the agreed **personnel or roles**.

###### HOW (specific approach)
Use a **centralised detection-to-alert pipeline** (security information and event management (SIEM) with security orchestration, automation and response (SOAR), or equivalent automation) that:
1. Maintains an **authoritative recipient list** mapped to the required roles: **system security officer, system owner, information system owner, incident response lead, and senior agency information security officer**.
2. Collects information (“telemetry”) from the system’s security tools and links related events to identify the SI-4(5) compromise indicators.
3. Automatically generates alerts (no manual action) when the linked-event logic matches the agreed indicators.
4. Sends alerts through at least one **supported notification channel** (for example, email and/or SMS/phone) using organisation-approved integrations.
5. Keeps audit evidence showing **(a)** which indicator triggered, **(b)** that an alert was generated, and **(c)** whether delivery attempts succeeded or failed.

###### Implementation steps (practical)
- **Recipient routing (authoritative list):** Create a role-to-contact mapping in the organisation’s identity system (or a controlled configuration store) and synchronise it to the SOAR/SIEM alert workflow. Apply change control to updates.
- **Indicator-to-source mapping:** Configure linking rules so alerts are generated from system-generated signals for each indicator:
  - Malware detection: endpoint/endpoint detection and response (EDR) detections.
  - Intrusion detection/prevention (IDS/IPS): network intrusion alerts.
  - Repeated authentication failures: identity provider/authentication logs (for example, multiple failed logins within a defined time window).
  - Privilege escalation attempts: privileged access/role change logs and security events showing elevation attempts.
  - Suspicious data exfiltration patterns: outbound traffic/data loss prevention (DLP) and network telemetry showing unusual destinations/volumes leaving the organisation.
  - Boundary deny/block events: firewall/gateway/router logs showing deny/block actions.
- **Detection-as-code:** Store the linking logic and notification workflows in version-controlled repositories with peer review, then promote changes through environments (development/test/production). Include clear mappings to the SI-4(5) indicators.
- **Alert content and evidence:** Ensure each generated alert includes, at minimum, the indicator type, affected asset/user, time of occurrence, and identifiers from the source event(s). Ensure the SOAR/SIEM execution log records delivery status.
- **Delivery and timeliness:** Configure notification channels (for example, email and/or SMS) and implement retry/escalation behaviour consistent with incident response expectations.
- **Privacy-aware logging:** Ensure alert messages and stored evidence meet organisational privacy requirements (for example, avoid including unnecessary sensitive information in notifications; keep only what is needed for investigation and audit).

###### WHO
- **System Security Officer / Incident Response Lead:** Own the indicator definitions, alert thresholds, and escalation expectations.
- **Security Engineering (SIEM/SOAR team):** Build the linking rules, notification workflows, and evidence capture.
- **System Owner / Information System Owner:** Approve recipient routing and confirm the system’s telemetry sources are correctly connected.
- **Identity and Access Management team:** Maintain the authoritative role-to-contact mappings.

###### Acceptance criteria
- When any configured compromise indicator occurs, the system **automatically generates** an alert and notifies the **five defined roles**.
- Alert generation is traceable: audit evidence exists showing **source indicator event(s) → linking match → alert creation → delivery outcome**.
- Recipient list is authoritative and up to date: changes to role contacts are reflected in alert routing after controlled updates.
- Notifications are sent via the configured, organisation-approved channels, with recorded delivery success/failure.
- Linking logic is version-controlled, can be tested, and is deployed through controlled environments.

###### Actions Required for Compliance

- [ ] Define and document the official mapping between each role and the correct contact for the five SI-4(5) recipients, and build this mapping into the alerting process.
- [ ] Bring together monitoring data for each sign of compromise, including: endpoint detection and response (EDR) and malware signals, intrusion detection and prevention system (IDS/IPS) alerts, identity and authentication logs, privilege escalation events, data loss prevention (DLP) and outbound traffic monitoring, and deny/block records from firewalls, gateways, and routers.
- [ ] Set up “detection-as-code” correlation rules that match system events to the six SI-4(5) compromise indicators and automatically generate alerts.
- [ ] Set up security orchestration, automation and response (SOAR) and security information and event management (SIEM) alert delivery channels (for example, email and/or text message/phone), and configure automatic retry and escalation of failed alerts in line with incident response expectations.
- [ ] Enable the collection of audit evidence that links source indicator events to correlation matches, alert creation, and delivery outcomes.
- [ ] Test the alert system end-to-end in a non-production environment by running controlled test events for each indicator, and confirm that the intended recipients receive the alerts.


---

#### SI-4.7 — Automated Response to Suspicious Events (Enhancement)

This requirement is about acting quickly when something suspicious is noticed, so small issues do not quietly grow into major incidents. If the organisation only becomes aware after the damage has already been done, an attacker could continue operating, spread to other parts of the business, and cause financial loss, disruption, or loss of sensitive information.

To meet this expectation, when the system detects a suspicious event it must immediately alert the security operations centre (SOC) incident commander and the on-call incident response lead. The alert must include enough detail to say what was detected and when it was detected.

At the same time, the system must automatically take the least disruptive response actions, including:
- opening a ticket for human review
- isolating the affected computer or network area to stop the suspicious activity
- blocking the specific malicious indicators linked to the event

The organisation must also record what actions it took to stop the suspicious activity, and keep those records so they can be checked later.

##### SOAR automated suspicious-event containment with human review

- Category: Software
- Priority: Critical

###### WHAT
When the system detects a suspicious event, it must (1) alert the identified incident response team members (security operations centre (SOC) incident commander and on-call incident response lead) with enough detail to act, and (2) automatically take the least disruptive steps to stop the suspicious activity. This includes raising a human review request, isolating the affected computer or network area, and blocking the specific malicious indicators linked to the event.

###### WHY (control requirement)
SI-4(7) enhancement requires **automated response to suspicious events** that combines **immediate notification** to the incident response team with **least-disruptive containment actions** (including starting a human review) and ensures the organisation can later check and confirm what actions were taken.

###### HOW (specific approach)
Set up detection-to-response automation using security orchestration, automation and response (SOAR) playbooks integrated with your security information and event management (SIEM), extended detection and response (XDR), intrusion detection system (IDS), and information technology service management (ITSM) tools, with strict limits to protect system availability.

1. **Define who to notify and what to include**
   - Notify the organisation’s defined incident response team: **SOC incident commander and on-call incident response lead**.
   - Send a structured message that includes: detection name, time of detection, affected asset (hostname/internet protocol (IP)/segment), triggering indicator(s) (hash/domain/IP/uniform resource locator (URL) as applicable), severity and confidence, and the recommended least-disruptive containment scope.

2. **Add a “human review ticket” step (least-disruptive)**
   - In the SOAR playbook, immediately create a ticket in the organisation’s ITSM tool with pre-filled evidence (alert details, indicator list, affected asset, and suggested next steps).
   - Make sure the ticket is linked to the alert and the SOAR run identifier for traceability.

3. **Automate least-disruptive isolation**
   - Contain the threat using the narrowest scope approved by the organisation (for example: endpoint network isolation using endpoint detection and response (EDR) containment, or a temporary firewall rule or security group (SG) rule limited to the specific host/workload identity and its network connections).
   - Do not take broad actions across an entire subnet unless the organisation explicitly approves them.

4. **Automate indicator blocking (limited and time-limited)**
   - Block only the malicious indicators tied to that specific suspicious event (for example: hashes in EDR allow/deny lists, domains/URLs in web/domain name system (DNS) controls, and IPs in firewall/proxy controls).
   - Prefer short-lived blocks with automatic expiry unless the analyst confirms an extension.

5. **Keep evidence that can be audited for every automated action**
   - Record each playbook step (notification, ticket creation, isolation change, indicator block change) with: who/what/when/parameters/outcome.
   - Store logs in an append-only or tamper-resistant way and keep them in line with enterprise logging requirements.
   - Link the SOAR run identifier to the ticket identifier, alert identifier, and containment change identifiers.

6. **Operational safeguards and testing**
   - Add safeguards in the playbook to prevent containment outside the approved scope (for example: allowlist of critical services/segments, maximum isolation duration, and escalation if containment fails).
   - Test using tabletop exercises and controlled test cases to confirm containment is least-disruptive for your multi-tier application environment.

###### WHO
- **SOAR/SIEM engineer**: build the playbooks, integrations, and logging.
- **SOC incident commander / on-call incident response lead**: check the notification details, approve containment scope and safeguards, and review the tickets.
- **ITSM administrator**: ensure ticket templates and required fields support fast human review.
- **Network/endpoint security owner**: approve isolation and indicator-blocking methods and ensure they are safely scoped.

###### Acceptance criteria
- For a test suspicious event, the system automatically:
  1) notifies the SOC incident commander and on-call incident response lead within the agreed automation time window, with a structured message containing detection context and indicators;
  2) creates a human review ticket promptly with pre-filled evidence and links to the alert and the playbook run;
  3) isolates only the approved affected host/network scope (not wider than the approved containment scope);
  4) blocks only the indicators linked to that event, using time-limited enforcement (unless the analyst extends it);
  5) produces audit-ready logs showing each automated action and how the alert, ticket, and containment changes are linked.

###### Actions Required for Compliance

- [ ] Set up security automation playbooks that start when the security monitoring tools detect a defined “suspicious event”, and record the full details of each alert (including all related context).
- [ ] Set up automated alerts to notify the security operations centre (SOC) incident commander and the on-call incident response lead, including clear event information and lists of relevant indicators.
- [ ] Set up security orchestration, automation and response (SOAR) to work with the IT service management (ITSM) tool, so that a human review ticket is created immediately after a detection. Link this ticket to the alert and to the playbook execution identifier.
- [ ] Automate isolation with the least disruption possible, using tightly limited controls (such as endpoint containment or firewall rules limited to a specific host or workload), within approved safety limits (guardrails).
- [ ] Automate blocking by sending only the specific indicators for each event to the relevant enforcement points, with a short expiry time.
- [ ] Set up append-only (immutable) audit logs for every playbook step, and record the execution ID, ticket ID, alert ID, and containment change IDs for each run.
- [ ] Run tabletop exercises and controlled tests to confirm the containment approach is the least disruptive option and does not significantly affect the availability of critical applications.


---

#### SI-4.9 — Testing of Monitoring Tools and Mechanisms (Enhancement)

This requirement is about making sure the tools your organisation uses to detect suspicious or unauthorised activity are working properly—not just installed and then ignored. If these tools are not checked regularly, they can fail without warning, miss important warning signs, or generate misleading alerts. This can mean you do not notice real incidents, or you waste time investigating false alarms.

To meet this expectation, the organisation must test its intrusion-monitoring tools and related measures at least once every quarter. The purpose is to confirm they are working as intended and still support the organisation’s monitoring objectives. The organisation must also have written instructions for how these quarterly tests are carried out, clearly name which staff are responsible for performing them, and include the testing activity in its system security planning documents.

Finally, the organisation must keep clear records for each quarter showing what was tested, who carried it out, the results, and any issues found and how they were fixed.

##### Quarterly testing of intrusion-monitoring detections with evidence packs

- Category: Manual
- Priority: High

###### WHAT
Test intrusion-detection monitoring tools and methods at the organisation-defined frequency (SI-4(9) parameter **frequency**, default quarterly) to confirm they are working properly and still meet the organisation’s monitoring goals.

###### WHY (control requirement)
SI-4(9) requires the organisation to **test intrusion-detection monitoring tools and methods**. The guidance explains that testing helps ensure the tools continue to meet monitoring goals, and that **how often and how thoroughly you test depends on the type of tool and how it is deployed**.

###### HOW (specific steps/approach)
Set up a repeatable quarterly “detection validation” process that tests the monitoring process end-to-end (data collected → detection logic → alert creation → alert visibility and where alerts are sent for triage). Use controlled, pre-approved test events.

1. **Create or maintain an inventory** of intrusion-detection monitoring tools and methods used for application monitoring (for example: security information and event management (SIEM) correlation rules, endpoint detection and response (EDR) detections, intrusion detection system (IDS)/web application firewall (WAF) signatures, and cloud security alerts). Link each tool or method to the monitoring goals it supports.
2. **Set quarterly test cases for each tool/method** that reliably produce the expected detection outcome without affecting real users (for example: harmless simulated authentication anomalies, test URL patterns for web application firewall (WAF), simulated domain name system (DNS) query sets, or vendor-supported test modes). For operational technology (OT) or other unsafe environments, use replay of captured harmless traffic in an isolated test area rather than active intrusion simulation.
3. **Write standard operating procedures (SOPs)** for each test case, including: what must be in place first, the exact steps to run, the expected results (including specific alert identifiers, fields, and severity), how to contain or roll back if needed, and what evidence must be kept.
4. **Run the tests on a quarterly schedule** (at least once every quarter) using named roles and controlled change management (pre-approved test windows/tickets where required). For each tool/method, record evidence including: date/quarter, tool/method name and version, test case identifier, expected versus actual results, alert identifiers, timestamps, and any differences.
5. **Check results against the monitoring goals** by confirming that the alerts include the required information (asset/user/service identity, severity, routing tags) and are sent to the correct triage workflow/queue.
6. **Record results and corrective actions**: produce a quarterly evidence pack for each tool/method, including any issues found, the root cause if known, what was fixed, and the outcome of any re-tests.
7. **Update the system security plan** to reference the quarterly testing programme and link each tool/method to the monitoring goals it validates.

###### WHO
- **Security Monitoring Lead (or security operations centre (SOC) Manager)**: owns the quarterly testing programme, ensures mapping to monitoring goals, and signs off the evidence packs.
- **Security information and event management (SIEM)/Detection Engineer**: creates and maintains the test cases and standard operating procedures (SOPs), and checks that detection results are correct.
- **System/Application Owner (or operational technology (OT)/Network Owner where applicable)**: approves safe testing methods and any containment/rollback limits.
- **Independent Reviewer (for example, Information Security Governance)**: reviews evidence packs for completeness and readiness for audit.

###### Acceptance criteria
- Evidence exists for **at least one test per quarter** for each identified intrusion-detection monitoring tool/method, showing **the expected alert/detection behaviour**.
- Each quarterly test records **expected versus actual results**, including alert identifiers/fields and timestamps.
- Test procedures/standard operating procedures (SOPs) are documented and followed, with **named roles** carrying out and approving the tests.
- Quarterly evidence packs are kept and include **issues and corrective actions** (and re-tests where applicable).
- The **system security plan** references the quarterly testing programme and the monitoring goals validated by each tool/method.

###### Actions Required for Compliance

- [ ] Create and keep an up-to-date list of intrusion-detection tools and methods, linked to the monitoring objectives they support.
- [ ] Define quarterly test cases for each mechanism, using safe, controlled test events and specifying the expected alert outcomes.
- [ ] Create standard operating procedures (SOPs) for running tests, including required prerequisites, the steps to contain and roll back any changes, and the evidence documents that must be produced
- [ ] Assign specific named responsibilities for quarterly execution and approval, and schedule tests to run at least once each quarter.
- [ ] Run the quarterly tests and record proof of results, including what was expected versus what actually happened, the alert identification numbers and fields, the date and time, and any differences.
- [ ] Check that alerts are sent to the correct triage process and include the information needed to meet the monitoring objectives.
- [ ] Prepare a quarterly set of evidence documents and update the system security plan to refer to the testing programme.


---

#### SI-4.10 — Visibility of Encrypted Communications (Enhancement)

This requirement is about ensuring that, even when sensitive messages are protected using encryption, the organisation can still see what is happening to those messages for security checks. Without this, attackers could hide harmful activity inside encrypted communications, and the organisation might not be able to spot suspicious behaviour or investigate security incidents involving confidential or highly sensitive information.

To meet this expectation, the organisation must first decide which encrypted internal and external communications that carry confidential or secret data should be visible. It must then make sure that this visibility is provided to the Security Operations Centre monitoring platform, and only to approved network traffic inspection tools. The approach must be properly set up and configured. The design and security planning records must clearly document what is monitored, which tools are used, and which communication methods are included.

Finally, named staff must be responsible for operating and maintaining this capability. The organisation must also keep evidence and records showing that the monitoring tools can actually see the defined encrypted traffic.

##### Enable SOC visibility for in-scope TLS traffic via controlled inspection

- Category: Software
- Priority: Critical

###### WHAT must be done
Provide clear visibility of the defined **encrypted communications traffic** (Transport Layer Security (TLS)-encrypted internal and external communications carrying **Confidential or Secret data**) to the defined **system monitoring tools and mechanisms** (the **security operations centre (SOC) monitoring platform** and **approved network traffic inspection tools**), in a way that supports monitoring and investigation.

###### WHY (control requirement)
Security control SI-4(10) enhancement requires: **"Make provisions so that {{ encrypted communications traffic }} is visible to {{ system monitoring tools and mechanisms }}."** The guidance requires balancing encryption with monitoring visibility, and deciding whether the requirement applies to internal encrypted traffic, external encrypted traffic, or only a subset.

###### HOW (specific steps/approach)
Implement **controlled TLS inspection at designated inspection points** for the TLS traffic in scope, ensuring that only **approved inspection tools** can access the visibility information.

1. **Define the in-scope encrypted traffic**
   - Document which TLS flows carry **Confidential/Secret** data (for example: inbound customer application programming interfaces (APIs), east-west service-to-service calls, partner integrations).
   - Specify the subset rules (for example: by destination/service, port, server name indication (SNI), application, or network zone) so the requirement is not applied to all TLS traffic indiscriminately.

2. **Select and standardise inspection points**
   - Route in-scope traffic through approved network/security inspection components (for example: secure gateways, reverse proxies, API gateways, load balancers, or service-mesh ingress/egress enforcement) that can perform TLS inspection.
   - Ensure the design supports consistent traffic paths across environments (production (prod), testing (test), disaster recovery (DR)) where applicable.

3. **Enable TLS termination/inspection with re-encryption**
   - Configure the inspection layer to end (terminate) TLS, perform the required inspection and metadata extraction, and then **re-establish TLS** to the upstream destination using managed certificates.
   - Ensure inspection is limited to the defined in-scope traffic, and that TLS sessions outside scope are passed through without inspection.

4. **Integrate the visibility feed to the SOC and approved tools only**
   - Send the resulting security-relevant outputs (for example: decrypted Hypertext Transfer Protocol Secure (HTTPS) metadata, security events, alerts, and/or structured logs) to the **security operations centre (SOC) monitoring platform**.
   - Ensure the same visibility feed is used only by **approved network traffic inspection tools** (enforce allow-listing of destinations/tools).

5. **Restrict and provide evidence of the capability**
   - Apply configuration controls so that only authorised components perform TLS inspection for in-scope traffic.
   - Provide audit-ready evidence: traffic-flow diagrams, inspection-point configuration records, allow-list evidence for approved tools, and test results showing that the SOC can observe the defined in-scope encrypted traffic.

###### WHO (role responsible)
- **Security Architect / Network Security Engineer**: define in-scope traffic and design inspection points.
- **Platform/Infrastructure Engineer**: implement TLS inspection configuration and routing.
- **SOC Lead / Security Information and Event Management (SIEM) Engineer**: confirm that the SOC monitoring platform receives the required visibility.
- **Information Security / Compliance**: approve the scope, review evidence, and ensure alignment with governance requirements.

###### Acceptance criteria
- The organisation can show that **TLS-encrypted communications carrying Confidential/Secret data** (as defined in the scope document) are **visible** to the **security operations centre (SOC) monitoring platform** and **approved inspection tools**.
- Inspection is applied **only** to the defined in-scope traffic subset; TLS traffic outside scope is not inspected.
- Evidence is available showing: (a) documented scope, (b) configured inspection points with re-encryption, (c) allow-list enforcement for approved tools, and (d) test results proving SOC visibility for in-scope flows.

###### Actions Required for Compliance

- [ ] Document the in-scope Transport Layer Security (TLS)-encrypted communications traffic that carries Confidential or Secret information (scope rules based on destination, Server Name Indication (SNI), application, and zone).
- [ ] Choose and deploy approved inspection points (gateways, proxies, or service-mesh enforcement) that can examine encrypted traffic using Transport Layer Security (TLS) and then re-encrypt it.
- [ ] Set up Transport Layer Security (TLS) termination and inspection for in-scope traffic, then re-encrypt the traffic when sending it to upstream destinations using managed certificates.
- [ ] Connect the inspection results to the security operations centre (SOC) monitoring system, and use an allow-list so only approved inspection tools can send their visibility feed.
- [ ] Create and keep up to date design documents (traffic flow diagrams, inspection policy, and rules for protocol, port, and server name indication (SNI)) and operational step-by-step guides (runbooks) for the inspection capability.
- [ ] Run validation tests (for example, controlled Transport Layer Security (TLS) sessions that carry Confidential or Secret information) and keep records showing that the security operations centre (SOC) can observe the agreed encrypted traffic.


---

#### SI-4.11 — Analyze Communications Traffic Anomalies (Enhancement)

This requirement is about regularly checking what your systems send to the outside world, and spotting anything that looks unusual or suspicious. Without this, harmful activity could quietly “phone home” or move data out in unexpected ways, such as unusually large downloads, connections that stay open for far too long, attempts to get information from unexpected places, or the use of unusual communication methods or ports. It also helps identify unexpected use of network methods that may not normally be monitored (for example, Internet Protocol version 6 (IPv6) during a transition) and attempts to contact external addresses that are suspected to be malicious.

To meet this expectation, the organisation must regularly review outbound communications leaving the system at its external connection points. It must also review outbound traffic coming from the demilitarised zone (DMZ), internal application areas, and critical subsystem network segments, using agreed indicators of unusual behaviour. The organisation must investigate and record what it finds, document the results, and keep evidence showing daily review at external points and traceable, well-documented follow-up for any identified anomalies.

##### Egress anomaly analysis for external and interior points

- Category: Software
- Priority: Critical

###### WHAT must be done
Set up continuous monitoring and analysis of **outbound (egress) communications** at:
- **External interfaces** to the system, and
- Organisation-defined **internal monitoring points** (specifically: **demilitarised zone (DMZ) subnetworks, internal application subnetworks, and critical subsystem network segments**),

Use agreed warning signs to **find unusual activity (anomalies)** and produce audit-ready proof that the activity was reviewed and investigated.

###### WHY (control requirement)
SI-4(11) enhancement requires the organisation to **analyse outbound communication traffic** at **external interfaces** and at **selected internal monitoring points** to **find anomalies**. The guidance examples include:
- large file transfers,
- connections that stay open for a long time,
- attempts to access information from unexpected locations,
- unusual communication methods and network ports,
- network protocols that are not normally monitored (for example, unexpected IPv6 during an IPv4 transition), and
- attempts to communicate with external addresses suspected to be malicious.

###### HOW (specific steps/approach)
###### 1) Define the analysis scope and map to “internal monitoring points”
- Create a mapping from network data sources (edge firewalls/routers, flow logs, proxy logs, and cloud flow logs) to the organisation-defined internal monitoring points: **DMZ subnetworks, internal application subnetworks, and critical subsystem network segments**.
- Identify the **external interface points** (for example, edge firewall egress, internet gateway, and cloud egress/network address translation (NAT) points) and ensure the data collected includes the outbound destination.

###### 2) Collect and standardise outbound traffic data
- Collect outbound (egress) information sufficient to support the guidance anomaly types: source subnet/host, destination IP address/fully qualified domain name (FQDN), protocol, port, bytes/packets, session duration, and whether the traffic was allowed or blocked.
- Standardise this into a common format in the security information and event management (SIEM) and security operations centre (SOC) analytics layer (for example, combine firewall logs with NetFlow/IP flow information export (IPFIX) and cloud virtual private cloud (VPC) flow logs).

###### 3) Set up anomaly detection rules that match the guidance
Create detection rules (or equivalent analytics settings) that cover at least the guidance categories:
- **Large file transfers**: alert when outbound data volume or number of objects exceeds an agreed baseline or threshold for the source subnet/service.
- **Persistent/long-lived connections**: alert when session durations are unusually long for a given protocol.
- **Unexpected destinations/locations**: alert when destinations are not on an approved list of expected partners/software-as-a-service (SaaS) endpoints for that internal monitoring point.
- **Unusual protocols/ports**: alert when protocol and port combinations are outside the organisation’s expected outbound pattern.
- **Unmonitored protocol detection (IPv6)**: alert when IPv6 outbound traffic appears where it is not expected/allowed during an IPv4 transition.
- **Suspected malicious external addresses**: alert when destination reputation (threat intelligence and/or internal blocklists) exceeds a defined threshold.

###### 4) Investigate, record, and close anomalies with traceable evidence
- Send alerts into analyst workflows/case management.
- For each anomaly, record: the detection rule used, the time window, the affected internal monitoring point, source and destination, the reason for the classification, the investigation result, and the closure decision.
- Keep the underlying traffic data and the case record to show that outbound traffic was analysed and anomalies were handled.

###### 5) Make sure reviews happen regularly and cover all relevant systems
- Set a review cadence (for example, continuous alerting with daily analyst review of high- and medium-confidence events) and ensure coverage for live (production), testing, and disaster recovery (DR) environments where applicable.
- Adjust thresholds using historical baselines to reduce false alarms while still detecting the guidance anomaly types.

###### WHO (role responsible)
- **Cybersecurity SOC / SIEM engineering**: implement the data collection pipelines, standardisation, and detection rules.
- **SOC analysts**: investigate, document, and close anomalies.
- **Network/security engineering**: maintain the internal monitoring point mappings and the expected outbound patterns.
- **System owner / data owner (as needed)**: confirm the business justification for unexpected destinations when required.

###### Acceptance criteria
- Outbound traffic from **external interfaces** and from **DMZ subnetworks, internal application subnetworks, and critical subsystem network segments** is analysed using centralised telemetry.
- Detection rules are in place and can be shown to identify anomalies matching the guidance categories (large transfers, persistent connections, unexpected destinations, unusual protocols/ports, unexpected IPv6, and attempts to contact malicious destinations).
- For a sample of generated/validated anomalies, the organisation can provide audit evidence showing: when the alert occurred, analyst review, investigation notes, the recorded outcome, and closure, with traceable references to the underlying logs/telemetry.

###### Actions Required for Compliance

- [ ] Define and document the external connection points, and match each one to the organisation’s internal connection points (demilitarised zone (DMZ), internal application subnets, and critical subsystem segments).
- [ ] Set up and centralise outgoing data collection (firewall and edge logs, and network flow logs) for all identified external and internal connection points.
- [ ] Standardise all telemetry data into a single common format in the security information and event management (SIEM) / security operations centre (SOC) analytics layer, including source and destination, protocol and port, data volume (bytes), and session duration.
- [ ] Set up alerts to detect large money transfers, connections that last unusually long, transfers to unexpected destinations, use of unusual network protocols or ports, unexpected Internet Protocol version 6 (IPv6) activity, and destinations with a known bad reputation.
- [ ] Set up how alerts are sent to analyst case management, including the required information needed to start an investigation and to close the case.
- [ ] Set up a regular review schedule and keep records of both system activity and case details so the work can be traced and checked during an audit.


---

#### SI-4.12 — Automated Organization-generated Alerts (Enhancement)

This requirement is about making sure the right people are automatically notified when something unusual may be happening involving sensitive information or personal data. Without it, suspicious behaviour—such as a trusted person acting oddly, unusual login attempts, unexpected access to highly sensitive files, or reports of possible rule-breaking—could go unnoticed for too long, allowing theft, misuse, or privacy harm before anyone can respond.

To meet this expectation, the organisation must keep a defined list of alert recipients, including the system security officer, system owner, system administrator, senior information security lead, senior privacy lead, privacy officer, and the mission or business owner.

Whenever the organisation’s monitoring tools detect signs of suspected insider threats, suspicious authentication activity, unusual access to Confidential or Secret information, or potential policy violations, it must automatically send alerts to these recipients by email and also automatically create or update a logged incident record in the incident management system through ticket integration. This ensures the alert is captured for an auditable record and that both security and privacy implications are considered.

##### SIEM-driven automated alerts with role-based email and ticketing

- Category: Software
- Priority: Critical

###### WHAT
Set up automated, organisation-generated security and privacy alerts. These alerts must be triggered when specific signs of inappropriate or unusual activity are detected, and they must automatically notify the defined people or roles using automated methods (email and ticketing system integration).

###### WHY (control requirement)
Security control SI-4(12) requires that alerts are generated using the organisation’s defined automated methods when the defined signs occur, and that the alerts are sent to the organisation’s defined people or roles. This improvement focuses on organisation-generated alerts (for example, suspicious activity reports and insider threat reports) and requires automated sending.

###### HOW (specific steps/approach)
1. **Define who receives alerts (role-based)**: Maintain a list that maps alert recipients to the organisation-defined roles, including: system security officer, system owner, system administrator, senior agency information security officer, senior agency official for privacy, privacy officer, and mission or business owner.
2. **Build the detection-to-alert process in the security information and event management (SIEM) system for the four trigger categories** (as SIEM-generated notifications):
   - **Suspected insider threat indicators**
   - **Suspicious authentication activity**
   - **Unusual access to Confidential or Secret data**
   - **Reports of potential policy violations**
   Make sure each alert includes a structured set of information, including pointers to supporting evidence (for example, log source, time, user, and session identifiers) and privacy-relevant context (for example, data classification and whether the activity suggests unauthorised handling).
3. **Set up the automated sending methods**: Configure the SIEM system to send notifications using the organisation-defined automated methods: **SIEM-generated notifications via email and ticketing integration to the incident management system**.
4. **Automate incident creation or update, with an audit trail**: Connect the SIEM system to the incident management system so that each alert results in an incident ticket being **created or updated** (remove duplicates using a correlation or event identifier). Ensure the incident system keeps the alert details so they can be reviewed for audit purposes.
5. **Test alert delivery and content**: For each trigger category, run tests to confirm that the correct roles receive the email notification and that the incident ticket is created or updated with the expected evidence and privacy context.

###### WHO
- **System Security Officer / security operations centre (SOC) analyst**: owns the SIEM detection rules, the alert content, and the routing logic.
- **System Owner / mission or business owner**: confirms the correct business or mission recipients and checks that alerts are useful.
- **Privacy Officer / senior agency official for privacy**: checks that privacy-related information in the alert is correct and that privacy impacts are clearly represented.
- **Incident Management Owner (IT Operations / Service Desk Lead)**: checks that the ticketing integration works as intended (create or update, deduplication, and retention).

###### Acceptance criteria
- For each of the four defined activity categories, when the indicator occurs, the system generates an organisation-generated alert via the SIEM system.
- Alerts are automatically sent to all recipients defined for SI-04.12_odp.01 using the automated methods defined for SI-04.12_odp.02 (email plus ticketing integration).
- The incident management system receives an automated **create or update** action for each alert, with deduplication and evidence links sufficient for audit review.
- The alert content includes privacy-relevant information sufficient for recipients to understand the security and privacy implications (at minimum: data classification such as Confidential or Secret, and a clear indication that the event has privacy or security implications).
- Test evidence confirms correct recipient routing and successful ticket creation or update for each trigger category.

###### Actions Required for Compliance

- [ ] Create and keep up to date a list that maps each role to the people who should receive it, covering the roles in **SI-04.12_odp.01**.
- [ ] Set up security information and event management (SIEM) detection rules to generate alerts for the SI-04.12_odp.03 trigger categories.
- [ ] Set up security information and event management (SIEM) alert notifications to use the automated notification method defined in SI-04.12_odp.02 (email plus ticketing system integration).
- [ ] Set up security information and event management (SIEM) to work with the incident management system so it can automatically create or update tickets, include links to supporting evidence, and avoid duplicate tickets.
- [ ] Add privacy-relevant details to alert information, such as the document’s classification (for example, Confidential or Secret) and indicators showing the privacy impact.
- [ ] Run tests for each trigger type to confirm that messages reach the right recipients and that tickets are created or updated correctly.


---

#### SI-4.13 — Analyze Traffic and Event Patterns (Enhancement)

This requirement is about learning what “normal” looks like for your system’s everyday communications and the events it produces, and then using that information to improve how your monitoring tools work. Without this, your organisation may be overwhelmed by unnecessary alerts, or—worse—fail to spot genuinely suspicious activity because the monitoring rules do not match your real day-to-day patterns.  

To meet this expectation, the organisation must decide which types of communication traffic and which system events it will study, and then regularly review them to identify common, repeated behaviours. It must create and keep documented profiles that describe typical traffic and typical events, including who is responsible for them and when they were last reviewed.  

Finally, the organisation must use these profiles to adjust its monitoring settings so alerts are more accurate. It must also set and track acceptable targets for both false alarms and missed detections, and update the profiles when patterns change.

##### Traffic & event baselines to tune monitoring detections

- Category: Software
- Priority: High

###### WHAT
Create and keep documented “expected behaviour” profiles for common communication traffic patterns and security-relevant event patterns for the application. Use these profiles to adjust the organisation’s monitoring alerts (rules, thresholds, and alert logic), and to check whether the adjustments meet agreed targets for reducing both false alarms and missed detections.

###### WHY (control requirement)
SI-4(13) enhancement guidance requires the organisation to identify and understand common communication traffic and event patterns, so monitoring tools can more effectively spot suspicious or unusual activity. This helps reduce both false positives (false alarms) and false negatives (missed issues). This is done by analysing traffic and events, creating profiles that represent expected “normal” behaviour, keeping those profiles up to date with clear ownership and review information, and using them to adjust monitoring settings.

###### HOW (specific approach)
1. **Define what to analyse (what to profile):**
   - Choose communication traffic sources relevant to the application (for example: reverse proxy and web application firewall (WAF) logs, firewall and network security group (NSG) flow logs, domain name system (DNS) logs, load balancer logs, and service-to-service telemetry where available).
   - Choose security-relevant event sources (for example: authentication events from the enterprise identity service, application audit logs, endpoint/server audit events, and security events reported by the security information and event management (SIEM) system that feed detections).
   - Split the scope by environment (production (prod), test, disaster recovery (DR)), application part (presentation, application, data, administration), and time of day/maintenance windows.

2. **Analyse traffic and event patterns (build “normal”):**
   - Create statistical “baseline” expectations for each segment for recurring behaviours (for example: connection and session rates, data volumes, most common destinations and ports, typical protocol mix, typical authentication success/failure ratios, typical frequency of administrative activity, and typical event sequences).
   - Use methods that allow for expected variation (for example: separate baselines for business hours versus out-of-hours; keep separate baselines for maintenance windows).

3. **Create and document traffic and event profiles (ready for audit):**
   - For each profile, document: what “normal” looks like, the data sources used, how it was created (baseline period and statistical approach), the profile owner, the last review date, and the next review date.
   - Store profiles in a version-controlled repository (or a configuration management system) so monitoring tuning changes can reference the exact profile used.

4. **Adjust monitoring using the profiles (reduce false alerts and misses):**
   - Turn profile outputs into specific monitoring changes: thresholds, suppression windows, rule logic that accounts for segmentation, and—where appropriate—allowlisting limited to profile attributes (for example: known service accounts and known administrative maintenance windows).
   - Make sure each tuning change clearly links to the specific profile version used.

5. **Set and track acceptable targets (measure effectiveness):**
   - Define measurable targets for acceptable false-positive and false-negative rates (or agreed proxy measures with the security operations centre (SOC)), and record the results of tuning (before and after) for each change.

6. **Keep profiles up to date as patterns change (ongoing governance):**
   - Review profiles on a planned schedule (for example, quarterly) and update them when the application changes significantly (new release, new endpoints, identity and access management (IAM) changes, network topology changes, or major traffic growth).

###### WHO (roles responsible)
- **Application Owner / Service Owner:** approves the profile scope and owns the profile content.
- **Security Operations Centre (SOC) / Detection Engineering Lead:** implements monitoring and SIEM (security information and event management (SIEM)) tuning changes and checks results against the targets.
- **Security Analytics Engineer:** performs baseline analysis and maintains the profile creation process.
- **Change Manager / Configuration Manager:** ensures tuning changes and profile versions are tracked and can be audited.

###### Acceptance criteria
- Documented traffic profiles and event profiles exist for the defined application segments, each with an owner and last/next review dates.
- Baselines are created from defined data sources, with the creation method documented.
- Monitoring detections are tuned using the profile outputs, and each tuning change references the profile version.
- False-positive and false-negative targets (or agreed proxy measures) are defined, and tuning results are recorded with evidence of improvement.
- Profiles are reviewed on schedule and updated after material application, network, or IAM changes.

###### Actions Required for Compliance

- [ ] Define and document which traffic and event data sources will be analysed for the application, including how the environment and components will be separated for analysis.
- [ ] Carry out baseline analysis to work out what “normal” network traffic and event patterns look like for each segment and for each time of day, including maintenance windows.
- [ ] Create traffic and event profile documents that are version-controlled, and include the document owner, how the information was derived, and the last and next review dates.
- [ ] Update security information and event management (SIEM) and monitoring detection rules and alert thresholds using the outputs from the profiles, and link each change to the specific profile version.
- [ ] Set clear, measurable targets for false positives and false negatives (or agree on proxy measures) and keep evidence showing results before and after tuning.
- [ ] Set up a regular review and a trigger-based process to update user profiles after software releases, identity and access management (IAM) changes, or major network and application changes.


---

#### SI-4.14 — Wireless Intrusion Detection (Enhancement)

This requirement is about monitoring for unauthorised wireless devices and suspicious wireless activity, even though wireless signals can travel beyond your buildings. Without this, someone could quietly connect an unapproved wireless device, attempt to break into your systems using wireless connections, or leave behind signs that your systems have been accessed or affected—possibly without anyone noticing.

To meet this expectation, the organisation must use a wireless monitoring system that continuously checks wireless activity to:
- spot and flag rogue (unauthorised) devices,
- detect and flag attempts to attack, and
- identify and flag signs that a system may have been compromised or breached.

Monitoring and searching must not be limited to areas inside facilities where systems are located. It must also include thorough wireless scanning of areas outside those facilities to confirm that unauthorised wireless access points are not connected to organisational systems.

##### Deploy WIDS sensors with external-area scanning and SIEM alerting

- Category: Software
- Priority: Critical

###### WHAT
Set up a Wireless Intrusion Detection System (WIDS) to continuously watch radio signals to spot unauthorised (“rogue”) wireless devices and to detect attempts to attack wireless networks, including possible compromises or breaches. Make sure monitoring also covers areas outside organisational sites by carrying out proactive wireless checks.

###### WHY (control requirement)
SI-4(14) enhancement requires using a Wireless Intrusion Detection System (WIDS) to:
- identify rogue wireless devices,
- detect attack attempts and possible compromises or breaches,
- proactively look for unauthorised wireless connections,
- carry out detailed checks for unauthorised wireless access points, including in areas outside facilities, to confirm that unauthorised access points are not connected to organisational systems.

###### HOW (specific steps/approach)
1. **Define the wireless monitoring coverage and radio frequency (RF) zones**: Create an RF coverage map for each site, including “outside” zones (for example, perimeter locations and nearby leased or public areas where signals could spread). Record the authorised network identifiers (service set identifiers (SSIDs) and basic service set identifiers (BSSIDs)) and the expected types of devices that should connect.
2. **Place WIDS sensors to cover overlapping areas**: Install dedicated WIDS sensors at key “choke points” and perimeter locations so that detection coverage overlaps. Set sensors to run continuous passive monitoring and scheduled active checks.
3. **Set up detection scenarios**: Configure WIDS to raise alerts at minimum for new or unknown SSIDs and BSSIDs, signs of rogue access points, unusual connection patterns, and common wireless attack signs (for example, abnormal deauthentication/disassociation behaviour and “evil twin”-like behaviour).
4. **Link to central monitoring**: Send WIDS alerts to the organisation’s security information and event management (SIEM) system (and to incident tracking and response tools if used). Compare WIDS findings with other network information (for example, switch and access point controller logs, and where available, dynamic host configuration protocol (DHCP) and domain name system (DNS) activity, and network access control (NAC) and 802.1X events) to reduce false alarms and support a clear, auditable investigation process.
5. **Carry out proactive checks beyond facilities**: Run controlled active checks from authorised external locations and/or place sensors in clearly defined external areas (where legally permitted). Keep records of the check times, locations, and results as evidence.
6. **Set up alert triage and response procedures**: Use step-by-step procedures to confirm findings against the authorised device and network inventory, determine likely impact (for example, which virtual local area network (VLAN), SSID, or device context is affected), and trigger containment actions (for example, temporarily isolating an SSID/VLAN, creating an incident ticket, and escalating to the incident response team).

###### WHO
- **Cybersecurity Operations Lead / security operations centre (SOC) Analyst**: responsible for reviewing alerts, setting correlation rules, and maintaining response procedures.
- **Network Engineering Lead**: responsible for sensor placement, RF zone mapping, and integrating with other network monitoring information.
- **Information Security Manager**: approves the monitoring coverage (including external checks) and ensures legal and privacy compliance.

###### Acceptance criteria
- WIDS sensors are installed with documented RF coverage (including external/perimeter zones) and are actively monitoring.
- The system produces alerts for rogue/unknown wireless devices and wireless attack indicators, and these alerts are sent to the SIEM with supporting context for correlation.
- Scheduled active checks identify unauthorised wireless access points, and proactive checks are carried out for areas outside facilities with documented evidence (check time/location and results).
- Alert triage procedures are in place and are tested (for example, using simulated rogue access points), with measurable reduction in false positives and documented outcomes.

###### Actions Required for Compliance

- [ ] Create a radio-frequency (RF) monitoring coverage map, including outside and perimeter areas. Document the authorised network names (service set identifiers (SSIDs)) and network hardware identifiers (basic service set identifiers (BSSIDs)), and list the expected devices that should connect.
- [ ] Deploy wireless intrusion detection system (WIDS) sensors with overlapping coverage at key access points (“choke points”) and at the site perimeter.
- [ ] Set up wireless intrusion detection system (WIDS) to continuously monitor wireless activity in the background and to run planned checks for unauthorised access points.
- [ ] Integrate WIDS event outputs into the security information and event management (SIEM) system, and link them with network and network access control (NAC) and 802.1X access logs to reduce false alarms.
- [ ] Carry out and record proactive wireless checks outside the premises during agreed scan time windows (where this is legally permitted).
- [ ] Create and test security operations centre (SOC) “triage” procedures for confirming suspected rogue devices, escalating the issue, and taking containment actions


---

#### SI-4.15 — Wireless to Wireline Communications (Enhancement)

This requirement is about monitoring the point where Wi‑Fi traffic moves into your main wired network. The goal is to spot suspicious activity early, before it can cause harm. Because Wi‑Fi is easier for outsiders to interfere with than wired connections, a malicious person could try to introduce harmful code or behaviour into the network using a wireless device—effectively turning your Wi‑Fi into a way to reach your wired systems.

To meet this expectation, the organisation must use a monitoring tool that can detect suspicious or malicious behaviour, and configure it to specifically watch traffic as it changes from wireless to wired. The organisation should record this in its internal rules and day-to-day working procedures. This should include which tools are used, how they are set up, which network handover points and communication rules are being monitored, and who is responsible for running the monitoring and reviewing the alerts. The organisation must also keep evidence that monitoring is in place and active, retain the relevant records, and deal with alerts promptly—taking actions designed to prevent impact on the wired network.

##### IDS sensors at wireless-to-wired handover with SIEM alerting

- Category: Software
- Priority: Critical

###### WHAT
Set up an intrusion detection capability that watches network traffic specifically as it moves from wireless networks (for example, Wi‑Fi virtual LANs (VLANs) and access point (AP) uplinks) into the wired enterprise network. Make sure alerts are raised and reviewed before any malicious activity can affect wired systems.

###### WHY (control requirement)
The National Institute of Standards and Technology (NIST) SI-4(15) requires: “Employ an intrusion detection system to monitor wireless communications traffic as the traffic passes from wireless to wireline networks.” The guidance explains that wireless can be used as an entry point into wired networks. Additional monitoring at the handover point helps detect malicious activity before it reaches wired systems.

###### HOW (specific steps/approach)
1. **Identify and document the wireless-to-wired handover points**: list each Wi‑Fi service name (service set identifier (SSID)) or area, the wireless VLAN/segment it uses, and the exact wired network interfaces where that traffic enters the wired network (for example, AP uplink aggregation ports, wireless VLAN trunk ports, or upstream firewall/edge interfaces).
2. **Place intrusion detection sensors where the handover traffic can be seen**: set up network monitoring using switch port mirroring (sometimes called SPAN) or hardware network taps (TAPs) on the wired-side interfaces that carry the wireless VLAN traffic into the wired network, so the intrusion detection system can see the full packet stream “at, or immediately before” the handover.
3. **Limit monitoring to the handover traffic**: configure the intrusion detection system to monitor only the identified wireless VLANs/segments and their uplink interfaces to reduce noise and improve detection accuracy.
4. **Turn on packet inspection and alerting for malicious content**: enable the relevant intrusion detection categories (for example, exploit attempts, indicators of malware delivery, and suspicious misuse of network protocols) and ensure alerts are raised for the wireless-to-wired handover traffic.
5. **Add context and link related alerts in the security information and event management (SIEM) system**: combine intrusion detection alerts with available wireless information (for example, client media access control (MAC) address and/or 802.1X identity where available, dynamic host configuration protocol (DHCP) lease mappings, SSID/VLAN identifiers, and the destination network/service details) so analysts can confirm whether the suspicious activity is coming from wireless and targeting wired assets.
6. **Make alert handling operational and keep evidence**: define an alert triage process (who reviews, when to escalate, and what response is expected) and retain intrusion detection and SIEM logs and configuration evidence showing that monitoring is active and covers the defined handover points.
7. **Test using controlled trials**: run scheduled test traffic from wireless clients that should trigger known intrusion detection detections (or safe test signatures) and confirm alerts appear with the expected wireless-to-wired context within the agreed monitoring and response time window.

###### WHO
- **Network Security Engineer / security operations centre (SOC) engineering**: sensor placement, intrusion detection system configuration, SIEM integration, and tuning.
- **SOC Analyst (Tier 1/2)**: review, triage, and escalation of alerts.
- **Network Operations / Infrastructure Team**: SPAN/TAP configuration and change implementation.
- **Information Security / Compliance**: review of coverage documentation and evidence retention.

###### Acceptance criteria
- Intrusion detection monitoring is deployed and actively receiving traffic from the defined wireless VLANs/segments at the wired-side handover interfaces.
- Intrusion detection alerts are generated for malicious or suspicious activity observed on the wireless-to-wired handover traffic.
- SIEM correlation and enrichment includes, at minimum: the source wireless client identifier (for example, MAC address and/or 802.1X identity where available), wireless VLAN/SSID context (or an equivalent identifier), and destination wired network/service details.
- Coverage documentation exists showing how wireless segments map to wired handover points, and evidence exists (logs, configuration exports, dashboards) proving monitoring is enabled.
- Test cases confirm that wireless-originated traffic triggers the expected intrusion detection alerts and is visible in the SIEM within the agreed time window.

###### Actions Required for Compliance

- [ ] Create a transition map showing how each wireless network (service set identifier (SSID)) moves into the correct wired network (virtual local area network (VLAN)) and which wired handover ports (interfaces) are used for each area (zone). Save this map as auditable design evidence.
- [ ] Set up SPAN (Switched Port Analyzer) and TAP (Test Access Point) on the wired network interfaces that carry wireless virtual local area network (VLAN) traffic into the wired network, so the intrusion detection system (IDS) can observe the traffic as it moves between networks.
- [ ] Set up and configure intrusion detection system (IDS) rules to examine the wireless-to-wired network traffic that is being mirrored or made visible, and to raise alerts when suspicious or malicious patterns are detected.
- [ ] Limit intrusion detection system (IDS) monitoring to the identified wireless virtual local area networks (VLANs) and network segments, and to the uplink interfaces, to reduce false alarms and improve detection quality.
- [ ] Add intrusion detection system (IDS) alerts to the security information and event management (SIEM) system, and enhance the alerts so they include context about the wireless client and the destination wired network.
- [ ] Define and document security operations centre (SOC) alert-handling and escalation steps for wireless-to-wired intrusion detection system (IDS) alerts, and keep intrusion detection system (IDS) and security information and event management (SIEM) logs for audit purposes.
- [ ] Run scheduled checks that confirm wireless-to-wired connections work correctly, and record the results showing that alerts are triggered and correctly linked to the right cause.


---

#### SI-4.16 — Correlate Monitoring Information (Enhancement)

This requirement is about bringing together information from all the ways your systems detect suspicious activity, so you can see one joined-up picture rather than separate, isolated alerts. Without this, important clues can be missed—for example, one tool may spot a problem on a device, while another flags suspicious network traffic, but the organisation never connects the two to recognise a wider pattern or a new attack as it develops.

To meet this expectation, the organisation must collect and combine monitoring information from every monitoring source it uses across the system. It must clearly define and document what information is combined and how, and ensure the system is designed and set up to produce consistent event records that can be linked together for analysis.

The organisation must do this combining as part of day-to-day monitoring, keep the combined records, and link them to audit records so they can be reviewed later. It must also assign clear responsibility to the relevant staff. This approach must continue to work during technology changes, such as moving from Internet Protocol version 4 (IPv4) to Internet Protocol version 6 (IPv6), so the combined view remains reliable.

##### SIEM correlation for multi-source monitoring with IPv4/IPv6 handling

- Category: Software
- Priority: Critical

###### WHAT
Set up an organisation-wide capability to link (correlate) monitoring information from the system’s monitoring tools and mechanisms (for example: host or endpoint monitoring, network monitoring, malicious code protection, and system audit logs). This will produce event records that are ready to link together and are aligned by time, so the organisation can identify correlated detections.

###### WHY (control requirement)
SI-4(16) requires the organisation to **link information from monitoring tools and mechanisms used across the system**. The guidance notes that linking tools that usually work separately gives a fuller picture and can uncover attack patterns that might otherwise go unnoticed. It also states that linking is especially important during transitions such as **Internet Protocol version 4 (IPv4) to Internet Protocol version 6 (IPv6)**.

###### HOW (specific steps/approach)
1. **Define what to correlate and how to link it**: Create a monitoring data map that lists each monitoring source in scope and the event types to link (for example: endpoint process start, malware detection, host audit or administrative actions, network connection/session events, and authentication events). Define the linking fields (join keys) and the time limits for matching (for example: host.id plus process.hash plus a time window; host.id plus user.id plus an authentication session; a malware detection event followed by related network connections).
2. **Standardise and add context to events into one common format**: Set up ingestion and standardisation so all sources produce the same key fields needed for linking, including consistent `timestamp`, `host.id`, `user.id` (or service account identifier), `event.type`, and network fields that clearly state `ip.version` (IPv4 or IPv6). Add context from authoritative sources for assets and identities (Configuration Management Database (CMDB) / Identity and Access Management (IAM)) so linking works consistently across environments.
3. **Create correlation rules/detections as controlled, versioned updates**: Build detection and correlation rules (for example, in security information and event management (SIEM) detection-as-code) that explicitly link across sources using the agreed join keys and time windows. Make sure the rules use `ip.version` so the same detection logic works during **IPv4 to IPv6** transition periods.
4. **Align time and manage clock differences**: Ensure all monitored hosts use Network Time Protocol (NTP) or chrony for time synchronisation. Configure the SIEM to allow an agreed level of timestamp mismatch (skew tolerance) while still producing clear, predictable timelines. Check that linked timelines make sense and do not show consistent ordering errors.
5. **Record and keep correlation results with audit traceability**: Configure the SIEM (or correlation layer) to store linked events, incidents, and timelines, and connect them back to the underlying raw events and audit log entries. This lets investigators trace from the correlation result back to the original audit records.
6. **Run it in day-to-day operations and confirm coverage**: Use correlation as part of routine monitoring (Security Operations Centre (SOC) workflows). Carry out scheduled validation tests (for example: synthetic event chains) and source health checks to confirm that each in-scope monitoring source is sending events and that the correlation rules trigger as expected.

###### WHO
- **Security Operations Lead / SOC Manager**: owns correlation use cases, day-to-day operating processes, and the validation schedule.
- **SIEM/Monitoring Engineer**: implements event ingestion standardisation, enrichment, and correlation rules.
- **Identity/Asset Data Owner (IAM/CMDB)**: provides the authoritative identity and asset details used for enrichment.
- **Change Manager / Security Architect**: ensures changes to correlation rules follow change control and are reviewed.

###### Acceptance criteria
- Correlation rules exist for the defined multi-source scenarios and use explicit join keys and time windows.
- All configured sources produce events that are ready for correlation, with consistent timestamps and the required identifiers.
- Correlated outputs (incidents/timelines) are kept and can be traced back to the underlying raw events and audit log entries.
- IPv4 and IPv6 events are correlated correctly using `ip.version` (no loss of correlation quality during **IPv4 to IPv6** transition testing).
- Scheduled validation tests show that each in-scope monitoring source contributes events and that correlation detections work as designed.

###### Actions Required for Compliance

- [ ] Create a monitoring data map that lists the monitoring tools and mechanisms that are in scope, and the event types that should be linked together for correlation.
- [ ] For each multi-source scenario, define the matching fields (“join keys”) and the time range (“time window”) to use when combining data (for example, host plus process hash plus time, or host plus user plus authentication session).
- [ ] Set up security information and event management (SIEM) to collect and standardise events into a single common event format, using consistent timestamps and clearly stating the IP version (ip.version).
- [ ] Set up enrichment for authoritative identity and asset information (identity and access management (IAM) and configuration management database (CMDB)) so that related events use the same host identifier and user identifier (host.id and user.id).
- [ ] Create and deploy version-controlled detection rules that link information from computers (hosts), network activity, malware protection, and audit records.
- [ ] Set how long data is kept and ensure traceability, so every combined result can be traced back to the original raw events and audit records.
- [ ] Run scheduled validation tests and check that data sources are healthy to confirm that correlation coverage is complete and that behaviour is correct for both Internet Protocol version 4 (IPv4) and Internet Protocol version 6 (IPv6).


---

#### SI-4.17 — Integrated Situational Awareness (Enhancement)

This requirement is about combining different types of security information so you can see the full picture of what is happening across the organisation, not just in one area. If physical security alerts, computer activity, and information about suppliers are not brought together, a sophisticated attacker could take advantage of weaknesses in more than one place at the same time—bypassing what separate teams can see—making it harder to spot what went wrong and how it happened.  

To meet this expectation, the organisation must decide which categories of monitoring information to combine from physical security, computer systems, and supplier sources. It must also ensure that records from each area can be linked together, and run a documented, repeatable process to correlate the information using defined tools and methods.  

The results must be kept as records for later review, made available to support investigations, and supported by clear procedures, assigned responsibilities, documented design and configuration details, audit evidence, and plans set out in the organisation’s security and supply chain risk documents.

##### Cross-domain integrated situational awareness via normalised event correlation

- Category: Software
- Priority: Critical

###### WHAT
Set up an organisation-wide capability to bring together **physical monitoring**, **cyber monitoring**, and **supply chain monitoring** signals into one combined, linked view (for example, a single timeline and set of alerts). Keep the results of this linking as records that are ready for audit.

###### WHY (control requirement)
SI-4(17) enhancement requires the organisation to **link information from physical, cyber, and supply chain monitoring activities** to achieve **joined-up, organisation-wide awareness of what is happening**. The guidance highlights that linking information beyond cyber helps detect more complex, multi-stage attacks and supports investigations into the methods and techniques used.

###### HOW (specific steps/approach)
1. **Define what will be linked and the categories (minimum set):**
   - Choose and document the categories of monitoring to link across at least:  
     - **physical** (for example, badge/access control events, perimeter alarms, site/facility security events)  
     - **cyber** (for example, authentication events, endpoint and network activity details, administrative actions)  
     - **supply chain** (for example, vendor or third-party security advisories, changes to component and version records, software bill of materials (SBOM)-based component-to-asset links, and third-party incident signals).
   - Define the minimum shared information needed for linked (correlation-ready) events: **timestamp**, **source domain**, **site/location**, **asset identifier**, **identity** (user or service account), **component/vendor** (where relevant), **event type**, **severity/impact**, and **linking keys** (for example, asset ID, identity ID, component ID).

2. **Standardise and add context to monitoring data into one common format:**
   - Set up data intake from physical monitoring systems, cyber monitoring sources (security information and event management (SIEM), endpoint detection and response (EDR), and authentication logs), and supply chain feeds/inventory systems into a **single standard event format**.
   - Add context using trusted information already held in the environment (for example, asset inventory/central configuration database (CMDB), identity directory attributes, system-to-owner and system-to-location mappings, and component-to-asset relationships derived from SBOM/inventory).

3. **Create linking rules across domains and define investigation steps:**
   - Build linking logic (detection-as-code) for multi-domain patterns, such as:  
     - a **physical anomaly** at a site + a **privileged cyber action** + a **deployment/change event** connected to a third-party component/version within a defined time window;  
     - a **supply chain advisory/component update** + **authentication/privilege changes** on affected assets.
   - Set up security orchestration, automation and response (SOAR)-style investigation playbooks that automatically:  
     - build an investigation timeline from linked events,  
     - move from component/vendor information to the affected assets,  
     - retrieve supporting evidence (original events and added-context snapshots), and  
     - record assumptions and conclusions.

4. **Record and keep the linking results as evidence:**
   - Store linking results (alerts, timelines, rule versions, enrichment snapshots, and investigation outputs) in an auditable way, with integrity controls (for example, write-once/immutable logging where available) and retention aligned to the organisation’s logging and incident evidence requirements.

5. **Run it as an operational capability with documented procedures and governance:**
   - Document the linking process, roles and responsibilities, the rule lifecycle (creation, review, approval, testing, deployment), and how evidence is produced for investigations.
   - Make sure the linking capability is reflected in relevant security and supply chain risk documentation and is maintained through change and configuration management.

###### WHO
- **Security Operations Lead / security operations centre (SOC) Manager:** owns linking use-cases, rule tuning, and investigation playbooks.
- **security information and event management (SIEM)/security orchestration, automation and response (SOAR) Engineer (or Platform Owner):** implements data intake, standardisation, linking rules, and evidence storage.
- **Physical Security Lead:** provides the physical event categories and ensures physical sources are correctly mapped to assets and locations.
- **Third-Party/Supply Chain Risk Manager:** provides supply chain monitoring inputs (advisories, component/version context) and validates component-to-asset mapping.
- **Information Security Governance / Compliance:** ensures documentation, approvals, and audit evidence meet organisational requirements.

###### Acceptance criteria
- The organisation can show that **physical + cyber + supply chain** events are ingested, standardised, and linked into an **integrated view** for investigation.
- At least **one** cross-domain linking use-case produces an alert/timeline that includes evidence from **all three domains** (physical, cyber, supply chain) and can be replayed using stored linking outputs.
- Linking outputs (alerts/timelines, rule versions, enrichment snapshots, and investigation records) are kept and can be retrieved for audit and investigation purposes.
- Linking rules and playbooks are managed through a documented lifecycle with defined roles and approvals.

###### Actions Required for Compliance

- [ ] Document the minimum monitoring categories for physical security, cyber security, and the supply chain, and specify the required information fields (keys) needed to link related events together.
- [ ] Set up data ingestion pipelines to convert physical, cyber, and supply chain information into one shared standard event format.
- [ ] Use authoritative records to enrich data by matching assets, identities, and software components to the specific assets they belong to (software bill of materials (SBOM) or inventory).
- [ ] Develop and test at least one cross-domain correlation rule that creates a single combined timeline and alert.
- [ ] Create security orchestration, automation and response (SOAR) investigation guides that move from supply chain or component information to the affected systems, and collect supporting evidence.
- [ ] Set up retention so that correlation results can be audited, including the rule versions used and the enrichment snapshots captured.
- [ ] Publish and keep documented procedures for correlating events, including assigned responsibilities and controls for how correlation rules are created, updated, and retired, using change and configuration management.


---

#### SI-4.18 — Analyze Traffic and Covert Exfiltration (Enhancement)

This requirement is about closely monitoring everything your systems send out, so that attempts to steal confidential information can be detected early. Without this, a malicious person could quietly move information out of your organisation in unusual ways, including hiding data inside messages or files that look normal, rather than sending it in an obvious “download” form.

To meet this expectation, the organisation must review all outgoing communications leaving the system at its external entry and exit points, and also at key internal locations. This includes:
- traffic going from the demilitarised zone (DMZ) into internal subnetworks  
- traffic from application server subnetworks  
- traffic from database subnetworks  
- traffic handled by the central logging and internet access (egress) proxy system  

The organisation must put monitoring and review processes in place that look for covert data-stealing patterns, including hidden-data techniques such as steganography. It must also ensure the results of this review are produced and checked for the relevant time period.

##### Central egress inspection for covert outbound exfiltration at choke points

- Category: Software
- Priority: Critical

###### WHAT
Set up analysis of outbound network traffic to detect covert data theft as it leaves the system boundary (external interfaces) and at specific locations inside the organisation: **DMZ-to-internal subnetworks, application server subnetworks, database subnetworks, and the central logging/exit proxy subsystem**. The analysis must clearly identify **covert data theft methods**, including **steganography/hidden-data techniques**.

###### WHY (control requirement)
NIST SI-4(18) requires the organisation to **analyse outbound communications traffic** at **external interfaces** and at the specified **interior points** to **detect covert theft of information**, where covert methods include **steganography**.

###### HOW (specific steps/approach)
1. **Ensure traffic visibility/coverage at the defined choke points**
   - Send all outbound traffic from the defined interior points (DMZ-to-internal, application subnetworks, database subnetworks) through the **central logging/exit proxy subsystem** (or a tightly controlled set of exit proxies) using policy-based routing and firewall controls.
   - Confirm that no outbound route can bypass the proxy by comparing proxy logs with firewall and network detection and response (NDR) flow logs.

2. **Collect outbound information needed to detect covert activity**
   - At the exit proxy, record investigation-grade details: source and destination, ports, protocol, SNI/host, Transport Layer Security (TLS)/certificate details, HTTP request and response metadata, and session timing and volume.
   - Where feasible and allowed, enable **content-aware inspection** for supported protocols to identify suspicious encoding, compression, and unusual payload characteristics.

3. **Detect signs of covert data theft (including hidden-data/steganography)**
   - Use analytics that flag “low-and-slow” and covert patterns (for example, regular “beacon” communications, unusual destination randomness, rarely used domains, and abnormal bytes-per-session).
   - Add content-aware rules to identify likely hidden payloads, such as:
     - suspicious file or container types used for outbound transfer (for example, media containers with abnormal metadata/size ratios),
     - abnormal encoding or compression ratios,
     - unusual character patterns or payload structure that does not match the stated content type.
   - Use detection rules as code, with version control and test cases using simulated covert data-theft samples (including steganography-like payloads) to reduce false negatives.

4. **Produce audit-ready outputs and ensure they are reviewed**
   - Create alerts or tickets with enough context (time window, affected subnetwork, destination, protocol, which rule triggered, and relevant evidence snippets/metadata).
   - Connect to security information and event management (SIEM) and security orchestration, automation and response (SOAR) so analysts can investigate and record outcomes for the relevant monitoring period.

###### WHO
- **Security Engineering / Network Security Team**: implement exit routing, proxy configuration, and detection analytics.
- **Security Operations Centre (SOC) / Security Operations**: review alerts and document investigation outcomes.
- **Platform/Infrastructure Team**: ensure proxy placement and network policy changes follow change control.

###### Acceptance criteria
- Outbound traffic originating from **DMZ-to-internal subnetworks, application server subnetworks, database subnetworks, and the central logging/exit proxy subsystem** is demonstrably analysed (with evidence of proxy coverage available).
- Covert data-theft detection analytics are enabled and generate alerts for covert indicators, including hidden-data/steganography-like patterns (validated using synthetic test cases).
- Alerts and investigation records are produced in an auditable way and reviewed by the SOC for the defined monitoring period.
- Evidence exists showing no significant outbound bypass routes (proxy logs reconciled with firewall and network detection and response (NDR) flow logs).

###### Actions Required for Compliance

- [ ] Define and document the approved outbound (egress) routing rules so that all outgoing traffic from the demilitarised zone (DMZ) to internal networks, application networks, and database networks passes through the central logging and egress proxy.
- [ ] Set up the central outbound (egress) proxy to collect outgoing connection and web traffic details (connection information and protocol/Hypertext Transfer Protocol (HTTP) metadata) that are enough to assess covert data exfiltration.
- [ ] Set up covert data-exfiltration detection analytics in the proxy and security information and event management (SIEM) pipeline, including rules to identify signs of hidden data, such as steganography-like indicators.
- [ ] Create detection rules as code, with automated test cases (including payloads designed to look like hidden or disguised data), and check that alerts are accurate and reliable.
- [ ] Integrate proxy alerts into security information and event management (SIEM) and security orchestration, automation and response (SOAR), including context that is ready for investigation, and ensure the security operations centre (SOC) has review workflows in place.
- [ ] Compare proxy logs with firewall and network detection and response (NDR) flow logs to confirm that outbound traffic inspection is covered, and to spot any possible bypass routes.


---

#### SI-4.19 — Risk for Individuals (Enhancement)

This requirement is about taking extra care with specific people who have been identified as higher risk. The aim is for the organisation to spot and respond to problems early, rather than relying only on routine checks. Without this, harmful incidents could go unnoticed for longer, putting colleagues, customers, and the organisation itself at risk. It could also increase the chance of acting unfairly or unlawfully.

The organisation must put in place additional monitoring for individuals identified as higher risk, using information from personnel records, law enforcement, intelligence agencies, and internal security referrals. For each person, it must clearly record the reasons they were selected. The organisation must coordinate this work with the appropriate internal leaders, including management, legal, security, privacy, and human resources. It must ensure the monitoring is carried out in line with all relevant laws, official directions, regulations, and the organisation’s own policies and procedures, and it must keep proper records so decisions and actions can be reviewed later.

##### Additional monitoring case workflow with legal/privacy approvals

- Category: Manual
- Priority: Critical

###### WHAT
Set up a documented, auditable “increased-risk monitoring” case process that adds **extra monitoring** for **specific individuals** identified as posing a higher level of risk, using the agreed **sources**.

###### WHY (control requirement)
This requirement (NIST SI-4(19) enhancement) means the organisation must **add extra monitoring** for **individuals identified by specified sources** as posing increased risk. The monitoring must be coordinated with **management, legal, security, privacy, and human resources officials**, and carried out in line with **all applicable laws, directives, regulations, policies, standards, and guidance**.

###### HOW (specific approach)
1. **Define “extra monitoring”** in an organisation-approved procedure. This should state what actions are allowed (for example, closer oversight of relevant account activity, more frequent review of security-relevant logs, extra scrutiny of privileged actions) and what is explicitly not allowed (for example, monitoring outside the approved scope).
2. **Create an “increased-risk register”** (the case record). This is the system of record for each individual. The register must, at minimum, record: the individual identifier, the **source(s)** used (from personnel records, law enforcement, intelligence agencies, internal security referrals), the **documented reason** for the increased risk, the monitoring start date, monitoring scope, case owner, review frequency, and the final outcome.
3. **Use role-based coordination and approvals** within the workflow: legal, privacy, security, and human resources must be consulted and must approve before monitoring starts. The workflow must record who approved what, and the dates and times of decisions.
4. **Carry out monitoring using controlled runbooks**: once a case is approved, the security operations team must perform only the monitoring steps listed in the approved case plan (for example, targeted log review, re-checking privileged access, enhanced incident triage for relevant accounts). Every monitoring action must be recorded back in the case record, with references to supporting evidence.
5. **Ensure legal and privacy compliance, and audit readiness**: the workflow must require evidence attachments (or references) that support the decision. It must keep an auditable record of who approved what and when, and ensure monitoring is carried out only under the approved case plan and in line with applicable laws and organisational policies.

###### WHO
- **Security Operations Lead / Security Operations Centre (SOC) Manager**: owns the monitoring runbooks and ensures they are carried out.
- **Governance, Risk and Compliance (GRC) / Compliance Analyst**: maintains the increased-risk register and the evidence requirements.
- **Legal Counsel**: approves the monitoring scope and confirms it is lawful.
- **Privacy Officer**: approves the privacy impact and ensures data minimisation.
- **Human Resources (HR) Representative**: confirms the correct linkage to personnel records and coordinates with HR.
- **Information Security Officer (or delegated authority)**: ensures the workflow is governed properly and meets security standards.

###### Acceptance criteria
- For each selected individual, the case record includes: (a) the individual identifier, (b) the **defined sources** used, and (c) a documented rationale linking the sources to the increased risk.
- Monitoring does not begin until **legal, privacy, security, and HR coordination/approvals** are recorded in the case workflow.
- Monitoring actions carried out by the SOC/security team are limited to the approved “extra monitoring” scope, and are recorded with evidence references in the case record.
- The organisation can produce an audit report showing: the individuals covered, sources used, approvals, monitoring start and end dates, actions taken, and review outcomes.

###### Actions Required for Compliance

- [ ] Define and document what “additional monitoring” is allowed for people considered to be at higher risk, including clear items that are not included.
- [ ] Create an “increased-risk register” case template that requires: an individual identifier, the source or sources of information, the reason for the risk rating, a monitoring plan, required approvals, and how often the case will be reviewed (review cadence).
- [ ] Set up the workflow so that legal, privacy, security, and human resources must record their coordination and approval before any monitoring starts.
- [ ] Create security operations centre (SOC) runbooks that link approved incident plans to specific monitoring actions and the steps needed to collect supporting evidence.
- [ ] Set up an audit process to confirm that every monitoring case includes supporting evidence, the required approvals, and a record of actions taken, in line with the relevant laws and organisational policies.
- [ ] Run a pilot using a small number of cases, and confirm that any monitoring actions stay within the approved scope and generate evidence suitable for audit.


---

#### SI-4.20 — Privileged Users (Enhancement)

This expectation is about keeping a close, live watch on the most powerful accounts in your systems, so you can see what they do while they are doing it. Privileged users can access sensitive information and make high-impact changes, so if their accounts are misused—whether by a criminal, a mistake, or a compromised device—damage can happen quickly and may be hard to trace later. To meet this expectation, the organisation must set up real-time monitoring for privileged user sessions, record what commands those users run and link them to the exact user and session, and automatically raise alerts when behaviour looks unusual based on clearly defined rules. Alerts must reach the people responsible for monitoring promptly enough for action, and the organisation must keep the session and command records for later review. It must also document how the monitoring is configured and operated, include it in the system’s security plan, and assign named staff to respond to alerts.

##### Real-time privileged session and command monitoring with alerts

- Category: Software
- Priority: Critical

###### WHAT
Set up **real-time monitoring of privileged user sessions**, including **auditing of privileged commands** and **alerts for unusual (anomalous) privileged activity**.

###### WHY (control requirement)
NIST SI-4(20) enhancement requires: **“Implement the following additional monitoring of privileged users: {{ insert: param, si-04.20_odp }}.”** The organisation-defined parameter **si-04.20_odp** specifies **real-time monitoring of privileged user sessions, including privileged command auditing and anomaly alerts**.

###### HOW (specific approach)
1. **Define privileged users and sessions** using the organisation’s main identity source (for example, identity provider (IdP) and privileged access management (PAM) roles or groups). Make sure the monitoring system can reliably mark activity as “privileged” based on role membership when the session starts.
2. **Collect session activity in real time** for administrator access paths (for example, admin consoles, secure shell (SSH) or remote desktop protocol (RDP) jump hosts, and privileged web administration tools). Capture at minimum: start and end time, user identity, session identifier, source, and target system.
3. **Audit commands during privileged sessions** where the access method supports it (for example, capture and parse terminal commands for SSH; capture commands and actions in an application-aware way for admin consoles). Make sure command events are linked to the same **user + session ID + target**.
4. **Send events to the security information and event management (SIEM) or monitoring platform** with low delay (near-real-time) and a consistent event format, so privileged-session and command events can be matched together.
5. **Set up anomaly detection** for privileged behaviour using documented, testable criteria (for example, commands outside an approved list for each privileged role, unusual command sequences, signs of privilege escalation, and abnormal login times or targets). Configure the rules to raise alerts when thresholds are met.
6. **Send alerts quickly** to the agreed monitoring and response channel (for example, security operations centre (SOC) queue, ticketing system, or incident workflow). Include enough information to act (user, session ID, target, command, timestamp, and the rule that triggered).
7. **Keep and protect monitoring records** (session and command audit logs) in an append-only or tamper-resistant way where possible, with access limited to authorised security and audit roles.
8. **Document how it is configured and operated** (monitoring scope, how “privileged” is defined, detection rules, alert routing, retention, and operational runbooks) and include this in the system security plan.

###### WHO
- **Security Engineering / SOC Engineering**: set up SIEM integrations, detection rules, alert routing, and evidence generation.
- **Identity and access management (IAM) / privileged access management (PAM) owner**: maintain the list of privileged users and ensure privileged sessions are tagged correctly.
- **System/Platform owner**: ensure privileged access routes go through the monitored mechanisms.
- **SOC analysts / incident response lead**: handle alert triage and carry out response playbooks.

###### Acceptance criteria
- Privileged sessions are **identified and tagged** as privileged at the start of the session using the organisation’s privileged-user definition.
- For privileged sessions, **command-level audit events** are created and **linked to user + session ID + target**.
- Anomaly detection rules generate **alerts** for the defined types of unusual privileged behaviour, and alerts include the required details.
- Alerts are sent to the monitoring and response channel with **near-real-time** timing suitable for investigation.
- Session and command audit records are **kept and protected** (restricted access; append-only or tamper-resistant where feasible).
- Monitoring configuration, detection logic, alert routing, and operational procedures are **documented** and referenced in the system security plan.

###### Actions Required for Compliance

- [ ] Define which users and roles are “privileged” in the main identity and access management (IAM) and privileged access management (PAM) system, and publish the mapping used to tag privileged sessions.
- [ ] Enable real-time session monitoring for all administrator privileged access routes, and ensure session IDs are recorded.
- [ ] Enable command-level auditing for privileged sessions where supported, and make sure every command record is linked to the user, the session ID, and the target.
- [ ] Send privileged session and command activity to the security information and event management (SIEM) or monitoring platform, delivered in near real time and using a consistent format.
- [ ] Create and test rules to detect unusual activity by privileged users, using documented approved lists and thresholds, and check that any alerts are accurate.
- [ ] Set up how alerts are sent to the security operations centre (SOC) and incident workflow, including full details (user, session ID, destination, command, time, and the rule that triggered the alert).
- [ ] Set how long session and command audit records are kept, and who can access them. Use records that cannot be changed (append-only/immutable) where possible, and record where the evidence is stored.


---

#### SI-4.21 — Probationary Periods (Enhancement)

This requirement is about closely monitoring what new starters do during their first 90 days, so any unusual or improper behaviour is identified early rather than weeks later. The real-world risk is that someone who is still on probation may misuse their access, try to do things they should not be able to do, view sensitive information, or carry out suspicious actions before they are fully trusted or before any issues are noticed.

To meet this expectation, the organisation must put enhanced monitoring in place for each new employee throughout their first 90 days. This must include recording and later reviewing:
- sign-in activity
- actions taken using higher-level permissions
- access to files and records
- alerts raised by the employee’s work device

The organisation must also document how this probation monitoring is set up and carried out, keep the monitoring records so they can be checked when needed, and make sure this approach is included in its overall security planning.

##### Probationary user monitoring scope via HR-to-IAM tagging

- Category: Software
- Priority: Critical

###### WHAT
Set up stronger monitoring for each employee during their probation period (the first 90 days). This includes the additional monitoring categories the organisation requires: **sign-in (logon) events, privileged actions, data access, and endpoint alerts**.

###### WHY (control requirement)
SI-4(21) enhancement requires the organisation to **put in place extra monitoring of individuals during probation** (parameter: **si-04.21_odp.02** = first 90 days) and to apply the organisation-defined **additional monitoring** (parameter: **si-04.21_odp.01** = enhanced access and activity monitoring, including sign-in (logon) events, privileged actions, data access, and endpoint alerts). The guidance notes that probation status and limited access can increase risk, so issues must be detected early.

###### HOW (specific steps/approach)
1. **Create an official probation period in identity systems**: Use Human Resources (HR) start-date information in the identity and access management (IAM) user process to calculate `probation_start_date` and `probation_end_date` (start date plus 90 days). Publish an identity attribute (for example, `employmentStatus=probation` and/or `probationExpiresOn`).
2. **Use identity attributes to control what is monitored**: Configure the security information and event management (SIEM) and related data pipelines so that events are **tagged and linked** to users while the probation attribute is active. Make sure sign-in (logon) events include the user identity and are sent to the SIEM.
3. **Turn on and centralise the required event types**:
   - **Sign-in (logon) events**: collect authentication/sign-in logs from the enterprise identity provider.
   - **Privileged actions**: collect admin and audit events (identity/directory admin events and, where relevant, operating system privilege changes and audit logs).
   - **Data access**: collect application, database, and file access audit logs where possible, ensuring events include the user identity and the specific resource accessed.
   - **Endpoint alerts**: ensure endpoint detection and response (EDR) / extended detection and response (XDR) alert information is sent into the SIEM and can be linked to the correct user account.
4. **Set up a probation-focused review process**: Create a dedicated “probation monitoring” queue/dashboard in the security operations centre (SOC) / SIEM that shows probation-tagged events and alerts. Include clear steps for checking, escalating, and recording analyst notes.
5. **Keep records for audit purposes**: Set log retention and access controls so probation monitoring records (including the identity attribute state used to decide what to monitor) are kept for later review and investigation.
6. **Document how it works**: Produce audit-ready documentation covering: (a) how probation dates are calculated (HR to IAM), (b) which data sources are used for each required category, (c) how probation scoping is applied in the SIEM and detections, and (d) how analysts review and close probation-related alerts.

###### WHO (role responsible)
- **IAM/Identity Engineer**: automate probation attributes from HR to IAM and manage the attribute lifecycle.
- **SIEM/Detection Engineer**: set up event collection, correlation/tagging, and probation-focused dashboards/queues.
- **SOC Lead / Incident Response Analyst**: run the probation queue triage process and manage evidence and case handling.
- **Information Security Governance**: review and approve documentation and retention settings.

###### Acceptance criteria
- For a test group of new starters, the system correctly marks users as probationary for **the first 90 days** and stops probation-based monitoring after day 90.
- The SIEM holds probation-scoped records for **sign-in (logon) events, privileged actions, data access, and endpoint alerts**, with consistent linking to the correct user identity.
- The SOC can show a probation monitoring queue, including analyst review results (triage/escalation/closure) for probation-scoped events.
- Evidence is kept and can be retrieved for audit, including the basis for probation scoping (the identity attribute state).
- Documentation exists and is up to date, describing configuration, data sources, scoping logic, the review process, and retention.

###### Actions Required for Compliance

- [ ] Use the employee start date from Human Resources (HR) in identity and access management (IAM) to calculate and publish probation start and end dates (the first 90 days) as the official identity information attribute.
- [ ] Set up security information and event management (SIEM) and log pipelines to label and link events to users whose probation status is active.
- [ ] Enable and centralise the collection of sign-in events, privileged actions, data access activity, and alerts from approved enterprise telemetry sources.
- [ ] Set up probation-only security operations centre (SOC) dashboards and queues, and define the analyst “first check” (triage) and escalation steps for events marked as probation.
- [ ] Set how long probation monitoring records are kept and who can access them, so the evidence is available later for review and investigation.
- [ ] Document the probation monitoring setup, how the scope is decided, where the monitoring data comes from, how reviews are carried out, and the data retention settings for audit purposes.


---

#### SI-4.22 — Unauthorized Network Services (Enhancement)

This requirement is about finding any network service that has not been formally approved before it starts being used. If unauthorised services are allowed to run without being noticed, they can become unreliable “imposters” that disrupt legitimate systems, or they can create a path for harmful activity that avoids normal safeguards.  

To meet this expectation, the organisation must continuously check for network services running on its systems and compare what it finds against the organisation’s documented approval record. This approval record must be created through the service request and approval process within the information technology (IT) service management ticketing system.  

Any service that cannot be matched to this approval evidence must be treated as unauthorised or unapproved. When this happens, the organisation must create an audit record that includes the service details, where it was found, when it was detected, and why it was judged unauthorised. The organisation must also raise an alert to the information system security officer and the network operations lead.

##### ITSM-approved network services registry with unauthorised service alerts

- Category: Software
- Priority: Critical

###### WHAT
Set up an automated, IT service management (ITSM)-based process that continuously finds network services and flags any service that has not been explicitly authorised/approved through the organisation’s IT service management (ITSM) service request and approval workflow.

###### WHY (control requirement)
SI-4(22) (Enhancement) requires that unauthorised or unapproved network services—including service-based “rogue” variants—are identified by comparing discovered services against the organisation’s proof of approval/validation. It also requires that unauthorised services are recorded for audit and reported to the information system security officer (ISSO) and the network operations lead.

###### HOW (specific steps/approach)
1. **Create a machine-readable “authorised services registry” from ITSM approvals**: For each approved service in the ITSM ticket or configuration item (CI) record, capture structured details needed to check matches (for example: service identifier/type, protocol, port(s), allowed scope such as hostname/FQDN/internet protocol (IP) range, environment such as production/test/development/disaster recovery, owning team, and approval/expiry status). Only treat services as authorised if the ITSM workflow records an approval outcome.
2. **Continuously discover network services**: Use enterprise asset/service discovery tools (using passive monitoring where available and active discovery where permitted) to list listening services and exposed endpoints across managed environments.
3. **Standardise and compare discovered services to the authorised registry**: Turn each discovery into consistent identifiers (protocol plus port plus endpoint identity such as FQDN/IP, and service details where available) and compare them to the registry for the correct asset/location/environment.
4. **Decide unauthorised status in a clear, repeatable way**: If a discovered service cannot be matched to an authorised registry entry (or the authorised entry is expired or outside scope), classify it as unauthorised/unapproved.
5. **Create audit evidence and raise alerts**: For each unauthorised service found, create an audit record that includes at least: service identifier/type, asset/location, time detected, and the reason (for example, “no matching ITSM approval”). Immediately alert the **information system security officer (ISSO)** and the **network operations lead**.
6. **Handle exceptions through ITSM**: If a legitimate service is found that is missing from the registry, require a new ITSM service request/approval to add or update the registry entry before the service is treated as authorised.

###### WHO
- **Information System Security Officer (ISSO)**: Receives alerts, reviews unauthorised decisions, and ensures follow-up actions are completed.
- **Network operations lead**: Investigates and fixes unauthorised services (or starts ITSM approval requests for legitimate services).
- **ITSM process owner / service management team**: Ensures approvals are recorded with structured, registry-ready details.
- **Security engineering / security operations centre (SOC) engineering**: Builds the discovery-to-registry matching, audit record creation, and alert routing.

###### Acceptance criteria
- For a test environment, if a service is introduced that has **no corresponding authorised ITSM approval entry**, the system must create an audit record with the required fields and alert both the ISSO and the network operations lead within the agreed monitoring/alerting service level agreement (SLA).
- If a service **does have a valid ITSM approval entry** (including the correct environment/scope), the system must **not** raise an unauthorised alert.
- The authorised services registry must be based on ITSM approval outcomes and must be versioned and auditable (so changes to authorisations can be traced back to ITSM records).
- Alert routing must reliably send alerts to the ISSO and network operations lead as defined by the organisation’s parameters.

###### Actions Required for Compliance

- [ ] Define the structured data model for authorised IT service management (ITSM) services, including: service identifier and type, protocol, port(s), what the service can access (endpoint scope), environment, approval outcome, and expiry date.
- [ ] Set up an automated process to export and transform approved IT service management (ITSM) requests into a version-controlled, authorised services register, with complete audit records.
- [ ] Set up continuous network service discovery (using passive monitoring and any allowed active checks) across all managed environments and separate each tier.
- [ ] Set up a process that matches each discovered service to the correct registry entry by checking its protocol, port, endpoint identity, and the environment it belongs to.
- [ ] Set up unauthorised decisioning to mark services as unauthorised when there is no matching authorised registry entry, or when the authorisation has expired or is no longer applicable.
- [ ] Create an audit record for every unauthorised detection, including the service identifier/type, the asset or location, the time of the detection, and the reason for it.
- [ ] Set up alerting so that unauthorised detections trigger notifications and security information and event management (SIEM) cases, which are sent to the information system security officer (ISSO) and the network operations lead.


---

#### SI-4.23 — Host-based Devices (Enhancement)

This requirement is about making sure every company device can be monitored from within, so suspicious activity and unauthorised changes are noticed quickly. Without this, a compromised server, laptop, or phone could quietly carry out harmful actions, and changes to important files or settings could be made without anyone being able to show what happened or when.

To meet this expectation, the organisation must put in place host-based monitoring on all servers, notebook computers, and mobile devices using three elements together:
- tools that can detect and respond to threats and send alerts to a central location
- automatic collection of device activity records into a central location for review
- integrity monitoring that records changes to key files or settings

The organisation must also:
- keep an up-to-date list of which devices are covered
- document which tools are used and how they are configured
- define who is responsible for running the monitoring and checking the results
- keep the alert and log records produced, so they can be audited and used as evidence over time.

##### Host-based monitoring on all endpoints via EDR, host logs, integrity

- Category: Software
- Priority: Critical

###### WHAT
Set up monitoring on the defined system components (servers, notebook computers, and mobile devices) using the organisation-approved host-based monitoring methods: **(1) endpoint detection and response (EDR) with central alerts, (2) host log collection (for example, Sysmon/Windows Event Forwarding), and (3) integrity monitoring**.

###### WHY (control requirement)
SI-4(23) enhancement requires: **“Implement the following host-based monitoring mechanisms at {{param, si-04.23_odp.02}}: {{param, si-04.23_odp.01}}.”** The guidance explains that host-based monitoring gathers information about the host/system and can be applied to servers, notebook computers, and mobile devices.

###### HOW (specific steps/approach)
1. **Define and keep an up-to-date list of which devices are in scope**, covering all servers, managed notebooks, and mobile devices (including production/test/disaster recovery where your system security plan scope requires it). Make sure every device has an assigned owner and a confirmed monitoring status.
2. **Install EDR on all in-scope devices** and configure **central alerting** so detections create alerts in a central console/workflow (for example, security operations centre (SOC) case management). Use consistent severity levels and alert routing.
3. **Turn on host log collection** on all in-scope devices:
   - For Windows devices, enable **Sysmon** and/or **Windows Event Forwarding** to send relevant device activity to the central log platform.
   - Ensure logs contain enough detail for investigations (for example, process start events, sign-in/authentication events, changes to services/drivers, and network connection details where supported).
4. **Turn on integrity monitoring** on all in-scope devices by:
   - Defining what will be monitored (for example, operating system files, security-relevant configuration files, and selected application folders).
   - Setting baseline rules to record and alert on unauthorised changes.
5. **Centralise and keep evidence** by configuring the EDR console, the forwarded host logs, and integrity monitoring alerts so they can be searched in central tools and retained according to the organisation’s logging and retention requirements.
6. **Make onboarding and coverage operational** by using group-based enrolment/automation from the endpoint management and mobile device management (MDM) layer, so new or reimaged devices automatically receive the correct EDR, log forwarding, and integrity monitoring settings.
7. **Document how it is implemented** (tools used, configuration baselines, monitored folders/files, alert routing rules, and where evidence is stored) and assign named responsibilities for monitoring health, tuning, and retrieving evidence.

###### WHO
- **Cybersecurity/Detection Engineering Lead**: defines EDR alert/detection routing and integrity monitoring targets/baselines.
- **Endpoint Management Lead (IT Ops/Platform)**: carries out agent deployment, group-based onboarding, and integration with MDM/management systems.
- **SOC/Monitoring Operations**: checks that alert triage workflows work correctly and that host telemetry is visible centrally.
- **Information Security/Governance, Risk and Compliance (GRC)**: ensures documentation and audit-ready evidence retention meet organisational requirements.

###### Acceptance criteria
- EDR is installed and actively reporting on **100%** of in-scope servers, notebook computers, and mobile devices.
- Host log collection is enabled and successfully forwarding device telemetry from **100%** of in-scope endpoints to the central log platform.
- Integrity monitoring is enabled and producing auditable records of changes for the defined monitored targets on **100%** of in-scope endpoints.
- Central alerting is configured so EDR detections appear in the central SOC workflow with consistent severity and routing.
- Evidence (EDR alerts, forwarded host logs, integrity monitoring events) can be retrieved for a sample incident and remains available within the agreed retention period.
- Implementation configuration and responsibilities are documented and approved for audit.

###### Actions Required for Compliance

- [ ] Create and keep an up-to-date, authoritative list of all servers, notebook computers, and mobile devices that are within scope for host-based monitoring.
- [ ] Install and register endpoint detection and response (EDR) agents on 100% of the agreed endpoints, and set up central alerts so they feed into the security operations centre (SOC) workflow.
- [ ] Turn on Sysmon and/or Windows Event Forwarding on all Windows devices, and send the required device activity information (host telemetry) to the central logging platform.
- [ ] Set up integrity monitoring on all devices, with agreed monitored targets and baseline rules for security-relevant changes.
- [ ] Check end-to-end monitoring by running test detections and confirming that endpoint detection and response (EDR) alerts, forwarded logs, and integrity events all appear in the central system.
- [ ] Set up and check how long EDR (endpoint detection and response) alerts, forwarded host logs, and integrity monitoring records are kept, and ensure they can be searched, so they can be used as audit evidence.
- [ ] Document endpoint detection and response (EDR), logging, and integrity configuration baselines, the systems to be monitored, and operational responsibilities; obtain approval


---

#### SI-4.24 — Indicators of Compromise (Enhancement)

This requirement is about identifying early warning signs of a suspected break-in and ensuring the right people can respond quickly. Without it, the organisation may miss important clues of harmful activity or respond too late, allowing the same type of attack to spread across systems and leading to avoidable disruption, data loss, or financial harm.

To meet this expectation, the organisation must regularly review and collect indicators of compromise from the Department of Defense (DoD) and Defense Information Systems Agency (DISA) threat intelligence feeds, the Defence Industrial Base Cybersecurity Information Sharing Program (DIB CSISP), and advisories from the Computer Emergency Response Team Coordination Center (CERT/CC) and the United States Computer Emergency Readiness Team (US-CERT). It must then record what it found with enough detail to explain what it is and where it came from.

The organisation must also share these indicators in a consistent, usable way with the security operations centre (SOC) analysts, the incident response team, and the owners of the information systems, so they can investigate, look for matching activity, and take the appropriate protective actions.

##### Automated IOC ingestion, validation, and SOC/IR distribution

- Category: Software
- Priority: Critical

###### WHAT
Set up an automated capability to **find, gather, and share** indicators of compromise (IOCs) from threat-intelligence sources defined by the organisation with the **security operations centre (SOC) analysts, incident response team, and information system owners**.

###### WHY (control requirement)
Security control SI-4(24) enhancement requires the organisation to **find, gather, and share** IOCs provided by **{{ param, si-04.24_odp.01 }}** with **{{ param, si-04.24_odp.02 }}**. The guidance explains that IOCs are forensic evidence items identified at host and network level, and that **sharing them quickly** improves how effective the defence is.

###### HOW (specific steps/approach)
1. **Take in data from the defined sources** on a clear, repeatable schedule (for example, hourly or daily) using dedicated connectors for:
   - Department of Defense (DoD) and Defense Information Systems Agency (DISA) threat-intelligence feeds
   - Defense Information Systems Agency (DIB) Cyber Security Information Sharing Program (CSISP)
   - Computer Emergency Response Team Coordination Center (CERT/CC)
   - United States Computer Emergency Readiness Team (US-CERT) advisories
2. **Extract and standardise IOC details** into a single internal IOC format (for example: indicator value, indicator type such as IP/URL/domain/hash/registry artefact where present, first-seen/received date and time, and a reference to the original advisory/feed item).
3. **Store IOCs in a central IOC register** with required fields to support audit and traceability: source name, date and time collected, indicator type and value, original reference (URL/identifier), and distribution status.
4. **Check before sharing** using a simple workflow: a SOC analyst reviews proposed IOCs, decides whether they are relevant (validated / not applicable / needs more information), and records the reason.
5. **Share with the defined recipients** using controlled methods:
   - SOC analysts: send validated IOCs into the security information and event management (SIEM) and security orchestration, automation and response (SOAR) context, and into a hunting queue (including the source reference and expected search scope).
   - Incident response team: attach validated IOCs to incident response (IR) case/incident templates (in a timeline-ready format).
   - Information system owners: send a short bulletin stating what to look for, where to check, and recommended actions.
6. **Keep full traceability and evidence** by linking every shared IOC back to the original source item, and by logging ingestion and sharing events (so they can be audited and reviewed after incidents).

###### WHO
- **SOC Lead / SOC Analyst**: validates IOCs and records the reason for each decision.
- **Security Engineering (SIEM/SOAR/Threat Intelligence Engineering)**: builds the ingestion connectors, standardises IOC data, maintains the IOC register, and sets up the sharing integrations.
- **Incident Response Manager**: ensures IR workflow templates use the IOC outputs correctly.
- **Information System Owners**: confirm receipt and carry out the recommended hunting and mitigation actions.

###### Acceptance criteria
- The system ingests IOC-containing content from all four required source types and produces standardised IOC records.
- Each IOC record includes traceability back to the originating advisory/feed item and a collection timestamp.
- Validated IOCs are shared to all three recipient groups (SOC analysts, incident response team, information system owners) through the defined channels.
- Sharing happens only after documented validation (or an explicit “not applicable/needs more information” outcome) recorded by the SOC.
- Ingestion, validation, and sharing actions are logged and can be retrieved for audit (for example: “show me IOC X → source item → validator → recipients → time”).

###### Actions Required for Compliance

- [ ] Define and set up data intake connections for Department of Defense (DoD) and Defense Information Systems Agency (DISA) feeds, the Defense Information Board (DIB) Cybersecurity Information Sharing Program (CSISP), the Computer Emergency Response Team Coordination Center (CERT/CC), and United States Computer Emergency Readiness Team (US-CERT) advisories.
- [ ] Create a standardised “indicator of compromise” (IOC) format and extraction rules for the indicator types expected in the feeds and advisories.
- [ ] Set up a single central “indicators of compromise” (IOC) register with required fields for the source reference, the indicator value and type, and the time the information was collected.
- [ ] Set up a security operations centre (SOC) validation process that records the validation outcome and the reason for it before any information is shared.
- [ ] Integrate verified indicators of compromise (IOCs) into security information and event management (SIEM) and security orchestration, automation and response (SOAR) search queues for security operations centre (SOC) analysts, and into incident response (IR) case and incident templates.
- [ ] Send indicator of compromise (IOC) bulletins to information system owners, including practical guidance for detecting threats and reducing risk, with clear traceability to the original sources.
- [ ] Turn on audit logging for data ingestion, validation, and distribution events, and check that each sample indicator of compromise (IOC) can be traced end to end.


---

#### SI-4.25 — Optimize Network Traffic Analysis (Enhancement)

This requirement is about making sure the organisation can clearly understand what network traffic is doing at both the outside entry points and the most important internal connections. This helps monitoring tools be tuned to spot real problems more reliably. Without this, the organisation may miss important activity because some traffic is hidden by encryption, takes different routes depending on direction, or is lost or delayed when systems are busy. Changes in technology (for example, moving between older and newer network methods) can also create gaps in visibility.

To meet this expectation, the organisation must first identify where visibility could be incomplete. It must then set up a practical approach to collect the relevant traffic from the agreed external and internal points, deal with encrypted traffic where permitted (or use an equivalent way to see what matters), clean and prepare the data for analysis, and send only the useful information to monitoring tools. The organisation must document the approach, assign responsibilities, keep records and reports of what was collected and improved, and use the results to continuously improve how effective monitoring is.

##### Interface flow visibility with blind-spot coverage and monitoring tuning

- Category: Software
- Priority: Critical

###### WHAT
Set up an interface-based capability to see network traffic by capturing it at agreed **external** and **key internal** system connection points. The traffic will be cleaned up and prepared, filtered to the traffic types that matter, and then used to **improve how effective monitoring is**. This includes finding gaps caused by encryption, one-way (asymmetric) routing, limits on capacity and delay, and changes during **Internet Protocol version 4 to version 6 (IPv4 to IPv6)** transitions.

###### WHY (control requirement)
SI-4(25) (Enhancement) requires the organisation to provide visibility of network traffic at **external and key internal system interfaces** to improve monitoring effectiveness. It also requires addressing blind spots caused by **encrypted traffic, asymmetric routing, capacity and latency limits, and technology transitions**. The guidance specifically expects the organisation to collect traffic, decrypt it where permitted, prepare it for analysis, and share only the relevant traffic with monitoring devices to make analysis more efficient.

###### HOW (specific steps/approach)
1. **Define observation points**: Using the system and network design, document the specific **external** interfaces (for example, internet edge firewall, virtual private network (VPN) concentrator, load balancer) and **key internal** interfaces (for example, east-west firewalls, boundaries of critical subnets, load balancer to application tiers) where traffic visibility is required.
2. **Collect consistent flow or metadata at each point**: At each observation point, collect traffic using a standard export method where available (for example, NetFlow or Internet Protocol Flow Information Export (IPFIX), or firewall flow logs). If flow export is not available, use an approved traffic copy method (mirroring or SPAN) with safeguards to protect performance and capacity.
3. **Normalise and add context**: Convert the collected traffic into a common format in a central processing pipeline. Enrich it with trusted information such as the asset register (configuration management database (CMDB)), service maps, environment tags (for example, production (prod), test, disaster recovery (DR)), and identity details where available.
4. **Prepare and filter to relevant traffic**: Apply rules to keep only the traffic categories needed to improve monitoring (for example, traffic to and from critical subnets, service virtual IP addresses (VIPs), and required protocol and port combinations). Add sampling and buffering controls to reduce blind spots caused by capacity or delay, and record any ingestion delays or export drop-outs.
5. **Reduce encrypted-traffic blind spots without decrypting the content** (unless explicitly allowed by organisational policy): Ensure sensors capture and keep available Transport Layer Security (TLS) or session details, such as server name indication (SNI), certificate subject and issuer (if exposed by the sensor), application-layer protocol negotiation (ALPN), and Transport Layer Security (TLS) fingerprints (for example, JA3/JA4), plus destination and port and session duration. Use these details to improve detection tuning and reduce gaps where traffic would otherwise be “unknown” or “opaque”.
6. **Find and fix asymmetric routing blind spots**: Check that both the request and response directions are observed for each interface and service. If gaps are found, adjust the export or mirroring points, or add a second observation point, so that coverage is bidirectional for each service.
7. **Handle IPv4 to IPv6 transition gaps**: Ensure the processing pipeline and monitoring logic support both IPv4 and IPv6 traffic. Create checks to confirm coverage for IPv6-only services and during dual-stack transitions.
8. **Improve monitoring effectiveness using evidence**: Produce dashboards and reports by interface that show (a) what traffic categories were seen, (b) what directions or protocols are missing, (c) sensor drop rates and ingestion delays, and (d) unknowns related to encryption. Use these outputs to tune monitoring rules and sensor settings, and record the before-and-after impact (for example, reduced blind-spot rate and improved alert quality and coverage).

###### WHO (role responsible)
- **Network Security Engineer / security operations centre (SOC) engineering lead**: defines observation points, implements collectors and sensors, and tunes monitoring based on coverage evidence.
- **Security Operations (SOC) Analyst**: confirms the blind-spot findings and validates the detection tuning results.
- **Platform or cloud network engineer** (where applicable): implements mirroring and export settings and ensures performance and capacity safeguards.
- **Compliance or assurance**: reviews audit evidence (configurations, reports, and change records) to confirm SI-4(25) is effective.

###### Acceptance criteria
- Traffic visibility is implemented at all documented **external** and **key internal** interfaces for the in-scope application environments.
- The solution produces auditable evidence of **collection, preparation, filtering, and distribution** of relevant traffic to monitoring and analytics components (including configuration records).
- Blind-spot coverage checks exist and show identification of gaps related to **encrypted traffic**, **asymmetric routing**, **capacity and latency limitations** (for example, export drop-outs and ingestion delays), and **IPv4/IPv6 transitions**.
- Monitoring tuning is carried out using the collected evidence, with documented outcomes (for example, reduced unknown or opaque traffic, improved bidirectional coverage per service, improved detection coverage for critical interfaces).
- Operational reports, dashboards, and logs are retained to support auditability of what was collected and how monitoring effectiveness was improved.

###### Actions Required for Compliance

- [ ] Record the agreed external and key internal network connections for the in-scope application and its environments.
- [ ] Deploy flow and metadata collectors at each connection point, using an approved export method (for example, NetFlow/Internet Protocol Flow Information Export (IPFIX) or firewall flow logs) or mirroring that is limited by available capacity.
- [ ] Set up a normalisation and enrichment process that links each network flow to the relevant asset, service, and environment context, and keeps the original interface identifiers.
- [ ] Set up pre-processing and filtering rules so only relevant types of network traffic are sent to monitoring analytics, and record how many items are dropped and any processing delays (lag).
- [ ] Enable transport layer security (TLS) and session metadata capture (for example, server name indication (SNI), application-layer protocol negotiation (ALPN), JA3/JA4 where available) and adjust the detection rules to reduce blind spots in encrypted traffic.
- [ ] Run two-way coverage checks for each service to spot one-direction routing gaps, then adjust where data is exported or mirrored until coverage is acceptable.
- [ ] Create and keep coverage reports for each interface, and use them to record the results of monitoring tuning for audit evidence.


---

### SI-5 — Security Alerts, Advisories, and Directives (Control)

This requirement is about making sure the organisation receives important security warnings quickly, shares them with the right people, and responds without delay. This is critical because threats and weaknesses can spread rapidly. If an official warning is missed, or a required fix is not applied in time, systems, services, people, partners, and day-to-day business operations can be harmed—sometimes immediately.

To meet this expectation, the organisation must:
- Continuously monitor for, and receive, external security alerts, advisories, and instructions from the Cybersecurity and Infrastructure Security Agency (CISA), the Office of Management and Budget (OMB), the National Security Agency / Central Security Service (NSA/CNSS), the Department of Defense (DoD) Chief Information Officer (CIO), the Defense Information Systems Agency (DISA), and relevant United States Computer Emergency Readiness Team (US-CERT) advisories.
- Create and issue internal alerts and guidance when needed.
- Promptly share these messages with the Chief Information Security Officer (CISO), the Information System Security Officer (ISSO), the system owner, security operations centre (SOC) analysts, the incident response lead, all affected programme offices, engineering teams, and the IT operations and patch management teams—plus any managed service providers, cloud or on-premises service providers, and supply chain partners supporting the affected systems.
- Implement each security instruction within the required timeframes, or notify the organisation that issued it if full compliance cannot be achieved.

##### Automated intake and SLA-driven implementation of security directives

- Category: Software
- Priority: Critical

###### WHAT
Set up an “automation-first single front door” to receive **external security alerts, advisories, and directives** (from the Cybersecurity and Infrastructure Security Agency (CISA), Office of Management and Budget (OMB), National Security Agency / Committee on National Security Systems (NSA/CNSS), Department of Defense Chief Information Officer (DoD CIO), Defense Information Systems Agency (DISA), and relevant United States Computer Emergency Readiness Team (US-CERT) sources). Convert these into **clear, actionable internal messages**, send them to **named internal roles and external partners**, and track **whether directives are implemented within the required timeframes** (or produce evidence-based notifications when compliance is not possible).

###### WHY (control requirement)
Security control SI-5 requires the organisation to **keep receiving** official external security alerts, advisories, and directives, **share** them with the named internal and external stakeholders, and ensure **security directives are carried out promptly** because delays could cause immediate harm.

###### HOW (specific approach)
###### 1) Set up official sources and continuous intake
- Maintain a list of external organisations to receive updates on an ongoing basis: **CISA, OMB, NSA/CNSS, DoD CIO, DISA, and relevant US-CERT advisories**.
- Continuously collect updates from available feeds/channels (for example, scheduled checks plus webhooks/subscriptions where available), with a **manual fallback** if a feed is unavailable.

###### 2) Standardise, assess, and create tracked work
- For each incoming item, standardise key details (type: alert/advisory/directive; severity; affected products/keywords; publication time).
- Automatically create a case/ticket in the organisation’s Security Operations (SecOps) / Security Operations Centre (SOC) case management system with fields for:
  - source and type
  - required timeframe (as stated in the directive/advisory)
  - initial affected asset/service scope (from the Configuration Management Database (CMDB)/inventory)
  - assigned owner (system owner / engineering / patch management)
  - communication status
  - links to supporting evidence

###### 3) Identify likely affected systems and produce internal directives
- Use the asset inventory/CMDB and vulnerability/patch information to identify likely affected systems.
- If the match is uncertain, send it to engineering to confirm.
- Create internal advisories/directives using templates that include:
  - why it applies (reasoning)
  - required actions
  - owners and due dates
  - how to verify and when the work can be closed

###### 4) Send to named internal roles and external organisations
- Send each internal advisory/directive to the named personnel/roles:
  - Chief Information Security Officer (CISO), Information System Security Officer (ISSO), system owner, SOC analysts, incident response lead
- Send to the named parts of the organisation:
  - all affected programme offices, engineering teams, and the IT operations and patch management teams
- Send to the named external organisations:
  - managed service providers, cloud/on-premises service providers, and supply chain partners supporting the affected systems
- Use workflow-based notifications linked to the case status (for example, “confirmed applicable”, “not applicable”, “needs engineering assessment”).

###### 5) Enforce directive timeframes, with escalation and reporting for noncompliance
- Set timers based on the directive’s required timeframe.
- If the timeframe cannot be met, require a formal notification to the issuing organisation that includes:
  - how far from compliance the organisation is
  - planned compensating actions
  - expected completion date
  - evidence of efforts and approvals

###### 6) Capture audit-ready evidence
- For each received item, record at minimum:
  - time it was received
  - time(s) internal communications were sent
  - the applicability decision and the reasoning
  - the actions taken and verification evidence
  - closure status and any noncompliance notification evidence

###### WHO
- **SOC/SecOps lead**: owns the case management workflow and the automation configuration.
- **CISO/ISSO**: approves internal directive templates, escalation thresholds, and noncompliance reporting requirements.
- **System owner / engineering leads**: confirm whether it applies and implement the required changes.
- **IT operations & patch management**: carry out patch/configuration actions and provide verification evidence.
- **Incident response lead**: ensures urgent directives are handled through the operational incident process where applicable.
- **Managed service providers / cloud/on-premises providers / supply chain partners**: receive and carry out partner-scoped actions.

###### Acceptance criteria
- For each external alert/advisory/directive received from the defined sources, the system:
  1) creates a tracked case within a defined operational window (for example, the same business day),
  2) sends internal communications to all defined roles/elements and partner recipients where applicable,
  3) enforces directive service-level agreements (SLAs) and escalates when deadlines are at risk,
  4) either completes implementation with verification evidence before the required timeframe or produces an evidence-based noncompliance notification to the issuing organisation.
- Audit evidence exists for receipt, communication, decision reasoning, implementation actions, and closure/noncompliance outcomes.

###### Actions Required for Compliance

- [ ] Define and keep up to date the official external sources list (including the Cybersecurity and Infrastructure Security Agency (CISA), the Office of Management and Budget (OMB), the National Security Agency / Committee on National Security Systems (NSA/CNSS), the Department of Defense Chief Information Officer (DoD CIO), the Defense Information Systems Agency (DISA), and relevant United States Computer Emergency Readiness Team (US-CERT) advisories). Set up ongoing automatic updates from these sources, with a manual option if the automatic process fails.
- [ ] Set up a security operations and response workflow (SOAR/SecOps) that automatically creates a tracked work item for every received alert, advisory, or directive, including the required deadline and initial scope details.
- [ ] Integrate the workflow with the configuration management database (CMDB) and inventory, and with patch and vulnerability information, to link each item to the systems it affects. Send any unclear matches to the engineering team for confirmation.
- [ ] Create standard internal advisories and directives, and set up an automated, workflow-based process to distribute them to the Chief Information Security Officer (CISO), Information System Security Officer (ISSO), system owner, security operations centre (SOC) analysts, the incident response lead, programme offices, engineering teams, and IT operations/patch management.
- [ ] Once it is confirmed that the requirement applies, set up sharing of the information with managed service providers, cloud and on-premises service providers, and supply chain partners that support the affected systems.
- [ ] Enforce service-level agreement (SLA) deadlines using escalation rules, and send notifications of non-compliance only when required timeframes cannot be met, supported by evidence.
- [ ] Ensure audit records capture: receipt, how information was shared, why it applies, evidence that it was implemented and checked, and the final outcome (either completion or non-compliance).


---

#### SI-5.1 — Automated Alerts and Advisories (Enhancement)

This expectation is about making sure important security warnings are sent automatically to the right people, quickly, so they can act before small issues become major incidents. Without automatic, well-targeted alerts, staff may miss critical information, the wrong teams may respond too late, and leadership and operational decisions may be based on incomplete or out-of-date information—especially when systems and environments change often.

The organisation must:
- define who should receive security alerts and security advisories (including system owners and the Security Operations Centre),
- document how alerts are created, received, and distributed, and
- use automated email, automated ticket notifications, and automated security-monitoring broadcasts to send the messages.

It must also ensure the information supports action at governance level, in day-to-day business processes, and at system level. The organisation must keep records of what was sent and when, and retain evidence of the alert activity so an auditor can trace it from start to finish.

##### SIEM-driven automated security alerts to email, tickets, and broadcasts

- Category: Software
- Priority: Critical

###### WHAT
Set up an automated process to share security alerts and advisories across the organisation. It will take alert/advisory information from the security information and event management (SIEM) system (and other security monitoring sources where applicable) and send it to the **defined recipients** using:
- **automated email**
- **automated ticketing notifications**
- **SIEM-driven alert broadcasts**

###### WHY (control requirement)
National Institute of Standards and Technology (NIST) Special Publication (SP) 800-53 **SI-5(1) Automated Alerts and Advisories** requires: **“Broadcast security alert and advisory information throughout the organization using {{ insert: param, si-05.01_odp }}.”**  
The organisation-defined parameter **si-05.01_odp** specifies **automated mechanisms** (automated email, ticketing notifications, and SIEM-driven alert broadcasts to system owners and the Security Operations Centre (SOC)). The guidance also expects information to be shared with the right parts of the organisation across **governance**, **mission/business process**, and **information system** levels.

###### HOW (specific approach)
1. **Define alert/advisory rules and recipients**: Create an official set of rules that links each type of alert/advisory (for example, detection alert, vulnerability advisory, containment directive) to the correct recipient groups at three levels:
   - **System level**: system owners/asset owners and relevant operational teams.
   - **Mission/business process level**: business process owners and service owners affected by the impacted assets.
   - **Governance level**: SOC leadership, security governance stakeholders, and (where required) risk and compliance contacts.  
   Use enterprise identity groups through the organisation’s identity provider (IdP) so that changes in membership automatically update who receives alerts.
2. **Standardise the alert/advisory message**: Make sure the SIEM sends a structured message (not free text) that includes at least:
   - alert/advisory type
   - severity/priority
   - identifiers for affected assets
   - recommended actions
   - validity/expiry (if applicable)
   - links to authoritative guidance
3. **Automate sending (“fan-out”) from the SIEM to three channels** using an orchestration workflow (security orchestration, automation and response (SOAR)/workflow automation):
   - **Automated email** to the mapped recipient groups using templates and consistent information fields.
   - **Automated ticketing notifications** that create or update tickets with routing keys (asset/service owner), severity, and required actions; include the SIEM event identifier for traceability.
   - **SIEM-driven alert broadcasts** (or equivalent notification channels) to the SOC and system owners for near real-time awareness.
4. **Apply routing and escalation rules**: Implement controlled configuration (policy-as-code or equivalent) so that severity and asset importance determine who receives escalations at governance and mission/business process levels. Add suppression and acknowledgement handling to reduce “alert storms” while ensuring important advisories are not missed.
5. **Keep evidence that can be audited end-to-end**: For every alert/advisory event, record and retain evidence of:
   - SIEM event identifier and time sent
   - recipients (email groups and ticket assignees)
   - message identifiers (email/broadcast) and ticket identifiers
   - workflow outcome (success/failure) and any retries  
   Keep these records according to the organisation’s logging and retention policy so an auditor can trace alert creation through to delivery.
6. **Test using controlled “canary” alerts**: Run scheduled test alerts/advisories that exercise every channel and every recipient mapping tier, confirming delivery, ticket creation/update, and broadcast visibility.

###### WHO
- **Security Operations Centre (SOC) lead / SIEM engineer**: defines the alert categories, severity mapping, and SIEM message structure.
- **SOAR/workflow automation engineer**: builds the orchestration that sends alerts to email, ticketing, and SIEM broadcasts.
- **Application/system owners and business process owners**: confirm recipient group mappings and the required actions.
- **Information security governance / risk team**: approves escalation rules at governance level.

###### Acceptance criteria
- For each defined alert/advisory type, an automated workflow generates and shares the alert using **automated email**, **automated ticketing notifications**, and **SIEM-driven alert broadcasts** to the **mapped recipients**.
- Routing covers **system**, **mission/business process**, and **governance** levels based on severity and asset importance.
- For every alert/advisory event, auditable evidence exists linking the SIEM event identifier to the delivered email/broadcast identifiers and the created/updated ticket identifiers.
- Controlled test alerts prove successful delivery to the SOC and system owners, and correct escalation to governance/mission-level recipients where configured.

###### Actions Required for Compliance

- [ ] Define the types of alerts and advisories, the required information for each, and how each severity level is sent to the right recipients across system, mission or business process, and governance levels.
- [ ] Set up security information and event management (SIEM) rules so they produce structured alert messages that use consistent identifiers, clearly state which assets are affected, include the severity level, and provide links to guidance.
- [ ] Implement security orchestration, automation and response (SOAR) and workflow automation to send each security information and event management (SIEM) alert to pre-set automated actions, including templated automated emails, creating or updating tickets, and sending notifications through SIEM broadcast channels.
- [ ] Connect recipient groups to the organisation’s identity provider so that any changes to group membership automatically update who receives alerts.
- [ ] Set up complete audit records for every alert, including the security information and event management (SIEM) event ID, who received it, the email or broadcast IDs, the ticket IDs, and the workflow status. Keep these records for the period required by your organisation’s policy.
- [ ] Run scheduled “canary” alert tests to confirm that messages are delivered correctly, routed to the right place, that the relevant tickets are updated, and that supporting evidence is generated for each channel.


---

### SI-6 — Security and Privacy Function Verification (Control)

This requirement is about making sure the system’s built-in safety and privacy protections actually work, not just that they are enabled. Without this, the system could start up or restart with protections that are broken, which could allow unauthorised access, leave security records incomplete, let malware or tampering go unnoticed, or cause personal data to be handled incorrectly (for example, kept for too long, not properly hidden, or used without the right permission).

The organisation must decide which security and privacy protections apply to its on-premises mixed information technology and operational technology environment. It must then automatically run the required checks every time the system starts up and restarts, and also during startup, restart, shutdown, and abort.

If any security or privacy check fails, the Information System Security Officer and the Privacy Officer must be alerted with details of what failed, and the system must be restarted promptly. If the organisation has an approved alternative approach, it must isolate the affected component and open an incident ticket.

The results of these checks must be recorded so they can be reviewed later. The process must be supported by documented procedures and plans, and carried out by trained personnel.

##### Boot/restart privacy & security verification gate with ISSO alerts

- Category: Software
- Priority: Critical

###### WHAT
Set up an automated “security and privacy function verification gate” that runs at specific points when the system changes state—at least when the system **starts up** and **restarts**—to check that the organisation’s defined **security functions** and **privacy functions** are working correctly. If any check fails, the system must **alert the ISSO and Privacy Officer** and carry out the organisation’s defined fix (default: **restart**; alternative: **isolate the affected component and open an incident ticket**).

###### WHY (control requirement)
The United States National Institute of Standards and Technology (NIST) **security and privacy function verification (SI-6)** requires checks that security and privacy functions work correctly at defined change points (including **startup and restart**), and that failures trigger the right notifications and corrective actions. The organisation must decide:
- which security and privacy functions are included,  
- which system change points must be checked, and  
- who must be notified if a check fails.

###### HOW (specific steps/approach)
1. **Define what will be checked and how**: For the on-premises Department of Defense (DoD) mixed information technology (IT) and operational technology (OT) system, translate the organisation’s scope into specific verification tests:
   - **Security functions** to check (for example: access control, authentication, session management, audit logging, malware protection, integrity checks).
   - **Privacy functions** to check (for example: data minimisation, enforcing consent/authorisation, applying privacy attributes, masking/redaction, enforcing retention and deletion).
2. **Run the verification gate at startup/restart**: Create a start-up job (or an orchestrated pre-service check) that runs **every time the system starts up or restarts**. The gate must:
   - run only an **approved test set** that is protected from tampering (for example, signed test materials), so the verification cannot be altered;
   - run a **defined set of verification tests** for the selected security and privacy functions (matching the organisation’s SI-06 test selection);
   - save **clear, time-stamped pass/fail results** for each test, including the system run identifier and the system change point.
3. **Cover system change points safely**: Where it is technically possible to check during shutdown/abort without affecting safe operation, extend the gate to those points. If this is not feasible for certain OT components, ensure checks are done at the IT-facing boundary and/or on supervisory components that can safely run the checks.
4. **Notify on failure with useful details**: If any security or privacy verification test fails, the system must automatically:
   - notify the **ISSO and Privacy Officer** with the **failed test identifiers**, the reason for failure, and the system change point when it happened;
   - start the organisation’s defined corrective action:
     - **Default**: restart the system.
     - **Alternative (if configured)**: isolate the affected component and open an incident ticket.
5. **Keep evidence for audits**: Store the verification results in an auditable place (for example, central logging/security information and event management (SIEM) or an immutable evidence store) and keep them according to the organisation’s logging and retention requirements.
6. **Document how to operate it**: Ensure the verification gate behaviour and corrective actions are documented in the system security and privacy procedures, so operators know what to do when alerts occur.

###### WHO (roles responsible)
- **ISSO (Information System Security Officer)**: Owns security verification results, triage, and escalation.
- **Privacy Officer**: Owns privacy verification results, triage, and escalation.
- **System/Platform Engineer (IT/OT)**: Builds the verification gate, test set, and evidence logging.
- **Incident Manager / Security Operations Centre (SOC)**: Runs the incident process when the alternative corrective action is selected.

###### Acceptance criteria
- On **every system startup and restart**, the verification gate runs and produces auditable results for all in-scope **security functions** and **privacy functions**.
- If any verification test fails, the **ISSO and Privacy Officer are alerted** within the organisation’s expected operational alerting timescales, and the alert states which test(s) failed and the system change point.
- The system carries out the configured corrective action: **restart** by default, or **isolate + incident ticket** when configured.
- Verification results are stored with **time-stamped, per-test pass/fail evidence** that can be retrieved for audit review.
- The verification test set is protected against tampering (for example, signed materials are validated before running).

###### Actions Required for Compliance

- [ ] Match the organisation’s defined security and privacy responsibilities to specific, testable checks to verify the on-premises Department of Defense (DoD) mixed information technology (IT) and operational technology (OT) system.
- [ ] Set up a service that starts automatically when the system boots or restarts, and runs the approved verification test suite each time.
- [ ] Create test modules that package and verify software signatures, and require signature validation before any code is executed.
- [ ] Record structured, time-stamped pass/fail results for each test and store them as audit evidence linked to the specific system run identifier.
- [ ] Set up automated alerts to notify the Information System Security Officer (ISSO) and the Privacy Officer if any security or privacy checks fail, including the identifier for the failed test and the system’s transitional status.
- [ ] Implement automated corrective actions: by default, restart the service; if the alternative option is chosen, isolate the affected component and raise an incident ticket.
- [ ] Document how the verification gate works, what happens when it fails, and the steps operators must follow in the system’s security and privacy procedures.


---

#### SI-6.2 — Automation Support for Distributed Testing (Enhancement)

This requirement is about using automated tools to keep security and privacy testing running smoothly when it is carried out across multiple sites or systems. Without this, tests can be missed, started late, carried out differently in different places, or produce results that are incomplete or unreliable—creating gaps that could be exploited or privacy issues that could go unnoticed.  

To meet this expectation, the organisation should put in place automated mechanisms and supporting processes to manage and oversee both security testing and privacy testing wherever they are performed, ensuring the work is complete, on time, and effective. These mechanisms should be used by the people responsible for checking security and privacy, and should align with the organisation’s existing policies, procedures, plans, system settings, and records. This will allow testing to be planned, carried out, and reviewed in a consistent way that can be audited.

##### Automated orchestration and evidence for distributed security/privacy tests

- Category: Software
- Priority: Critical

###### WHAT must be done
Set up automated ways to run security and privacy testing across multiple systems and locations. The testing must be **protected against changes**, **done on time**, **cover everything intended**, and **produce results you can rely on**.

###### WHY (control requirement)
SI-6(2) enhancement requires automated mechanisms to support the **management of distributed security and privacy function testing**. This keeps the testing dependable (integrity), ensures it happens when required (timeliness), covers all intended targets (completeness), and delivers results that can be trusted (effectiveness).

###### HOW (specific steps/approach)
1. **Create standard test run templates with version control** for both security and privacy testing (for example, security checks such as scanning and configuration compliance; privacy checks such as data flow, retention, deletion, and consent evidence). Each template must specify: how targets are selected, what must be in place before testing starts, the test steps, what outputs are expected, and what evidence must be saved.
2. **Set up an orchestration workflow** that sends the same template version to the correct distributed targets (cloud accounts, on-premises network segments, separated environments, and any operational technology (OT)-adjacent management hosts where applicable). The workflow must store **unchangeable** run details (template version, list of targets, who started it, start and end times, and whether it succeeded).
3. **Automate evidence collection and standardise it**: automatically gather scan reports, configuration differences, and privacy evidence. Convert them into a single consistent format so results can be compared across sites and over time.
4. **Protect the integrity of testing evidence** using tamper-evident storage (for example, write-once, append-only storage with cryptographic signing or hashes). Store the run details alongside the evidence so auditors can trace results back to the exact template version and target list.
5. **Add automated checks for completeness and timeliness**: the orchestration layer must confirm that every eligible target in the inventory was tested (or that it was explicitly excluded with an approved reason) and that results are produced within agreed time windows. If not, it must automatically raise exceptions (for example, schedule a re-run, create a ticket, or escalate).
6. **Provide central visibility** through dashboards that show, for each target, the current status, the last successful run, the reason for any exceptions, and whether evidence is available. Ensure dashboards are based on the same run details and evidence records.

###### WHO (role responsible)
- **Security Engineering Lead / Privacy Engineering Lead**: owns the test template definitions and the acceptance criteria.
- **Platform/DevOps Engineering (Automation Owner)**: builds the orchestration, automates evidence capture, and creates the dashboards.
- **Information Security Governance / Compliance**: sets the timeliness and completeness thresholds and approves how exclusions and exceptions are handled.

###### Acceptance criteria
- For a defined distributed scope (for example, multiple environments or sites), a security test run and a privacy test run can be started using a single template version and automatically executed across all eligible targets.
- For each run, **unchangeable** run details exist for: who initiated it, the template version, the target list, start and end time, and the final outcome.
- Evidence is captured automatically, stored in a tamper-evident way, and can be traced back to the run details.
- The system identifies and reports missing, out-of-date, or incomplete results and triggers automated exception handling (for example, re-run or escalation) without relying on manual tracking.
- Central dashboards show the current status and evidence completeness for each target and each type of test.

###### Actions Required for Compliance

- [ ] Create version-controlled templates for security and privacy test runs, including rules for choosing targets, required prerequisites, and the evidence files that must be produced
- [ ] Set up an automated workflow to send the same template version to all eligible distributed locations, and record unchangeable details about each run.
- [ ] Automate collecting evidence and put the results into a single standard format for security and privacy testing.
- [ ] Store run evidence and metadata in a tamper-evident, write-once ledger that uses cryptographic checks to ensure the information cannot be altered without detection.
- [ ] Set up automated checks for completeness and timeliness that raise an exception if targets are missing, results are out of date, or supporting evidence is incomplete
- [ ] Set up central dashboards and exception-handling workflows so test owners can track progress and fix any failures


---

#### SI-6.3 — Report Verification Results (Enhancement)

This requirement is about ensuring that the results of both security checks and privacy checks are not just stored, but are formally shared with the appropriate senior decision-makers. If this does not happen, important findings could be overlooked or misunderstood, meaning security weaknesses may not be fixed, privacy protections may not work as intended, and the organisation may not be able to show that it has properly assessed its systems.

To meet this expectation, the organisation must produce reports that set out:
- the outcomes of security checks, and
- the outcomes of privacy checks.

Each report must then be sent or delivered to the System Security Officer, the Senior Agency Information Security Officer, and the Senior Agency Privacy Official.

The organisation should use a repeatable process so it can provide evidence of:
- who received each report,
- when each report was sent, and
- that each report clearly includes the actual verification results and is clearly labelled as either a security result or a privacy result.

##### Automated routing of security/privacy verification results to senior officials

- Category: Software
- Priority: Critical

###### WHAT
Set up a repeatable, auditable reporting process that produces two clearly named verification documents—**Security Function Verification Results** and **Privacy Function Verification Results**—and sends each one to the organisation’s defined recipients: **System Security Officer**, **Senior Agency Information Security Officer**, and **Senior Agency Privacy Official**.

###### WHY (control requirement)
The National Institute of Standards and Technology (NIST) Special Publication 800-53 **SI-6(3)** enhancement requires: **“Report the results of security and privacy function verification to {{ param, si-06.03_odp }}.”** The guidance suggests that relevant organisational roles include the system security officer, senior agency information security officer, and senior agency privacy officials. This approach ensures the verification results are not only produced, but also formally reported to the correct senior roles.

###### HOW (specific steps/approach)
1. **Create two standard report templates** (or report types) with required fields (for example: verification period, scope/system identifier, overall verification outcome, key findings, and remediation/next steps). Ensure the reports are **clearly labelled** as either *Security Function Verification Results* or *Privacy Function Verification Results*.
2. **Build verification reporting into a case/workflow system** (for example, ticketing or case management) so that each verification run automatically creates a case record that includes:
   - the report document (for example, a PDF or signed document) as an attachment,
   - a unique report reference (report ID/version/date),
   - the verification outcome content,
   - the environment/system scope details.
3. **Control recipient routing** in the workflow so the case cannot be closed or approved unless the recipient list includes exactly (or at least) the three required roles from **si-06.03_odp**: System Security Officer, Senior Agency Information Security Officer, and Senior Agency Privacy Official.
4. **Record proof of delivery** in the case audit trail by logging the delivery event(s) (for example, notification sent, message ID, and time) and the recipients at the time of delivery. The case record is the official evidence, even if email/notification delivery is delayed.
5. **Add checks before sending** to confirm the attached document title/body contains the correct label (*Security* versus *Privacy*) and includes the verification outcome section, to reduce the risk of sending the wrong or incomplete results.
6. **Run regular reconciliation checks** (for example, weekly) to confirm that the latest verification cases for each system were delivered to all required recipients, and that attachments are present and correctly labelled.

###### WHO (role responsible)
- **System Security Officer (SSO)**: ensures the security verification reporting process is used and receives the security results.
- **Senior Agency Information Security Officer (SAISO)**: receives the security and privacy verification results and checks that reporting is complete.
- **Senior Agency Privacy Official (SAPO)**: receives the privacy verification results and checks that privacy labelling/content is correct.
- **Security Governance / Governance, Risk and Compliance (GRC) Workflow Owner** (or equivalent): sets up and maintains the case/workflow templates, recipient enforcement, and reconciliation checks.

###### Acceptance criteria
- For each completed security and privacy function verification, the workflow creates a case with an attached document clearly labelled as the correct type (*Security Function Verification Results* or *Privacy Function Verification Results*).
- The case audit trail shows the document was delivered/notification sent to **all three** required roles from **si-06.03_odp**, including timestamps and the recipient list.
- The workflow blocks case closure/approval unless the required recipients are included and the attachment passes labelling and outcome checks.
- Reconciliation checks show no missing deliveries for the most recent verification cycles across managed systems.

###### Actions Required for Compliance

- [ ] Create two templates for verification results—one for **Security Function Verification Results** and one for **Privacy Function Verification Results**—each with required outcome fields.
- [ ] Set up the case or workflow system to create one verification case for each security and privacy verification run, and attach the resulting report as an artefact.
- [ ] Set up workflow controls so a case cannot be approved or closed unless the recipients include the three roles listed in **si-06.03_odp**.
- [ ] Before sending, check the attachment is correctly labelled and includes the section with the verification result.
- [ ] Turn on audit logging to record delivery events, including the date and time, the recipient, and the report reference or version in the case record.
- [ ] Carry out and record regular reconciliation checks to confirm that every required recipient received the latest verification results.


---

### SI-7 — Software, Firmware, and Information Integrity (Control)

This requirement is about making sure the software, device start-up settings, and sensitive information your organisation depends on have not been secretly changed. Without this, an attacker (or even a mistake) could replace approved operating system parts, change applications, tamper with start-up firmware settings, or alter Confidential and Secret information and its privacy-related details. This could lead to data theft, fraud, or systems being taken over.

To meet this expectation, the organisation must use integrity-checking tools to detect unauthorised changes to:
- operating system components
- middleware and hosted applications
- UEFI/BIOS firmware images and configuration settings
- Confidential and Secret information, including security and privacy details and personally identifiable information

If any unauthorised changes are detected, the organisation must:
- isolate the affected components
- alert the security team within one hour
- start incident response and restore from trusted versions

For suspected firmware tampering, it must:
- stop the device from booting
- reflash (reinstall) approved firmware
- keep evidence for investigation

For suspected information tampering, it must:
- block access to the affected datasets
- confirm the data has not been altered
- preserve relevant logs
- reissue the data from trusted sources

##### TPM-measured boot and host integrity verification with SOC-driven recovery

- Category: Software
- Priority: Critical

###### WHAT
Set up checks to confirm that the following have not been changed without authorisation:
1. **Organisation-approved software** (operating system kernels/drivers, middleware, and hosted applications)
2. **Organisation-approved firmware** (UEFI/BIOS images and, where technically supported, device configuration settings)
3. **Organisation-approved Confidential/Secret information integrity** (including security and privacy metadata and personal data)

Use integrity-checking tools (for example, cryptographic hash checks) and related tooling. If unauthorised changes are detected, the system should automatically **contain or quarantine** the affected component, **notify the security operations centre (SOC) within 1 hour**, start **incident response**, and **restore from trusted baselines**.

###### WHY (control requirement)
This requirement (SI-7) ensures there are integrity checks to detect unauthorised changes to software, firmware, and information, and to take the required actions when changes are found. Required actions include **quarantine/containment**, **SOC notification within 1 hour**, **incident response**, and **trusted recovery**. For suspected firmware or information tampering, the response must also **stop the device booting where feasible**, **reflash using approved firmware**, **block access**, **preserve logs**, and **reissue data from trusted sources**.

###### HOW (specific steps/approach)
1. **Define trusted baselines for software and firmware**
   - For each approved operating system version and application release, create an official baseline of the expected cryptographic hashes or signatures for kernels, drivers, middleware components, and hosted application files.
   - For firmware, define the approved UEFI/BIOS image(s) and the approved configuration settings for each device model.

2. **Run integrity checks while systems are operating**
   - Use a host integrity platform (for example, endpoint detection and response (EDR) or extended detection and response (XDR) with file/hash/signature verification) to continuously check operating system kernels/drivers, middleware libraries/services, and hosted application files against the trusted baseline.
   - Where supported, enable **trusted platform module (TPM)-based measured boot / secure boot** to detect unauthorised changes to UEFI/BIOS and boot settings. Include device “posture” and attestation results in the same monitoring and alerting process.

3. **Protect Confidential/Secret information integrity (data-level)**
   - For datasets and security/privacy metadata and personal data stored by the application, add integrity checks using cryptographic hashes or checksums when data is received (ingested) and before key processing steps.
   - Store and verify integrity information (for example, expected hashes) in a way that makes tampering evident (for example, signed records or a protected metadata store) so integrity failures can be detected and linked to a cause.

4. **Automate detection-to-response**
   - **If software integrity fails**: automatically quarantine the affected host/component (for example, EDR containment or network isolation), alert the SOC, and start the incident response process.
   - Ensure the SOC is notified **within 1 hour** of detection.
   - Restore the affected host/component using an approved golden image or redeploy approved signed packages from the trusted repository.
   - **If firmware integrity fails** (where measured boot/attestation indicates tampering): apply a policy to stop the device booting where feasible, reflash using approved firmware, and preserve evidence for investigation.
   - **If information integrity fails**: block access to the affected datasets, validate checksums, preserve relevant logs/evidence, and reissue data from trusted sources.

5. **Evidence and auditability**
   - Keep records of integrity check results, baseline versions, detection times, containment actions, SOC notifications, and recovery actions to support audits and incident investigations.

###### WHO (role responsible)
- **Security Engineering / SOC Engineering**: implement and fine-tune integrity checks and automated response procedures; ensure SOC notification within 1 hour.
- **Platform/Infrastructure Engineering**: maintain golden images, signed package repositories, and firmware baselines; integrate measured boot/attestation where supported.
- **Application Owner / Data Engineering**: implement data integrity checks for Confidential/Secret information (including security/privacy metadata and personal data) and define trusted sources for reissue.
- **Incident Response Lead**: approve the incident response process and ensure evidence is preserved.

###### Acceptance criteria
- For organisation-approved software (kernels/drivers/middleware/hosted applications), integrity checks detect unauthorised changes and generate events that can be audited.
- For organisation-approved firmware (UEFI/BIOS), where technically supported, measured boot/attestation detects tampering and triggers the defined firmware response process.
- For organisation-approved Confidential/Secret information (including security/privacy metadata and personal data), integrity checks detect tampering/corruption and trigger dataset access blocking, checksum validation, log preservation, and reissue from trusted sources.
- When integrity failures occur, the system quarantines/isolates the affected components and notifies the SOC within **1 hour**, then starts incident response and restores from trusted baselines.
- For firmware tampering, the response includes stopping boot (where feasible), approved reflash, and evidence capture.
- Audit evidence exists for baselines, detection, containment, SOC notification, incident response initiation, and recovery actions.

###### Actions Required for Compliance

- [ ] Create and digitally sign trusted integrity baselines for approved operating system (OS) kernels and drivers, middleware, and hosted application binaries.
- [ ] Turn on trusted platform module (TPM)-based measured boot and secure boot, and where supported, collect and use attestation results for the unified extensible firmware interface (UEFI)/basic input/output system (BIOS) and the computer’s boot settings.
- [ ] Deploy host integrity verification to continuously check that binaries and modules match the trusted baseline versions.
- [ ] Use cryptographic hash/checksum checks to verify the integrity of Confidential/Secret datasets, security and privacy information, and personal data (PII) when data is first received (ingested) and again before any critical processing.
- [ ] Set up automated response “playbooks” to isolate any affected computers or components and alert the security operations centre (SOC) within 1 hour.
- [ ] Put in place trusted recovery procedures to restore systems from approved “golden” images or redeploy signed packages, and to reissue any affected datasets from trusted sources.
- [ ] Ensure the firmware tampering response includes, where feasible, a controlled “halt boot”, an approved reflash process, and preservation of forensic evidence.


---

#### SI-7.1 — Integrity Checks (Enhancement)

This requirement is about making sure the software, device firmware, and security settings your systems depend on have not been secretly changed. Without these checks, an attacker (or faulty updates) could swap trusted files for altered ones, or quietly change security settings. This could lead to unauthorised access, data loss, or systems behaving in unsafe ways.

To meet this expectation, the organisation must check that authorised software files, firmware images, and security configuration data are still intact:
- every time the system starts, restarts, shuts down, or stops unexpectedly (aborts), and
- after any installation of new software or firmware.

It must also check:
- operating system and application software files when updates or patches are installed,
- firmware and boot images every time the system boots, and
- configuration files, security policies, and records of trusted software at system start-up and after any security-relevant configuration change, at least every quarter.

The organisation must have:
- documented procedures,
- a written policy and plan,
- supporting design and configuration documentation,
- named responsible staff,
- documented checking tools, and
- records showing the checks were carried out.

##### Verify signed software/firmware/config integrity at defined events

- Category: Software
- Priority: Critical

###### WHAT must be done
Put in place checks that confirm the integrity of the organisation-approved **software files, firmware images, and security configuration data** at the organisation-defined **key moments or security-relevant events**. This includes system **start-up, restart, shutdown, and abort**, and the **installation of new software or firmware**. Perform these checks at the organisation-defined **frequency**, including:
- every time software is updated or a patch is installed
- every time the system boots
- at least **quarterly** for configuration and information checks

###### WHY (control requirement)
NIST SP 800-53 **security information and event management (SIEM)** SI-7(1) enhancement requires: “Perform an integrity check of {{ si-7.1_prm_1 }} {{ si-7.1_prm_3 }} at {{ si-7.1_prm_4 }}.” The guidance also explains that:
- **security-relevant events** include **new threats** and the **installation of new hardware/software/firmware**
- **transitional states** include **start-up, restart, shutdown, and abort**

The organisation-defined parameters for this assessment specify:
- **Software**: authorised operating system and application software files
- **Firmware**: system firmware and bootloader images
- **Information**: configuration files, security rules, and trusted software listings (manifests)
- **Events**: start-up/restart/shutdown/abort and installation of new software/firmware
- **Frequency**: at every occurrence (and, based on the provided defaults, software at each update/patch, firmware at each boot, and information quarterly and after security-relevant changes)

###### HOW (specific steps/approach)
###### 1) Set trusted references for what is “authorised”
- Keep a **trusted listing (manifest)** (for each host type/environment) that names the authorised:
  - software files (using hashes and/or signing keys/versions)
  - firmware/bootloader images (using hashes and/or signing keys/versions)
  - security configuration data (using hashes and/or signed configuration bundles)
- Make sure the manifest is **version-controlled** and **protected** (for example, stored in a central configuration service with access controls).

###### 2) Carry out integrity checks at the required key moments/events
- **At each system boot event**:
  - Check firmware/bootloader images against the trusted reference (for example, using secure/verified boot where available, plus an operating system step that records what was checked/verified).
- **At system start-up/restart/shutdown/abort**:
  - Run an integrity check routine that verifies:
    - authorised operating system/application software files
    - authorised security configuration data (configuration files/security rules/trusted software listings)
  - Ensure the routine also runs during restart and abort paths (for example, via system service hooks and emergency/maintenance boot processes).

###### 3) Re-check integrity after security-relevant changes and installations
- **After installing new software or firmware**:
  - Check the newly installed items immediately against the trusted manifest before they are allowed to become active.
- **After security-relevant configuration changes**:
  - Re-check the affected configuration/security packs at start-up and immediately after the change is applied.

###### 4) Check integrity when software updates/patches are installed
- Build the checks into the release/patch process so that when operating system/application patches are installed, the installer:
  - validates signatures/hashes before the update is activated
  - records evidence of the check (item version, hash/signature status, time, and the host identity)

###### 5) Keep audit-ready evidence and define what happens if checks fail
- For every required check, record at least:
  - what was checked (software/firmware/config category and identifiers)
  - which trusted reference version was used
  - the outcome (pass/fail) and the basis for the decision (hash match/signature valid)
  - the time and host identity
- Define and implement actions for failures (for example, “stop” or move to a controlled recovery mode appropriate to how critical the system is), ensuring the system does not continue using unauthorised or tampered components.

###### WHO (role responsible)
- **Security Engineering / Platform Security**: owns the trusted manifest design, the verification rules, and the failure response criteria.
- **Infrastructure/Operational Technology (OT)/Systems Engineering**: implements boot/start-up hooks and the integrity check routines.
- **Release/Configuration Management Team**: builds integrity checks into patch/release pipelines and ensures software/config bundles are signed.
- **Security Operations Centre (SOC) / security information and event management (SIEM) Operations**: ensures results are sent, monitored, and kept for audit.

###### Acceptance criteria
- For each in-scope host, at every required event (start-up/restart/shutdown/abort and after software/firmware installation), the system performs integrity checks of the organisation-defined **authorised software files, firmware images, and security configuration data**.
- Firmware/bootloader integrity is checked at **every boot event**.
- Software files are checked at **every software update/patch installation**.
- Configuration/security rules/trusted manifest integrity is checked at **start-up and after security-relevant configuration changes**, and at least **quarterly**.
- Evidence is produced for every check and can be retrieved for audit (including pass/fail, trusted reference version, time, and host identity).
- If integrity checking fails, the system follows the defined failure handling (for example, blocks activation or moves to a controlled recovery mode) and raises an alert for investigation.

###### Actions Required for Compliance

- [ ] Create and keep an up-to-date, version-controlled list of trusted software binaries, firmware images, and security configuration data that only authorised items are allowed to use.
- [ ] Set up checks during system start-up to confirm that the firmware/bootloader and approved software files match the trusted list (manifest).
- [ ] Add integrity checks to the software/firmware installation and update process so verification is completed before the software or firmware is turned on.
- [ ] Check that system configuration and policies have not been changed in an unauthorised way when the system starts up, and again right after any security-relevant configuration changes. Also repeat this check every quarter.
- [ ] Record evidence for the integrity check (artefact identifiers, the trusted reference version, the cryptographic verification basis, the time the check was made, and the host identity) in central logging and security information and event management (SIEM).
- [ ] Define and test what should happen when an integrity check fails (either block activation or move the system into controlled recovery), and raise an alert to the security operations centre (SOC) using the security information and event management (SIEM) system.


---

#### SI-7.2 — Automated Notifications of Integrity Violations (Enhancement)

This requirement ensures that if an automated integrity check finds that something has been changed unexpectedly or does not match what it should be, the right people are alerted immediately. Without this, unauthorised changes to software, firmware, or sensitive information could go unnoticed for too long, increasing the risk of fraud, service disruption, privacy breaches, and expensive investigations.

To meet this expectation, the organisation must use automated integrity-check tools that can detect differences and automatically create alerts as soon as they are found. These alerts must be sent promptly to the system owner, the senior agency information security official, the privacy officer, and the information security officer.

The organisation must also keep evidence that integrity checks were carried out, and that the alerts and notifications were created and delivered. This evidence must include records that can be traced back to the specific integrity-check event.

##### Automated integrity-discrepancy alerts to defined roles

- Category: Software
- Priority: Critical

###### WHAT
Set up automated checks to confirm that system data and software have not been altered. If the checks find a problem, the system should automatically alert the named people or job roles.

###### WHY (control requirement)
NIST SI-7(2) enhancement requires that the organisation **uses automated tools** to **send alerts** to the specified people or job roles **when integrity checks find discrepancies**. The guidance stresses that alerts should be sent promptly to the relevant integrity stakeholders.

###### HOW (specific steps/approach)
###### 1) Define who will be notified using the organisation’s roles
Use the organisation-defined roles in **si-07.02_odp**: **the system owner, the senior agency information security official, the privacy officer, and the information security officer**.

###### 2) Ensure integrity checks produce events that machines can read
Configure the integrity verification tooling (for example: file or package integrity monitoring, checks that signed software is valid, configuration change checks, or application integrity checks) so that when a problem is found it produces a structured event that includes, at minimum:
- asset identifier (host/service/component)
- type of integrity check (for example: hash mismatch, invalid signature, configuration drift)
- expected versus actual value (or a reference to the stored expected/actual values)
- time the problem was detected
- a unique integrity-check job/scan ID and discrepancy/alert ID

###### 3) Automate alert creation and sending
In the organisation’s monitoring environment, implement an automated process (for example: a security monitoring correlation rule plus an automated response workflow) that:
- starts when the integrity-discrepancy event is received
- creates an incident or ticket and generates alerts
- sends alerts to **all four** roles from **si-07.02_odp**
- uses an up-to-date identity and group mapping approach so the correct people receive alerts (for example: directory groups mapped to each role)

###### 4) Ensure alerts are sent on time and handle failures
Set an operational service level agreement (SLA) for how quickly alerts must be delivered (for example, within a defined number of minutes, aligned with the organisation’s incident response expectations). Also set up monitoring for workflow failures (for example: a dead-letter queue, retry rules, and an escalation route).

###### 5) Keep evidence that can be audited and traced
Make sure the process keeps audit evidence that links the integrity discrepancy to the alerts, including:
- the original integrity-check event ID/job ID
- the security monitoring correlation/alert ID
- the alert/ticket IDs
- delivery result (sent/failed) and the relevant timestamps

###### 6) Test using controlled discrepancy scenarios
In a non-production environment, deliberately create a controlled integrity discrepancy and confirm that:
- all four roles receive alerts for the same discrepancy event
- the alert message includes the discrepancy context and identifiers
- records can be traced end-to-end from the discrepancy event → alert → notifications

###### WHO (role responsible)
- **Security Operations / SOC engineer**: implement the security monitoring correlation and automated response workflows, set timeliness SLAs, and retain evidence.
- **System owner / Application security lead**: confirm that integrity checking covers the required areas and that the produced events include the required discrepancy details.
- **Privacy officer and Information security officer**: confirm that alert content and handling meet the needs of privacy and security stakeholders.

###### Acceptance criteria
- When the integrity verification tooling detects an integrity discrepancy, an automated alert is generated without manual intervention.
- Alerts are delivered to **all four** roles specified in **si-07.02_odp**.
- Each alert can be traced back to the originating integrity discrepancy using shared identifiers (job/scan ID and discrepancy/alert ID) and timestamps.
- Evidence is retained showing the discrepancy event, the automated alert/correlation, the alert/ticket IDs, and delivery outcomes.
- Timeliness and failure handling are demonstrated in a controlled test (including escalation if delivery fails).

###### Actions Required for Compliance

- [ ] Map the four SI-07.02 ODP roles to the relevant authorised directory groups and confirm that dynamic group membership is enabled.
- [ ] Set up the integrity-checking tool to report structured “discrepancy” events that include: the asset ID, what was expected versus what was actually found (or the related references), the date and time, and unique IDs for the job/scan and for the discrepancy.
- [ ] Create security information and event management (SIEM) alert rules for integrity mismatch events, and format the results into a consistent alert structure.
- [ ] Set up a security automation playbook that starts when a related alert is detected, creates an incident or ticket, and sends notifications to all four roles.
- [ ] Set service-level targets (SLAs) for sending notifications and monitor performance. If a workflow or notification delivery fails, automatically try again and escalate to the right team.
- [ ] Set up audit logging to keep a complete evidence trail from the discrepancy event ID to the alert ID, then to the notification and ticket IDs, and finally to the delivery outcome.
- [ ] Run a controlled test in a non-production environment to check for integrity issues, and confirm that all four roles receive notifications that include traceable identifiers.


---

#### SI-7.3 — Centrally Managed Integrity Tools (Enhancement)

This expectation is about making sure the organisation uses one approved set of tools, run from a central location, to regularly check that software, firmware, and stored information have not been changed or tampered with. Without this, unauthorised changes could be made quietly on individual devices, which could lead to fraud, disruption to services, or the use of altered systems that still look genuine.

To meet this expectation, the organisation must appoint named people to set up and run the central tools. It must also clearly state in its integrity rules and day-to-day procedures that these central checks are used for software, firmware, and information. The organisation must document how this approach is built into system designs and how it is recorded in configuration details, keep documentation on how the tools are used, and keep records of completed scan results and any follow-up actions taken when problems are found. These items must be referenced in the organisation’s system security planning.

##### Centrally managed integrity verification with standard scan profiles

- Category: Software
- Priority: Critical

###### WHAT
Set up centrally managed integrity checking tools (for software, firmware where supported, and the integrity of stored information) using one approved platform. Use centrally defined scan settings, central timing/scheduling, and central storage of results.

###### WHY (control requirement)
The National Institute of Standards and Technology (NIST) SI-7(3) enhancement requires the organisation to **use centrally managed integrity checking tools**. The guidance explains that central management improves **consistency** and **coverage** of integrity checking activities.

###### HOW (specific steps/approach)
1. **Choose and standardise an approved integrity checking platform** that can run centrally managed agents and provide a central console/reporting function across the organisation’s managed endpoints/servers and relevant storage items.
2. **Set centrally managed integrity checking profiles** for:
   - **Software integrity**: approved application locations, critical executables, package details (manifests), and signed-file verification where applicable.
   - **Information integrity**: integrity checking of baseline configuration exports and other protected information items that can realistically be checked (for example, hashes/checksums of approved configuration bundles).
   - **Firmware integrity**: enable only the firmware/UEFI/BIOS integrity checks that the chosen platform can support safely for the relevant device types.
3. **Apply central scheduling and configuration** so scans run from the central console (not ad-hoc local scripts). Use central policy/configuration management to apply the same scan settings and schedules to production, test, and disaster recovery (DR) environments based on their risk category.
4. **Centralise evidence and the fix/remediation process**:
   - Store scan results centrally and keep them for audit purposes.
   - Link “fail” results to the organisation’s security information and event management (SIEM) and security orchestration, automation and response (SOAR) systems and the ticketing/remediation workflow, so follow-up actions are recorded against the scan evidence.
5. **Document the approach in integrity governance documents and system design**:
   - Update the organisation’s integrity policy/procedures to name the centrally managed tool, the scan profiles, and the escalation/remediation steps.
   - Record the tool configuration settings and the scan scope in system design/configuration documentation.
   - Reference the centrally managed integrity checking approach in the system security plan.

###### WHO (role responsible)
- **Cybersecurity/Information Security Manager**: owns the integrity policy/procedure updates and system security plan references.
- **Platform/Endpoint Security Engineering (or security operations centre (SOC) Engineering)**: selects the tool, defines scan profiles, and manages central configuration.
- **System Owners / Infrastructure Owners**: ensure the correct scan scope is applied in their environments and that remediation tickets are completed.

###### Acceptance criteria
- One approved integrity checking platform is used across the organisation for the defined scope (no uncontrolled local integrity checking scripts for that scope).
- Software and information integrity scan profiles are centrally defined and applied through the central console/policy.
- Firmware integrity checks are enabled only where supported by the platform, and are documented for the applicable device types.
- Scan results are stored centrally, kept for audit, and linked to remediation evidence for any integrity failures.
- Integrity policy/procedures, system design/configuration records, and the system security plan explicitly reference the centrally managed integrity checking approach and configuration settings.

###### Actions Required for Compliance

- [ ] Choose an approved, centrally managed integrity verification platform that provides central reporting through a control console and uses agent-based checks.
- [ ] Set up centrally managed integrity scan profiles for software integrity and information integrity items, with clearly defined scan areas (scope) and items to exclude.
- [ ] Only enable firmware integrity checks for device types where the platform supports safe firmware, Unified Extensible Firmware Interface (UEFI), and Basic Input/Output System (BIOS) integrity verification, and document what device types are not covered.
- [ ] Set up central scheduling and require profile updates through a central rule (no local, one-off integrity scripts for the defined scope).
- [ ] Link central scan results to security monitoring and automation tools (security information and event management (SIEM) and security orchestration, automation and response (SOAR)) and to the ticketing system, so that any integrity failures trigger traceable, auditable fix actions connected to the scan evidence.
- [ ] Update the integrity policy and procedures, the system design and configuration documents, and the system security plan to refer to the tool, the profiles, and the configuration settings.


---

#### SI-7.5 — Automated Response to Integrity Violations (Enhancement)

This requirement is about making sure your systems respond immediately if something important has been changed without permission, rather than waiting for someone to notice. If unauthorised changes go unnoticed, they could quietly weaken your defences, change how software or device firmware behaves, or tamper with important data. This could lead to fraud, service disruption, or a wider security incident.

To meet this expectation, the organisation must set up its integrity-checking process so that, as soon as an integrity problem is detected, the system automatically carries out the agreed response. It must either shut the system down, restart it, or raise audit alerts, and it must do so without manual approval.

The organisation must also ensure that integrity checks are carried out using automated checking tools. The system must record what was checked, what was found, and exactly which automated action was taken. These audit records must be kept for later review.

##### Automated integrity violation response with audit alerts

- Category: Software
- Priority: Critical

###### WHAT
Put in place an automated mechanism that, when the system detects integrity problems within the organisation-defined scope (for example, critical security software/firmware and/or critical security files/data), automatically carries out the pre-set response actions without needing human approval. This includes at least triggering audit alerts, and—if the organisation chooses—stopping and/or restarting affected systems.

###### WHY (control requirement)
SI-7(5) enhancement requires that systems **automatically** carry out the organisation-defined response action **when integrity problems are detected**. The guidance explicitly allows automated responses such as **undoing changes, stopping the system, or triggering audit alerts** when unauthorised changes are made to critical security files.

###### HOW (specific steps/approach)
1. **Define integrity scope and link it to responses**: For the application’s multi-layer components (presentation/application/data/admin functions), identify the critical items that must be checked (for example, signed application files, critical configuration files, security libraries, and any supported boot/firmware checks where applicable). Link each item type to the required automated response type(s). Make sure the response settings match the organisation-defined parameter **si-07.05_odp.02** (default user value: **trigger audit alerts**).
2. **Deploy automated integrity checking**: Use an enterprise-approved integrity checking capability (for example, endpoint/server integrity monitoring, signed file verification, and/or configuration integrity checks) configured to detect unauthorised changes to the defined critical items. Ensure checks run in production and, where required, in disaster recovery environments.
3. **Set up an automated response process (no manual approval step)**: Connect the integrity checker to an orchestration/automation component so that, as soon as an integrity problem is detected, it immediately runs the configured response action(s). At minimum, this must **trigger an audit alert** into the organisation’s security information and event management (SIEM) and monitoring pipeline. If the organisation later selects additional actions (stop/restart), extend the process to stop/restart the affected host/virtual machine/container and then re-check integrity.
4. **Keep evidence of what was detected and what was done**: Ensure the audit alert includes, at minimum, the timestamp, asset identifier, integrity item identifier/type, a summary of the detected change (for example, hash/signature mismatch), and the **exact automated action taken** (for example, “audit alert triggered”). Store logs centrally in the SIEM with tamper-evident/immutable retention in line with enterprise logging standards.
5. **Test safely in test and disaster recovery (DR)**: Run controlled test cases (for example, change a non-production copy of a critical security file to cause a violation) to confirm the system detects the change and automatically triggers the audit alert with the correct evidence fields. Repeat using deployment patterns that closely match production.

###### WHO
- **Application Owner / Security Engineering Lead**: responsible for defining the integrity scope and mapping it to responses.
- **Platform/Infrastructure Engineer (Cloud/On-Premises)**: implements the integrity checking and the automation integration.
- **Security Operations Centre (SOC) / SIEM Engineer**: ensures audit alerts are correctly sent, formatted, and retained.
- **Change Manager**: ensures the integrity/response configuration is deployed according to release/change governance.

###### Acceptance criteria
- For each configured critical integrity item type, an integrity violation in production triggers the configured automated response **immediately** (with no human approval step).
- Audit alerts are produced for integrity violations and are visible in the SIEM with the required fields: asset ID, integrity item/type, detection time, and the exact automated action taken.
- The response process is implemented as an automated integration (integrity checker → orchestration → SIEM alert) and works consistently across production-like environments.
- Evidence is stored centrally and is tamper-evident/immutable in line with enterprise logging requirements.

###### Actions Required for Compliance

- [ ] Identify and record the application’s critical integrity items (software, firmware, and/or data, as applicable), and link each one to the automated response action(s) that have been set up.
- [ ] Set up an enterprise integrity verification tool to check for unauthorised changes to the defined critical items in both live production and disaster recovery environments.
- [ ] Set up the integrity tool to work with your automation or orchestration process, so that any detected violation automatically triggers the pre-set response (at least an audit alert) without needing human approval.
- [ ] Set up security information and event management (SIEM) alerts for integrity violations, using structured details including the asset identifier, the integrity item or class, the time the issue was detected, and the exact automated action that was taken.
- [ ] Set up centralised, tamper-evident storage for integrity detection and response logs, and check that the logs are complete.
- [ ] Run the test cases in an environment that closely matches production to confirm that the automated process from detection to alert works correctly and that the system produces the right evidence.


---

#### SI-7.6 — Cryptographic Protection (Enhancement)

This expectation is about using tamper-evident checks to make sure software, device firmware, and important information have not been changed without permission. Without these checks, someone could secretly alter an update, a device’s built-in code, or critical files. The organisation might then unknowingly trust and run the altered versions, which could lead to fraud, service disruption, or data loss.

To meet this requirement, the organisation must apply cryptographic integrity checks to software, firmware, and information. These checks must use signed proof that the system can verify using a verification key that is safe to share. The organisation must keep the secret signing keys protected so only authorised people or systems can create the signed proof. It must also use integrity-check tools to confirm integrity when items are released, updated, or processed.

If a problem is detected, the organisation must record and keep clear evidence of what failed, when it was detected, and the result of the integrity check. It must also document the approach, procedures, responsibilities, and the system design and settings that make these checks possible.

##### Signed software artefacts with enforced verification and audit logs

- Category: Software
- Priority: Critical

###### WHAT
Implement cryptographic integrity protection for **software and information** by creating **digital signatures** (and/or **signed hashes**) for release items, and requiring **public-key checks** at every point where trust changes (CI/CD promotion and deployment). Keep records of verification results and any integrity failures so the activity can be audited.

###### WHY (control requirement)
NIST SP 800-53 **SI-7(6)** enhancement requires using **cryptographic methods to detect unauthorised changes to software, firmware, and information**. The guidance calls for **asymmetric cryptography** (sign with a private key; verify with a public key), protecting the **confidentiality of the key used to create the hash/signature**, and using the **public key to verify integrity**. It also expects organisations to consider **cryptographic key management solutions**.

###### HOW (specific steps/approach)
1. **Define the items in scope** for the application and its delivery approach (for example: application binaries, installers, container images, Helm/Kustomize charts, Infrastructure as Code (IaC) modules, configuration bundles, and any information items that must not be changed).
2. **Sign items in the build/release pipeline** using asymmetric cryptography:
   - Use a managed key service or a Hardware Security Module (HSM)-backed signing capability to store and use the **private signing key**.
   - Create a **signature** (and optionally a **signed hash/manifest**) that links the item to an unchangeable identifier (version, build ID, commit hash, and target environment where relevant).
3. **Share the verification information**:
   - Publish the matching **public verification key/certificate chain** to the deployment and verification components.
   - Ensure verifiers can check signatures without needing access to the private key.
4. **Require verification automatically at trust boundaries**:
   - Stop promotion/deployment unless the item’s signature (or signed hash) verifies successfully.
   - Apply the same requirement for configuration/information bundles that are used during runtime.
5. **Reduce the risk of key compromise and misuse**:
   - Limit signing to the CI/CD signing service identity.
   - Use key rotation and revocation procedures that match the organisation’s key management approach.
6. **Record and keep evidence**:
   - Log every verification attempt (success/failure), item identifier/version, signer identity (where available), verification key identifier, time, and reason codes.
   - If verification fails, raise an incident/ticket and keep the evidence needed for investigation.

> Note on firmware: this approach mainly covers **software and information** integrity. Firmware integrity is covered only when firmware images are distributed/updated using the same signed-item process and can be verified by the update mechanism.

###### WHO (role responsible)
- **Application owner / DevSecOps lead**: defines in-scope items and builds signing/verification into pipelines.
- **Security architect / Public Key Infrastructure (PKI) and key management owner**: approves the key management approach, the verification trust anchors, and rotation/revocation procedures.
- **Platform/infrastructure engineers**: implement deployment approval gates and connect logging to a security information and event management (SIEM) system.
- **Security Operations Centre (SOC) / incident response**: triages and investigates integrity verification failures.

###### Acceptance criteria
- Every in-scope software item and information bundle is **cryptographically signed** using asymmetric cryptography.
- Deployment/promotion is **technically blocked** when signature verification fails.
- Private signing keys are **protected using an approved key management solution** (no unencrypted keys in CI runners).
- Verification results (including failures) are **logged and retained** with enough detail to identify the item and the verification outcome.
- Audit evidence is available showing: signing configuration, where verification is enforced, and sample logs for both successful and failed verifications.

###### Actions Required for Compliance

- [ ] Define which software and information types are included (in scope) for this application release process.
- [ ] Set up asymmetric signing in the build and release process, using a hardware security module (HSM) or a managed key service to protect the private signing key.
- [ ] Create and publish digital signatures (and/or signed lists of hash values) that link each software artefact to an unchangeable version or build identifier.
- [ ] Set up deployment and promotion “gates” to check digital signatures using the public key or certificate chain before any trust is granted.
- [ ] Record whether each verification attempt succeeds or fails in the central security information and event management (SIEM) system, including the relevant reference identifier, the time it happened, and the reason code.
- [ ] Set up clear procedures for rotating and cancelling access credentials, and test them using a controlled exercise that deliberately triggers a verification failure.


---

#### SI-7.7 — Integration of Detection and Response (Enhancement)

This requirement is about making sure the organisation can identify and respond to two serious types of wrongdoing: unauthorised changes to agreed settings, and unauthorised increases in users’ access rights. If this is not in place, an attacker could quietly change how systems are configured or gain higher access, and the organisation might not notice, might respond too slowly, or might not have the evidence needed to understand what happened and prove it later.

To meet this expectation, the organisation must include these types of changes in its incident response approach by clearly defining what counts as unauthorised, documenting the steps staff must follow, and assigning named responsibilities. It must use suitable detection tools to find these changes, send any detections into the incident process, monitor the impact, restore approved settings and access levels, and keep complete incident records. These records must be kept for later review and possible legal use, with supporting audit evidence preserved.

##### Baseline drift + privilege elevation alerts routed into IR with evidence

- Category: Software
- Priority: Critical

###### WHAT
Implement detection of **unauthorised security-relevant changes**—specifically **(1) unauthorised changes to established configuration settings** and **(2) unauthorised elevation of system privileges**—as an integrated part of the organisation’s incident response process.

###### WHY (control requirement)
NIST SI-7(7) enhancement requires that the organisation’s incident response capability includes detection of the changes defined in **param si-07.07_odp (“unauthorised changes to established configuration settings and unauthorised elevation of system privileges”)**. The guidance highlights that combining detection and response helps ensure events are **recorded, monitored, corrected, and kept for historical review**, including for longer-term investigation of attacker activity and potential legal action.

###### HOW (specific steps/approach)
1. **Define what counts as “unauthorised”** for both change types within the incident workflow logic, based on approved change windows/tickets and agreed exception rules (for example, changes outside an approved maintenance window are unauthorised).
2. **Create and keep up-to-date “known-good” baselines** for configuration settings (for example, hardened configuration profiles, infrastructure as code outputs, approved “golden” images, and approved security policy definitions) and for privilege status (for example, expected membership of privileged groups/roles, and expectations under privileged access management policies).
3. **Detect configuration changes that drift from the baseline** using integrity and compliance monitoring that compares the current state to the baselines (for example, file/config integrity monitoring, configuration compliance checks, and cloud posture checks where relevant).
4. **Detect privilege elevation** using trusted identity and audit sources (for example, changes to privileged role/group membership, admin consent events, local administrator changes, and privileged access management session/role assignment events) and compare them to the expected privileged state.
5. **Send detections into the incident response process** using an automated workflow (security orchestration, automation and response (SOAR) / ticket automation) that:
   - creates or updates an incident,
   - adds supporting information (before/after values, baseline reference, timestamps, actor identity where available, and the affected system/service),
   - sets severity and suggested first actions (triage, containment, and remediation).
6. **Include corrective actions and evidence preservation** in the incident runbook for these change types (for example, revert to the approved configuration, remove unauthorised privilege elevation, and disable/contain affected accounts or sessions where appropriate), and ensure the incident record keeps the historical evidence for later review.

###### WHO
- **Cybersecurity Operations Lead / security operations centre (SOC) Manager**: owns the incident workflow integration and triage/closure standards.
- **Security Engineering (detection / incident response automation)**: creates baseline definitions, detection rules, and SOAR routing.
- **System/Platform Owners**: confirm the approved baselines and remediation steps for their environments.
- **Identity and Access Management (IAM) Team**: ensures the sources used for privileged-change detection and the expected privilege state are accurate.

###### Acceptance criteria
- For both change types in **si-07.07_odp**, the organisation can show that a detection produces an **incident record** that includes: baseline reference, before/after evidence, timestamps, affected asset/service, and (where available) actor identity.
- Detections that occur **outside approved change windows/tickets** are treated as unauthorised and sent into the incident workflow.
- Remediation for these incidents includes restoring the approved configuration and removing unauthorised privilege elevation, with the reason for closure recorded.
- Incident records and supporting evidence are retained and can be retrieved for historical analysis (for example, for at least the organisation’s incident record retention period).

###### Actions Required for Compliance

- [ ] Set rules for what counts as unauthorised changes to configurations and access privileges, using approved change windows and tickets, and agreed exception rules.
- [ ] Create and version “known-good” baseline settings and the expected privileged access state for each environment (production, test, and disaster recovery).
- [ ] Set up integrity and compliance checks to alert when settings change from the approved baseline, and link those alerts to the incident response workflow.
- [ ] Set up detection of changes made with privileged access using trusted identity and audit records, and link any alerts to the incident response workflow.
- [ ] Set up automated incident routing that adds supporting information to alerts, including what changed (before and after), a comparison to the normal baseline, the time it happened, which systems or assets were affected, and the identity of the person or account involved where this information is available.
- [ ] Update incident response playbooks to include steps for: containing the issue, fixing it (reverting the configuration and removing any added privileges), and preserving evidence for these types of changes.
- [ ] Use tabletop exercises and technical checks to confirm that incidents are recorded, fixed, and kept with historical evidence that can be audited.


---

#### SI-7.8 — Auditing Capability for Significant Events (Enhancement)

This requirement is about ensuring that if something suspicious happens to your software, firmware, or stored information—such as unauthorised or unexpected changes—your organisation can quickly record exactly what occurred and start the right response. Without this, you may not be able to prove what was changed, when it happened, or who or what caused it, which can delay investigation and allow further damage or fraud to go unnoticed.

To meet this expectation, the organisation must be able to detect possible integrity problems. When one is detected, it must automatically create an audit record for that specific event, notify the information system security officer, and begin incident response within 24 hours. It must also keep the relevant logs and supporting evidence so they remain available for later review, ensuring the audit record, the alert, and the response all clearly relate to the same detected event.

##### Event-linked audit, ISSO alert and 24-hour incident trigger on integrity violation

- Category: Software
- Priority: Critical

###### WHAT
Set up an automated capability that, when a possible integrity breach is detected, will: (1) create an audit record specific to that event, (2) notify the Information System Security Officer (ISSO), and (3) start the organisation’s incident response actions—including keeping the relevant logs and evidence—within the required 24-hour service level agreement (SLA).

###### WHY (control requirement)
NIST Special Publication 800-53 security control SI-7(8) (enhancement) requires: “Upon detection of a potential integrity violation, provide the capability to audit the event and initiate the following actions: {{ insert: param, si-07.08_odp.01 }}.” The organisation-defined parameters specify the ISSO alert target (si-07.08_odp.02) and the incident response and evidence-preservation actions (si-07.08_odp.03).

###### HOW (specific steps/approach)
###### 1) Define what counts as a potential integrity breach and the event format
- Use the application’s official inventory of assets to define which software, firmware, and configuration items are in scope for “potential integrity violation” (for example: configuration changes that should not have occurred, failure to verify signed files, unexpected changes to package or container images, or a mismatch in the expected file hash for critical files).
- Standardise a structured event message produced by the detection mechanism, including: a correlation/event ID, the time the issue was detected, the identifier of the affected item, the type and result of the integrity check, a reason code, and references to the detection evidence (for example: scan output IDs).

###### 2) Link the detection event to the audit record
- Configure the detection mechanism to write an audit record that cannot be altered (immutable) and is linked to the event into the organisation’s audit logging system (or the security information and event management (SIEM) audit index), using the same correlation/event ID and detection time.
- Make sure the audit record includes enough information to support later investigation (what was detected, where it was detected, and the result of the integrity check).

###### 3) Alert the ISSO for the same event
- Create an automated alert process that, when the integrity-breach detection event is received, notifies the ISSO defined in si-07.08_odp.02 (for example, through the organisation’s on-call or ticketing channel) and includes the correlation/event ID and a link to the audit record.

###### 4) Start incident response within 24 hours and preserve evidence
- Using the same event, automatically open or trigger an incident case and carry out the organisation-defined “other actions” (si-07.08_odp.03): start incident response within the 24-hour SLA and preserve the relevant logs and evidence.
- Evidence preservation must package together: the integrity detection output, the event message, and the related logs from the SIEM and observability tools (for example: authentication and authorisation context, and signals related to process execution and change management), all tied to the correlation/event ID.

###### 5) Enforce and measure the 24-hour SLA
- Add tracking to record: the detection time, the time the audit record was created, the time the ISSO alert was sent, and the time the incident case was created.
- Alert on any workflow failures (for example: failure to write the audit record, failure to deliver the alert, or failure to create the incident case) and ensure that retries do not break the link between the event and its records.

###### WHO
- **Security Operations / Security Operations Centre (SOC) Lead**: owns the security information and event management (SIEM) and security orchestration, automation and response (SOAR) workflow design and alert routing.
- **Information System Security Officer (ISSO)**: receives the event-linked alerts and checks that incident triage expectations are met.
- **Application Security / Platform Engineering**: implements the integrity detection capability and the event message format.
- **Incident Response Manager**: ensures the incident case workflow matches the organisation’s 24-hour SLA process.

###### Acceptance criteria
- When a potential integrity breach is detected, an audit record is created that is linked to the exact detection event (same correlation/event ID and detection timestamp).
- The ISSO defined in **si-07.08_odp.02** is automatically alerted for that same event, with a reference to the audit record.
- An incident case is automatically started and evidence is preserved per **si-07.08_odp.03**, with incident case creation occurring within the organisation’s 24-hour SLA.
- The evidence package includes the integrity detection output and the related logs needed for investigation, and can be retrieved using the correlation/event ID.
- Workflow tracking shows end-to-end timing (detection → audit record → ISSO alert → incident) and confirms there are no unhandled failures for integrity-breach events.

###### Actions Required for Compliance

- [ ] Define which integrity-violation types are in scope, and the official asset and component identifiers used to detect them.
- [ ] Set up integrity checks to send a structured event message that includes a unique correlation/event ID and the time the issue was detected.
- [ ] Set up audit logging to create an unchangeable audit record that is linked to the relevant event, using the same correlation or event ID.
- [ ] Create an automated security operations workflow that uses security information and event management (SIEM) and security orchestration, automation and response (SOAR) to alert the information system security officer (ISSO) named in **si-07.08_odp.02**, and include a reference to the relevant audit record.
- [ ] Automatically create incident case records and preserve evidence in line with **SI-07.08_ODP.03**, by combining the detection results with related log records.
- [ ] Set up monitoring to track how long it takes from detection to audit, from audit to an information security officer alert, and from detection to an incident. Ensure these timings meet the 24-hour service level agreement (SLA).


---

#### SI-7.9 — Verify Boot Process (Enhancement)

This expectation is about ensuring that your servers and virtual machines only start using trusted, unmodified start-up code. If someone changes the start-up parts of a machine, it could quietly run malicious software before the operating system even loads—allowing attackers to take control while everything still appears normal.

To meet this expectation, the organisation must clearly define which start-up components are checked for every on-premises server and virtual machine: the Unified Extensible Firmware Interface (UEFI) firmware, the bootloader, and the operating system kernel and initial boot files. There must be a working integrity check that verifies each component before the machine continues to boot. If any component fails the check, the system must block or refuse to continue as trusted.

The organisation must also:
- record the results of these checks and keep the records for later review,
- maintain audit evidence,
- document the tools used and the steps taken, and
- assign named responsibility for performing and reviewing the checks.

##### UEFI Secure Boot + TPM measured boot with boot-fail blocking

- Category: Software
- Priority: Critical

###### WHAT
Set up checks that confirm the organisation-defined **system components** (UEFI firmware, bootloader, and OS kernel/initramfs) are genuine and trusted when the system starts. Apply this to on-premises servers and virtual machines using **UEFI Secure Boot** and **TPM-based measured boot**. Make sure the system **checks integrity during start-up** and **stops the boot process** when required components are not trusted.

###### WHY (control requirement)
NIST SI-7(9) (Enhancement) requires: **“Verify the integrity of the boot process of the following system components: {{ insert: param, si-07.09_odp }}.”** The guidance explains that integrity checks provide assurance that only trusted code runs during start-up.

###### HOW (specific steps/approach)
1. **Define the boot sequence in scope** for each on-premises server/virtual machine:
   - UEFI firmware trust state
   - Bootloader binary (and any boot manager path)
   - OS kernel and initramfs images
2. **Enable and enforce UEFI Secure Boot** on each in-scope system:
   - Turn Secure Boot **on**.
   - Enrol only approved signing keys (platform keys/custom keys as per your standard) and prevent unauthorised key changes.
   - Ensure the boot path cannot switch to unsigned or legacy boot options.
3. **Enable TPM measured boot** where available:
   - Configure firmware/operating system to record measurements for the boot sequence into TPM event logs.
   - Ensure measurements cover firmware, bootloader, and kernel/initramfs (as supported by the platform).
4. **Stop boot continuing when integrity checks fail**:
   - Configure Secure Boot policy so unsigned or untrusted boot components cannot run.
   - For measured boot, set an operational rule that treats “not trusted” measurements as a boot failure (for example, the system halts into recovery/maintenance mode and does not proceed to normal service).
5. **Record and keep evidence**:
   - Collect TPM event logs/attestation results and Secure Boot state indicators.
   - Store evidence centrally (for example, in a security information and event management (SIEM) system or log platform) with the system identifier and timestamp.
   - Keep records in line with organisational audit and log retention requirements.
6. **Document the verification method and responsibilities**:
   - Maintain runbooks showing how verification is done, what counts as “trusted/pass” versus “fail/not trusted”, and what recovery actions are required.
   - Assign named roles for (a) key/certificate management, (b) signing pipeline validation, and (c) periodic review of boot integrity evidence.
7. **Apply through standard baselines and change control**:
   - Use configuration management to apply Secure Boot and measured-boot settings consistently across production, test, and disaster recovery (as applicable).
   - Integrate signing and release processes so kernel/initramfs and bootloader updates are always signed and can be verified.

###### WHO
- **Infrastructure/Platform Engineering Lead**: owns the Secure Boot and measured-boot baseline configuration.
- **Security Engineering / PKI Owner**: owns the key/certificate lifecycle and trust policy.
- **Release/DevOps Lead**: owns the signing pipeline for bootloader, kernel, and initramfs artefacts.
- **Security Operations Centre (SOC)/Monitoring Lead**: owns central evidence ingestion, alerting, and review workflow.

###### Acceptance criteria
- For every in-scope on-premises server and virtual machine, **UEFI Secure Boot is enabled** and only approved signed boot components are allowed to run.
- TPM measured boot evidence is produced at start-up and includes measurements covering **UEFI firmware, bootloader, and kernel/initramfs** (to the extent supported by the platform).
- If any required component is untrusted, the system **does not proceed with normal boot** (it halts or enters an explicitly defined recovery/maintenance state).
- Boot integrity results (Secure Boot state and TPM measurements/attestation outcomes) are **recorded centrally** with system ID and timestamp and retained for audit.
- Runbooks and named responsibilities are in place and are used during key changes and release/signing activities.

###### Actions Required for Compliance

- [ ] Define the exact in-scope start-up sequence for **si-07.09_odp** for each platform type, covering the **UEFI firmware**, **bootloader**, and **kernel plus initial RAM filesystem (initramfs)**.
- [ ] Turn on UEFI Secure Boot for all in-scope on-premises servers and virtual machines, and disable or avoid starting the system using unsigned or legacy boot methods.
- [ ] Only enrol and use approved signing keys and certificates, and prevent unauthorised changes to keys.
- [ ] Enable trusted platform module (TPM) measured boot, and confirm that TPM event logs and measurements are generated for the firmware, bootloader, and kernel and initial RAM file system (initramfs).
- [ ] Set up the system so that if a boot failure is caused by untrusted components, the normal service will not start (it will stop or switch to recovery or maintenance mode).
- [ ] Set up central collection and retention of evidence showing **Secure Boot** status and **Trusted Platform Module (TPM)** measurements/attestations, linked to the system identification and including the date and time (timestamps).
- [ ] Publish runbooks and assign named owners for key management, validation of the signing pipeline, and periodic review of evidence for boot integrity.


---

#### SI-7.10 — Protection of Boot Firmware (Enhancement)

This requirement is about making sure the very first code your devices use to start up cannot be changed without authorisation. If someone could tamper with the start-up (boot) firmware, it could permanently stop your systems from working or allow harmful software to stay hidden and reappear every time the device restarts.

To prevent this, the organisation must protect boot firmware on its servers, hypervisors, and network security appliances that support secure boot and firmware updates by:
- only accepting firmware updates that are signed by the approved source and checked for integrity before installation
- enforcing secure boot so unauthorised firmware cannot run
- using firmware write protection so unauthorised changes are blocked

The organisation should also:
- document how these protections work
- keep the relevant settings and design information up to date
- define clear procedures for how updates are verified and applied
- assign responsibility to the right roles
- keep records and audit logs showing that integrity checks and secure boot enforcement are carried out

##### Signed firmware updates with secure boot and firmware write lock

- Category: Software
- Priority: Critical

###### WHAT
Put boot-firmware protection in place for the in-scope parts of the system (servers, hypervisors, and network security appliances) by:
- turning on **secure boot**
- allowing **only cryptographically signed firmware updates**
- checking **firmware integrity and authenticity before installation**
- using **firmware write protection** to stop unauthorised changes

###### WHY (control requirement)
This requirement, NIST SI-7(10) enhancement, asks for “mechanisms to protect the integrity of boot firmware” for the specified system components {{ insert: param, si-07.10_odp.02 }} and the specified mechanisms {{ insert: param, si-07.10_odp.01 }}. The guidance notes that unauthorised changes to boot firmware can be a sign of targeted attacks that may install malicious code that persists, or cause permanent denial of service.

###### HOW (specific steps/approach)
1. **Define the in-scope component set**: build or confirm an inventory of servers, hypervisors, and network security appliances that support secure boot and signed firmware updates. Include the exact firmware update method used by each vendor and model.
2. **Standardise secure boot enforcement**: for each platform, configure BIOS/UEFI (or an equivalent system) so secure boot is **enabled** and uses organisation-approved keys where supported. Disable any “setup bypass” or other insecure boot options. Apply this through configuration management and record the baseline.
3. **Only allow signed firmware updates**: configure the vendor update tools or process (or management application programming interface (API)) so firmware updates are accepted **only if they are cryptographically signed**. Ensure the platform checks **integrity and authenticity before flashing**. Remove or disable any way to “force flash”, “skip signature checks”, or “install anyway”.
4. **Enable firmware write protection**: enable the platform’s built-in write-protection features (for example, BIOS/UEFI write protect, restrictions on the hardware or management interface, or equivalent controls). Limit firmware settings and update access to a small, privileged group using approved change requests.
5. **Set up evidence and monitoring**: gather and centralise proof that secure boot is enabled and that firmware update checks were performed (for example, secure boot status exports, update acceptance/rejection logs, and alerts for configuration changes). Keep logs according to the organisation’s logging requirements.
6. **Test with negative cases**: during a controlled maintenance window, try to install an invalid, unsigned, or altered firmware package and confirm the platform rejects it before any firmware change is applied.

###### WHO (role responsible)
- **Infrastructure/Platform Engineering Lead**: owns the platform baselines (secure boot and write protection) and the firmware update process configuration.
- **Security Engineering / Chief Information Security Officer (CISO) delegate**: approves trusted signing sources/keys and confirms evidence requirements.
- **Privileged Access Administrator**: enforces restricted access to firmware settings and firmware update tools.
- **Change Manager**: ensures firmware updates follow approved change management and occur only during approved maintenance windows.

###### Acceptance criteria
- For **100%** of in-scope components, secure boot is **enabled** and cannot be bypassed using normal operational procedures.
- Firmware update processes accept **only cryptographically signed** firmware and reject invalid or altered updates before installation.
- Firmware write protection is enabled, and unauthorised people or processes cannot modify boot firmware.
- Central logs and evidence exist showing secure boot status and firmware update verification results (success/failure) for each update event.
- A negative test confirms invalid or unsigned firmware is rejected and no firmware change occurs.

###### Actions Required for Compliance

- [ ] Create or confirm an inventory of the in-scope servers, hypervisors, and network security appliances that support secure boot and signed firmware updates.
- [ ] Set up the computer’s basic start-up settings (BIOS/UEFI, or an equivalent system) to enable **secure boot**, and where the system allows, lock it so it only accepts **organisation-approved keys**.
- [ ] Disable or remove any firmware update options that could allow bypassing signature and integrity checks (for example, options that force flashing or skip verification).
- [ ] Enable firmware write protection and limit firmware configuration and update access to an approved set of privileged users.
- [ ] Set up central logging and evidence collection to record the secure boot status and the results of firmware update checks (accepted or rejected).
- [ ] Try to install an invalid or unsigned firmware update and confirm the device refuses it before any firmware is applied (flashed).


---

#### SI-7.12 — Integrity Verification (Enhancement)

This expectation is about making sure that any software people install themselves, and any updates they download, are genuine and have not been changed before the software is allowed to run. Without this check, a damaged or harmful version could be introduced—for example, through a modified download—and then run on your computers, potentially leading to data loss, fraud, or disruption.

To meet this requirement, the organisation must clearly state which self-installed software and updates are covered. It must only allow items obtained from approved vendor websites or the organisation’s internal software sources. Before running the software, it must verify that the file is intact using reliable checks provided by the vendor or another approved trusted method. If the integrity check cannot be completed or does not pass, the software must be blocked from running.

The organisation must keep records showing what was checked, the result, and when the check was completed. It must also document the process, responsibilities, and how the system is set up to support these checks.

##### Verify signed user-installed software before execution (fail-closed)

- Category: Software
- Priority: Critical

###### WHAT
Implement integrity checks for **user-installed software and updates** (including installers and update files) **before they run**, and **stop the software from running** if integrity cannot be verified or if the check fails. Only software from **approved vendor websites or internal repositories** is eligible.

###### WHY (control requirement)
This requirement comes from NIST Special Publication 800-53, security and event management (SI-7(12)) enhancement, which states: **“Require that the integrity of the following user-installed software be verified prior to execution: {{ insert: param, si-07.12_odp }}.”** The guidance also expects organisations to consider **whether the source is genuine** (approved sources) and whether it is **practical to perform reliable integrity checks** (for example, vendor-provided checksums or digital signatures).

###### HOW (specific steps/approach)
1. **Define the scope (allowlist) for si-07.12_odp**: create an allowlist of approved download sources (vendor domains/URLs) and internal repositories for both base installers and updates.
2. **Use trustworthy integrity information**: standardise on vendor or organisational **code-signing digital signatures** for installers and update files. Where digital signatures are not available, use vendor-provided **cryptographic hashes/checksums** obtained through an approved channel.
3. **Check integrity at the point where the software is executed**:
   - Configure endpoint application control / software restriction policy so that **only** executables/installers with **valid digital signatures** (and, where possible, expected publisher identities) are allowed to run.
   - Ensure the policy applies to both **first-time execution** and **update execution** (for example, updater programs and patch installers).
4. **Fail-closed behaviour**: if the signature/hash check cannot be completed (for example, missing signature, checksum mismatch, or the verification service is unavailable), **deny execution** and raise an alert.
5. **Keep evidence that can be audited**: for every execution attempt, log the software identifier (name/version/package hash), the verification method (signature/hash), the verification outcome (pass/fail), the signer/publisher (if signature-based), and the time; send this to the organisation’s security information and event management (SIEM) system for audit traceability.
6. **Embed into change/release governance**: link updates to the allowlist and changes to signing trust to the organisation’s change management, so auditors can trace **approved source → trusted file → verified execution**.

###### WHO
- **Endpoint Security / Platform Engineering Lead**: implements and maintains the endpoint enforcement policy.
- **Security Operations Centre (SOC) / SIEM Engineer**: ensures verification events are correctly formatted, stored, and alerted on.
- **Application / IT Release Manager**: ensures internal packages are signed and that vendor files are mapped to the approved source allowlist.
- **Compliance / Assurance**: checks that the evidence is sufficient for audits.

###### Acceptance criteria
- For every user-installed software/update that matches **si-07.12_odp**, execution is **blocked** unless integrity verification succeeds.
- Only software from **approved vendor websites or internal repositories** is eligible (enforced through the allowlist and/or repository trust).
- Verification events are logged centrally with **method, result, software identifier, and timestamp**.
- A test case shows that a tampered installer/update (invalid signature or checksum mismatch) is **not executed** and produces an auditable alert/event.

###### Actions Required for Compliance

- [ ] Create and maintain a list of approved download sources (vendors) and internal repositories for the **si-07.12_odp** software and updates.
- [ ] Use code-signing (or vendor-provided cryptographic hash values) for all eligible software installers and update packages.
- [ ] Set up endpoint application control and software restriction rules so that programs can run only when their digital signature or file hash has been verified successfully.
- [ ] Set enforcement to “fail closed”, so execution is blocked if the integrity check fails or cannot be completed.
- [ ] Record the verification outcome in the security information and event management (SIEM) system, including the software identifier, the verification method used, the result, the signer or publisher (if applicable), and the date and time (timestamp).
- [ ] Test by using a modified (tampered) installer or update to confirm that it is blocked from running and that an auditable record is created.


---

#### SI-7.15 — Code Authentication (Enhancement)

This requirement is about making sure only genuine, approved software and firmware are installed on your on-premises systems. Without this check, someone could install altered or harmful code, or a faulty update could be applied, which could cause service disruption, data loss, or unauthorised access.

To meet this expectation, the organisation must confirm that every software package, firmware image, and update bundle intended for on-premises installation is digitally verified before installation. This must be done using certificates the organisation recognises and has approved. Any package or image with a missing, untrusted, or invalid digital signature must be blocked, unless there is a properly documented and approved exception.

The organisation must also keep clear, audit-ready records showing the result of these signature checks for each deployment. It must document the method and procedures used, ensure the relevant policies and system plans cover this activity, and name specific people who are responsible for carrying out the checks and managing approved certificates and any exceptions.

##### Gate on signed artefacts before on-prem install

- Category: Software
- Priority: Critical

###### WHAT
Add cryptographic authentication for **all software packages, firmware images, and update bundles** meant for on-premises installation. This means checking **digital signatures** against an organisation-approved list of trusted certificates **before installation**. Any component that is **not signed**, **not trusted**, or has an **invalid signature** must be blocked, unless there is a formally documented and approved exception.

###### WHY (control requirement)
NIST SP 800-53 **SI-7(15)** requires: *“Implement cryptographic mechanisms to authenticate the following software or firmware components prior to installation: {{ insert: param, si-07.15_odp }}.”* The guidance explains that cryptographic authentication includes confirming the component was **digitally signed using certificates recognised and approved by the organisation**, and that organisations should consider **cryptographic key management solutions**.

###### HOW (specific steps/approach)
1. **Define what must be checked** to match `si-07.15_odp` (all software packages, firmware images, and update bundles deployed to on-premises systems).
2. **Set up an approved trust model for signers**: keep an allow-list of trusted signing certificates (for example, by thumbprint/serial/issuer) in a central configuration service used by deployment tools.
3. **Make signature checking a mandatory “stop before install” step** in the release/deployment pipeline and/or on the staging gateway/jump host used to move files into the on-premises environment:
   - Check that the signature is valid and that the certificate links back to the approved trust set.
   - **Fail closed**: do not install or promote artefacts if signature verification fails or is missing.
4. **Keep evidence for every deployment**: record the artefact identifier/version, signing certificate details (where allowed), verification result (pass/fail), and the time it was checked, and link this evidence to the relevant change/release record.
5. **Control certificate updates and exceptions**:
   - Use an approval process to add or remove trusted certificates.
   - Any exception must be documented, assessed for risk, and approved, including certificate expiry and any compensating controls.
6. **Use secure key management for signing** (where the organisation signs artefacts): store signing keys in a signing service backed by a hardware security module (HSM) or key management service (KMS), and limit signing actions to authorised roles.

###### WHO (roles responsible)
- **Release/Deployment Engineering Lead**: implements the verification gate and captures evidence in the deployment pipeline.
- **Security Engineering / PKI Owner**: manages the approved certificate trust set and its approvals.
- **Change Manager / CAB**: ensures any exceptions are documented, approved, and tracked.
- **Privileged Access Administrator**: limits and monitors access to trust-store management and signing services.

###### Acceptance criteria
- For every on-premises deployment of a component in `si-07.15_odp`, the deployment process performs signature verification **before installation**.
- Deployments of unsigned, untrusted, or invalidly signed artefacts are **blocked** and never reach installation.
- The trust set used for verification contains only **organisation-recognised and approved** certificates.
- For a sample of deployments (for example, the last 10 releases), evidence exists showing: artefact ID/version, verification outcome, and timestamp linked to the corresponding change/release record.
- Changes to the certificate trust store and any exceptions are traceable to approvals and are time-limited where applicable.

###### Actions Required for Compliance

- [ ] Define the exact set of on-premises software packages, firmware files, and update bundles covered by **SI-07.15_ODP**.
- [ ] Create and keep an organisation-approved list of signing certificates that deployment verification tools are allowed to use.
- [ ] Set up a pre-install check that verifies the installer’s signature. If the signature is missing, not trusted, or invalid, the installation must be blocked (fail closed).
- [ ] Add the results of signature checks to deployment and change records, including time-stamped audit evidence.
- [ ] Set up an approval process for updates to the trusted store, and record any time-limited exceptions along with compensating controls.
- [ ] Use a hardware security module (HSM) or key management service (KMS) backed signing service (or an equivalent solution) to protect signing keys, and allow signing only for authorised roles.


---

#### SI-7.16 — Time Limit on Process Execution Without Supervision (Enhancement)

This requirement is about ensuring that no software task is allowed to run on its own for too long without being checked. If a process can keep running unchecked for more than 2 hours, it could mean something is wrong, an unexpected change has occurred, or there is malicious activity that quietly uses up resources, changes data, or spreads further before anyone notices.

To meet this expectation, the organisation must set a maximum unsupervised run time of 2 hours for processes where normal running periods can be identified, and enforce this limit using built-in timing features, automated stop or restart actions, and, where automation is not enough, clear manual oversight procedures.

The organisation must:
- define what counts as “supervision”  
- document how the 2-hour limit is built into system settings and designs  
- assign named staff responsibility  
- keep records showing when processes were stopped or brought back under supervision  
- include this approach in its system security planning

##### Enforce 2-hour hard timeouts for unsupervised job execution

- Category: Software
- Priority: Critical

###### WHAT
Set a strict maximum run time of **2 hours** for application-initiated processes that run without active human monitoring. When this limit is reached, the system must carry out an **automated, supervised response** (for example: stop/terminate, contain, quarantine, or restart using a controlled procedure) and keep **evidence that can be audited**.

###### WHY (control requirement)
The U.S. National Institute of Standards and Technology (NIST) **security control SI-7(16)** (enhancement) requires: **“Prohibit processes from executing without supervision for more than {{ insert: param, si-07.16_odp }}.”** The guidance explains that **supervision** includes operating system timers, automated responses, and human oversight when unusual behaviour is detected. This approach ensures the organisation does not exceed the agreed **time limit**.

###### HOW (specific steps/approach)
1. **Define what counts as “processes”** in the enterprise application: scheduled jobs, background workers, batch or report generation, workflow steps, maintenance tasks, and any microservice/worker tasks that can run without anyone watching them.
2. **Standardise how processes run** using a managed scheduler/workflow (or wrap existing execution so it is controlled by the scheduler). This ensures every in-scope process run has a recorded start time and a controlled lifecycle.
3. **Set a hard timeout of 2 hours** (parameter **si-07.16_odp**, default/user value **2 hours**) for each job/workflow run where normal run times can be identified. You may also set an earlier alert point (for example, 1 hour 50 minutes), but the enforced limit must be **2 hours**.
4. **On timeout, carry out an automated supervised response**:
   - Stop/terminate the process run.
   - Reduce impact (for example: stop downstream spreading, revoke/rotate any temporary credentials used by the job, and/or quarantine outputs).
   - Restart only if the documented procedure (runbook) says it is safe, and the restart must still be done under supervised conditions.
5. **Set up manual oversight for exceptions** where stopping or restarting could be unsafe (for example, long-running operations that hold state). The runbook must require operator approval and specify the target time to bring the process back under supervision.
6. **Record and keep audit evidence** for every timeout event: job/workflow instance ID, start/end times, the timeout threshold reached, the automated action taken, and any operator actions taken under the manual runbook.
7. **Enforce through configuration and “policy as code”** so new job definitions cannot be deployed unless they include a configured timeout of **2 hours** (or less where the risk requires it).

###### WHO
- **Application/Platform Engineering Lead**: responsible for integrating the scheduler/workflow and enforcing job run control.
- **Security Engineering (SIEM/Monitoring) Lead**: ensures timeout events are recorded and can trigger alerts.
- **Operations/Runbook Owner**: maintains the manual oversight procedures and the approval workflow.
- **Change Management Owner**: ensures policy-as-code and job template standards are applied through release governance.

###### Acceptance criteria
- For all in-scope scheduler/workflow-managed processes, **no process run continues without supervision for longer than 2 hours** (si-07.16_odp).
- When the 2-hour limit is reached, the system performs an **automated supervised response** (terminate/contain/quarantine and/or a controlled restart per the runbook) and records the event.
- Timeout events generate **audit logs** that include instance identifiers, timestamps, the reason for the timeout, and the action taken.
- New or updated job definitions are blocked by **policy as code** unless a timeout of **2 hours** (or less) is configured.
- A manual oversight runbook exists and is used for the defined unsafe-exception cases, with evidence of operator approval and actions.

###### Actions Required for Compliance

- [ ] Identify and list all in-scope unattended processes (scheduled jobs, background workers, workflows, and batch tasks), and assign each one to the person responsible for the scheduler or workflow.
- [ ] Set a strict maximum runtime of 2 hours for each job or workflow run type (si-07.16_odp) where the usual, normal run times are already known.
- [ ] Set up automated time-out actions to stop, contain, or quarantine the affected process, and then restart it in a controlled way according to the runbook. Also ensure that credentials and any output are handled safely.
- [ ] Create and get approval for manual oversight procedures (runbooks) for exceptions where automatic shutdown or restart is not safe. These procedures must include operator approval and the expected response times for the target actions.
- [ ] Enable audit logging for every timeout event, including the instance ID, the start and end times, the threshold that was reached, and the actions taken (both automated and manual).
- [ ] Add policy checks and template validation to stop deployments of job definitions that do not include the required 2-hour timeout.


---

#### SI-7.17 — Runtime Application Self-protection (Enhancement)

This requirement is about actively protecting your software while it is in use, so that suspicious behaviour is stopped immediately rather than being noticed after damage has already been done. Without this, attackers could exploit weaknesses in an application to break in, steal data, or change what the software does. In that case, unauthorised changes could go unnoticed until they cause harm.

To meet this expectation, the organisation must run runtime self-defence for its applications in protection mode. This should include built-in exploit prevention and tamper detection that use information gathered from the application while it is running. If a threat is detected, the system must block the harmful attempt and take appropriate actions, such as warning the user, ending the user session, and/or stopping the application. It must also automatically send an alert to the organisation’s Security Operations Centre.

The approach must be documented in design and integrity procedures, included in the security plan, with relevant responsibilities assigned. The organisation must also maintain records of the specific configuration used and the known vulnerabilities covered by the runtime defences.

##### Deploy RASP in protection mode with exploit prevention, tamper detection

- Category: Software
- Priority: Critical

###### WHAT must be done
Implement runtime application self-protection (RASP) for the application in **protection mode**, providing **real-time exploit prevention** and **real-time tamper detection**. When threats are detected, take the **defined response actions** (for example, warning the user, ending the user session, or ending the application). Also, **automatically alert the security operations centre (SOC)** when threats are detected.

###### WHY (control requirement)
SI-7(17) enhancement requires: “Implement {{ insert: param, si-07.17_odp }} for application self-protection at runtime.” The organisation-defined parameter specifies **runtime application self-protection in protection mode**, including exploit prevention, tamper detection, and automatic alerting to the SOC. The control guidance also requires runtime monitoring and protection actions (monitor versus protection mode), including blocking exploitation, detecting tampering, and taking response actions, with automatic alerting.

###### HOW (specific steps/approach)
1. **Select and integrate a RASP/runtime exploit-prevention capability** that adds protection while the application is running (for example, a host-based RASP agent or an application runtime protection module). It must support **protection mode** (block/terminate), not only monitoring.
2. **Set protection-mode rules** for exploit prevention using runtime information (for example, suspicious input patterns, dangerous execution paths, exploit-like payload indicators). Link each detection to the **response actions**, such as:
   - warning the user with a generic message,
   - ending the user session and/or terminating the application process,
   - ensuring the application fails safely without revealing sensitive details.
3. **Enable tamper detection** using checks that fit the application technology (for example, detecting unauthorised code or module loading, unexpected integrity changes, or suspicious changes in memory). Adjust thresholds to reduce false alarms while keeping effective detection.
4. **Set up automated SOC alerting** by sending RASP events (exploit-prevention and tamper-detection) into the organisation’s security information and event management (SIEM) and SOC tools using existing logging and monitoring routes. Ensure alerts include enough detail (application instance, time, detection type, action taken, and correlation identifiers).
5. **Make evidence and coverage auditable**: keep a record of (a) which protections are enabled, (b) the configuration and policy versions, (c) which tamper-detection checks are enabled, and (d) the **vulnerability coverage list** (which types of vulnerabilities/exploit patterns the runtime protections are intended to address). Ensure this is included in the system security plan and integrity procedures.
6. **Assign responsibilities and document the runbook**: define who maintains the RASP configuration and policies, who triages SOC alerts, and what operational steps are taken after a detection (including rollback and containment steps under change management).

###### WHO (role responsible)
- **Application Security Lead / Security Architect**: responsible for the RASP design, mapping the policies, and maintaining the vulnerability coverage list.
- **Platform/Cloud Engineer or Infrastructure Engineer**: deploys and integrates the RASP runtime component across environments.
- **SOC Analyst / Detection Engineer**: checks that alert routing works, validates the triage process, and confirms correlation rules.
- **Application Owner**: approves the safe user experience when the application fails, and helps tune settings to manage false positives.

###### Acceptance criteria
- RASP is deployed and running for the application in **protection mode** (blocking/terminating behaviour is clearly active).
- Exploit attempts that match the configured exploit-prevention rules are **blocked**, and the configured response action(s) occur (for example, session termination and/or application termination) without exposing sensitive error information.
- Tamper events that match the configured tamper-detection checks are **detected** and trigger the configured response actions.
- For both exploit-prevention and tamper-detection events, **automated SOC alerts** are generated in the SIEM/SOC workflow with sufficient context and are correctly linked to the relevant application instance.
- An evidence package is available and audit-ready: current RASP configuration/policy version, enabled protections, tamper-detection checks, vulnerability coverage list, and confirmation that the approach is included in the system security plan and integrity procedures.

###### Actions Required for Compliance

- [ ] Choose a runtime application self-protection (RASP) capability that can run in protection mode and provide runtime monitoring for the application stack.
- [ ] Set up protection-mode exploit-prevention rules to stop inputs that could enable exploits, and link any detections to the agreed safe “fail” responses.
- [ ] Set up and adjust real-time checks to detect unauthorised loading of code or modules and to identify unexpected changes to the application’s integrity.
- [ ] Integrate runtime application self-protection (RASP) event reporting with the security information and event management (SIEM) system and security operations centre (SOC) so that exploit-prevention and tamper-detection events automatically create alerts with the required supporting details.
- [ ] Create and keep an auditable list of known vulnerabilities and exploit patterns, matched to the runtime protections that are currently configured.
- [ ] Update the system security plan and the procedures for checking system integrity to use the runtime application self-protection (RASP) configuration approach, to capture supporting evidence, and to define day-to-day operational responsibilities.


---

### SI-8 — Spam Protection (Control)

This expectation is about preventing unwanted messages from reaching people, and keeping the tools that do this up to date. Without spam protection at the points where messages enter and leave your systems (such as email, web access, remote access, and devices like laptops and mobile phones), unwanted messages can get through, waste staff time, and potentially expose the organisation to harmful content or scams.

To meet this requirement, the organisation must have spam-checking in place at every relevant entry and exit point, so that unsolicited messages are identified and handled correctly (for example, blocked, put in quarantine, or rejected), using the organisation’s chosen settings. The organisation must also update its spam-protection features whenever new approved releases are available, following its normal change and approval process, and keep records showing when updates were applied and what changes were made.

##### Central spam filtering at email and web/proxy entry points

- Category: Software
- Priority: Critical

###### WHAT
Put spam-protection in place at all relevant points where unsolicited messages can enter or leave the system—specifically for incoming and outgoing email, and for web and proxy access. Use centrally managed, signature-based spam detection. Make sure detected spam is stopped or contained using clear, repeatable actions (for example: reject, quarantine, delete, or mark). Ensure the spam-protection components are updated using only approved releases.

###### WHY (control requirement)
System requirement SI-8 says that system entry and exit points (including electronic mail servers and web/proxy servers) must have spam protection, and that spam-protection settings (such as signature definitions) must be kept up to date. It also expects spam can arrive through multiple routes (email, attachments, and web access), so the organisation must apply spam protection at the points where messages enter and leave the system.

###### HOW (specific steps/approach)
1. **Identify all entry and exit points** for unsolicited messages, including:
   - incoming email (mail exchange records, “MX”)
   - any email delivery routes that could send messages to user mailboxes
   - web access through a proxy or secure access service (for example, secure web gateway / secure access service)
   - any remote-access portals that could deliver unsolicited content
2. **Set up centrally managed spam filtering**:
   - Use an enterprise **secure email gateway** (or equivalent email security service) that uses signature and reputation-based spam detection.
   - Use an enterprise **secure web/proxy filtering** capability (secure web gateway / secure access service, or proxy security) to inspect and block harmful or unwanted content delivered through the web.
3. **Set clear, deterministic outcomes at both entry and exit points**:
   - For email: configure the gateway to **reject** high-confidence spam and **quarantine** suspicious messages; ensure quarantined items are not delivered to user inboxes.
   - For web/proxy: configure the proxy/secure access service to block or contain unwanted or harmful content and prevent delivery to users when policy conditions are met.
4. **Enable logging that can be audited and kept as evidence**:
   - For each detected message, record at minimum: message identifier, detection reason (for example, signature or reputation match), date and time, and final outcome (quarantined/rejected/deleted/marked).
   - Send logs to the organisation’s security information and event management (SIEM) or logging platform, with retention aligned to enterprise policy.
5. **Update spam protection using approved releases only**:
   - Subscribe to the vendor’s signature and engine update feeds.
   - Keep an internal record of **approved releases**, and deploy updates through the organisation’s change and configuration management process (including testing in non-production where possible, then a controlled rollout).
   - Keep evidence of each update: version/release date, change reference (ticket), and deployment timeframe.
6. **Check coverage and manage exceptions**:
   - Run regular configuration checks to confirm the same spam outcome rules are applied across the main email and web/proxy delivery routes.
   - Document and get approval for any exceptions (for example, specific allowlists), including the justification and any compensating controls.

###### WHO (role responsible)
- **Security Operations / Security Operations Centre (SOC)**: responsible for tuning detection and outcomes, monitoring, and reviewing evidence.
- **Email and Web Security Administrators**: implement gateway/proxy configurations and carry out update deployments.
- **Configuration Management / Change Management**: ensures updates follow approved release and change processes.
- **Application and Infrastructure Owners**: confirm the relevant entry and exit paths for their applications are correctly routed through the controlled gateways.

###### Acceptance criteria
- Incoming email and web/proxy access routes are directed through the configured spam-protection controls.
- For test spam samples, the system creates an auditable log entry and applies the configured outcome (for example, reject/quarantine) without delivering spam to user inboxes.
- Spam-protection signature or engine updates are applied only from approved releases, with evidence showing the version/release date and the change reference.
- Logs are available in the SIEM (or equivalent) and include message ID, detection reason, and final action for a representative sample of detections.
- Any policy exceptions are documented, approved, and reviewed under the organisation’s governance process.

###### Actions Required for Compliance

- [ ] Identify and document every email and web or proxy route that could allow unsolicited messages to reach users.
- [ ] Set up and enforce secure email filtering to detect spam, and clearly define what happens to detected spam (either reject it or quarantine it).
- [ ] Set up and apply secure web and proxy filtering rules to block or limit unwanted content delivered through the web
- [ ] Set up and centralise audit records for spam detections, including the message ID, the reason it was flagged, the time it was detected, and the final outcome.
- [ ] Set up an approved process for releasing updates to the spam detection signatures and engine, and roll them out using the organisation’s change management process.
- [ ] For each update, collect and keep the supporting evidence (version or release date and the change reference), and check in security information and event management (SIEM) that the evidence is complete.


---

#### SI-8.2 — Automatic Updates (Enhancement)

This requirement is about making sure your spam-blocking tools update automatically, so they can recognise the newest techniques used by spammers. If updates are not applied regularly, your email and messaging systems can become less effective, which may allow more unwanted or harmful messages through and increase the risk of fraud, phishing, and disruption to staff and customers.

To meet this expectation, the organisation must configure its spam protection to update automatically at least once every week, without relying on someone to remember to do it manually. It must also keep clear records showing that the updates actually took place, including when they were applied and what was changed, and keep those records so they can be reviewed later.

The organisation should have documented procedures for setting up the weekly automatic updates and for what to do if an update fails. It should also name specific people who can demonstrate that the weekly updates are being monitored and evidenced.

##### Weekly automated spam protection updates with audit evidence export

- Category: Software
- Priority: Critical

###### WHAT
Set up the organisation’s spam protection so it **automatically updates at least weekly** (frequency parameter: **weekly**). This may include hosted email security signatures/engines/rules and/or on-premises mail gateway spam filters. Keep **verifiable records** showing **when** updates happened and **what** was changed.

###### WHY (control requirement)
NIST SI-8(2) (Enhancement) requires: **“Automatically update spam protection mechanisms {{ insert: param, si-08.02_odp }}.”** The guidance explains that automated updating helps ensure updates happen regularly and provide the latest protection capabilities. The organisation-defined parameter **si-08.02_odp (frequency)** is set to **weekly**, so updates must run at least once every 7 days.

###### HOW (specific steps/approach)
1. **List all places where spam protection is applied** for the messaging routes (inbound email gateway, hosted email security, and any additional filtering layers that inspect email content/attachments).
2. **Turn on automated update scheduling** provided by the vendor/platform for each spam protection mechanism, and confirm it is set to **weekly or more frequent** (record the exact setting name/value used).
3. **Enable audit and event logging** for spam protection updates, so every update creates a time-stamped record showing the result (success/failure) and what was updated (for example, signature/rule/engine version or component name).
4. **Send or centralise update evidence** into an auditable location (for example, a security information and event management (SIEM) index, an immutable log store, or a scheduled evidence report/API pull) with retention long enough for audit checks.
5. **Set up failure detection and alerts** for the update job (for example, alert if no successful update occurs within 8 days, or if the update result is failure). Route alerts to the operations/security on-call process.
6. **Create a short runbook** explaining how to check the most recent successful update (where the evidence is stored) and what to do if an automated update fails (triage steps, escalation, and how often to re-check).
7. **Regularly check evidence completeness** (for example, monthly) by sampling the last 4–8 weeks and confirming each week has a time-stamped successful update record in the central evidence store.

###### WHO
- **Email security / infrastructure engineer**: configure automated update scheduling and logging on the spam protection platform(s).
- **Security operations (SOC) / SIEM engineer**: set up log ingestion/evidence export and alerts for update failures.
- **Security operations lead / IT operations manager**: own the runbook, escalation process, and periodic evidence checks.

###### Acceptance criteria
- For each identified spam protection mechanism, automated updates are enabled and set to run **at least weekly** (si-08.02_odp frequency = weekly).
- Central evidence includes **time-stamped records** for each weekly update showing **success/failure** and **what was updated** (component/version/rule set identifier).
- Alerts are raised when updates fail, or when no successful update is recorded within **8 days**.
- A runbook exists and is followed during checks, including where evidence is located and how failures are handled.
- Evidence is retained and can be retrieved for audit (for example, the last 8 days of update records can be produced on request).

###### Actions Required for Compliance

- [ ] Identify every incoming messaging route and the spam protection measures used for each one (both hosted and on-premises).
- [ ] Set up and configure automatic spam-protection updates for each mechanism so they run at least once a week, and record the exact configuration setting used.
- [ ] Turn on audit and event logging for spam protection update activity, and check that the logs include the time (timestamp), the affected component and version, and the result of the update.
- [ ] Set up a central way to export and store evidence (for example, from a security information and event management system (SIEM) or log store, or via a scheduled report or application programming interface (API) pull) so that update records are kept, regardless of what the provider’s user interface shows.
- [ ] Set up alerts for (1) update failures and (2) updates that have not completed successfully within 8 days, and route these alerts to the on-call operations workflow.
- [ ] Create and get approval for a step-by-step guide (runbook) to check that the most recent update was successful, and to follow a clear escalation and triage process if an update fails.
- [ ] Carry out a monthly check of the evidence by reviewing a sample of the last 4 to 8 weeks and confirming that each week has a successful, time-stamped update record.


---

#### SI-8.3 — Continuous Learning Capability (Enhancement)

This requirement is about improving your spam protection over time, so it can learn which messages are genuinely unwanted and which are legitimate. Without this, important emails and messages may be wrongly blocked or delayed, while spam and scams may get through more easily—causing disruption for staff and customers and increasing the risk of fraud or data loss.

To meet this expectation, the organisation must use spam protection that can learn from feedback. For example, it should be able to adjust its decision rules when users (or an authorised process) mark messages as spam or not spam. The organisation must document how this learning works, include it in system design and security planning, record the relevant configuration choices, and keep audit records showing that feedback was received and that learning updates were applied.

Named individuals must be responsible for operating it, with clear procedures for managing updates and keeping the supporting records.

##### Feedback-driven Bayesian spam learning with audit evidence

- Category: Software
- Priority: Critical

###### WHAT
Set up spam protection that improves over time using a learning approach (for example, Bayesian or adaptive filtering). It should update its settings based on feedback from authenticated users (or authorised processes) that identifies messages as spam or legitimate.

###### WHY (control requirement)
NIST security control SI-8(3) (Enhancement) requires implementing spam protection with a learning capability. This helps the system identify legitimate communication traffic more accurately. The guidance includes learning methods such as Bayesian filters, which update their settings based on user input.

###### HOW (specific steps/approach)
1. **Choose the control point**: Use an enterprise email security gateway or secure email service that supports adaptive/Bayesian learning based on feedback.
2. **Enable learning explicitly**: Configure the gateway/service to turn on adaptive learning. Define the learning scope (for example, tenant, domain, or message category) and record it.
3. **Capture authenticated feedback**: Enable user actions such as **“Report spam”** and **“Not spam”** (or equivalent). Make sure feedback is linked to an authenticated mailbox/session and is accepted only from authorised users.
4. **Constrain and protect the learning process**: Add safeguards to reduce the risk of malicious or incorrect feedback affecting the model (for example, minimum confidence thresholds before updates, a maximum learning rate, and limits to approved scopes/domains).
5. **Record learning changes for audit purposes**: Send gateway/service logs to the security information and event management (SIEM) system and keep evidence showing feedback events and the resulting learning/model updates (including timestamps, the affected service, feedback type, and indicators of the update/training run).
6. **Document the learning design and configuration**: Update system design and security documentation to describe the workflow from **feedback → setting updates → message classification**, including the exact configuration choices and where evidence is stored.
7. **Operate with clear ownership and controlled change**: Assign named roles responsible for operating the learning capability. Define a process for reviewing and approving changes to the learning settings.

###### WHO (role responsible)
- **Email Security Administrator / Security Operations**: Configure learning, feedback capture, safeguards, and log forwarding.
- **Information Security Manager / Security Governance**: Own the documentation, named responsibilities, and approval process for changes to learning configuration.
- **SIEM/Monitoring Engineer**: Ensure audit logs and retention meet organisational requirements and can be searched to provide evidence.

###### Acceptance criteria
- Spam protection is configured with an enabled learning mechanism (Bayesian/adaptive) that updates settings based on authenticated feedback.
- **“Report spam”** and **“Not spam”** (or equivalent) options are available to users and are accepted only when feedback is authenticated/authorised.
- Learning updates are limited by configured safeguards (for example, thresholds/rate limits/scope restrictions) to prevent untrusted feedback from corrupting the model.
- Audit evidence exists showing (a) feedback events and (b) the corresponding learning/model update activity, with logs sent to the SIEM and retained.
- System design/security documentation includes the learning workflow and the exact configuration settings used for the learning capability.
- Named roles and an operating procedure exist for managing learning configuration changes and maintaining evidence.

###### Actions Required for Compliance

- [ ] Choose an enterprise email security gateway or service that can improve its protection by learning from user feedback (using adaptive or Bayesian learning).
- [ ] Turn on the learning feature in the gateway and service policies, and record the exact learning scope and configuration settings.
- [ ] Set up feedback options that require a logged-in user (for example, “Report spam” or “Not spam”), and make sure only authorised users can submit feedback.
- [ ] Apply safety controls to the learning process (for example, a minimum confidence level, a maximum learning rate, and limits on what the system is allowed to learn) to reduce the risk of malicious data poisoning.
- [ ] Connect gateway and service logs to the security information and event management (SIEM) system, and check that the logs record both customer feedback events and the signals that show the model or learning has been updated afterwards.
- [ ] Update the system design and security documentation to explain how feedback is turned into learning, and keep configuration snapshots as evidence.
- [ ] Assign specific operational roles and set up a process to approve and manage changes to learning configuration.


---

### SI-10 — Information Input Validation (Control)

This requirement is about making sure that every piece of information your systems receive from people or other software is checked to confirm it is in the correct format and has the intended meaning before the system acts on it. Without this, incorrect or deliberately “messy” information could be misunderstood, leading to the wrong actions, damaged data, or harmful outcomes—for example, running scripts in a web browser or hiding commands inside messages.

To meet this expectation, the organisation must:
- Keep an up-to-date list of all places where incoming information must be checked.
- Set clear rules for each place (for example, which characters are allowed, the required length, what numbers are acceptable, and which options are permitted).
- Ensure the system rejects any user input, software-to-software information, file uploads, or structured messages that do not meet those rules.

Validation must be built into the system design, set up correctly, assigned to authorised staff, supported by documented procedures and any automated checking tools, and proven through records showing that invalid inputs are blocked and valid inputs are accepted.

##### Schema-driven input validation for all application inputs

- Category: Software
- Priority: Critical

###### WHAT must be done
Implement input checks for **all information inputs** (both external and internal) that need validity checks. Each input must be checked for **correct meaning and format** (for example: allowed character set, length, numerical range, and permitted values). **Invalid inputs must be rejected** before they can be used or interpreted by downstream components.

###### WHY (control requirement)
NIST SI-10 requires: “Check the validity of the following information inputs: {{ insert: param, si-10_odp }}.” The guidance explains that checking both format and meaning (including character set, length, numerical range, and permitted values) helps prevent incorrect interpretation and attacks such as injection and cross-site scripting. It also states that corrupted inputs should not be accepted as input to the system.

###### HOW (specific steps/approach)
1. **Create an authoritative Input Validation Registry** that covers every item in **si-10_odp (information inputs)**, including: user-entered fields, API parameters, file uploads, and structured protocol/message payloads.
2. **Set validation rules for each input** using machine-readable definitions (for example: OpenAPI/JSON Schema for APIs; strict typed contracts for internal service calls; clear message envelope definitions for structured messages; explicit upload limits for file uploads). Rules must include: allowed character set/charset, required length/format, numerical minimum/maximum ranges, and a defined list of acceptable values.
3. **Apply validation at the system boundary and before any interpretation**:
   - API gateway/service layer: reject requests with invalid parameter types, out-of-range values, invalid allowed values (enums), or character set/format mismatches.
   - UI: carry out checks in the browser for usability, but **server-side enforcement is mandatory**.
   - Structured messages: validate the message envelope/metadata and command fields using strict allowed values and fixed message structures, so attacker-controlled data cannot be treated as control or metadata.
   - File uploads: validate MIME type/extension and enforce size limits; reject content that fails verification.
4. **Use “reject early” handlers** so invalid inputs never reach business logic, template processing, database query building, or message construction/interpreters.
5. **Record validation outcomes** (including reason codes and correlation identifiers) for audit purposes, without recording sensitive payload content.
6. **Manage changes to validation rules**: treat schema/contract updates as controlled items (review, versioning, and release gating) so only authorised staff can change validation behaviour.

###### WHO (role responsible)
- **Application Security Lead / Security Architect**: owns the validation approach and ensures coverage of si-10_odp inputs.
- **Software Engineering Manager / Tech Lead**: ensures enforcement is implemented at the boundary layers and that reject-early handlers are in place.
- **Developers**: implement the schemas/contracts and validation middleware/handlers.
- **Change Manager / Release Manager**: ensures controlled release of validation rule updates.

###### Acceptance criteria
- Every input listed in **si-10_odp** has an associated validation rule (schema/contract) and a defined enforcement point.
- For each input, invalid format/meaning (for example: numbers outside the allowed range, disallowed characters, invalid allowed values, malformed structured messages) is **rejected** with a controlled error response and **does not** reach downstream interpreters/business logic.
- Structured message/command fields are validated so attacker-supplied data cannot be treated as metadata/control information.
- Validation rule artefacts are versioned, reviewed, and deployed through the organisation’s change/release process, with evidence available (registry entries, schema versions, and validation logs/reason codes).

###### Actions Required for Compliance

- [ ] Create and keep an input validation register for every item in `si-10_odp` (user interface fields, application programming interface (API) parameters, file uploads, and structured messages).
- [ ] Define machine-readable validation rules for each input, including the allowed character set and pattern (character set/regular expression), required length and format, numeric minimum and maximum limits, and the permitted options (allowed enumerations/values).
- [ ] Set up “reject early” validation at the API or service entry point, before any interpreter or business logic runs.
- [ ] Add strict checks to ensure structured message “envelopes” and command/control fields follow the required format exactly, with no free-form or unstructured extra information.
- [ ] Check every uploaded file meets the required rules (file size limits and file type checks using MIME type, file extension, and content) and reject any uploads that do not comply.
- [ ] Set up validation logging to include correlation identifiers and reason codes, and avoid logging sensitive request or response content.
- [ ] Place validation rule and schema changes under controlled review and release them only through version-controlled approval gates.


---

#### SI-10.1 — Manual Override Capability (Enhancement)

This requirement ensures there is a carefully controlled “human check” when the normal automatic checks for certain input data are not sufficient. Without this, incorrect or harmful information could be entered during urgent situations, which could result in wrong decisions, delays, or damage to records and day-to-day operations.

The organisation must provide a manual override option to validate the specified input data only when it is genuinely needed. This manual override must be limited to exactly three authorised roles: the system owner, the information system security officer, and the incident commander.

The organisation must also keep a clear record of every time the manual override is used, including who used it, what input was changed, when it happened, and whether the override worked.

##### Role-gated manual override for si-10.01_odp with auditable evidence

- Category: Software
- Priority: Critical

###### WHAT
Add a **manual override** for the **si-10.01_odp input validation** process. This can be used **only** when automated checks are not enough (for example, during contingency or incident handling), and **only** by the organisation’s **authorised individuals**.

###### WHY (control requirement)
SI-10(1) enhancement guidance requires that, in limited situations defined by the organisation (for example, during contingency plan events), there is a **manual override** for input validation. It must be used **only in those limited circumstances**, using **inputs defined by the organisation**. The guidance also requires that the override is limited to the **authorised individuals** (si-10.01_odp: system owner, information system security officer, incident commander) and that every use is **auditable**.

###### HOW (specific steps/approach)
1. **Pinpoint the exact si-10.01_odp validation checks** in the application (for example, specific API schema validation failures, user interface field validation failures, or ingestion/batch checks). Also define what counts as an “override” (for example, accepting the provided value even though a specific validation rule fails, or marking the record as “exception validated”).
2. Add a **separate override action/endpoint** (not a hidden or silent bypass) that is available **only** from the validation-failure handling flow. The override request must include the **incident evidence** required by the organisation (for example, an incident/ticket reference and justification) and must identify the specific input/workflow being overridden.
3. Enforce **role-based authorisation** using the organisation’s identity and access management system (enterprise identity provider/authorisation layer), so only these three roles can perform the override:
   - system owner
   - information system security officer
   - incident commander  
   Block all other identities, including service accounts and contractors, unless they are explicitly mapped to one of the three roles.
4. Require **step-up authentication** (multi-factor authentication (MFA)) for the override action. Ensure the override is recorded with a **server-side timestamp** and the **immutable subject identifier** from the identity provider.
5. Create **structured audit records** for **every override attempt** (both allowed and blocked). Each record must, at minimum, include: user identity (username plus immutable subject identifier), the si-10.01_odp input/workflow identifier, the incident reference (or a pointer/hash if sensitive), whether justification is present, the timestamp, and the result (validated/denied).
6. Send audit events to the central logging system and security information and event management (SIEM) platform, and set up **alerts** for unusual override patterns (for example, repeated overrides or overrides outside incident time windows).

###### WHO
- **Application owner / engineering lead**: implement the override action/workflow and enforce authorisation.
- **Information System Security Officer (ISSO)**: define the required incident evidence fields and the validation/override policy mapping.
- **System owner**: approve the override policy for si-10.01_odp inputs and ensure the operational approach is ready to use.
- **Incident commander (or delegated incident role)**: uses the override during contingency/incident events.

###### Acceptance criteria
- Only identities mapped to the three authorised roles can successfully use the manual override for si-10.01_odp validation.
- Override requests are rejected if required incident evidence/justification is missing or does not match the organisation’s required format/rules.
- Every override attempt (successful or denied) creates an audit event containing: immutable user identity, si-10.01_odp input/workflow identifier, timestamp, incident reference/pointer, and outcome.
- Audit events appear in the central logging/SIEM within the organisation’s expected time for data to arrive, and are suitable for reviewing after an incident.

###### Actions Required for Compliance

- [ ] Match each specific `si-10.01_odp` validation failure to a defined override result (for example, “exception validated” versus “accepted value”).
- [ ] Set up a dedicated manual override option (endpoint/action) that is only triggered by the **si-10.01_odp** validation failure process.
- [ ] Set up role-based authorisation so that only the system owner, the information system security officer (ISSO), and the incident commander can use the override.
- [ ] Require incident evidence in any override request, including the incident or ticket reference and a clear justification. Reject any override request where the evidence is missing or not valid.
- [ ] Require multi-factor authentication (MFA) as an extra check before allowing the override action, and record the identity provider (IdP) subject identifier in an unchangeable form.
- [ ] Create audit records for every attempt to override access (both accepted and denied) and send them to the central security information and event management (SIEM) and logging system.
- [ ] Set up alerts for unusual override activity, such as overrides outside incident time windows or overrides happening much more often than normal.


---

#### SI-10.2 — Review and Resolve Errors (Enhancement)

This requirement is about finding mistakes in the information people or systems submit, and correcting them quickly so transactions can be completed correctly. If these input errors are ignored or only dealt with superficially, customers and staff can be prevented from completing their requests, and payments or claims can be delayed or rejected. The same issue can then keep happening, creating avoidable operational and financial risk.

The organisation must review every recorded input validation error within 24 hours, and fix each one within 72 hours. “Fixing” means not only correcting the immediate mistake, but also identifying and correcting the underlying recurring cause. The organisation must then resubmit any affected transactions with the corrected information so they are accepted.

The organisation must keep clear records of what errors occurred, what actions were taken to resolve them, and be able to show when resubmission happened and the evidence that the resubmitted transactions were successful.

##### Workflow-driven review and resolution of input validation errors

- Category: Software
- Priority: Critical

###### WHAT must be done
Set up an auditable process (supported by system automation) to **review every recorded input validation error within 24 hours** and **fix each within 72 hours**, including:
- correcting the **underlying/systemic cause** (not just closing the incident), and
- **re-submitting any affected transactions** using corrected input.

###### WHY (control requirement)
NIST SI-10(2) requires: “Review and resolve input validation errors within {{ insert: param, si-10.2_prm_1 }}.” The guidance also says that fixing the issue includes correcting the underlying systemic cause and re-submitting transactions with corrected input. Input validation errors are those related to the information inputs defined by the organisation in the base control **SI-10**.

###### HOW (specific steps/approach)
1. **Define what counts as “validated inputs”**: keep an authoritative catalogue of the organisation-defined “validated inputs” (fields/schemas/ranges/formats) for each application endpoint, so only SI-10-defined input validation errors are tracked under this control.
2. **Standardise error reporting**: update the application/application programming interface (API) gateway to produce structured events for each input validation failure, including at minimum: transaction reference, input field(s), expected rule/schema, error category, correlation/request ID, actor/system, and timestamps.
3. **Create an error workflow with enforced service levels (SLAs)**:
   - In IT service management (ITSM)/case management, create a case for each input validation error event.
   - Automatically assign ownership to the responsible team based on the endpoint/service.
   - Record **reviewed_at** when a reviewer analyses the error.
   - Record **resolved_at** when a fix is deployed/verified and the error can no longer be reproduced.
   - Enforce the **24-hour review** and **72-hour resolution** timelines, with escalation and mandatory reason codes if deadlines are at risk.
4. **Correct systemic causes and trigger change**:
   - For repeated error types/fields, require a root-cause analysis outcome and a linked change request (for example: schema/rule correction, mapping fix, transformation update, or policy-as-code update).
   - Test the systemic fix (including negative tests for the specific validation error type).
5. **Re-submit affected transactions with corrected input**:
   - Use a controlled reprocessing method to re-play/re-submit the affected transaction(s) using corrected input derived from the systemic fix.
   - Record the re-submission result (accepted/rejected) and link it to the original input validation error case.
6. **Keep audit-ready evidence**:
   - Ensure records show the full chain: error event → case creation → reviewed_at within 24 hours → resolved_at within 72 hours → systemic fix/change reference → re-submission attempt(s) and outcomes.

###### WHO (role responsible)
- **Application Owner / Service Owner**: responsible for systemic fixes and re-submission outcomes.
- **Security/Compliance or Governance Lead**: ensures the workflow evidence meets audit requirements and that the SI-10 input scope is mapped correctly.
- **ITSM Case Handler / Triage Analyst**: completes the 24-hour review and records the analysis.
- **Engineering (Backend/API/Data)**: implements validation rule/schema fixes and the reprocessing logic.

###### Acceptance criteria
- **100%** of recorded input validation errors are **reviewed within 24 hours** (from the error event timestamp to reviewed_at).
- **100%** of recorded input validation errors are **resolved within 72 hours** (from the error event timestamp to resolved_at), including systemic/root-cause correction.
- For each resolved case, evidence shows that affected transactions were **re-submitted with corrected input**, and the outcome is recorded.
- Audit evidence shows traceability across: error event identifiers/correlation IDs, case/ticket IDs, timestamps, linked change requests, and re-submission results.
- Repeated error types trigger systemic change requests rather than repeated incident-only closures.

###### Actions Required for Compliance

- [ ] Create and keep an official catalogue of the validated inputs defined by SI-10 for each endpoint or service.
- [ ] Update the application and application programming interface (API) gateway to send structured events when input validation fails, including a unique reference number (correlation ID) and the time the error occurred (timestamp).
- [ ] Set up an information technology service management (ITSM) case workflow that automatically creates a case for each validation error, with a requirement to review each case within 24 hours and resolve it within 72 hours.
- [ ] Set up a process to resubmit and replay any affected transactions using the corrected information, then record the results.
- [ ] For recurring validation error types, perform root-cause analysis and link each issue to the relevant change request (only apply systemic fixes).
- [ ] Check the audit evidence by running a test cycle and confirming that you can trace the full path from the error event through to the resubmission result.


---

#### SI-10.3 — Predictable Behavior (Enhancement)

This requirement is about making sure the service responds in a steady, expected way every time when people or systems send the wrong or incomplete information. Without this, invalid information can lead to unpredictable outcomes, such as accidentally changing records, starting actions that should not happen, crashing the service, or showing confusing or technical error details that reduce trust and safety.

To meet this expectation, the organisation must clearly define what counts as invalid information for each relevant input, document exactly what the system should do next for each case, and ensure the system moves to a known, safe outcome with no harmful side effects. The organisation must keep this guidance up to date, assign named responsibility for maintaining and checking it, and test the system using the defined invalid cases to confirm that the real results match the documented responses.

Where automated features handle inputs, the organisation must verify they follow the same documented rules, and keep evidence such as test results and consistent log records showing predictable handling.

##### Invalid-input handling contract with known safe state tests

- Category: Software
- Priority: Critical

###### WHAT
Create and enforce an **Input Validation and Predictable Error Handling Agreement** for every information input in scope (starting from the base SI-10 input validation scope). For each **invalid input scenario**, the agreement must state the **exact response the system will give** and the **known safe next step** (meaning the system will not cause any unintended effects).

###### WHY (control requirement)
SI-10(3) requires proof that the system **responds in a predictable and documented way when it receives invalid inputs**. This ensures the system can **move to known, safe conditions** without adverse, unintended side effects. Invalid inputs are those related to the **information inputs the organisation defines under SI-10**.

###### HOW (specific steps/approach)
1. **List invalid input scenarios for each input field or parameter** in the agreement (for example: missing or blank, wrong data type, out of range, incorrect format, invalid allowed values, oversized content, unexpected characters). Keep this aligned to the SI-10 input validation scope.
2. For **each invalid scenario**, specify:
   - **Expected external response** (for example: HTTP status, application error code, and the message and field errors shown to the user).
   - **Expected internal behaviour** (for example: no database update, no workflow started, no change of state, no partial updates, and no actions that create side effects).
   - **Known safe next step** (for example: the request is rejected; the user session remains valid; the resource state does not change).
3. Use **fail-fast validation** at the earliest practical point (API gateway or middleware for APIs; server-side validation for websites; schema validation for message consumers) so invalid inputs are rejected **before** any actions that could change system state.
4. Add **side-effect protections** so validation failures cannot cause partial effects (for example: validate before starting transactions; use “all-or-nothing” behaviour with rollback; apply repeat-safe handling where relevant).
5. **Publish and version** the agreement in system documentation and security procedures, with a named owner responsible for keeping it up to date.
6. **Create automated negative tests** from the agreement (unit and integration tests) to confirm that real system behaviour matches the documented responses and that the system moves to the agreed safe state.
7. Ensure there is **operational evidence at runtime** for every failure path (for example: consistent error codes, correlation identifiers, and logs showing that no unintended side effects occurred).

###### WHO (role responsible)
- **Application Security Lead / Security Engineering**: owns the agreement template, reviews it, and defines the test approach.
- **Software Engineering Lead / Backend/API Engineers**: implement validation, side-effect protections, and correct error mapping.
- **QA/Test Engineering**: runs and maintains the negative test suite and captures the evidence.
- **System Owner**: ensures the agreement stays current through change control.

###### Acceptance criteria
- For every invalid input scenario defined within the SI-10 scope, the system returns the **documented response** (status/error code/message/field errors) and causes **no unintended side effects**.
- Automated tests exist and pass for all invalid scenarios, and evidence (test run identifiers and representative logs with correlation identifiers) shows consistent behaviour.
- The agreement is published, version-controlled, and has a named owner; changes to inputs trigger updates to the agreement and the matching updates to the tests.

###### Actions Required for Compliance

- [ ] Create an input validation and predictable error-handling agreement that covers all inputs within the scope of SI-10 and all listed invalid cases.
- [ ] For each invalid case, define the exact external response that should be returned and the known safe next step to move to, with no side effects.
- [ ] Carry out “fail-fast” checks as early as possible (at the gateway, middleware, or server) and translate any validation failures into the error codes and messages described in the contract.
- [ ] Add safeguards to prevent unintended effects: check inputs before starting transactions, ensure changes are rolled back as one unit if anything fails (atomicity), and stop workflow actions from running when inputs are invalid.
- [ ] Publish the contract using version control, and appoint a named owner who is responsible for updates through the change control process.
- [ ] Create and run automated negative unit and integration tests for every invalid case, and keep the test results and correlation identifier (correlation-ID) logs.


---

#### SI-10.4 — Timing Interactions (Enhancement)

This requirement is about making sure the system responds correctly when it receives bad or invalid information, even if different parts of the system send and receive messages at different speeds. The main risk is that one part may handle an error in the expected way, but another part—because it sees the timing of that error—could misunderstand what happened and take the wrong corrective action. For example, it might slow down or try again as if there were a network problem, rather than treating it as a bad request.

To meet this requirement, the organisation must:
- identify where invalid inputs arriving through any connection could affect timing and change how other parts handle errors;
- define the correct overall response for each type of invalid input;
- ensure the system selects that response using an approach that takes these timing effects into account;
- verify through testing that the behaviour remains correct across all connected components;
- document the approach and test results;
- assign named responsibility;
- update procedures and design records;
- keep relevant settings consistent; and
- include this approach in the system’s security plan.

##### Timing-interaction error classification across protocol stack

- Category: Manual
- Priority: High

###### WHAT
Create and apply a repeatable, documented analysis of how timing and interactions affect system behaviour. For each SI-10 invalid input (as defined by the organisation), define one correct overall system response. The analysis must also explain how timing and delays, and the spread of errors through the protocol stack, could cause other layers to misunderstand what happened.

###### WHY (control requirement)
SI-10(4) requires the organisation to “account for timing interactions among system components in determining appropriate responses for invalid inputs.” The guidance notes that timing effects across different protocol layers can change behaviour (for example, link-layer drops can lead TCP to take congestion-style actions). It also notes that an attacker may combine acceptable behaviours from multiple protocol layers to cause harmful outcomes.

###### HOW (specific steps/approach)
1. **List the protocol and interface boundaries for SI-10 invalid inputs**: For each interface where invalid inputs can enter (for example, application programming interface (API) gateway, web tier, message bus, load balancer, virtual private network (VPN)/edge, and any relevant transport or link boundaries), document the protocol stack layers involved and the downstream components that could react to delays, timing signals, or error signals.
2. **Define a cross-layer error “type” list and rules that must always hold**: For each invalid-input type, define (a) the outward response (for example, Hypertext Transfer Protocol (HTTP) 4xx status code and message body, connection close/reset/drop/quarantine behaviour, application error code) and (b) the internal classification signals that must be used so downstream components do not assume the wrong cause (for example, “invalid input” must not be reclassified as “congestion” or “network impairment”).
3. **Carry out the timing-interaction analysis using a repeatable method**: Identify which downstream mechanisms react to loss, delay, or timing (for example, retransmission timers, congestion-control triggers, rate limiters, web application firewall (WAF) or backoff logic, load balancer health checks, and client retry logic). Analyse how bursts of invalid inputs could change observed timing and therefore change downstream behaviour.
4. **Set “do-not-trigger” limits and decision rules**: Create clear constraints that stop invalid-input handling from causing the wrong downstream behaviours (for example, make sure invalid-input responses do not cause transport-layer effects that lead to congestion-style reactions; make sure retry and backoff logic is not activated as if the network were impaired).
5. **Apply the decision rules at the earliest practical point**: Put the mapping from invalid-input type → correct overall response and internal classification into the application gateway/WAF/API gateway/service middleware (or an equivalent control point). This ensures the same invalid input produces consistent behaviour regardless of timing or burst conditions.
6. **Update design records and the security plan**: Record the analysis method, assumptions, component interactions, and the test evidence plan in design documentation. Ensure the approach is reflected in the system security plan.

###### WHO (role responsible)
- **Application Security Architect / Security Engineering Lead**: owns the timing-interaction analysis method, error taxonomy, and invariants.
- **Solution/Platform Architect**: confirms the protocol stack boundaries and downstream component behaviours.
- **Application Gateway/WAF/API Gateway Engineers**: implement the decision rules.
- **Change Manager / Configuration Manager**: ensures design records and security plan updates are versioned and controlled.

###### Acceptance criteria
- For every SI-10 invalid input type, there is a documented mapping to a single correct outward response and internal classification that prevents downstream components from misunderstanding the event.
- The timing-interaction analysis explicitly identifies downstream mechanisms that react to loss and delay, and explains how invalid-input handling avoids triggering incorrect behaviours.
- The decision rules are implemented at the earliest practical boundary and are consistent across environments (for example, production and test) through controlled configuration.
- Design documentation and the system security plan include the analysis method, the rationale for component interactions, and references to the implemented rules.
- There is evidence that the analysis is repeatable (the same method is used across interfaces) and audit-ready (versioned records, named ownership).

###### Actions Required for Compliance

- [ ] Create an inventory of every interface and “protocol stack” component that can receive invalid input for SI-10, including any downstream components that could respond based on timing.
- [ ] Define an error category system that links each “SI-10 invalid input” type to the correct message sent to the outside world and to the required internal classification rules.
- [ ] Run a repeatable timing-and-interaction analysis to identify which downstream systems could mistake invalid-input timing as network congestion or a network problem
- [ ] Write “do not trigger” constraints and decision rules that stop invalid input handling from causing incorrect downstream behaviour.
- [ ] Put the decision rules in place at the earliest practical point in the process (for example, at the application programming interface (API) gateway, web application firewall (WAF), or service middleware) to ensure consistent behaviour when traffic arrives in bursts.
- [ ] Update the design records and the system security plan to include the analysis method, the assumptions used, and references to the rules that have been implemented.


---

#### SI-10.5 — Restrict Inputs to Trusted Sources and Approved Formats (Enhancement)

This requirement is about ensuring the system only accepts information from sources you explicitly trust, and only in file types you have approved. If it accepts data from unknown or unapproved sources, or in unexpected formats, attackers could insert harmful content, damage or corrupt your records, or trick the system into installing altered updates. This could cause operational disruption and lead to financial loss or reputational harm.

To meet this requirement, the organisation must keep a documented, up-to-date list of trusted sources. This includes DoD-approved public key infrastructure (PKI)-signed feeds, internal enterprise data services, and vendor updates from authenticated repositories that comply with International Traffic in Arms Regulations (ITAR) and Export Administration Regulations (EAR). The organisation must also keep a documented list of approved file formats, including comma-separated values (CSV), JavaScript Object Notation (JSON), and extensible markup language (XML), where XML files are checked against the required XML schema; portable document format, archive (PDF/A); and signed software packages such as Microsoft Installer (MSI) and Microsoft application installer (MSIX), where the checksum is verified.

The system must enforce these rules automatically. Named individuals must be responsible for oversight, the result of every input attempt must be recorded in audit logs, and the approach must be included in the system’s security plan, as well as its design and configuration documentation.

##### Enforce trusted-source and approved-format allow-lists at ingestion

- Category: Software
- Priority: Critical

###### WHAT
Set up an ingestion/update control that only accepts information from **trusted sources** and only when the content matches **approved formats**. This includes **XSD validation** for XML files and **PDF/A conformance** checks for PDF files. For signed software packages, it also includes **signature validation** and **checksum/hash verification**.

###### WHY (control requirement)
NIST SP 800-53 **SI-10(5)** requires limiting the use of information inputs to the organisation’s defined boundaries: **si-10.05_odp.01 (trusted sources)** and **si-10.05_odp.02 (formats)**. This lowers the risk of malicious activity by stopping untrusted origins and unexpected file/content types from reaching processing or installation steps.

###### HOW (specific steps/approach)
1. **Create and maintain allow-lists**
   - Trusted sources allow-list (si-10.05_odp.01) including:
     - **DoD-approved PKI-signed feeds**
     - **internal enterprise data services**
     - **vendor updates from authenticated ITAR/EAR-compliant repositories**
   - Approved formats allow-list (si-10.05_odp.02) including:
     - **CSV**
     - **JSON**
     - **XML (XSD-validated)**
     - **PDF/A**
     - **signed MSI/MSIX packages** with **checksum verification**
2. **Enforce at the point of ingestion/update**
   - Add a dedicated control component in front of every ingestion path (for example: API upload endpoints, scheduled feed collectors, message ingestion, and software update/staging services).
   - **Trusted source enforcement**: require strong proof of identity (for example: **mutual Transport Layer Security (mTLS)** client certificates, authenticated service principals, or signed feed identity). Then check that identity against the trusted-source allow-list and **reject anything not listed**.
   - **Format enforcement**: check the content type and perform detailed checks before any parsing or processing:
     - **XML**: validate against the required **XSD** before processing.
     - **PDF**: confirm **PDF/A conformance** and **reject non-conforming files**.
     - **JSON/CSV**: validate against the expected structure and encoding rules for the application’s schema, and **reject unexpected structures**.
   - **Software package enforcement** (for MSI/MSIX):
     - Require a valid signature chain that matches the expected trusted roots.
     - Verify the **checksum/hash** against an organisation-maintained expected value or signed manifest.
     - Only after these checks pass, forward the package to the deployment/staging pipeline.
3. **Make decisions auditable and consistent**
   - For every input attempt, record an audit entry including: input type, source identity, detected format, validation results (XSD/PDF-A/signature/checksum), decision (accept/reject), and a correlation ID.
4. **Operationalise through policy-as-code and controlled change**
   - Keep allow-lists and validation rules in version-controlled configuration (**policy-as-code**), with review and promotion through environments (development/test/production) under existing change management.

###### WHO (role responsible)
- **Application Security Engineer / Security Architect**: define enforcement requirements, validation rules, and audit entry fields.
- **Platform/Integration Engineer**: implement the ingestion/update enforcement control and integrate it with existing ingestion/update services.
- **Data/Update Owners (business or vendor management)**: approve and maintain trusted sources and expected checksum values/manifests.
- **Operations/SOC**: monitor audit logs and investigate repeated rejection patterns.

###### Acceptance criteria
- The system **rejects** any ingestion/update request where the source identity is not in the trusted-source allow-list (si-10.05_odp.01).
- The system **rejects** any payload where the format is not in the approved-format allow-list (si-10.05_odp.02).
- XML inputs are accepted only after successful **XSD validation**; PDF inputs are accepted only after successful **PDF/A conformance** checks.
- MSI/MSIX packages are accepted only when **signature validation** succeeds and the **checksum/hash** matches the expected value/manifest.
- For every accepted and rejected input attempt, the system generates an **audit record** with a correlation ID and the validation results.

###### Actions Required for Compliance

- [ ] Define and get approval for the trusted-source allow-list matching **si-10.05_odp.01**, including **public key infrastructure (PKI)-signed feeds** and **authenticated repositories that comply with International Traffic in Arms Regulations (ITAR) and Export Administration Regulations (EAR)**.
- [ ] Define and get approval for the approved-format allow-list that matches **si-10.05_odp.02**, including the required **XML schema definitions (XSDs)** and the **PDF/A compliance requirements**.
- [ ] Set up an ingestion and update control layer that verifies the identity of the data source and blocks any sources that are not on the approved (allow-listed) list.
- [ ] Perform deep format checks when data is first received (including XML schema validation using XSD and PDF/A compliance checks), and reject any files that fail these checks before any further processing.
- [ ] Set up Microsoft Installer (MSI) and Microsoft Installer eXtension (MSIX) enforcement so that files must pass signature validation and checksum or hash checks before they are prepared for installation or installed.
- [ ] Set up audit logs for every attempt to submit information (whether it is accepted or rejected, the source identity, the result of any checks, and the correlation ID) and ensure the logs are kept for the required period in line with security information and event management (SIEM) retention requirements.
- [ ] Put allow-lists and validation rules into version-controlled “policy as code”, and move changes through testing and live environments using controlled approvals.


---

#### SI-10.6 — Injection Prevention (Enhancement)

This requirement is about preventing harmful or accidental text from being inserted into the system in a way that changes what the system does or what it shows. Without these protections, someone could try to trick the system by sending untrusted information that the system treats as instructions. This could lead to unauthorised actions, damaged or incorrect records, or unsafe content being displayed to users.

To meet this expectation, the organisation must clearly state which specific inputs the system is allowed to use (as defined in its input-checking procedures). It must then make sure the system handles those inputs safely every time they are used—both when the inputs are used in commands and when they appear in outputs that another part of the system could interpret.

This means keeping data separate from instructions, and, where needed, converting risky characters so they are treated as plain text. The organisation must only accept these inputs from approved trusted sources and in approved formats. It must also document this approach in its policies, procedures, system design, and configuration settings, and keep audit records showing that the protections are working.

##### Enforce parameterised inputs and context-aware output escaping

- Category: Software
- Priority: Critical

###### WHAT
Put injection protection in place for every organisation-defined SI-10 information input by making sure it is **never used in a way that changes how commands or queries behave** (using parameterised interfaces), and by ensuring it is **safely displayed in any place where an interpreter could treat it as instructions** (using the right output escaping and encoding).

###### WHY (control requirement)
SI-10(6) requires: **"Prevent untrusted data injections."** The guidance says this is achieved by using **parameterised interfaces** (keeping data separate from code so injections cannot change meaning/behaviour) and/or **output escaping (output encoding)** (using the correct characters so the interpreter treats the content as data, not executable instructions). This must be applied to the **information inputs defined by the organisation in SI-10**.

###### HOW (specific steps/approach)
1. **Create an Injection Prevention Standard mapped to SI-10 inputs**: for each SI-10 in-scope information input, document the required handling for each usage situation (for example: database query, search/filter, command/execution interface, template rendering, HTML/JSON/XML responses, email content, and log/report display).
2. **Use parameterised interfaces for all command/query creation**: remove any string-building or dynamic query construction for in-scope inputs, and replace it with prepared statements, bound parameters, query-builder parameter binding, or command interfaces that take arguments separately.
3. **Apply context-aware output escaping/encoding**: use the correct escaping for each output type (for example: HTML escaping for web pages, JSON escaping for JSON responses, URL encoding for query strings, template-safe escaping for server-side rendering, and the right escaping for emails and reports).
4. **Add automated enforcement in CI/CD**: use security scanning (static application security testing) and code checks that stop merges when in-scope SI-10 inputs reach known injection “danger points” without parameterisation and/or without the required context-aware encoding.
5. **Add targeted tests using injection payloads**: create unit and integration tests that send realistic malicious inputs for each in-scope input, and confirm that (a) commands/queries run using bound parameters, and (b) outputs show escaped/encoded text rather than executable or interpreted instructions.
6. **Produce audit-ready evidence**: keep the results from build gates, test reports, and code review records showing that parameterisation and encoding were applied for each SI-10 in-scope input and its output context.

###### WHO (role responsible)
- **Application Security Lead / Secure Coding Champion**: owns the Injection Prevention Standard and the mapping to SI-10 inputs.
- **Software Engineers**: implement parameterised interfaces and context-aware escaping in application code.
- **DevOps/CI/CD Engineers**: implement CI/CD enforcement and keep evidence.
- **QA/Test Lead**: maintains the injection test cases and ensures they run in test pipelines.

###### Acceptance criteria
- For every SI-10 in-scope information input, there is documented handling for each usage context.
- All database/search/filter/command/query paths that use SI-10 inputs use parameterised interfaces (no concatenation-based approaches that change command/query behaviour).
- All interpreter-sensitive outputs that include SI-10 inputs apply the correct context-aware output escaping/encoding.
- CI/CD systems block code that routes SI-10 inputs to injection danger points without parameterisation and/or without the required encoding.
- Automated tests show that malicious inputs do not change command/query behaviour and are displayed as harmless text in outputs.
- Evidence (the standard, CI/CD gate logs, test reports, and code review records) is retained for audit.

###### Actions Required for Compliance

- [ ] Create an injection prevention standard that links each in-scope input covered by SI-10 to the required parameterisation or context-aware output encoding.
- [ ] Refactor all query and command building paths that use SI-10 inputs so they use prepared statements with bind parameters, or command interfaces that take arguments directly.
- [ ] Implement and standardise context-aware escaping and encoding functions for every type of output the application produces (HTML, JSON, XML, templates, email, and logs or reports).
- [ ] Set up continuous integration and continuous delivery (CI/CD) checks to stop code merges when inputs from SI-10 reach places where they could be executed (injection sinks) without proper parameter binding and/or the required encoding.
- [ ] Create automated unit and integration tests using realistic test inputs for each in-scope “SI-10” input, and confirm that the content is rendered harmlessly and that only safe, pre-defined parameters are used when the code runs.
- [ ] Store build gate results and test evidence to show, for audit purposes, that injection prevention controls are being enforced


---

### SI-11 — Error Handling (Control)

This requirement is about ensuring that when something goes wrong, the system clearly tells people what they need to do to fix the problem, without revealing information that could help someone attack it. Without this, error messages could expose how the system works, internal system clues, or sensitive personal or account information. They could also accidentally reveal secrets that users entered, which could make fraud or unauthorised access easier.

To meet this expectation, the organisation must design and configure error messages so they are clear and written in plain language for corrective action, while deliberately avoiding technical implementation details, passwords or other secrets, personal identifiers, payment details, and any business or operational information that should not be shown. Detailed error information must be shown only to authorised system administrators, the incident response team, and the information system owner. Everyone else must see only the safe, generic message.

##### Role-gated safe error messages with correlation IDs

- Category: Software
- Priority: Critical

###### WHAT
Implement a standard error-handling approach that gives most users **clear, actionable, generic error messages**, while providing **detailed error information** (for example, diagnostics) **only** to authorised recipients.

###### WHY (control requirement)
SI-11 (Error Handling) guidance requires error messages to be **shaped by organisational policy and operational needs**, and to ensure sensitive or exploitable information is not revealed. The guidance specifically warns against exposing **stack traces/technical implementation details**, **authentication mistakes** (for example, entering a password where a username is expected), **business or mission information inferred from errors**, **personal data (PII) and account/payment identifiers**, and **hidden communication channels**.

###### HOW (specific steps/approach)
1. **Define an error-message agreement** for the application/application programming interface (API) (for example, JSON response fields):
   - `message` (generic, safe for users)
   - `next_step` (high-level corrective action)
   - `error_category` (broad)
   - `correlation_id` (non-secret reference)
   - `debug_details` (only included when authorised)
2. **Control who can see details at the point errors are created or returned**:
   - If the caller is in the organisation’s authorised group—**authorised system administrators, the incident response team, and the information system owner**—include `debug_details`.
   - Otherwise, **remove `debug_details` completely** and ensure the user-facing response includes only the safe contract fields.
3. **Strengthen authentication error handling** to prevent account guessing and secret leakage:
   - Use the same generic message for invalid username and password.
   - Never repeat back user-supplied credentials or other secret-like inputs.
4. **Stop exploitable content in user-facing errors**:
   - Configure global exception handling to suppress stack traces, internal component names, database identifiers, SQL/trace output, and any PII/payment-like values.
   - Ensure error text does not change in a way that could act as a hidden communication channel (keep `message`/`error_category` broad and consistent).
5. **Log safely for investigation**:
   - Keep full diagnostic details on the server side (and/or in secure observability tooling) using the same `correlation_id`.
   - Redact secrets and PII in logs.
6. **Check with automated tests and live safeguards**:
   - Add continuous integration (CI) tests that fail the build if user-facing responses contain forbidden patterns (for example, `Exception`, `stack`, `trace`, `SQLSTATE`, `at `, internal hostnames, or credential-like strings).
   - Add security information and event management (SIEM) and monitoring rules to alert if forbidden patterns appear in responses.

###### WHO (role responsible)
- **Application owner / engineering lead**: implements the error contract and access control (gating).
- **Security architect / security engineering**: defines forbidden patterns, redaction rules, and checks that authorisation logic is correct.
- **Authorised system administrators / incident response team / information system owner**: confirm that authorised users receive the required diagnostic detail.

###### Acceptance criteria
- For unauthorised users, error responses contain only the safe contract (`message`, `next_step`, `error_category`, `correlation_id`) and **never** include stack traces, technical implementation details, PII/payment identifiers, or echoed secrets.
- For authorised recipients (authorised system administrators, incident response team, information system owner), error responses include `debug_details` and can be linked to server-side diagnostics using `correlation_id`.
- Automated tests and monitoring confirm that forbidden patterns do not appear in user-facing error payloads across representative endpoints (web, API, and authentication flows).

###### Actions Required for Compliance

- [ ] Define a user-safe error contract with the fields **message**, **next_step**, **error_category**, and **correlation_id**, and add a separate **debug_details** field that is only visible to authorised users.
- [ ] Set up a global error handler that hides technical details and stack traces from users when errors occur.
- [ ] Only return `debug_details` to authorised system administrators, the incident response team, and the information system owner by using role-based access control (RBAC).
- [ ] Update how authentication errors are handled so that the same generic message is used every time, and ensure that usernames, passwords, or any other secret-like information is never shown back in the response.
- [ ] Set up server-side logging to include a correlation identifier (correlation_id), and remove sensitive information—such as secrets and personal data (PII)—from the logs.
- [ ] Add continuous integration and continuous delivery (CI/CD) tests and security information and event management (SIEM) detection rules to block or alert on forbidden error-message patterns (for example: stack traces, trace logs, SQL output, personal data, or credentials being echoed).


---

### SI-12 — Information Management and Retention (Control)

This requirement is about making sure the organisation properly manages and keeps the information it stores in its systems, and the reports and other outputs those systems produce, for as long as the law and internal rules require—even after a system is switched off. Without this, important records could be deleted too early, key evidence could be lost, legal and regulatory duties could be breached, and the organisation may struggle to show what it did and when.

To meet this expectation, the organisation must:
- identify all retention rules that apply
- document clear policies for how stored information and system outputs are handled and kept throughout their full life cycle
- put practical procedures in place so staff follow these rules

It must also:
- keep the supporting records and documents that justify retention decisions
- assign named responsibilities for records, information handling, and privacy
- ensure retention requirements are maintained during system disposal or migration

##### Retention schedule mapping and enforced lifecycle for data/output

- Category: Software
- Priority: Critical

###### WHAT
Implement an auditable information management and retention capability that (1) identifies the retention requirements that apply to both information stored by the system and information produced as output from the system, (2) enforces those retention rules throughout the information’s full life cycle (including when the system is disposed of or migrated), and (3) keeps evidence showing that the organisation is complying.

###### WHY (control requirement)
The United States National Institute of Standards and Technology (NIST) SI-12 requires the organisation to **manage and retain information within the system and information produced as output from the system** in line with **applicable laws, executive orders, directives, regulations, policies, standards, guidance, and operational requirements**—including cases where retention continues **after the system is disposed of**. The guidance also notes that retained information may include administrative records, and that retention must cover the full life cycle.

###### HOW (specific steps/approach)
1. **Create a retention map (single source of truth):**
   - Create a retention schedule that links **record types** (including administrative records that support retention decisions) and **system output types** (for example, reports/exports created by the application) to: retention period, what happens to the information next (disposition), the legal or policy reason, and the applicable scope (for example, production/test/disaster recovery if relevant).
2. **Apply classification and retention tagging when information is created:**
   - Ensure the application (or its storage/archiving gateway) adds retention information at the moment data is created or produced (for example, when a record is ingested, when an export/report is generated, and when logs/events are produced).
3. **Enforce retention using storage and archiving life-cycle controls:**
   - Set up storage life-cycle and records management so items are kept for the required time, moved to an approved records repository when needed, and only disposed of according to the schedule.
   - Ensure backup, replication, and disaster recovery retention minimums match the schedule (i.e., backups are not kept for a shorter time than required for the underlying information).
4. **Enforce retention for system outputs:**
   - Send system outputs (exports/reports/datasets) into a controlled archiving process that applies the same retention information and disposition rules as the original record type.
5. **Keep retention during disposal or migration:**
   - Before decommissioning or migrating the system, carry out a transfer step that preserves retention: check retention tags, transfer eligible records/outputs to the approved repository, complete legal-hold checks and handle exceptions, and record disposition evidence (transfer logs, checksums/hashes where supported, and approvals).
6. **Keep audit-ready evidence:**
   - Store evidence that retention rules were applied (for example, life-cycle job runs, disposition events, legal-hold/exception approvals, and transfer logs) in a tamper-evident way, with access limited to authorised roles.

###### WHO (role responsible)
- **Information Security / Service Integration and Management (SIAM) Lead (Accountable):** owns the SI-12 compliance approach and evidence requirements.
- **Application Owner / Engineering Lead (Responsible):** implements retention tagging at creation time and routes outputs correctly.
- **Records Management / Governance (Responsible):** provides the retention schedule and the reasons for disposition.
- **Cloud/Infrastructure Engineer (Responsible):** configures storage life-cycle, aligns backup/disaster recovery, and sets up archiving pipelines.
- **Compliance/Audit Liaison (Responsible):** checks that audit evidence is complete and supports audit readiness.

###### Acceptance criteria
- A documented retention schedule exists that covers **both system-held information and system outputs**, including administrative records that support retention decisions.
- The application (or its integration layer) applies retention information at the time of creation/production for all in-scope information and outputs.
- Storage and archiving life-cycle rules enforce retention periods and disposition actions exactly as stated in the schedule, including alignment with backup/disaster recovery retention.
- System outputs are captured in a controlled archiving pipeline with retention enforcement and disposition.
- During disposal or migration, a retention-preserving transfer process is carried out and produces auditable evidence (transfer/disposition logs and approvals).
- Evidence is kept and can be accessed by authorised auditors/roles for the required retention period.

###### Actions Required for Compliance

- [ ] Create a retention schedule that links each type of record and each type of system output to the required retention period, what action to take when that period ends, and the legal or policy reason for doing so.
- [ ] Add retention tags at the time of creation for all in-scope information stored by systems and for all generated outputs.
- [ ] Set up storage and archiving rules so that information is kept for the required time and then disposed of according to the retention information (metadata).
- [ ] Route system outputs (exports, reports, and datasets) into a controlled archive process that applies the same retention rules.
- [ ] Make sure backup and disaster recovery (DR) retention settings match the required retention periods or are longer.
- [ ] Set up and run a transfer process that keeps records for the required retention period when disposing of or migrating systems, including checks for legal holds and capturing evidence.
- [ ] Store and protect records that show retention rules were enforced, including lifecycle, disposal, and transfer logs and approvals, in an authorised way that makes any tampering evident.


---

#### SI-12.1 — Limit Personally Identifiable Information Elements (Enhancement)

This requirement is about keeping personal information to the minimum needed. Across the entire journey of the data, the organisation should only collect, use, store, share and finally delete the specific types of personal information listed below: name, a government-issued identifier, date of birth, biometric data, financial account number, and health information.

This matters because holding extra personal information that is not truly needed increases the risk of privacy harm, misuse, or costly security breaches—especially when data is copied, shared, or kept for longer than necessary.

To meet this expectation, the organisation must clearly define and document which types of personal data are allowed, build these limits into its internal rules and day-to-day processes, and ensure the same limits apply from the moment information is created or collected through to sharing and deletion. It must also keep an up-to-date inventory and map of what personal data it processes, record and review checks showing that the limits are followed, and ensure its retention and deletion practices remove or destroy any personal data that is not on the allowed list, in line with applicable laws and its own privacy assessments.

##### Enforce allowed PII elements via schema/API validation and quarantine

- Category: Software
- Priority: Critical

###### WHAT
Put in place a strong technical control so the application can only collect, use, store, maintain, share, disclose, and dispose of the specific personal information elements that are explicitly allowed: **name, government-issued identifier, date of birth, biometric data, financial account number, and health information**. Any attempt to add other personal information elements is **rejected or placed in a quarantine area** and cannot be saved or exported.

###### WHY (control requirement)
The National Institute of Standards and Technology (NIST) Special Publication (SP) 800-53 **SI-12(1)** enhancement requires limiting personal information handled through the full information life cycle to the set defined by the organisation in **param: si-12.01_odp**. This lowers privacy risk by stopping unnecessary personal information from entering the system at any stage (creation/collection, use/processing, storage/maintenance, sharing/disclosure, and disposal).

###### HOW (specific steps/approach)
1. **Create an official “personal information element allow-list”** that contains exactly the six elements from **si-12.01_odp**, and publish it as the application’s single source of truth.
2. **Enforce at collection and user interface**: remove or disable any non-approved personal information fields in web and mobile forms and onboarding steps. If older systems capture free text, send it through a controlled “unstructured data” process that removes or redacts personal information fields before anything is saved.
3. **Enforce at integration and application programming interface (API)**: add request and response checks at the API gateway (or service layer) using an allow-list of permitted personal information field names and types. Reject any payload that contains non-approved personal information fields and record the attempt.
4. **Enforce at storage**: make sure regulated datasets only include columns or attributes that match the six allowed elements (for example, through database structure rules and/or data model checks). Non-approved personal information must not be saved. Instead, store it only in a restricted quarantine area with access controls and a documented process for exceptions.
5. **Enforce during processing, extract-transform-load (ETL), and exports**: configure data pipelines to remove or quarantine non-approved personal information fields during intake, transformation, and replication. Restrict reporting and export templates to allowed fields only, and prevent exports that include non-approved personal information.
6. **Create audit evidence**: produce audit logs that show allow, deny, or quarantine decisions at each enforcement point (dataset, service or user identity, time, and the field-level outcome) so compliance can be demonstrated.
7. **Handle exceptions clearly**: if business or legal needs require additional personal information elements, require a documented exception approval supported by privacy and risk assessment evidence, and update the allow-list only through that controlled process.

###### WHO
- **Application Owner / Product Owner**: responsible for implementing the allow-list enforcement in application workflows.
- **Security Engineering / Privacy Engineering**: define the enforcement rules, exception criteria, and what audit evidence is required.
- **Data Engineering / Platform Team**: implement the schema, ETL, export enforcement, and quarantine mechanisms.
- **API/Integration Team**: implement the gateway or service validation.
- **Information Governance / Data Protection Officer (where applicable)**: approves exceptions and confirms that any deviation is justified.

###### Acceptance criteria
- The application **cannot save** any personal information element outside the six allowed elements from **si-12.01_odp** (confirmed through negative testing and checks of database, ETL, and exports).
- API, user interface, and integration tests show that non-approved personal information fields are **rejected or quarantined** and do not appear in production datasets or exports.
- Audit logs exist for enforcement outcomes (allow/deny/quarantine) with enough detail to support review.
- An exception process exists, and any expansion of the allow-list can be traced back to approved privacy and risk assessment evidence.

###### Actions Required for Compliance

- [ ] Define and publish the official personal data (PII) element allow-list, containing exactly the six elements from `si-12.01_odp`.
- [ ] Remove or disable any non-approved personal data (PII) fields in all customer-facing data collection forms and onboarding steps.
- [ ] Set up API gateway and service checks to block requests that include non-approved personal data (PII) field names or data types.
- [ ] Limit database and data models so only approved personal data (PII) fields can be stored. Send any other fields to a restricted quarantine area.
- [ ] Update the extract, transform and load (ETL) and streaming pipelines and the export and reporting templates to remove or quarantine any non-approved personal data (PII) elements, and block any exports that include them.
- [ ] Set up audit logging at the level of individual data fields to record the decisions to allow, deny, or quarantine data across collection, integration, storage, processing, and export.
- [ ] Set up an exception process that requires approved privacy and risk assessment evidence before any allow-list change is made.


---

#### SI-12.2 — Minimize Personally Identifiable Information in Testing, Training, and Research (Enhancement)

This expectation is about making sure that when staff test systems, practise skills, or carry out research, they do not unnecessarily use real personal information about people. Without this, sensitive details such as names, contact details, or account numbers could be exposed, misused, or accidentally shared, causing real privacy harm and potential legal and reputational damage.

To meet this expectation, the organisation should use privacy-protecting approaches such as removing identifying details, replacing them with codes, replacing direct identifiers with tokens, and using artificial data that behaves like real data. It should also only allow access to datasets that have been formally approved for testing, training, or research.

For testing, synthetic data should be the default, with coded replacements used only when realistic behaviour is needed, and access should be limited to the minimum required. For training, the organisation should use synthetic or de-identified datasets, remove direct identifiers, pseudonymise personal fields, and restrict downloads so only authorised users can obtain them for approved purposes.

##### Automated privacy-minimised datasets for testing/training/research

- Category: Software
- Priority: Critical

###### WHAT
Implement an automated “privacy-minimised dataset factory” that creates research, testing, and training datasets only from approved sources. The factory must apply privacy-protecting methods—such as removing identifying details (de-identification), replacing identities with consistent substitutes (pseudonymisation), replacing identifiers with tokens (tokenisation), and/or using made-up but realistic data (synthetic data)—as defined by the organisation.

###### WHY (control requirement)
The National Institute of Standards and Technology (NIST) security control SI-12(2) enhancement requires: “Use the following techniques to minimize the use of personally identifiable information for research, testing, or training: {{ insert: param, si-12.2_prm_1 }}.” The guidance also expects methods such as de-identification or synthetic data, and using personally identifiable information (PII) only when it is truly needed.

###### HOW (specific steps/approach)
1. **Define and enforce the approved techniques** from `si-12.2_prm_1`: de-identification, pseudonymisation, tokenisation, and synthetic data. Also enforce “restrict access to approved test datasets only”.
2. **Create a dataset catalogue** that lists candidate source datasets and records whether they include direct identifiers (for example, names, contact details, or account numbers). It must also record whether each source dataset is approved for use in downstream outputs.
3. **Build a dataset factory pipeline** that produces three types of outputs, each with different default privacy transformations:
   - **Testing**: use synthetic data by default; pseudonymise where realism is needed; tokenise identifiers; keep relationships consistent by using the same tokenisation approach within the dataset.
   - **Training**: use synthetic or de-identified datasets; pseudonymise personal fields; remove direct identifiers.
   - **Research**: de-identify or pseudonymise data; tokenise direct identifiers; optionally use synthetic versions where direct identifiers are not required.
4. **Add automated validation checks before publishing outputs**:
   - Confirm there are no direct identifiers using dictionary and pattern (regular expression) checks, plus data dictionary rules.
   - Confirm tokenisation is consistent (for example, the same mapping within a dataset version).
   - Apply basic “re-identification risk” checks (for example, uniqueness thresholds) and stop publishing if thresholds are exceeded.
5. **Enforce dataset-level approval and controlled export/download**:
   - Allow access only to the factory outputs (not the raw personal source datasets) using the principle of least privilege and workload identity.
   - Require explicit permission for export/download and record all access and exports.
6. **Label each output with metadata** showing the technique used (for example, synthetic/pseudonymised/tokenised), the transformation version, and the approval reference. This allows auditors to see which methods were applied.

###### WHO (role responsible)
- **Data Protection Officer / Privacy Lead**: approves the technique rules and validation thresholds.
- **Data Engineering Lead**: builds the dataset factory and the validation checks.
- **Security Architect**: ensures dataset-level access control, logging, and export controls match the organisation’s identity and access management and least-privilege approach.
- **Application Owner / Research/Test Lead**: requests datasets by purpose (research/testing/training) and uses only approved factory outputs.

###### Acceptance criteria
- For each research/testing/training request, the system provides a dataset created by the factory and labelled with the technique(s) used.
- Automated validation prevents publishing datasets that contain direct identifiers for training and blocks outputs that fail re-identification risk checks.
- Users for testing/training/research are not given access to raw personal source datasets; they can access only approved factory outputs.
- All dataset access and export/download events are logged and linked to an identifiable user or service identity.

###### Actions Required for Compliance

- [ ] Define and publish the approved privacy-minimisation methods and the default settings that are specific to research, testing, and training.
- [ ] Register all candidate datasets in a data catalogue, and record which sources are approved for loading into the factory system.
- [ ] Set up the dataset factory pipeline to produce outputs tailored to specific purposes, using de-identification, pseudonymisation, tokenisation, and synthetic data.
- [ ] Add automated checks to stop any outputs that include direct identifiers, and to ensure tokenisation is consistent.
- [ ] Apply access controls at the dataset level so research, testing, and training users can only access factory outputs that have been approved.
- [ ] Set up controlled export and download of datasets, allowing only authorised users with clear permissions, and record every dataset access and export in an audit log.
- [ ] Add technical details and approval references to every published version of each dataset so you can trace changes for audit purposes.


---

#### SI-12.3 — Information Disposal (Enhancement)

This requirement is about making sure information is properly wiped, destroyed, or erased once it is no longer needed, so it cannot be recovered later. Without this, old files, copies, archived records, and even system logs could be exposed through discarded computers, returned devices, or reused storage. This creates risks to privacy and could lead to fraud, complaints, or regulatory action.

The organisation must set out and follow approved disposal methods for each type of information and storage. This includes:
- securely wiping or using cryptographic erasure for stored data
- using certified sanitisation for storage media
- using degaussing and authorised physical destruction (such as shredding or incineration) for magnetic media
- using cryptographic erasure by destroying encryption keys (and overwriting where applicable)

Disposal must only take place after the retention period ends. It must cover originals, copies, archives, and logs, and it must be overseen by named responsible staff. The organisation must keep clear records showing what was disposed of, when, and how, with evidence that can be traced back to audits.

##### Automate end-of-retention sanitisation with media-appropriate methods

- Category: Software
- Priority: Critical

###### WHAT
Set up an automated, auditable process for disposing of, destroying, or erasing information once the retention period ends. Use organisation-approved, media-appropriate methods for **stored data** and **physical media** (including system logs that may contain personal data).

###### WHY (control requirement)
The National Institute of Standards and Technology (NIST) security control SI-12(3) enhancement requires: “Use the following techniques to dispose of, destroy, or erase information following the retention period: {{ insert: param, si-12.3_prm_1 }}.” This enhancement expects approved sanitisation methods to be applied **after** the retention period ends, and to cover originals, copies, archived records, and logs.

###### HOW (specific steps/approach)
1. **Map disposal methods to each media and data type** in the organisation’s sanitisation standard, using the approved methods in **si-12.3_prm_1**: secure wipe (NIST 800-88), cryptographic erasure, degaussing, physical destruction (shredding/burning), and certified media sanitisation.
2. **Create policy-as-code rules** that trigger disposal only when the retention window for each information class ends (including backups/snapshots where retention applies, and log retention in the security information and event management (SIEM) system/log platform).
3. **Implement automated sanitisation execution** for IT storage and endpoints:
   - For encrypted stored data: carry out **cryptographic erasure** by destroying encryption keys (and overwrite where applicable, in line with NIST 800-88).
   - For unencrypted or partially encrypted stored data: carry out **secure wipe** in line with NIST 800-88.
   - For removable media and any storage media that needs physical handling: send to a certified sanitisation process or destruction service that performs **certified media sanitisation** or **physical destruction** (shredding/burning), and records proof.
   - For magnetic media types: ensure **degaussing** is used where applicable, or send for physical destruction.
4. **Create tamper-evident disposal proof for each asset/object at the time the action runs**: asset identifier(s), information class, retention expiry date/time, chosen method, execution date/time, operator/automation identity, and sanitisation result (success/failure plus reason).
5. **Reconcile and audit**: regularly compare the list of eligible items (based on retention rules) against completed sanitisation jobs and the evidence repository. Raise alerts for exceptions (items missed after retention expiry, failed jobs, or unsupported media types).
6. **Ensure system log coverage**: apply the same end-of-retention disposal process to log stores/archives (including logs containing personal data), so that log retention expiry leads to erasure/destruction using the approved methods.

###### WHO (role responsible)
- **Information Security / Data Protection Lead**: owns the sanitisation standard and the mapping of methods.
- **Infrastructure/Platform Engineering**: implements the automated disposal process and the integrations with storage/endpoint platforms.
- **SIEM/Logging Platform Owner**: ensures log retention expiry triggers sanitisation/erasure for log stores and archives.
- **IT Asset Management (ITAM) / Operations**: keeps an accurate media inventory and supports handling of exceptions.
- **Internal Audit / Compliance**: checks that evidence is complete and that reconciliation results are correct.

###### Acceptance criteria
- For each information class and media type, the workflow selects only methods from **si-12.3_prm_1**, and applies them **only after** retention expiry.
- System logs (including those containing personal data) are disposed of/erased using the same end-of-retention workflow.
- For every completed disposal action, there is tamper-evident evidence that includes: asset/object identifier, retention expiry basis, method used, timestamps, and execution identity.
- Reconciliation reports show no eligible items remain undisposed beyond the retention expiry window without explanation.
- Exceptions (unsupported media types, failed sanitisation, missing evidence) are detected and fixed with documented corrective actions.

###### Actions Required for Compliance

- [ ] Publish a media and data sanitisation standard that links each data class to only the approved techniques listed in **si-12.3_prm_1**.
- [ ] Set up automated “policy-as-code” rules that automatically end retention and delete stored data, backups and snapshots (where applicable), and system log records stored or archived.
- [ ] Link the disposal process with IT asset management (ITAM) and inventory, so every eligible asset or item has the correct media type and encryption status.
- [ ] Set up automated sanitisation so that encrypted data is removed using cryptographic erasure, and non-encrypted data is removed using secure wipe. For any storage media that must be handled, use certified sanitisation or physical destruction.
- [ ] For each disposal job, enable tamper-evident evidence capture, including: identifiers, the technique used, the basis for when retention expires, timestamps, the identity of the person or system that carried out the job, and the job outcome.
- [ ] Carry out regular checks to reconcile eligible items against completed items, and fix any exceptions by taking corrective actions that are recorded in writing.


---

### SI-13 — Predictable Failure Prevention (Control)

This requirement is about stopping security equipment from failing in a predictable, planned way, rather than letting it fail unexpectedly. If key security parts—such as network firewalls, intrusion monitoring sensors, authentication servers, virtual private network (VPN) gateways, key-handling modules, and log-collecting agents—stop working earlier than expected, the organisation could lose protection, be unable to confirm who users are, stop secure connections, or lose important records. This risk is especially relevant across different environments, including on-premises systems and mixed information technology (IT) and operational technology (OT) zones.

The organisation must measure how long each of these components typically lasts in its installed environment. Using those results, it must replace any component when its average time to failure falls below 12 months. It must also keep pre-approved spare replacement units on standby and switch between the working unit and the standby unit in a way that keeps the system’s current operating state unchanged, so safety, day-to-day availability, and security functions are not reduced.

The organisation must document how this will be done, assign named responsibilities, keep its design and configuration records up to date, and keep audit records of the measurements and replacement decisions, including in the system’s security plan.

##### MTTF-based replacement and state-preserving failover for security components

- Category: Manual
- Priority: Critical

###### WHAT must be done
Set installation-specific “time to failure” (MTTF) targets for security-capable parts of the system. If monitoring shows that a component’s measured MTTF in the real installed environment drops below the organisation’s agreed threshold (**12 months**, as stated in SI-13_odp.02), replace the working (active) unit with a pre-approved standby unit. Make sure the switch keeps the system’s important operating information (system state variables) and does not reduce safety, day-to-day operational readiness, or security capabilities.

###### WHY (control requirement)
SI-13 is designed to prevent predictable failures in components that provide security functions. It requires:
- failure rates based on the organisation’s actual installation conditions (not vendor averages),
- clear rules for when to swap active and standby units,
- assurance that the switch does not harm safety, operational readiness, or security,
- preservation of system state variables during the switch.
Standby units must be ready to take over, except when they are unavailable due to maintenance or recovery work already in progress.

###### HOW (specific steps/approach)
1. **Define scope and environments**: Create an inventory of the “system components” covered (at minimum: network firewalls, intrusion detection and prevention sensors, authentication servers, virtual private network (VPN) gateways, key management and hardware security module (HSM) modules, and log collection agents). Cover both on-premises and mixed information technology (IT) and operational technology (OT) zones (SI-13_odp.01). For each component type, define the environments used to measure MTTF (for example: IT demilitarised zone (DMZ), OT DMZ, IT/OT connections, high availability (HA) pair role, and maintenance/recovery modes).
2. **Measure installation-specific MTTF**: Collect reliability information for each component instance and environment to calculate MTTF using failure events that match the organisation’s installation (for example: complete service outage, security-service unavailability, or security-relevant degraded states defined by the organisation). Do not count planned maintenance periods as failures, and label recovery/maintenance downtime so it is not incorrectly treated as component failure.
3. **Apply the substitution rule**: Use a written decision rule that triggers a swap when the measured MTTF for a component in its installed environment falls below **12 months** (SI-13_odp.02). Apply the rule for each component instance (or for a pre-defined group of equivalent components) and for each environment.
4. **Maintain pre-qualified standby units**: For each component type, pre-approve standby replacements (hardware/software images, configurations, and certificates/keys where relevant) and keep them available at all times, except when maintenance or recovery work is already in progress.
5. **State-preserving active/standby switch**: Put the failover (automatic takeover) mechanism in place and test it so that system state variables are preserved during the switch (for example: session continuity where supported for VPN/authentication; preservation of security-relevant configuration and operating status; log agent buffering/continuity to prevent data loss). Confirm that failover does not reduce safety, operational readiness, or security capabilities.
6. **Record evidence and update the security plan**: Keep audit-ready records of how MTTF was calculated, the decisions to swap components, and the results of tests showing state preservation and failover performance. Ensure the approach and evidence are reflected in the system’s security plan and supporting design/configuration records.

###### WHO (role responsible)
- **Security Engineering Lead / Reliability Engineering Lead**: owns the MTTF approach, applies the substitution criteria, and sets evidence standards.
- **Infrastructure/Platform Engineering (IT/OT)**: implements monitoring/telemetry, high availability (HA) and failover coordination, and ensures standby readiness.
- **System Owner / Authorising Official (or delegated governance)**: ensures the approach is documented, approved, and included in the system security plan.
- **OT Safety/Operations Representative (where applicable)**: checks that failover switching does not harm safety or operational readiness in OT settings.

###### Acceptance criteria
- The organisation has an approved list of the covered “system components” and defined operating environments (including on-premises and mixed IT/OT zones).
- For each covered component instance (or equivalence class), MTTF is calculated using installation-specific failure events and is kept as auditable evidence.
- A swap is triggered when **MTTF < 12 months** for the component in its installed environment, and the swap actions are recorded.
- Pre-qualified standby units are kept available and can be shown to be ready (except during maintenance/recovery already in progress).
- Active-to-standby switching preserves the required system state variables, supported by test evidence showing no compromise to safety, operational readiness, or security capabilities.
- All MTTF calculations, swap decisions, and failover/state-preservation test results are documented and included in the system security plan.

###### Actions Required for Compliance

- [ ] Create and get approval for an inventory of “system components” under SI-13 (firewalls, intrusion detection and prevention system (IDS/IPS) sensors, authentication servers, virtual private network (VPN) gateways, key management hardware security module (HSM) modules, and log collection agents), and map them to the information technology (IT) and operational technology (OT) environments.
- [ ] Set the failure-event rules and the mean time to failure (MTTF) calculation method for each component type and environment, including exclusions for planned maintenance.
- [ ] Document the replacement decision rule: replace the asset when the measured mean time to failure (MTTF) in the installed environment falls below 12 months.
- [ ] Arrange advance approval for standby replacement units (including any required configuration documents) and set expectations for how available standby should be, including any exceptions for maintenance and recovery.
- [ ] Define and document the requirements for transferring from an active system to a standby system without losing information, and list the specific state information (state variables) that each type of component must keep.
- [ ] Run and record failover and service-continuity tests to show that safety, day-to-day operations, and security capabilities are not affected.
- [ ] Keep audit-ready records of mean time to failure (MTTF) measurements, any replacement decisions, and the results of failover tests, and make sure they are included in the system security plan.


---

#### SI-13.1 — Transferring Component Responsibilities (Enhancement)

This requirement is about not waiting for a key part of a service to fail before switching to a backup. It ensures that, when a part is likely to wear out, the organisation moves its work to a replacement part and takes the original part out of service no later than 80% of its expected working life. This helps prevent important work from slowing down or stopping unexpectedly.

Without this, the organisation risks poorer performance, loss of service, and expensive emergency fixes if a part fails earlier than expected.

To meet this expectation, the organisation must:
- set a clear rule for the 80% timing
- identify suitable replacement parts for each main part
- transfer responsibilities before the original part is removed
- document the approach in relevant policies and step-by-step procedures
- keep design and configuration records showing that replacements are ready
- keep audit records of when responsibility transfers and removals took place
- assign named people to manage and carry out the process
- use practical automated or manual methods that can trigger the switch in time

##### MTTF-based responsibility transfer with T80 failover runbook

- Category: Software
- Priority: Critical

###### WHAT
For each main system component that supports critical business activities, move its responsibilities to an approved replacement component in advance, and take the main component out of service **no later than 80% of its mean time to failure (MTTF)**.

###### WHY (control requirement)
The United States National Institute of Standards and Technology (NIST) Special Publication (SP) 800-53 **SI-13(1)** (enhancement) requires that components are taken out of service by moving responsibilities to a replacement component **no later than {{ insert: param, si-13.01_odp }} of mean time to failure**. The organisation-defined parameter **si-13.01_odp** is set to **80% of MTTF**, so the responsibility handover and removal must be planned and carried out by **T80 = 0.8 × MTTF**.

###### HOW (specific steps/approach)
Set up an auditable and repeatable process that (1) calculates a T80 deadline for each component, (2) identifies and pre-approves replacement components that can take over, and (3) starts a controlled handover and removal process at the T80 deadline.

1. **Create an MTTF register and calculate T80 deadlines**
   - For each main component type (for example: application node, database instance, message broker, network appliance), record the MTTF value, the basis/method used for the calculation, and the component instance start-of-life date/time.
   - Calculate and store **T80 = start-of-life + 0.8 × MTTF** (or the equivalent “no later than 80% of MTTF” deadline).

2. **Define what “responsibility transfer” means for each component**
   - Describe what it means to transfer responsibilities (for example: failover of a service endpoint, promoting a standby database, rerouting traffic to a redundant path, enabling an alternate controller/worker pool).
   - Define the checks that confirm the replacement component has taken over (for example: health checks, service level objective/service level agreement thresholds, replication caught up, control-plane status OK).

3. **Pre-approve replacement components and readiness requirements**
   - For each main component, link it to one or more replacement components.
   - Ensure replacements are set up to take over responsibilities (for example: standby instances, redundant routing, replicated storage), and confirm readiness before any T80 trigger.

4. **Set up an automated or reliably executed trigger at/before T80**
   - Use monitoring and telemetry, plus a scheduler, to assess component ageing and raise an event at **T80** (optionally earlier than T80 to allow for operational lead time).
   - The event must start a controlled workflow that: (a) transfers responsibilities to the replacement, (b) confirms the transfer worked, and only then (c) removes the main component from service.

5. **Keep audit evidence for timing and actions**
   - Maintain tamper-resistant records showing: the inputs used to calculate T80, the trigger time, the transfer start time, the transfer completion time, the verification results, and the time the main component was removed.
   - Keep evidence to show the transfer and removal happened **no later than 80% of MTTF**.

6. **Governance and responsibilities**
   - Name accountable owners for: maintaining the MTTF register (reliability/engineering), approving replacement mappings (architecture/operations governance), and carrying out the handover/removal workflow (operations/platform team).
   - Define escalation and contingency steps if the replacement is not available at the trigger time (for example: start incident/change escalation and apply compensating controls).

###### WHO
- **Reliability/Engineering lead**: maintains the MTTF register and T80 calculations.
- **Architecture/Operations governance**: approves replacement mappings and the responsibility-transfer definitions.
- **Platform/Operations team**: carries out the handover/removal workflow and performs the acceptance checks.
- **Security/Compliance**: checks that the evidence is sufficient and that audit record retention meets organisational requirements.

###### Acceptance criteria
- For each in-scope main component, there is a documented replacement mapping and a defined responsibility-transfer procedure.
- For each component instance, the organisation can produce **T80** evidence based on **si-13.01_odp = 80% of MTTF**.
- During testing or a controlled exercise, the workflow transfers responsibilities and removes the main component from service **no later than the T80 deadline**.
- Audit logs show timestamps for the trigger, transfer, verification, and removal, and evidence is kept for audit review.
- Replacement readiness checks and acceptance criteria are clearly met before the main component is removed.

###### Actions Required for Compliance

- [ ] Create and keep a register for mean time to failure (MTTF) for each primary component type. For each component, record the start date of its first use (start-of-life) and the target deadline for reaching 80% of its mean time to failure (T80).
- [ ] Define and document the process for transferring responsibility from each primary role to its substitute, including the acceptance checks for every primary-to-substitute mapping.
- [ ] Arrange substitute components in advance, pre-approve them, and confirm they are ready for use (their health, configuration, and ability to take over responsibilities).
- [ ] Set up an automated, scheduled trigger that starts the transfer process at or before each component’s T80 deadline.
- [ ] Carry out a controlled handover of responsibilities, confirm that the replacement has taken over, and only then take the original system or person out of service.
- [ ] Record permanent (unchangeable) audit evidence with timestamps for the data used to calculate T80, the trigger time, the start and completion of the transfer, the verification results, and the primary removal.


---

#### SI-13.3 — Manual Transfer Between Components (Enhancement)

This requirement is about moving a system from its main working part to its backup part before the main part is likely to fail, based on how long it normally lasts. If the organisation keeps using the main part until it is close to its expected failure point, a predictable failure could interrupt services, cause delays, or result in the loss of important work.

To meet this expectation, the organisation must describe this approach in its system documentation and procedures. It must use a clear trigger point: switch at 90% of the component’s mean time to failure (for example, if a component is expected to last 100 days on average, the switch should be started after 90 days).

Staff must:
- calculate the exact trigger time for each relevant component
- carry out the switch using a manual, human-led step between the designated active (main) and standby (backup) components
- follow a documented method for doing this

The organisation must also:
- assign named people to manage the timing and perform the switch
- keep evidence of the active/standby arrangement and the related settings
- record when each manual switch was started and the reason it was started at the 90% point

##### 90% MTTF manual transfer trigger with runbook and audit evidence

- Category: Manual
- Priority: High

###### WHAT
Manually start transfers between each designated active and standby component when the active component has been in use for **{{ insert: param, si-13.03_odp }} of the mean time to failure (MTTF)** (percentage defined by the organisation; default **90%**).

###### WHY (control requirement)
The NIST SI-13(3) enhancement requires that transfers are **manually started** at the specified point in the component’s reliability life (for example, **after 90 days if MTTF is 100 days**, and the organisation-defined percentage is 90%). This helps prevent predictable failures from causing avoidable service disruption.

###### HOW (specific approach)
1. **Identify active/standby pairs** in the system design (for example, load balancer virtual IP (VIP) to standby node, database primary/replica promotion, or redundant network service endpoints). Document which component is treated as “active” and which is “standby” for the transfer.
2. **Set the MTTF source and calculation basis** for each active/standby pair (vendor reliability data, engineering estimates, or a reliability model). Record the assumptions and the MTTF value used.
3. **Calculate the manual transfer trigger time** for each active/standby pair as:
   - `trigger_time = active_component_start_time + (si-13.03_odp × MTTF)`
   - Use the organisation-defined parameter `si-13.03_odp`, set to **90 percent** (unless the organisation changes it).
   - Define and document what counts as the “active_component_start_time” (for example, the time the last manual transfer finished, or the deployment/activation time) so the trigger can be repeated reliably.
4. **Create a runbook for manual transfer** for each active/standby pair, including:
   - The exact manual steps to transfer from active to standby (and any required routing/VIP changes)
   - Checks to confirm the service is working (service health, connectivity, and application-level checks)
   - Backup/contingency steps if standby promotion/activation fails
   - Safety constraints (maintenance windows, change approvals, and any required coordination)
5. **Schedule and track due transfers** using an operational calendar or ticketing process that shows the calculated `trigger_time` and links to the correct runbook and component pair.
6. **Carry out the transfer manually** at or before the calculated trigger time by an authorised operator.
7. **Keep audit evidence** for each manual transfer, including:
   - Time the transfer was started
   - Active component ID and standby component ID
   - Operator identity
   - The reason for starting: a reference to the calculated trigger and a clear statement that it was started at **{{ insert: param, si-13.03_odp }} of MTTF** (for example, “90% of MTTF; trigger_time = …”)
   - Result (success/failure) and verification outcomes

###### WHO
- **Reliability/architecture owner**: confirms MTTF values and defines the basis for “active_component_start_time”.
- **System owner / infrastructure lead**: approves the runbooks and the scheduling workflow.
- **Authorised operators / administrators**: perform the manual transfer and complete the required audit record.
- **Security/compliance function**: checks that evidence is complete for audit readiness.

###### Acceptance criteria
- For each designated active/standby component pair, there is a documented MTTF value source and a repeatable calculation of the manual transfer trigger time using **si-13.03_odp** (default 90%).
- A documented manual transfer runbook exists and is linked to the scheduled due transfer for each component pair.
- For every executed manual transfer, audit records show: start time, active/standby IDs, operator, and a clear confirmation that the transfer was started at **{{ insert: param, si-13.03_odp }} of MTTF**, with a reference to the calculated trigger.
- Transfers are carried out by named/authorised people (not only automatic failover) in line with the runbook and any change/maintenance constraints.

###### Actions Required for Compliance

- [ ] Create a list (inventory) of every designated “active” and “standby” component pair, and record which component is treated as the active one for SI-13(3) purposes.
- [ ] For each pair of components, document where the mean time to failure (MTTF) value comes from and the assumptions used. Also record the organisation-defined percentage for **si-13.03_odp** (default: 90%).
- [ ] Define and document how `active_component_start_time` is set (for example, the time the last manual transfer finished or when the component was activated) so that trigger calculations can be repeated and produce the same results.
- [ ] For each component pair, calculate and record `trigger_time` as:

`active_component_start_time + (si-13.03_odp × MTTF)`
- [ ] Create and get approval for a manual transfer procedure (“runbook”) for each pair of components, including the steps to check the transfer and the steps to undo it if needed.
- [ ] Schedule due transfers in the day-to-day operating process, and require an authorised operator to carry out the manual transfer at or before the trigger time.
- [ ] For each transfer, record the audit evidence: the time the transfer was started, the active and standby identifiers, the operator, and an explicit confirmation that the transfer was initiated at **si-13.03_odp** of **MTTF**.


---

#### SI-13.4 — Standby Component Installation and Notification (Enhancement)

This requirement ensures that if part of a system fails, the organisation can quickly and smoothly switch to backup parts so services continue to run. Without this, a failure could leave customers and staff unable to access services, lead to expensive downtime, and delay help because the right people are not alerted or the backup is not put in place quickly enough.

The organisation must be able to detect component failures and, when they occur, successfully install the correct standby components within 4 hours in a way that users do not notice—so there is no unnecessary disruption or unexpected change.

At the same time, it must raise an alert, start the switch to the standby components, and notify the on-call incident response lead. The organisation must also keep clear written procedures and assign responsibility, so staff know exactly what to do. Finally, it must keep records showing the timeline from failure detection through installation, raising the alert, notifying the lead, and switching to the standby components.

##### Automated standby install + failover with 4-hour SLA and lead notification

- Category: Software
- Priority: Critical

###### WHAT must be done
When failures are detected in system components, the organisation must (a) install the correct standby components within the defined **time period (within 4 hours)**, (b) raise an **alarm** when failures are detected, and (c) **switch over to the standby components** and **notify the on-call incident response lead**.

###### WHY (control requirement)
NIST SI-13(4) (Enhancement) requires that, once component failures are detected, the organisation can switch to standby components (automatic or manual) and meet the organisation-defined operational expectations for **standby component installation time**, **alarm activation**, and **response actions**.

###### HOW (specific steps/approach)
Set up an automated failover process that starts when component-failure alerts are received and enforces the 4-hour installation window.

1. **Define standby matches and the switch method**: For each critical component, document the standby equivalent(s), any compatibility requirements, and how the switch will be made (for example, changing a cluster role, switching a load balancer target, or failing over a service endpoint) so the process selects the correct standby component.
2. **Standardise standby components**: Create signed, version-controlled standby component packages (for example, approved “golden” virtual machine or container images, plus configuration-as-code) and store them in a controlled repository. Include checks for integrity and dependencies so the installed standby is known to be working.
3. **Connect failure detection to an orchestration system**: Link monitoring and operational alerts (server/service health, synthetic checks, and dependency checks) so they produce one clear “component failure detected” event that starts the process timer.
4. **Install and validate health within 4 hours**: When the event is received, the process installs the correct standby component, runs automated health checks, and only proceeds with the switch after the checks pass. Enforce the **time period** limit: if health checks cannot finish within the remaining time, the process escalates to a pre-defined manual runbook while still meeting the overall 4-hour objective.
5. **Alarm + notify the incident response lead**: When a failure is detected, automatically activate the configured **alarm** in the monitoring and IT service management tools (the **alarm** parameter). At the same time, create an incident and notify the **on-call incident response lead** (paging/SMS/email integration) with incident details and the relevant timestamps.
6. **Minimise impact for users**: Use stable service addresses (for example, virtual IP, DNS, or ingress/service routing) and perform a controlled switch so users experience minimal disruption. Ensure the process records which switch method was used.
7. **Create audit evidence with timestamps**: Save records and logs from each run showing: detection time, standby installation start/end, health-check results, alarm activation time, notification time, and failover completion time. Send relevant events to security information and event management (SIEM) for correlation.

###### WHO (role responsible)
- **Application/Platform Engineering Lead**: owns the standby mappings, approved “golden” components, and the orchestration process implementation.
- **Operations / Site Reliability Engineering (SRE) (on-call)**: checks runbooks, escalation paths, and how transparent the switch is for users.
- **Incident Response Lead / Security Operations Centre (SOC)**: ensures notifications are routed correctly and incidents are handled properly.
- **Security/Compliance**: reviews evidence capture, integrity controls, and auditability.

###### Acceptance criteria
- A component failure detection event reliably starts the process.
- For each mapped critical component, the correct standby component is installed and becomes operational **within 4 hours** of detection.
- An **alarm** is activated when failures are detected (according to the organisation-defined selection).
- The process **switches over to standby components** only after standby health checks pass.
- The **on-call incident response lead** is notified with incident context; the notification timestamp is recorded.
- Evidence shows an end-to-end timeline (detection → installation → alarm → notification → failover completion) with consistent timestamps suitable for audit.

###### Actions Required for Compliance

- [ ] Define how each critical component will switch from standby to active use, and the process for performing the cutover.
- [ ] Create signed, version-controlled standby “golden” image and configuration bundles, with integrity checks to confirm they have not been altered.
- [ ] Set up monitoring alerts so they send one “component failure detected” message that starts a 4-hour workflow timer.
- [ ] Set up orchestration to install the correct standby component and run automated health checks before switching over (failover).
- [ ] Set up alarms so that, as soon as a problem is detected, the alarm is activated and an incident is created immediately.
- [ ] Set up paging and information technology service management (ITSM) notifications to alert the on-call incident response lead, and record the time each notification was sent.
- [ ] Create audit logs that record: the time a detection was made, when installation started and finished, the results of health checks, the time an alarm was raised, the time notifications were sent, and when failover was completed.


---

#### SI-13.5 — Failover Capability (Enhancement)

This requirement is about ensuring your important services can keep running even if the main site goes down. It does this by automatically switching to a nearby mirrored site and keeping the data up to date. Without this, events such as a power cut, hardware failure, or a major outage could prevent customers and staff from accessing the systems. It could also mean the backup site starts with out-of-date information.

To meet this expectation, the organisation must set up the system so that, in near real time, it automatically takes over on a mirrored on-premises processing site when the primary site fails, without anyone needing to manually trigger the switch. The mirrored site must be kept current by automatically copying the required data from the primary site at least every 15 minutes.

The organisation must also:
- document how failover works
- have clear procedures for managing it and preventing predictable failures
- assign named people who are responsible
- ensure the system design and settings match the plan
- keep audit records showing that failover and mirroring happened when expected

##### Automated on-prem failover with 15-minute data mirroring

- Category: Software
- Priority: Critical

###### WHAT
Set up an automatic failover capability so that if the primary site fails, the system automatically switches to a mirrored on-premises processing site. Keep the mirrored site up to date by copying the required data every 15 minutes.

###### WHY (control requirement)
NIST security control SI-13(5) enhancement requires providing **{{ insert: param, si-13.05_odp.01 }}** and **{{ insert: param, si-13.05_odp.02 }}** for the system. The organisation-defined parameters specify:
- **si-13.05_odp.01:** *near real-time*
- **si-13.05_odp.02:** *automatic switchover to a mirrored on-premises processing site with periodic data copying every 15 minutes*

This matches the guidance that failover is **automatic switchover** to an alternative system and includes **mirrored system operations** and/or **periodic data copying at intervals defined by recovery time periods**.

###### HOW (specific steps/approach)
1. **Define failover scope and measurable targets**: Identify the exact live (production) services covered (web/application programming interface (API)/application layers, databases, message queues, caches/persistent state, and identity/session dependencies). Set measurable targets for “near real-time” and for recovery time objective (RTO) and recovery point objective (RPO) acceptance for automated switchover.
2. **Build a mirrored on-premises processing site that can take over**: Set up the same application and required supporting components at the alternate site (infrastructure, configuration, secrets/certificates, network routes, and service endpoints). This should allow it to handle live traffic without rebuilding by hand.
3. **Implement automated switchover coordination**: Set up health checks and failure detection for the primary site. Use an automated method (for example, load balancer/reverse proxy failover, an orchestration controller, or infrastructure automation) to redirect traffic to the mirrored site without needing staff to intervene.
4. **Configure automated periodic data copying (every 15 minutes)**: Set up scheduled replication/copying for the required data sets (for example, database replication, storage replication, and message backlog/state replication where applicable). Make sure the copying is automated, runs on a 15-minute schedule, and is monitored.
5. **Ensure failover uses mirrored operations and data**: Confirm that the mirrored site uses the copied/replicated data. Also ensure application/session/state dependencies are either copied or safely rebuilt after switchover.
6. **Enable audit-ready evidence**: Keep central, time-stamped records of (a) replication/data-copying job runs and results, and (b) failover events (detection, start/end of switchover, and traffic cutover). Ensure this evidence can be provided during audits.
7. **Test and record failover performance**: Run controlled failover tests to confirm that automated switchover happens and that the data-copying schedule meets the 15-minute requirement. Record timing to show it meets the “near real-time” expectation.

###### WHO
- **Disaster Recovery (DR)/Business Continuity Planning (BCP) Lead / Service Owner**: owns the failover scope, targets, and acceptance criteria.
- **Infrastructure/Platform Engineer**: prepares the mirrored site and implements automated traffic cutover.
- **Database/Storage Engineer**: implements the 15-minute periodic data copying and checks data consistency.
- **Security Operations / Security Operations Centre (SOC)**: ensures logging, monitoring, and evidence retention meet enterprise requirements.

###### Acceptance criteria
- When the primary site is declared failed by the configured detection method, **traffic is automatically redirected** to the mirrored on-premises site **without manual action by operators**.
- The mirrored site can run the system using **copied/replicated data**.
- Data copying runs automatically on a **15-minute interval** for the defined data sets, and job results are recorded with timestamps.
- Failover and data-copying events generate **audit-ready, time-stamped evidence** (replication/copying runs and switchover events).
- Test results show that switchover meets the organisation’s defined **near real-time** threshold.

###### Actions Required for Compliance

- [ ] Document the failover scope, including which services, dependencies, and data sets are covered. Also set measurable targets for “near real-time” performance and for recovery time objective (RTO) and recovery point objective (RPO) thresholds.
- [ ] Set up and configure the mirrored on-premises processing site so it runs the same application stack and required supporting software.
- [ ] Set up automated failure detection and automatic traffic cutover so the switchover happens without any manual intervention.
- [ ] Set up automated, regular copying of the required data sets every 15 minutes, with monitoring and alerts.
- [ ] Confirm that the mirrored site is serving the live production service using copied production data, and that any required user sessions or system dependencies are correctly handled after a failover.
- [ ] Set up central, time-stamped logging for replication runs and failover events, and keep the records as evidence for audit purposes.
- [ ] Run and document controlled failover tests to show that automatic switching works and that mirroring meets the 15-minute compliance requirement.


---

### SI-14 — Non-persistence (Control)

This requirement is about ensuring the computer environment that runs your customer-facing applications is temporary. It should start from a trusted, clearly defined starting point every time, and it should be shut down when it is no longer needed. If this is not done, a determined attacker could try to take advantage of weaknesses during a session and make changes that remain after the session ends, giving them more time and more opportunities to break in or cause harm.

To meet this expectation, the organisation must run the virtual machines that support customer-facing applications and their supporting services in a non-permanent way. They must be started from a clearly defined and documented trusted baseline every time, and they must be automatically terminated when the user session ends. In addition, even if sessions are infrequent, these temporary machines must be ended at least every 7 days.

The organisation must document how this is done, name specific people who are responsible, keep records showing when machines start and stop, and use automated mechanisms so termination happens reliably without manual effort.

##### Session-scoped VM instances from golden image with auto-termination

- Category: Software
- Priority: Critical

###### WHAT
Set up **non-persistent system components and services** within the organisation-defined scope (user-facing application virtual machines and the supporting middleware services). Run them as **virtual machine instances** that:
- **Start in a known, trusted state** (a defined and documented baseline), and
- **Automatically stop** when the **end of the user session** occurs, and
- Are also forcibly stopped **no later than every 7 days**.

###### WHY (control requirement)
NIST Special Publication 800-53 **SI-14 (Non-persistence)** requires: “Implement non-persistent {{ insert: param, si-14_odp.01 }} that are initiated in a known state and terminated {{ insert: param, si-14_odp.02 }}.” The guidance also explains that non-persistence reduces the time an attacker has to exploit weaknesses, and that the stopping frequency must be defined for the selected option (here: **every 7 days**, si-14_odp.03).

###### HOW (specific approach)
###### 1) Define what is included and when it must stop
- Identify the exact virtual machine roles that match **si-14_odp.01** (“virtual machine instances for user-facing applications and supporting middleware services”).
- Define the session end event that matches **si-14_odp.02** (“upon end of session of use”)—for example, a logout event, a session timeout, or a “session closed” signal from the session broker.

###### 2) Create and manage a documented “known state” baseline
- Create a hardened **golden image/template** for each included virtual machine role using an automated image-building process.
- The golden image baseline must be **documented** (for example, a baseline record including operating system hardening, middleware/application versions, configuration checksums, required services, and health checks).
- Ensure no session-specific information is built into the image; session data must be stored outside the virtual machine in approved persistent services.

###### 3) Start session virtual machines from the golden image
- When a session begins, automatically create virtual machines from the golden image/template.
- Add only session-specific credentials/configuration using short-lived tokens/secrets (avoid storing long-term secrets on the virtual machine’s disk).

###### 4) Stop at session end using automation (not manual action)
- Connect the session broker/application logout/session-timeout event to the orchestration system so it **powers off and deletes** (or otherwise stops) the session virtual machines.
- Make sure stopping is enforced by automation and is safe to repeat (repeated stop requests should not fail silently).

###### 5) Enforce the maximum lifetime: stop no later than every 7 days
- Set up a scheduled “reaper” job that finds any session virtual machines older than **7 days** and stops them.
- Alert if stopping fails and record what remediation was done.

###### 6) Keep evidence for audits
- Centralise logs for virtual machine lifecycle events: creation/start, session association, stopping trigger (session end versus reaper), and completion of delete/power-off.
- Ensure logs include correlation identifiers (session ID, user/service identity, application, virtual machine ID) so the activity can be traced for audit purposes.

###### WHO (roles responsible)
- **Infrastructure/Cloud Engineering Lead**: implements virtual machine orchestration, the golden image build process, and reaper enforcement.
- **Application Owner / Service Owner**: defines the session end trigger rules and ensures integration with the session broker.
- **Security/Compliance Lead**: approves the documented “known state” baseline and checks that audit evidence is sufficient.
- **Operations/SRE**: monitors stopping alerts and handles incidents if stopping fails.

###### Acceptance criteria (verifiable)
1. For each included virtual machine role, a documented golden image/template baseline exists and is used to create session virtual machines.
2. In a test session, the session virtual machines automatically stop when the session ends (logout/timeout) without manual intervention.
3. In a test where session-end signalling is blocked, the reaper stops the session virtual machines within **7 days**.
4. Audit logs show virtual machine lifecycle events linked to the session ID and the stopping reason (session end versus reaper) for at least one end-to-end test per included virtual machine role.
5. No session-specific data remains on the disks of the stopped virtual machines (validated by test: changes made during a session do not appear after starting a new session).

###### Actions Required for Compliance

- [ ] Define and document the exact virtual machine (VM) roles that are included as non-persistent system components and services (si-14_odp.01).
- [ ] Document the “end of session of use” trigger (si-14_odp.02) and link it to an orchestration event.
- [ ] Create and get approval for hardened “golden” images and templates for each virtual machine (VM) role covered, including a baseline set of settings that represents the known trusted starting state.
- [ ] Set up orchestration so that, when a session starts, it creates the session virtual machines from the approved “golden” image and links each virtual machine to that session’s ID.
- [ ] Set up automated shutdown and removal (power off and delete) of session virtual machines when the session ends, with safe repeat handling and alerts if anything fails.
- [ ] Set up an automated scheduled job to shut down any virtual machines used for sessions that are older than 7 days (si-14_odp.03), and record the results.
- [ ] Enable centralised logging of virtual machine (VM) start, change, and stop events, linked to the session ID, user, and application, and including the reason for shutdown, to provide audit evidence.


---

#### SI-14.1 — Refresh from Trusted Sources (Enhancement)

This requirement is about ensuring that when the organisation updates or refreshes the software and data used in its systems, it only uses sources it can trust. These trusted sources are write-once, read-only media and specific offline secure storage facilities that the system owner has approved.

Without this control, there is a real risk that harmful or unauthorised changes could be introduced during an update. This could disrupt services, lead to information theft, or cause systems to work incorrectly.

To meet this expectation, the organisation must:
- Clearly define what counts as a trusted refresh source.
- Ensure every refresh uses only the approved trusted sources.
- Keep evidence showing which offline secure storage facilities were approved and which source was used for each refresh.

The organisation must also:
- Appoint named people with information security responsibilities to carry out the process.
- Follow documented procedures every time.
- Record the source used for each refresh.
- Ensure relevant system plans, integrity procedures, design and configuration documentation, and any automated update tools are set up so they can only obtain refresh materials from the trusted sources.

##### Trusted refresh media vault and kit workflow with source evidence

- Category: Manual
- Priority: Critical

###### WHAT
Set up a controlled process to make sure that, when system components and services are refreshed, **all software and data** are obtained **only from trusted sources**: **write-once, read-only media** and **selected offline secure storage facilities** that are **approved by the system owner**.

###### WHY (control requirement)
The National Institute of Standards and Technology (NIST) Special Publication 800-53 security control SI-14(1) enhancement requires that, during refreshes, software and data are obtained only from the trusted sources defined in **param: si-14.01_odp** (write-once, read-only media and selected offline secure storage facilities approved by the system owner). The guidance also confirms that trusted sources include write-once, read-only media or selected offline secure storage facilities.

###### HOW (specific steps/approach)
1. **Create a Trusted Refresh Media Vault** with two storage categories:
   - **Write-once, read-only media** (for example, write-once, read-only (WORM)-capable media or an equivalent write-once/read-only method).
   - **Offline secure storage facilities** (for example, isolated (air-gapped) or offline encrypted repositories, or offline media libraries).
2. **Keep system-owner approval records** for each offline secure storage facility:
   - Maintain an auditable approval record that links **system owner approval** to a **facility identifier**.
3. **Set a standard “Refresh Kit” package** for every refresh item:
   - Each kit must include a **manifest** (what it contains, which component/service it is intended for, version/build, cryptographic hashes/checksums, and creation date) and a **trusted source reference** (media ID or facility ID).
4. **Control how kits are retrieved and checked**:
   - Only authorised staff may retrieve kits from the vault.
   - When preparing for a refresh, check kit integrity using the manifest hashes and record the results of the checks.
5. **Record the actual trusted source used for each refresh**:
   - For each refresh, capture evidence showing: **kit ID**, **manifest checksum verification**, **target component/service**, **date and time**, and the **trusted source reference** (media ID/facility ID).
6. **Link to change/release records**:
   - Link each change/release ticket to the **kit ID** and attach the evidence that the trusted source was verified, so auditors can trace “source used” to “refresh performed”.

###### WHO (role responsible)
- **System Owner**: approves each offline secure storage facility (and re-approves when changes occur).
- **Information Security / Compliance**: defines the trusted-source and evidence requirements; checks that they are followed.
- **Change/Release Manager or Engineering Lead**: ensures refreshes reference kit IDs and that evidence is included in change records.
- **Authorised Operators/Administrators**: retrieve kits from the vault, perform hash checks, and complete the evidence capture for the refresh.

###### Acceptance criteria
- A Trusted Refresh Media Vault exists with clearly separated storage categories for write-once, read-only media and offline secure storage facilities.
- For every offline secure storage facility used, there is an auditable **system owner approval** record linked to a facility identifier.
- Every refresh uses a **Refresh Kit** whose manifest includes cryptographic hashes and a trusted source reference.
- For each refresh event, evidence exists showing: kit ID, manifest hash verification, and the trusted source reference (media ID/facility ID) used.
- Change/release records are traceable from the refresh action to the kit ID and the source evidence.

###### Actions Required for Compliance

- [ ] Define and publish the organisation-approved list of trusted refresh sources—specifically write-once, read-only media and offline secure storage facilities—aligned to SI-14.01_ODP.
- [ ] Set up a Trusted Refresh Media Vault with separate controls for write-once/read-only media and for offline secure storage facilities.
- [ ] Set up an approval process and a place to store proof for the system owner to approve each offline secure storage facility (include the facility ID and the approval record).
- [ ] Create a “Refresh Kit” manifest template that must include: the kit ID, what the kit contains, the version/build number, cryptographic hash values, and a reference to the trusted source (media ID and/or facility ID).
- [ ] Document and enforce a process for retrieving and checking kits. Only authorised staff may access kits, and the kit’s manifest must be verified using a manifest hash before any refresh is carried out.
- [ ] Update the change and release procedures so that every refresh is linked to a kit identification (kit ID), and attach proof that the information was verified using a trusted source.


---

#### SI-14.2 — Non-persistent Information (Enhancement)

This requirement is about treating short-lived information like a disposable item: it is kept only while it is needed, and then it is removed. If this information is kept for too long, it can be misused—for example, someone may reuse old login details, alter temporary results, or use leftover system traces to probe and attack your services.

To meet this expectation, the organisation must clearly identify what counts as short-lived information, including session tokens, temporary authentication artefacts, and temporary processing outputs. The organisation must decide how to handle these items by either refreshing them at least every 24 hours or creating them only when needed for the current task. In both cases, the organisation must delete these items as soon as they are no longer required, using documented procedures, named accountable people, system settings that enforce the approach, and records showing that refresh and deletion took place.

##### Automated session/token rotation and transient artefact purge

- Category: Software
- Priority: Critical

###### WHAT must be done
Set up handling for **short-lived (non-persistent) information** so that **session tokens, temporary authentication items, and temporary processing results** are either:
1) **updated at least every 24 hours**, or
2) **created only when needed for the current task**,

and in both cases are **securely deleted as soon as they are no longer needed**.

###### WHY (control requirement)
SI-14(2) (Non-persistent Information) is meant to reduce the risk that short-lived information is kept for longer than necessary. Keeping it longer increases the risk of **unauthorised disclosure, unauthorised changes, or theft of data**, and gives attackers useful information to help them move to other systems.

###### HOW (specific steps/approach)
###### 1) Define exactly what counts as “non-persistent information” for this application
- Create an application security standard that clearly lists what is included, aligned to the organisation’s guidance:
  - **session tokens**
  - **temporary authentication items**
  - **temporary processing results**
- Add clear examples for this technology stack (for example: refresh/authorisation codes, one-time links, multi-factor authentication (MFA) challenge items, cross-site request forgery (CSRF)/session cookies, pre-authorised links, cached access/authorisation decisions, temporary export files).

###### 2) Choose how to refresh and meet the 24-hour rule
- Choose the **refresh method** for session tokens and temporary authentication items.
- Configure the identity system and the application session system so that refresh/renewal happens **at least every 24 hours** (organisation-defined setting: `frequency = every 24 hours`).
- Make sure the new items replace the old ones, and that the old items are no longer valid.

###### 3) Delete securely when the work is finished
- For each type of temporary item, set a clear, repeatable deletion process:
  - delete temporary files/objects immediately after use (or when they expire)
  - remove temporary caches/working folders using application “finally”/cleanup steps
  - remove one-time items immediately after they are successfully used
- Make sure deletion happens for both normal completion and error situations.

###### 4) Produce audit evidence automatically (ready for review)
- Ensure records (logs) show:
  - token/session refresh/renewal events (with correlation IDs)
  - one-time item creation and successful use
  - deletion/cleanup events (or proof that expiry enforcement happened) for temporary processing results
- Store this evidence in the existing security information and event management (SIEM) and monitoring system.

###### 5) Assign clear ownership and build it into the system design
- Assign a responsible named owner (for example, the Application Security Lead or Identity and Access Engineering Lead) for:
  - maintaining the non-persistent information standard
  - approving exceptions
  - checking refresh and deletion behaviour during releases
- Record this in the system security documentation and design records.

###### WHO (role responsible)
- **Application Owner / Application Security Lead**: defines what is in scope, approves exceptions, and ensures the application design meets the deletion requirements.
- **Identity and Access Management Engineer**: configures identity provider (IdP) and session/token rotation to meet the 24-hour refresh requirement.
- **Software Engineers**: implement the full lifecycle for temporary items (creation, use, deletion) in the code.
- **DevOps/Platform Engineer**: ensures configuration-as-code and operational controls are in place (cleanup jobs, retention settings).
- **Security Assurance/Compliance**: checks the evidence and keeps audit readiness up to date.

###### Acceptance criteria
- The application has a documented list of in-scope non-persistent information types (session tokens, temporary authentication items, temporary processing results).
- Session tokens and temporary authentication items are refreshed/rotated **no less frequently than every 24 hours** while the application is in use.
- One-time/temporary items are invalidated after successful use and cannot be retrieved after completion/expiry.
- Temporary processing results are deleted immediately after they have served their purpose (including in error cases).
- Audit evidence exists showing refresh/renewal and the follow-on deletion/cleanup for representative workflows.
- Named responsibility is assigned and recorded in the system security documentation.

###### Actions Required for Compliance

- [ ] Document the in-scope types of non-persistent information used by this application (session tokens, temporary authentication items, and short-lived processing results), including concrete examples.
- [ ] Set up identity and session management so that session tokens and temporary authentication records are refreshed or replaced at least every 24 hours.
- [ ] Implement application-level invalidation so that refreshed artefacts replace earlier ones, and older artefacts cannot be reused.
- [ ] Add reliable cleanup steps to delete temporary processing outputs as soon as the work finishes, including when errors occur.
- [ ] Use one-time authentication codes that can only be used once and expire quickly, and make sure they are deleted after they have been successfully used.
- [ ] Enable audit logging for account refresh and renewal, and for deletion and cleanup activities. Include correlation identifiers so related actions can be linked together, and send the logs to the security information and event management (SIEM) system.
- [ ] Create a release-time verification checklist and run it in continuous integration and continuous delivery (CI/CD) to confirm how often data is refreshed and what happens when it is deleted.


---

#### SI-14.3 — Non-persistent Connectivity (Enhancement)

This expectation is about keeping system access short-term. Connections should only be opened when someone or a task actually needs them, and then they should be ended automatically after a set period with no activity. Without this, an attacker who gains access once could use those lingering connections to move around inside the organisation and get closer to more valuable information or services.

To meet this expectation, the organisation must set a clear rule for each relevant system part that creates or maintains connections. This rule must state whether connections end when the work is finished or after a specified period of inactivity, and it must define what counts as “no use”. The organisation must configure the system so connections are truly only started on demand and automatically shut down. This should be supported by written procedures, system design and configuration records, and a security plan.

The organisation must also keep records showing that connections were started only for active requests and were ended as required, with named responsibility assigned to the information security team.

##### On-demand session connectivity with inactivity-based auto-termination

- Category: Software
- Priority: Critical

###### WHAT must be done
Set up connectivity so that connections to the application are created only when there is an active request. Automatically end those connections after a defined period of inactivity (**si-14.03_odp**). Optionally, end the connection immediately when the request is finished.

###### WHY (control requirement)
The National Institute of Standards and Technology (NIST) SI-14(3) requires: “Establish connections to the system on demand and terminate connections after {{ insert: param, si-14.03_odp }}.” The guidance explains that keeping connections open for long periods can help advanced attackers move to other systems and get closer to high-value assets. Limiting how long connections remain available makes this harder.

###### HOW (specific steps/approach)
1. **Define “inactivity”**: Treat “inactivity” as *no application-level activity* for the period specified by **si-14.03_odp** (for example: no authenticated application programming interface (API) calls, no active user interface (UI) interaction, and no requests currently in progress). Record whether connections are ended on **request completion**, **inactivity**, or **both**.
2. **Use on-demand connectivity**: Configure the entry point (API gateway, reverse proxy, zero trust network access (ZTNA), or access gateway) so that sessions are created for each authenticated request or workflow, rather than keeping long-lived connections open for interactive use.
3. **End connections after inactivity**: Configure the gateway/session rules to automatically end sessions when the inactivity period reaches **si-14.03_odp**. Make sure the timing is based on application-level inactivity (for example, no requests), not just network “keep-alive” signals.
4. **Apply the same approach everywhere**: Make sure the same inactivity-ending behaviour is enforced for every component that creates connections to the application (for example: API gateway, web reverse proxy, the admin console entry point, and any remote administration access route).
5. **Create audit evidence**: Turn on logging for when sessions start and why they end (for example: “ended due to inactivity” and/or “ended after request completion”), and send this information to the security information and event management (SIEM) system for auditability.
6. **Operational ownership**: Assign responsibility to a named security role (for example, Information Security or Security Engineering) to maintain the **si-14.03_odp** setting and review any exceptions.

###### WHO (role responsible)
- **Security Engineering / Information and Access Management Lead**: owns the inactivity/session policy design and configuration.
- **Platform/Infrastructure Engineer**: implements the gateway/proxy/ZTNA configuration across environments.
- **Application Owner**: confirms what “request completion” means for the relevant workflows.
- **Security Operations Centre (SOC) / SIEM Analyst**: checks that termination events are logged and monitored.

###### Acceptance criteria
- For each defined connection entry point, sessions are created only when an authenticated request/workflow starts (no always-on/persistent sessions).
- After **si-14.03_odp** of application-level inactivity, the session/connection is automatically ended.
- Connection-ending events are recorded with enough detail to demonstrate compliance (timestamp, session identifier, and termination reason).
- The configuration is consistent across production and any other in-scope environments (test/development/production as required by governance) and is documented with the agreed meaning of “inactivity”.

###### Actions Required for Compliance

- [ ] Document what “non-use” means in terms of application-layer inactivity, and confirm whether termination happens when a request is completed, when inactivity occurs, or both.
- [ ] Set up the API gateway, reverse proxy, and zero trust network access (ZTNA) access gateway so that it creates a session only when needed—based on each authenticated request or workflow.
- [ ] Set the session inactivity timeout to exactly `si-14.03_odp`, and confirm it is enforced when the application is inactive (not by TCP keepalives).
- [ ] Apply the same inactivity-based disconnection rule to every way users can connect (website, admin console, application programming interfaces (APIs), and any remote access route).
- [ ] Set up and centralise audit logs for when a session starts and ends, including the reason for termination, and send the logs to the security information and event management (SIEM) system.
- [ ] Assign a responsible security role to maintain **SI-14.03 ODP** and to manage and approve any exceptions.


---

### SI-15 — Information Output Filtering (Control)

This requirement is about making sure that what your web pages, application screens, and database-based reports show to people is exactly correct and does not include anything extra. Without this, attackers could try to make the system display incorrect or hidden information, such as unexpected text or data that should never appear. This could expose confidential or secret information, or lead to decisions being made using wrong figures.

To meet this expectation, the organisation must clearly define what “correct output” looks like for each relevant web application, interface, and reporting portal that handles confidential and secret data. The system must then automatically check every result before it is shown to users or returned. If any output does not match the expected content, the system must block the inconsistent or incomplete result, record the details of the failure for later review, and alert the organisation’s monitoring capability that unusual behaviour has been detected.

Named individuals with information security responsibilities must be accountable for this validation. The organisation must also clearly assign responsibility to the technical teams that build, operate, and maintain it. Finally, the organisation must document the approach, keep evidence of the design and configuration, and include it in the system security plan.

##### Output filtering gate for web/API/report responses

- Category: Software
- Priority: Critical

###### WHAT
Implement an automated **“output validation gate”** for all in-scope **web applications, application programming interfaces (APIs), and database-driven reporting portals** that handle **Confidential/Secret** data. The gate must check the **final information output** against **expected content rules** and **block or remove** any extra or inconsistent content before it is shown to users or returned to API callers.

###### WHY (control requirement)
National Institute of Standards and Technology (NIST) **SI-15 Information Output Filtering** requires the organisation to **check information output** from the specified software programmes/applications so that the information is **consistent with expected content** (SI-15 statement: “Validate information output… to ensure that the information is consistent with the expected content: {{ insert: param, si-15_odp }}.”). Guidance explains that attacks (for example, **SQL injection**) can cause **unexpected/extra output**, so filtering must **detect, prevent display/return, and alert monitoring tools**.

###### HOW (specific approach)
1. **Define expected output rules for each endpoint/view/report**
   - APIs: create and maintain **response contracts** using **OpenAPI/JSON Schema** (allowed fields, data types, required properties, allowed values, text/length limits, numeric ranges, and whether null is allowed).
   - Web applications: define **view-model contracts** (allowed data fields and formatting) and enforce **template constraints** so only approved fields are shown; prevent arbitrary HTML fragments coming from data sources.
   - Reporting portals: define **report output contracts** (allowed columns, formatting rules, how totals/aggregation behave, row/record limits, and permitted value ranges).
2. **Check the final formatted output before it is sent**
   - Implement a middleware/component that intercepts the **final response payload** (API JSON, rendered HTML fragments, and report result sets) and validates it against the relevant contract.
   - Ensure validation happens **after** data retrieval and formatting, so injection-driven extra content is caught.
3. **Fail closed with controlled behaviour**
   - If validation fails: **block the response** (preferred) or **remove only the invalid elements** according to a documented, per-application policy.
   - Return a **generic error** that does not repeat unexpected content.
4. **Alert and record validation failures**
   - Send structured events to **security information and event management (SIEM)**/monitoring including: timestamp, component/endpoint/report identifier, correlation/request ID, user/session identity (where permitted), validation rule/contract ID, and failure category.
   - Set up detection rules for unusual patterns (for example, repeated failures, new contract violations, spikes by endpoint).
5. **Run contract management as an operational process**
   - Version contracts and link them to releases; require change control for contract updates so expected output remains auditable.

###### WHO
- **Application Security Lead / SIEM Detection Engineer**: owns detection logic and the categories (taxonomy) for failure events.
- **Application Owner / Engineering Lead**: owns implementing the output validation gate and mapping contracts to applications.
- **Security Architect**: approves contract design standards and the fail-closed policy.

###### Acceptance criteria
- For every in-scope web/API/report handling Confidential/Secret data, there is a **mapped expected output contract** (API schema, view-model contract, or report output contract).
- For each contract, the system **blocks or sanitises** responses that do not meet the contract (so no extra content reaches the client/caller).
- Validation failures produce **audit-ready logs/events** and are sent to monitoring/SIEM with the required identifiers.
- Demonstrated test: simulated injection/tainted data leads to a **contract violation**, **blocked/sanitised output**, and an **alert/event** within the agreed monitoring pipeline.

###### Actions Required for Compliance

- [ ] Identify and list all in-scope web applications, application programming interface (API) endpoints, and reporting portals that handle Confidential or Secret information.
- [ ] Create and version the expected output “contracts” for every endpoint, page view, and report (OpenAPI/JSON Schema for application programming interfaces (APIs); view-model contracts for web pages; output contracts for reports).
- [ ] Set up an output check (validation gate) that compares the final message payload to the agreed contract mapping before it is sent.
- [ ] Set the system to fail safely if something goes wrong (block the response or remove invalid parts), and make sure errors are handled in a generic way so no sensitive information is revealed.
- [ ] Send validation failure events to security monitoring (security information and event management (SIEM)) and other monitoring tools, including the correlation identifier, component identifier, contract or rule identifier, and the type of failure category.
- [ ] Run automated tests (including tests that use potentially harmful or “tainted” data) to prove that unwanted extra output is blocked or cleaned up, and that alerts are triggered.


---

### SI-16 — Memory Protection (Control)

This requirement is about setting up the computer’s working memory so that unauthorised code cannot simply run itself from the wrong places. Without these protections, an attacker who gains access could try to trick the system into treating data as if it were instructions, or rely on predictable memory locations to make the attack work.

To meet this expectation, the organisation must configure and maintain each system so that memory is protected using hardware-supported safeguards. These safeguards prevent code from being executed from memory areas that are not meant to run code, and they randomise memory locations to make attacks harder.

The organisation must also document how these safeguards are implemented and managed, record the exact system settings used, include them in the system’s security plan and design information, and keep a clear list of the safeguards that protect memory. Finally, it must be able to provide evidence from system audit records showing that these settings are enabled and checked after any changes.

##### Enable hardware NX/DEP and ASLR with drift-evidenced verification

- Category: Software
- Priority: Critical

###### WHAT
Configure each system so that **hardware-enforced data execution prevention (NX/DEP)** and **address space layout randomisation (ASLR)** are enabled together. Also ensure the organisation can **evidence** that these settings stay enabled after changes and after reboots.

###### WHY (control requirement)
NIST SP 800-53 **SI-16 (Memory Protection)** requires controls to protect system memory from unauthorised code being executed. The guidance says to use **data execution prevention** (preferably **hardware-enforced**) and **address space layout randomisation** to stop execution from memory areas that are not allowed to run code.

###### HOW (specific steps/approach)
1. **Choose the approved configuration method** for each platform (for example, an operating system hardening baseline applied through enterprise configuration management). Make sure the baseline explicitly sets:
   - **Hardware-enforced DEP/NX** (not software-only), and
   - **ASLR** (enabled).
2. **Use configuration-as-code / policy-as-code** so the same settings can be repeated across environments (production, testing, disaster recovery) and deployed through approved change control.
3. **Apply at build time and keep in place during operation**:
   - Apply settings to **golden images** (where used) and to live systems.
   - Run **scheduled compliance checks** that confirm both NX/DEP and ASLR are enabled and report the results.
4. **Create audit evidence**:
   - Store the check results (for example, operating system mitigation status and ASLR status) centrally with timestamps and links to the related change.
   - Keep a **documented list of memory-protection safeguards** showing that NX/DEP and ASLR are the implemented measures.
5. **Update system documentation**:
   - In the **system security plan** and system design/configuration documentation, reference the safeguards implemented and the exact configuration baseline used.
6. **Manage drift in day-to-day operations**:
   - If checks find any deviation (for example, after patching or reboots), automatically fix it through the same configuration management pipeline and record the evidence of the fix.

###### WHO (role responsible)
- **Platform/Systems Engineering Lead**: owns the baseline and the verification approach.
- **Configuration Management/DevOps Engineer**: implements policy-as-code, golden images, and drift fixes.
- **Information Security / Compliance Lead**: ensures the security plan/design documentation and evidence retention meet audit expectations.

###### Acceptance criteria
- For every system in scope, **hardware-enforced DEP/NX is enabled** (hardware enforcement indicator is present) and **ASLR is enabled**.
- After a reboot and after approved configuration/patch changes, automated checks continue to confirm both controls are enabled.
- Evidence is available showing: (a) the exact baseline/settings used, (b) verification results with timestamps, and (c) links to the relevant change records.
- The system security plan/design documentation includes a current list of the memory-protection safeguards (NX/DEP and ASLR) and references the baseline mechanism.

###### Actions Required for Compliance

- [ ] Define an approved operating system (OS) security baseline that explicitly turns on hardware-based data execution prevention (DEP) and address space layout randomisation (ASLR).
- [ ] Set up the baseline by using “policy as code” in the enterprise configuration management tool that is used for the platform.
- [ ] Apply the baseline to golden images (where applicable) and to all existing systems through approved change control procedures.
- [ ] Set up automated checks to run on a schedule, to confirm that both NX/DEP hardware protection and address space layout randomisation (ASLR) are still enabled after a reboot and after software updates.
- [ ] Centralise and keep verification results as audit evidence, linked to the corresponding change records.
- [ ] Update the system security plan and the system design and configuration documents to refer to the baseline, and list **NX (no-execute)**, **DEP (data execution prevention)**, and **ASLR (address space layout randomisation)** as the memory-protection safeguards that have been put in place.
- [ ] Set up drift remediation so that any change away from the required settings is automatically fixed and recorded as proof.


---

### SI-17 — Fail-safe Procedures (Control)

This requirement is about making sure the organisation has a clear, pre-planned “safe response” if key parts of its systems lose contact with each other, or if they lose contact with the places where the system is used. If communications break down, the system could behave unpredictably, stop working at the worst possible time, or make changes that are difficult to reverse—potentially disrupting operations and causing avoidable harm.

To meet this expectation, the organisation must keep documented fail-safe procedures that set out exactly what to do in two situations:
- loss of communications among critical system components
- loss of communications between system components and operational facilities

If either situation occurs, operator staff must be alerted and given step-by-step instructions to:
- check the connections
- restore the last known working settings
- restart the affected services

If communications with operational facilities are lost, staff must:
- switch to local safe mode
- restart the system
- contact the designated organisational personnel identified for this purpose

##### Automated comms-loss alerts with operator fail-safe runbooks

- Category: Software
- Priority: Critical

###### WHAT
Set up automated detection for the two SI-17 failure situations, and automatically start clear, step-by-step “safe actions” for operators that match the organisation’s requirements.

###### WHY (control requirement)
SI-17 requires the organisation to “implement the indicated fail-safe procedures when the indicated failures occur” for the organisation-defined failure situations in **si-17_prm_1**, including:
- **Loss of communications among critical components**: alert operators; check the connections; restore the last known-good settings; restart the affected services.
- **Loss of communications between system components and operational facilities**: alert operators; switch to local safe mode; restart the system; contact the designated organisation personnel.
The guidance also requires that the fail-safe procedures include **alerting operator personnel** and **clear instructions for what to do next**.

###### HOW (specific steps/approach)
###### 1) Set up detection triggers that match the two failure situations
- Identify which services/components are “critical” (using your asset and service inventory) and which network connections count as “operational facilities” connectivity.
- Set up monitoring that can tell the difference between:
  - **Loss of communications within the system** (for example, message bus/service-to-service health issues, replication or heartbeat failures, or API dependency failures) for “loss among critical components”.
  - **Loss of communications to operational facilities** (for example, site-to-site tunnel, virtual private network (VPN), or software-defined wide area network (SD-WAN) down, facility gateway not reachable, or cloud-to-plant link down) for “loss between system components and operational facilities”.
- Configure alert rules so each failure situation triggers a different operator runbook.

###### 2) Create operator runbooks that match si-17_prm_1 exactly
For each alert type, the runbook must be written as step-by-step instructions and include the required actions:

- **Runbook A: Loss of communications among critical components**
  1. Alert operator personnel.
  2. Check the connections (connectivity checks relevant to your setup).
  3. Restore the last known-good settings (restore from versioned configuration snapshots/baselines).
  4. Restart the affected services (using an agreed restart order, with rollback/stop guidance).

- **Runbook B: Loss of communications between system components and operational facilities**
  1. Alert operator personnel.
  2. Switch to local safe mode (define what “local safe mode” means in your environment).
  3. Restart the system.
  4. Contact designated organisation personnel (named roles/on-call contacts).

###### 3) Provide runbooks through the operator’s normal working process
- When a trigger occurs, automatically send the correct runbook to operators through your usual operational channel (for example, a supervisory control and data acquisition (SCADA)/human-machine interface (HMI) alarm banner, an incident management tool, or secure paging/notifications) and create an incident/ticket record.
- Require operator acknowledgement and collect evidence:
  - time the issue was detected, affected components/facility, runbook version, operator acknowledgement, and confirmation that each step was completed (or a documented reason for any deviation).

###### 4) Make sure “last known-good” restoration is practical
- Keep versioned configuration snapshots/baselines for the affected services/system so operators can restore “last known-good settings” quickly and consistently.
- Test the restore process in a non-production environment, and ensure the runbook points to the correct snapshot/baseline identifiers.

###### WHO
- **System/Platform Owner**: responsible for defining critical components, the boundaries for facility connectivity, and what “local safe mode” means.
- **Security operations centre (SOC) / Monitoring Engineer**: builds the detection logic and links each alert to the correct runbook.
- **Operations Lead / Authorised Operators**: carry out the runbook steps and record evidence.
- **Configuration Management Lead**: maintains the versioned “last known-good” configuration snapshots.
- **On-call / Designated Personnel (information technology (IT)/operational technology (OT) incident responders)**: contacted when facility communications loss occurs.

###### Acceptance criteria
- For both failure situations in **si-17_prm_1**, the system reliably detects the situation and triggers the correct operator runbook.
- Each runbook includes, in the correct order, the required steps: **alert operators**, **check the connections**, **restore last known-good settings**, **restart affected services** (for component communications loss) and **alert operators**, **switch to local safe mode**, **restart the system**, **contact designated personnel** (for facility communications loss).
- Operators can restore “last known-good” using the versioned snapshots referenced in the runbook.
- Audit evidence is produced, including alert trigger details, runbook version, operator acknowledgement, and confirmation of step completion (or documented exceptions).

###### Actions Required for Compliance

- [ ] Define and document which parts of the system are “critical”, and which network connections count as “operational facilities” for this system.
- [ ] Set up two separate communications-loss detection triggers, each linked to one of the two failure conditions described in **si-17_odp.02**.
- [ ] Create two operator runbooks. Their step order and content must exactly match **si-17_prm_1**:

1. **Verify links**, check the **last known-good settings**, then **restart any affected services**.  
2. Enter **local safe mode**, **restart the system**, then **contact the designated personnel**.
- [ ] Set up alerting so that when a trigger happens, it automatically sends the correct runbook and creates an incident record for the operator to acknowledge.
- [ ] Create versioned “last known good” configuration snapshots (baselines) and reference them in the component communications runbook.
- [ ] Test the runbooks in a non-production environment and keep evidence that operators can carry out every required step.


---

### SI-18 — Personally Identifiable Information Quality Operations (Control)

This requirement is about making sure any personal information you hold about people is correct, still needed, up to date, and complete, and then fixing or removing anything that is wrong. Without regular checks, out-of-date or incorrect information can cause people to be denied the right service or benefit, contacted at the wrong address, or have their records handled incorrectly. This can lead to financial loss, complaints, and reputational damage.

The organisation must, at least every quarter, review personal information across its full lifecycle—from when it is created or collected, through how it is used, stored, maintained, shared and disclosed, to when it is eventually disposed of. The organisation must check that the information is accurate, relevant, timely, and complete. After each quarterly review, it must correct any inaccurate details and delete information that is no longer current.

Where appropriate, it should also validate addresses when they are entered using automated address look-ups, track changes over time, set the level of checking based on how sensitive the information is and how it is used, and apply more thorough checks when the information is used to decide rights, benefits, or privileges.

Named staff who have both information security and privacy responsibilities must carry out the work. They must keep clear records of how checks are done and what was found, and retain reports, maintenance logs, and audit records showing the reviews and any follow-up actions.

##### Quarterly PII quality sweeps with automated address validation and remediation

- Category: Software
- Priority: Critical

###### WHAT
Set up a process to manage the quality of personal information (PII) throughout its life. At least every quarter, check PII for **accuracy, relevance, timeliness, and completeness**. Where addresses are collected or entered, automatically verify them using an address verification service. Track changes over time, and **fix or remove** any inaccurate or out-of-date PII, keeping evidence that can be audited.

###### WHY (control requirement)
Control SI-18 requires organisations to manage PII quality across the full PII life cycle (creation/collection, use, processing, storage, maintenance, sharing/disclosure, and disposal). The goal is to confirm PII is **accurate and relevant**, **up to date**, and **complete**, and to apply safeguards to protect PII quality based on the situation and how sensitive it is. It also specifically requires address checking/editing using automated address verification look-up services, and tracking updates over time so incorrect information can be identified and corrected.

###### HOW (specific approach)
###### 1) Define quality rules and thresholds (based on purpose and sensitivity)
- Create an official mapping of PII fields to:
  - the system(s) they come from,
  - the purpose(s) they support,
  - how sensitive they are,
  - and the retention/disposal rules.
- Create rule sets for each purpose/sensitivity that cover:
  - **Accuracy**: check against reference data (for example, country/postcode formats), apply business rules (for example, rejecting impossible values), and standardise to a consistent format.
  - **Relevance**: identify “orphaned” fields (data no longer needed for the stated purpose).
  - **Timeliness**: compare the last-verified or last-updated date against agreed thresholds.
  - **Completeness**: check required fields are present (not blank).
- Set the organisation’s agreed **quarterly** frequency for each quality area (accuracy, relevance, timeliness, completeness).

###### 2) Verify addresses automatically when collected/entered
- For any address data captured through forms, application programming interfaces (APIs), or batch uploads, use an **automated address verification look-up service**.
- Store both:
  - the **verified/corrected** address value (where the result is clear), and
  - the **verification result** (for example, verified/corrected/unverified/ambiguous), including the time it was checked.
- If the service returns an ambiguous result, hold the record for human review rather than changing it automatically.

###### 3) Run quarterly “quality sweeps” across the life cycle
- Set up a quarterly job/workflow to scan the main systems and key downstream datasets that contain PII.
- For each record/field, apply the rule sets and create a remediation (fix) queue:
  - **Automatically correct** when the outcome is clear and allowed under the retention/disposal rules.
  - **Quarantine** when the fix is uncertain or would significantly change the meaning of the data.
  - **Delete** when the PII is clearly inaccurate or out of date and deletion is allowed under the retention/disposal rules.

###### 4) Track changes over time with an auditable quality record
- Keep an auditable record for each remediation event, including:
  - what changed (at field level),
  - the previous value versus the new value (or a deletion marker),
  - the rule/policy reference and which quality area(s) were triggered,
  - the time and the workflow/service that initiated it,
  - the reason code (accuracy/relevance/timeliness/completeness),
  - and the approval reference when human review is required.

###### 5) Evidence and reporting
- Produce a quarterly quality report covering:
  - how many records were checked,
  - counts by quality area (accuracy/relevance/timeliness/completeness),
  - what actions were taken (corrected/quarantined/deleted),
  - exceptions requiring manual review and what happened to them.
- Keep the reports and remediation logs as audit evidence.

###### WHO
- **Data Protection Officer (DPO) / Privacy Lead**: approves how strict the purpose/sensitivity rules are, and how deletion/quarantine is handled.
- **Information Security Lead**: ensures quality operations align with security and audit requirements.
- **Data Steward / Data Owner**: owns the PII field mapping and relevance rules.
- **Application/Data Engineering Team**: implements the address verification integration and the quarterly sweep/remediation workflows.
- **Operations/Compliance Analyst**: reviews exceptions and approves remediation outcomes where required.

###### Acceptance criteria
- Quarterly sweeps run successfully for all in-scope PII systems and produce evidence (report plus quality record entries).
- Each sweep checks **accuracy, relevance, timeliness, and completeness** and generates remediation actions.
- Address fields are verified using an automated address verification look-up service when collected/entered, and the verification results are stored.
- Inaccurate or out-of-date PII is corrected or deleted in line with the retention/disposal policy, and all changes are recorded in an auditable quality record.
- Any exceptions or ambiguous address matches are quarantined for human review rather than being changed automatically.

###### Actions Required for Compliance

- [ ] Create an official inventory that maps in-scope personal data (PII) fields to the systems that hold them, the reasons they are used, how sensitive they are, and the rules for how long they are kept and how they are disposed of.
- [ ] Set validation rules based on each item’s purpose and sensitivity to check accuracy, relevance, timeliness, and completeness, using quarterly threshold targets.
- [ ] Add an automated address verification check to every way we collect an address, and record the result of each verification.
- [ ] Set up a quarterly scheduled process to scan personal data (PII) storage locations, check data-quality rules, and create actions to fix any issues.
- [ ] Set up remediation so it can automatically fix issues in a consistent, repeatable way, place unclear or uncertain cases into quarantine, and only delete data when the retention and disposal policy allows it.
- [ ] Set up an auditable quality change log that records, for each exception, the field-by-field information before and after the change, the rule identifier, the time the change was made, and the approval details.
- [ ] Produce and keep quarterly quality reports and repair (remediation) records as evidence for audits.


---

#### SI-18.1 — Automation Support (Enhancement)

This expectation is about using built-in, automated checks to keep personal information accurate and protected. The organisation should automatically fix or remove details that are wrong, out of date, judged to carry the wrong privacy risk, or de-identified incorrectly. Without these checks, personal data that is inaccurate or not properly protected can cause people to be linked to the wrong records, break privacy commitments, or leave sensitive information visible when it should not be.

The organisation should run these automated correction and deletion steps within its on-premises personal information management platform, and only when the data quality rules are clearly defined and documented. It must assess and record any privacy risks that the automation could create, make sure decisions match its privacy plans, and ensure named staff with responsibility for privacy and information security oversee and validate the results.

The organisation must also produce quality reports and keep maintenance and audit records showing what was changed or deleted, why it was changed or deleted, and which automated process was used. It must review any audit findings and make improvements when needed.

##### On-prem PII platform automation for correction/deletion with audit trails

- Category: Software
- Priority: Critical

###### WHAT
Set up automated features inside the organisation’s **on-premises personally identifiable information (PII) management platform** that can **fix or remove** personally identifiable information (PII) when it is: (1) wrong or out of date, (2) assessed as having the wrong privacy impact, or (3) de-identified incorrectly.

###### WHY (control requirement)
The United States National Institute of Standards and Technology (NIST) **SI-18(1) Automation Support** requires that any automated features used to fix or remove PII are defined and work in a way that supports privacy risk governance. The guidance notes that automated data-quality tools can create privacy risks (for example, unintended links between systems). Organisations must therefore assess and document these risks in privacy impact assessments and ensure their decisions match the organisation’s privacy programme plans.

###### HOW (specific approach)
1. **Define clear rules for what counts as “good quality” PII and who is eligible for correction/removal** in the on-premises PII management platform for:
   - **Wrong or out-of-date information** (for example, time limits for when data becomes stale, values that are malformed or invalid, or values that fail checks against approved reference sources).
   - **Wrong privacy impact assessment** (for example, checks that the stored impact category matches the logic used in the documented decision).
   - **Incorrect de-identification** (for example, detecting leftover direct identifiers or signs that data could be re-identified in fields that are expected to be de-identified).
2. **Build the automation as version-controlled, “policy-as-code” workflows** inside the platform:
   - Keep the rule logic and the correction/removal actions as controlled, managed items.
   - Require peer review and formal approval before rule updates can be applied.
   - Ensure the workflow runs **only within the on-premises PII management platform** (no external “sidecar” systems should perform the correction/removal).
3. **Add safeguards to prevent unintended links**:
   - Limit any matching or enrichment to **approved, documented data sources**.
   - Use a “no external linkage” mode for automation where possible.
   - Set explicit confidence thresholds for linking records; if confidence is below the threshold, send the case to a **controlled review queue** instead of automatically correcting/removing it.
4. **Produce predictable results with evidence that can be audited**:
   - For each automated run, output structured results showing: the record identifier(s), the PII field(s) affected, the action taken (**correct** versus **delete/redact**), the reason code, and the **exact workflow/rule version** used.
   - Keep **maintenance logs** showing what was changed/removed and why, and ensure system audit records capture the automation execution details.
5. **Ensure automation decisions follow privacy governance**:
   - Link each rule set/workflow to the relevant **privacy impact assessment (PIA)** and the privacy programme plan decision.
   - Document the privacy risks of the automation (including unintended linking risks) and ensure day-to-day operational decisions follow those decisions.
6. **Set up named oversight and review**:
   - Send low-confidence or high-risk cases to a review queue for checking by staff with privacy and/or information security responsibilities.
   - Review audit findings on an agreed schedule and feed improvements back into the rule sets.

###### WHO (roles responsible)
- **PII Platform Owner / Data Protection Officer (DPO)**: owns rule governance, alignment to PIAs, and privacy impact decisions.
- **Privacy Engineering / Data Quality Engineering**: builds the rule sets, workflow logic, and evidence outputs.
- **Information Security / Audit & Compliance**: checks that audit logging is correct, evidence is complete, and reviews audit findings.
- **Authorised reviewers (privacy/security roles)**: review queued cases and approve remediation actions.

###### Acceptance criteria
- The on-premises PII management platform can **automatically correct or delete** PII that meets the defined eligibility criteria for wrong/out-of-date information, wrong privacy impact assessment, and incorrect de-identification.
- Automation runs **within the on-premises PII management platform** with no external system performing the correction/removal.
- For every automated change/removal, the platform produces **audit-ready evidence** showing what changed/was removed, when it happened, which rule/workflow version ran, and the reason code.
- The privacy risks of automation (including unintended linking) are **assessed and documented** in PIAs, and operational decisions are **aligned** to the privacy programme plan.
- Low-confidence/high-risk cases are **not applied automatically**; they are sent to an authorised review queue with documented oversight.

###### Actions Required for Compliance

- [ ] Define and document “rule packs” for the on-premises personal information (PII) management platform to address: inaccurate or outdated personal information (PII), incorrect privacy impact determinations, and incorrect de-identification.
- [ ] Set up correction and deletion processes within the on-premises personal identifiable information (PII) management platform, using predictable steps and clear rules for who is eligible.
- [ ] Set privacy-risk controls to limit matching and enrichment to approved sources, and require a minimum confidence level for linking—otherwise send the case to a review queue for manual checking.
- [ ] Ensure that every automated run produces structured evidence (including record and field identifiers, the action taken, the reason code, and the workflow or rule version), and store maintenance logs and system audit records.
- [ ] Link each rule pack and workflow to the relevant privacy impact assessment and the privacy programme plan decisions, and record the automation privacy risks (including the risk of unintended data linking).
- [ ] Set up authorised review procedures for cases in the queue, and agree a regular schedule to review audit findings and update the rule packs.


---

#### SI-18.2 — Data Tags (Enhancement)

This requirement is about using built-in labels on personal information so the organisation can automatically correct or delete it when it should no longer be kept. Without this, personal data could remain in systems for too long, be used when it should not be, or be handled in ways that break privacy commitments and laws—causing real harm to people and damaging the organisation’s reputation.

To meet this expectation, the organisation must define how the labels identify personal information and apply them consistently across the full life cycle of the data, from creation through use, storage, sharing, archiving and deletion. The labels must show what processing is allowed, who is authorised to access or use the data, whether the data has been made non-identifying, the potential impact if it is mishandled, the current life-cycle stage, and the required retention period (or the last updated date). This allows automated tools to reliably trigger the right correction or deletion without relying on manual judgement.

The organisation must document the procedures, assign named responsibility, include this approach in relevant policies and plans, maintain an up-to-date inventory of where personal information is held, and keep audit records and review evidence showing tagging and any automated actions. This should be supported by privacy impact and risk assessments and other governance evidence.

##### Machine-readable PII tags with automated correction/deletion

- Category: Software
- Priority: Critical

###### WHAT must be done
Add machine-readable labels (tags) to personal data (PII) so that automated systems can **fix or remove** that PII consistently throughout its full life cycle.

###### WHY (control requirement)
SI-18(2) enhancement requires using tags on PII that, at minimum, include labels for **what processing is allowed, who is authorised to process it, whether it has been de-identified, the impact level, the current stage of the information life cycle, and the retention date/last updated date**. This allows automation to **fix or delete** the relevant PII across the organisation’s systems.

###### HOW (specific steps/approach)
1. **Define a standard (canonical) PII tag format** for the application and its data stores. The format must record: what processing is allowed, who is authorised to process it, de-identification status, impact level, life cycle stage, and the retention/last-updated (or retention-until) date.
2. **Apply tags when data is first written or received** for every PII entry point (user interface forms, application programming interfaces (APIs), batch imports, and event streams). Ensure the application service layer (or data ingestion service) sets and checks the tags automatically using the standard format.
3. **Use tags to control life cycle changes**: when the life cycle stage changes (for example, active → archived → eligible for deletion), automated jobs/workflows must read the tags and carry out the required **correction or deletion** using platform interfaces (for example, database deletion, updating records to de-identify them, or purging from storage/software-as-a-service (SaaS) where supported).
4. **Add automatic checks** so tags cannot be contradictory (for example, a retention-until date is missing or has expired, de-identification status conflicts with what processing is allowed, or an invalid life cycle stage change is attempted). Send any exceptions to a controlled remediation process.
5. **Create audit records** for both (a) when tags are created or changed and (b) when automated systems carry out correction/deletion actions. Include correlation identifiers that link each automated action back to the tag values that triggered it.
6. **Put governance in place**: keep an inventory of where tagged PII is stored (tables/collections/objects/fields) and ensure the tagging approach is documented in the relevant system and privacy procedures, so that changes to retention or processing authority update the tag rules.

###### WHO (role responsible)
- **Application/Data Owner**: responsible for defining the standard tag format and life cycle rules.
- **Software Engineers / Data Engineers**: implement tagging at the time of data entry, set up validation checks, and build the automated jobs that enforce life cycle actions.
- **Privacy Officer / Data Protection Lead**: approves what the tags mean for permissions/authority/impact and the retention/last-updated logic.
- **Security/Compliance (Governance, Risk and Compliance (GRC))**: checks that audit evidence is sufficient and that procedures align with SI-18(2).

###### Acceptance criteria
- PII records/fields in the in-scope systems are tagged using the standard format, including the required elements: processing permissions, authority to process, de-identification status, impact level, life cycle stage, and retention/last-updated (or retention-until).
- Automated workflows can show (through logs/audit trails) that they **correct or delete PII** based on tag values, without manual judgement for routine cases.
- Tag checks prevent inconsistent tag states; exceptions are handled through an approved remediation process.
- Using a test dataset with known retention dates and life cycle stages, the system performs the expected correction/deletion and produces audit evidence linking the action to the tag values that triggered it.
- The organisation can produce an inventory of where tagged PII is located and demonstrate the documented procedures that govern tag meaning and life cycle transitions.

###### Actions Required for Compliance

- [ ] Define and publish a single, standard set of personal data (PII) labels that covers: who is allowed to access the data, the level of authority required, whether the data has been de-identified, the potential impact level, the stage of the data’s life cycle, and the retention period and last updated date.
- [ ] Set up automatic tagging for all personally identifiable information (PII) data being received or written (user interface, application programming interface, batch jobs, and event streams) using the agreed standard schema.
- [ ] Set up automated checks to ensure tags can only be changed in approved ways, and that all required tags are present and match each other consistently.
- [ ] Set up jobs or workflows that automatically enforce the correct handling of personal data (PII) based on its life cycle stage, and either correct or delete it according to the retention rules and the last-updated date.
- [ ] Keep audit logs for every tag that is created or changed, and for every automated correction or deletion action, linked to the tag values that triggered the action.
- [ ] Keep an up-to-date list of all locations that contain tagged personal data (tables, collections, objects, and fields), and update the list when systems change.


---

#### SI-18.3 — Collection (Enhancement)

This expectation is about collecting people’s personal information directly from them (or from someone they have formally authorised) when they complete the organisation’s own forms or screens, rather than using third-party assumptions or copied details. This matters because if information is wrong or comes from the wrong source, the organisation could make unfair or incorrect decisions about the person—for example, about eligibility for benefits or access to rights and services.

To meet this expectation, the organisation must provide a clear way for individuals to enter their own information through its user interface. It must also carry out sensible checks at the time the information is collected to confirm it is accurate, with stronger checks when the information will be used for high-stakes decisions.

The organisation should document how these checks work, who is responsible for carrying them out, involve the appropriate privacy and oversight roles, keep records showing when and how the information was collected and validated, and assess the privacy risks of collecting and validating this information.

##### Identity-bound PII intake with adaptive validation and audit evidence

- Category: Software
- Priority: Critical

###### WHAT
Set up organisation-controlled ways for people to enter information (for example, web, mobile, app, or assisted channels) that collect personally identifiable information (PII) **directly from the person** or **their designated/authorised representative**. Use **checks at the moment the information is entered** and keep **audit evidence** that shows **who entered the data** and **what checks were carried out**.

###### WHY (control requirement)
NIST SI-18(3) requires the organisation to **collect PII directly from the individual**. Further guidance expects the organisation to use validation steps that are **appropriate for the situation** and **how the PII will be used**—with **stronger checks** when the PII is used to make decisions about **rights, benefits, or privileges**.

###### HOW (specific steps/approach)
1. **Create PII entry journeys in the application user interface (UI)** for each relevant process (for example, registration, account creation, and benefits/service applications). Make sure PII fields are filled **only from the user/representative’s own entry** during that journey (no automatic “silent” pre-filling from a third party for the first capture).
2. **Link each submission to a verified logged-in identity** using the organisation’s enterprise identity provider (IdP) and session controls. For higher-risk entry journeys, require phishing-resistant multi-factor authentication (MFA) (for example, FIDO2/passkeys) to reduce the risk of incorrect data being submitted under an impersonated identity.
3. **Add checks at the point of entry** in the UI and/or application service using rule sets that are **versioned** and **can be audited**:
   - **Checks on individual fields**: validate format, length, and range (for example, whether a date of birth is plausible where lawful), check identifier structure, and check postcode/address consistency where available.
   - **Checks across multiple fields**: confirm related information matches (for example, name and date of birth plausibility where lawful; address and postcode mapping).
   - **Checks based on the process/context**: if the information is used for decisions about **rights/benefits/privileges**, apply stronger checks (for example, extra verification, stricter thresholds, or a mandatory review/confirmation).
4. **Support authorised representatives within the same UI flow**:
   - Ask the representative to select/confirm that they are acting as a representative.
   - Capture the representative’s identity using the same logged-in session.
   - Collect and store a reference to the authorisation/consent evidence (for example, an uploaded document reference or a case/appointment identifier) entered or linked through the UI.
5. **Create audit evidence for every submission**:
   - Record the UI/form identifier, time submitted, the authenticated identity (individual or representative), and the validation rule set version.
   - Log the result of each check (accepted/blocked/flagged) and any escalation or review triggers.
   - Send the logs to the organisation’s security information and event management (SIEM) or logging platform in line with existing retention requirements.
6. **Document the validation approach and responsibilities** in the application’s security and privacy documentation:
   - Explain which checks apply by PII type and how much the decision depends on it.
   - Define who reviews and approves escalations for high-impact decisions (privacy and security oversight roles).
   - Keep traceability between the documented rules and the deployed, versioned rule sets.

###### WHO (role responsible)
- **Application Owner / Product Owner**: ensures the correct entry journeys and how decision impact is classified.
- **Security Engineering / Identity and Access Management (IAM) Team**: implements identity linking and multi-factor authentication (MFA) requirements.
- **Privacy Officer / Data Protection Lead**: approves that checks are proportionate and lawful.
- **Developers / Platform Team**: implements the checks, the representative process, and audit logging.
- **Operations / Security Operations Centre (SOC)**: monitors audit logs and supports incident response for suspicious submissions.

###### Acceptance criteria
- For each configured entry journey, PII is collected through the organisation’s UI from the individual/authorised representative (no unauthorised third-party pre-filling for the initial capture).
- Each submission is technically linked to a verified logged-in session identity (individual or representative) and recorded in audit logs.
- Point-of-entry validation rules run and produce audit-ready results; journeys that lead to high-impact decisions use stronger checks and/or escalation.
- Audit records exist for every submission showing: UI/form ID, timestamp, authenticated identity, validation rule set version, and the validation outcome/escalation.
- The authorised representative process requires representative confirmation and stores an evidence reference linked to the submission, with all actions logged.

###### Actions Required for Compliance

- [ ] Add personal data (PII) collection forms to the application user interface, with no third-party information automatically filled in for the first submission.
- [ ] Require users to sign in through the organisation’s identity provider (IdP) and use phishing-resistant multi-factor authentication (MFA) for high-risk onboarding steps.
- [ ] Create version-controlled validation rules at the point where data is collected (both for individual fields and for relationships between fields), and build them into the submission process.
- [ ] Add an authorised representative workflow that records the representative’s status and stores an evidence reference through the same user interface (UI).
- [ ] Record and send audit events that include the user interface or form identifier, the authenticated user identity, the date and time, the version of the validation rules used, and the result of each validation.
- [ ] Define and document decision-impact levels (for example, rights, benefits, and privileges). Then apply stronger checks and escalation steps for the highest-impact levels.


---

#### SI-18.4 — Individual Requests (Enhancement)

This requirement is about ensuring people can correct or remove their personal information when they ask. If an organisation keeps incorrect personal information, it can lead to wrong decisions, missed benefits, or unfair treatment. Even correct information can sometimes cause harm if it is kept when it should not be.

To meet this, the organisation must provide a clear, documented process for individuals (or someone properly authorised to act for them) to request that their personal information be corrected or deleted. It must first verify that the request genuinely comes from the person, or from someone who is properly authorised to act on their behalf. It must then decide what to do—correct the information, delete it, or refuse the request—based on what the person asked for, the likely impact, and relevant laws and internal rules. Where there is any discretion, it should seek privacy and legal advice.

Finally, the organisation must carry out the approved changes and keep complete, verifiable records showing what was changed or deleted, when it happened, and who made the change, so the outcome can be checked later.

##### Privacy request portal for PII correction/deletion with audit evidence

- Category: Software
- Priority: Critical

###### WHAT
Set up an identity-first “Privacy Request Portal” and a case-handling process that lets individuals (or their authorised representatives) ask for their personally identifiable information (PII) to be corrected or deleted. Before any change is made, the portal verifies the requester’s identity and authority. It then applies the approved correction or deletion to the correct records and produces complete, verifiable evidence that links the request to the final outcome.

###### WHY (control requirement)
SI-18(4) requires the organisation to **correct or delete PII when individuals (or their authorised representatives) request it**, using discretion where appropriate (for example, based on scope, impact, relevant laws, and internal policies). It also requires consulting privacy and legal advisers when needed. The control guidance highlights the risk of incorrect PII and the need to balance correction or deletion against potential harm and legal, regulatory, and policy limits.

###### HOW (specific steps/approach)
1. **Provide a documented request route**: publish one main way to submit requests (a web portal, plus other accessible options). Capture the request type (correction or deletion), the PII fields/records being requested, and a description of the requester.
2. **Verify identity and authority before any action**: require strong, phishing-resistant identity checks for individuals (for example, FIDO2/passkeys or multi-factor authentication (MFA)). For representatives, require and validate proof of authorisation (including scope, expiry, and the relationship/authority). Record the result of these checks.
3. **Record request details for traceability**: keep structured case records that include the request reference, date received, the verification result for identity/authority, the PII items/fields requested, and the requester’s reason/description.
4. **Apply documented discretion with privacy/legal input**: use workflow decision points such as approve correction, approve deletion, refuse, or partially refuse. Set up policy rules so that privacy/legal advisers are consulted for high-impact cases or cases constrained by law.
5. **Carry out approved changes on the correct information**: connect the workflow to downstream systems (for example, customer relationship management (CRM), human resources information system (HRIS), customer data platform (CDP), and document storage) using controlled interfaces (application programming interfaces (APIs) and connectors) and field-by-field mapping to ensure the right attributes/records are updated.
6. **Keep complete, verifiable audit evidence**: for every approved action, record evidence that cannot be altered, linking request reference → decision → execution. Include who did what and when, which fields were changed or what deletion method was used, and the system responses. Where full deletion is not technically possible, use an approved “tombstone” or restricted-access approach and record the reason and method.

###### WHO
- **Data Protection Officer (DPO)/Privacy Lead**: sets the discretion criteria and when consultation is required.
- **Legal Counsel (Privacy/Legal)**: provides sign-off for cases that require consultation.
- **Application Owner / Product Owner**: ensures the portal and workflow are built and integrated with business systems.
- **Identity and Access Management (IAM) Team**: implements strong identity checks and supports representative verification.
- **Security/Compliance Team**: checks auditability, retention, and completeness of evidence.

###### Acceptance criteria
- A requester can submit a correction or deletion request and receive a case reference.
- The system verifies identity for individuals and authority for representatives **before** any PII change is made.
- For each request, the organisation can produce an audit trail showing: request details, verification outcomes, the decision rationale (including refusal or partial refusal where relevant), and execution evidence (fields changed or deletion method).
- Approved corrections/deletions are applied to the correct records/fields in connected downstream systems.
- Cases that meet the configured thresholds trigger privacy/legal consultation, and the resulting approvals are kept in the case record.
- Audit evidence is immutable (append-only) and is retained according to the organisation’s logging and retention requirements.

###### Actions Required for Compliance

- [ ] Create and publish one documented way to receive and process personal information (PII) correction or deletion requests, through the main portal and other accessible options.
- [ ] Integrate the portal with the organisation’s identity and access management (IAM) system to ensure phishing-resistant sign-in for individuals and stronger identity checks for representatives.
- [ ] Check that the person’s authority is valid for the right purpose, is still within the allowed time period, and is linked to the correct relationship. Record the result of this check in structured case evidence.
- [ ] Set up a case workflow with clear decision points (approve a correction, approve a deletion, refuse, or partially refuse) and automated policy checks that trigger privacy and legal review.
- [ ] Connect workflow results to downstream systems using approved application programming interfaces (APIs) and connectors, and use field-by-field mapping to update the correct personal data (PII) fields and records.
- [ ] Set up an unchangeable, add-only audit record that links: the request reference → the verification result → the reason for the decision → the execution outcome. If full deletion is not possible, include the “tombstone” or restricted-access approach in the record.


---

#### SI-18.5 — Notice of Correction or Deletion (Enhancement)

This requirement is about making sure people are told when their personal information is changed or removed. If your organisation corrects or deletes someone’s personal information, but the wrong people are not told, outdated or incorrect details could be used again. This could also cause partners or other organisations to continue acting on information that should no longer be relied upon.

To meet this expectation, the organisation must:
- identify the person concerned
- work out exactly which personal details were corrected or deleted, and when
- notify every authorised recipient who was previously given those affected details, explaining clearly whether the information has been corrected or deleted
- notify the individual concerned, or their recorded representative, with enough information to understand what was changed or removed

Notifications must be sent after the correction or deletion is completed. The organisation must also keep evidence showing who was notified and when.

##### Privacy correction/deletion notifications to recipients and individual

- Category: Software
- Priority: Critical

###### WHAT
Implement an auditable “privacy correction/deletion notice” capability that, whenever personal data is corrected or deleted, notifies:
1) all **authorised recipients** who were previously given the affected personal data, and
2) the **individual** (or their nominated representative),

with enough detail about what was corrected or deleted.

###### WHY (control requirement)
The National Institute of Standards and Technology (NIST) SI-18(5) enhancement requires: **“Notify {{ insert: param, si-18.05_odp }} and individuals that the personally identifiable information has been corrected or deleted.”** The guidance also requires making sure **all authorised recipients** and **the individual (or nominated representative)** are told about the corrected or deleted information when personal data is corrected or deleted.

###### HOW (specific steps/approach)
###### 1) Define the notification event and evidence (case-based)
- Create a privacy event record (case ID) for each correction/deletion, capturing: the individual identifier, the action type (corrected/deleted), the affected personal data fields/records, the completion time (when the system of record confirms the change), and references to supporting evidence.

###### 2) Identify the authorised recipients for that specific event
- For each case, work out the set of **authorised recipients** defined by **si-18.05_odp (recipients)** for the affected personal data and event.
- Implement recipient identification by linking to the organisation’s authoritative sources (for example, data-sharing/recipient registers, customer relationship management (CRM)/marketing distribution systems, and/or internal “who received what” logs for that personal data).
- Store the resolved recipient list (recipient identity plus destination/channel) against the case ID.

###### 3) Create notices with clear, field-level detail
- Use controlled templates that state:
  - whether the personal data was **corrected** or **deleted**,
  - which personal data elements were affected (with field-level detail appropriate to the purpose of the notice),
  - the effective completion time (or date) of the correction/deletion.
- Ensure the individual/representative notice includes enough information to understand what changed or was removed.

###### 4) Only send after the change is complete (“completion gate”)
- Notifications must be sent **after** the correction/deletion is completed.
- Use a completion gate so sending only happens when the system of record confirms success (for example, transaction confirmation, a successful application programming interface (API) response, or a workflow callback).

###### 5) Send notices and keep proof
- Send notifications to:
  - every authorised recipient resolved for the case, and
  - the individual (or nominated representative) using the contact details linked to the case.
- Record sending evidence: recipient identity, destination, time sent, message template/version, and the case ID.

###### 6) Provide audit-ready reporting
- Provide an internal audit view/application programming interface (API) that can retrieve, by case ID and individual ID, the affected personal data, completion time, recipient list, and notification evidence.

###### WHO
- **Data Protection Officer (DPO) / Privacy Lead**: approves the notice content, templates, and the mapping of who counts as **si-18.05_odp** recipients.
- **Application Owner / Engineering Lead**: builds the case model, completion gate, recipient reconciliation integration, and notification sending log.
- **Identity and Access Management (IAM) / Security Engineering**: ensures the individual/representative notification channel and any privacy portal access checks match organisational standards.

###### Acceptance criteria
- For each personal data correction/deletion event, the system creates a case record containing the affected personal data fields/records and a completion timestamp.
- The system identifies and stores the complete set of **authorised recipients** for that specific event (as defined by **si-18.05_odp**).
- Notifications to all authorised recipients and the individual/representative are sent **only after** the completion gate confirms the update/deletion succeeded.
- Each notification is logged with recipient identity/destination and timestamp, linked to the same case ID.
- An auditor can retrieve, for a given case ID, the affected personal data, completion time, recipient list, and proof that notifications were sent.

###### Actions Required for Compliance

- [ ] Create a privacy correction or deletion case template that includes: case ID, the personal data (PII) fields or records affected, the type of action to take, and the time the action was completed.
- [ ] Set up a completion gate so notifications are sent only after the system of record confirms that the correction or deletion was successful.
- [ ] Integrate recipient reconciliation to identify, resolve, and store the authorised recipient list for each case, in line with SI-18.05 ODP.
- [ ] Set up notification templates for corrected versus deleted personal data (PII), including enough detail at the field level for the individual or their representative.
- [ ] Send notifications to all resolved authorised recipients and to the individual (or their representative), using contact details linked to the case.
- [ ] Record the notification details (recipient identity, destination, date and time, and template version) against the case reference number, and make them available for audit retrieval.


---

### SI-19 — De-identification (Control)

This expectation is about removing personal information from data sets before they are used or shared, so that people cannot be identified from the data. Without this, information such as names, national identity numbers, passport or identity details, biometric records, and even details that may seem harmless—such as exact dates of birth or full addresses—could be exposed or combined to identify someone, especially when data sets are updated or linked together. This could cause privacy harm and may lead to regulatory breaches.

The organisation must:
- identify which data fields directly identify a person and which could help identify a person when combined with other information;
- decide which fields are not needed for the intended purpose;
- remove those fields, or change them in a way that makes them permanently non-identifying, using trained staff and, where appropriate, automated tools.

It must then check at least quarterly, and again after any change to the data set’s structure or the way data sets are linked, that the de-identification still works effectively. It must record the results, fix any weaknesses found, and keep this approach consistent with its privacy planning and assessments.

##### Automated de-identification release gate with quarterly effectiveness tests

- Category: Software
- Priority: Critical

###### WHAT
Put a standard process in place to remove identifying information from every dataset the application produces for analysis or sharing. The process must (1) set out which data items are direct identifiers and quasi-identifiers, (2) remove or permanently change those items when they are not needed for the dataset’s intended use, and (3) check at least every quarter—and again after any dataset structure or linking changes—that the de-identification still works.

###### WHY (control requirement)
SI-19 requires de-identification of datasets by breaking the link between identifying information and the person, including direct identifiers and quasi-identifiers (including fields that could be used to link records). It also requires checking how well the de-identification works at a set frequency and after any dataset structure or linking changes, recognising that re-identification is still a residual risk.

###### HOW (specific steps/approach)
1. **Define identifier types and allowed outputs**: Create an organisation-approved list mapping each dataset field to (a) direct identifiers (for example: name, Social Security Number (SSN)/passport/ID numbers, biometric records) and (b) quasi-identifiers (for example: exact date of birth, exact address, full date and place of birth). For each dataset purpose, define which identifiers are *not needed* and must therefore be removed or permanently changed (for example: exact date of birth → month/year or age band; exact address → region/postcode sector).
2. **Automate detection and enforcement in the data pipeline**: In the application’s Extract, Transform and Load (ETL) / Extract, Load and Transform (ELT) or data export step, implement automated checks to find likely direct/quasi-identifiers (including scanning the structure, matching patterns for ID formats, and basic profiling).
3. **Apply approved de-identification changes**: Use a version-controlled, repeatable set of changes (for example: removing columns, generalising values, suppressing values, tokenising with a non-reversible mapping where required) so that every output consistently matches the approved “allowed outputs” for that dataset purpose.
4. **Release gate (block non-compliant datasets)**: Add a publishing check that stops release if the output includes forbidden identifier fields or if sample values match “exact” patterns (for example: full date of birth format, full address components, biometric fields). Record the outcome of the check and the transformation/policy version used.
5. **Use trained staff to approve rules and exceptions**: Require privacy and security-trained analysts to approve the identifier list, the de-identification rules, and any exceptions. The pipeline must record who approved, the approval reference, and the policy version.
6. **Quarterly effectiveness checks and evidence**: At least every quarter, run a test suite against the latest released dataset versions (and a representative sample of rows) to confirm forbidden fields are not present and that the changes work as intended. Save the results as audit evidence.
7. **Re-check after structure/linking changes**: When the dataset structure changes or linking jobs are updated, automatically re-run the effectiveness tests and require sign-off before publishing the updated dataset.

###### WHO
- **Data Protection Officer / Privacy Lead**: owns the identifier list and the de-identification definitions for each dataset purpose.
- **Privacy/Security-trained Data Analysts**: approve the de-identification rules and exceptions; review the quarterly effectiveness results.
- **Data Engineering / Platform Engineering**: implements the de-identification changes, the release gate, and the automated test suite.
- **Application Owner**: ensures every dataset export/sharing route uses the standardised process.

###### Acceptance criteria
- For each dataset purpose, direct identifiers and quasi-identifiers defined as unnecessary are removed or permanently changed in all released outputs.
- The release gate blocks publishing when forbidden identifier fields are present in the dataset structure or detected in sample values.
- Quarterly effectiveness checks are carried out and the results are kept as auditable evidence.
- After any dataset structure or linking change, effectiveness tests are re-run and publishing is blocked until results are reviewed and approved.
- All de-identification rules and exceptions are approved by trained staff and recorded with policy/version evidence.

###### Actions Required for Compliance

- [ ] Create and get approval for an identifier taxonomy that maps direct identifiers and quasi-identifiers for each dataset’s purpose.
- [ ] Set up automated checks to identify possible direct or quasi-identifiers by discovering the data structure and value patterns during data import and export.
- [ ] Create versioned de-identification methods (remove, generalise, or suppress) that match the approved allowed outputs for each purpose.
- [ ] Set up a release gate that stops dataset publishing if forbidden identifier fields or exact-match values are detected.
- [ ] Set up an approval process for transformation rules and any exceptions, using trained staff, and record who approved them and which policy version was used.
- [ ] Run a quarterly test to check how effective the de-identification is on each released version of the dataset, and keep the audit records showing the test results.
- [ ] Automatically re-check how effective the de-identification is after any change to the dataset structure or how records are linked, and require approval before the data is released.


---

#### SI-19.1 — Collection (Enhancement)

This requirement is about ensuring you do not collect personal information that could identify a person in the first place. In practice, the risk is that collecting unnecessary details—such as names, addresses, dates of birth, or National Insurance or passport numbers—could lead to misuse, mishandling, or exposure of that information, causing legal, financial, and reputational harm.

To meet this expectation, the organisation must set clear rules in its privacy and data-handling approach. Every time data is collected, the system must be designed to exclude personal information at the point of collection. This includes identifying and removing any such fields from forms, file uploads, imports, and other ways of bringing data into the system.

The organisation must also use practical checks to prevent people and other systems from accidentally submitting those details, and it must verify that what is stored contains no personal information.

Finally, it must document how this is done, keep evidence of the decisions, and have named privacy and information-responsibility staff review and approve the collection design before it goes live.

##### PII-free intake via schema enforcement and PII exclusion catalogue

- Category: Software
- Priority: Critical

###### WHAT
Set up a “de-identify-by-collection” approach so that personal data is not asked for, received, or saved when information is first collected. This is done by removing personal data fields from intake screens and requiring “no personal data” formats (schemas) in the application programming interface (API) and data intake processes.

###### WHY (control requirement)
The National Institute of Standards and Technology (NIST) SI-19(1) requires: **“De-identify the dataset upon collection by not collecting personally identifiable information.”** The guidance allows de-identification by **not collecting** personal data elements when they are not intended to be used.

###### HOW (specific steps/approach)
1. **Create and keep up to date a version-controlled list of what must be excluded**: map each data source or intake method (web form, mobile form, API endpoint, file upload/import, batch job) to the exact personal data elements that must not be collected.
2. **Apply “no personal data” rules at the point of intake**:
   - For web and app forms: remove personal data fields completely from the user interface and any customer-side (client-side) data models.
   - For APIs: use strict request checks (for example, OpenAPI/JSON Schema) so requests that include excluded personal data keys are rejected (HTTP 4xx) and never proceed to saving.
   - For file uploads and imports: check the file column headings and reject any files that include excluded personal data columns (or send them to a quarantine process that does not fill the target dataset).
3. **Ensure personal data is not saved on the server**: build server-side checks so that even if a user tries to change requests, excluded personal data fields are removed and never written to the database, message bus, or any later downstream datasets.
4. **Add automated checks in continuous integration and continuous delivery (CI/CD)**:
   - Submit test data that includes representative personal data values for each excluded element.
   - Confirm one of the acceptable outcomes: the field does not appear in the saved record, the submission is rejected, or the data is quarantined and not saved in the dataset.
5. **Keep audit-ready proof**: save the version of the personal data exclusion list, any schema or policy changes, the CI/CD test results, and a report showing verification of saved records as part of the system’s privacy and data-handling evidence.

###### WHO (role responsible)
- **Data Protection Officer / Privacy Lead**: owns and approves the personal data exclusion list and the intake de-identification decisions.
- **Application Owner / Engineering Lead**: implements the schema enforcement and “do not save” controls in the application and data intake pipelines.
- **Security Engineer**: ensures the server-side controls cannot be bypassed and that evidence is kept for audit.

###### Acceptance criteria
- For every configured intake method, excluded personal data fields are **not requested** (removed from the user interface), **not accepted** (rejected by API schema checks or ingestion checks), and **not saved** (the database or dataset contains no excluded personal data elements).
- CI/CD includes automated tests showing that submissions containing personal data do not result in stored personal data in the target dataset.
- Evidence exists showing the enforced version of the personal data exclusion list and the results of the verification tests for the deployed release.

###### Actions Required for Compliance

- [ ] Create a version-controlled catalogue of personally identifiable information (PII) exclusions that maps each data intake source to the PII elements that are excluded.
- [ ] Remove any excluded personal data (PII) fields from all user interface (UI) and form definitions, and from all client-side intake models.
- [ ] Apply strict checks to ensure every application programming interface (API) request follows the required format, and reject any request that includes excluded personal identifiable information (PII) fields.
- [ ] Add server-side controls to remove (or exclude) any excluded personal data fields before saving them to storage.
- [ ] Check that uploaded or imported files use the correct header format for the “no personal information” (PII) schema. Reject the file or place it in quarantine if it contains any excluded PII columns.
- [ ] Add continuous integration and continuous delivery (CI/CD) tests that submit representative personal data (PII) values and verify that the data is not stored or is rejected.
- [ ] Keep records showing the version of the personal data (PII) exclusion catalogue, any changes made to how the data format is enforced (schema enforcement), and the test results, so they are available for audit.


---

#### SI-19.2 — Archiving (Enhancement)

This requirement is about ensuring that, when we keep older records for later use, we only store the personal information that is actually needed for the approved purpose.

The risk it addresses is that unnecessary personal details could be kept in archives “just in case”, which would make it easier for the wrong people to access the information, misuse it, or expose it during audits, transfers, or future releases.

To meet this expectation, the organisation must:
- Clearly state why each archived dataset is being kept.
- Identify which specific items in each dataset are personal identifiers.
- Decide and record whether each personal item will still be needed after archiving for that approved purpose.

Any personal item marked as not needed must be excluded from the archived dataset, based on the recorded decisions.

Where possible, this should be enforced using automated checks. Named staff must be responsible for the decisions, and evidence must be kept showing what was excluded and why.

##### PII-minimising archive contract enforced by policy-as-code

- Category: Software
- Priority: Critical

###### WHAT
For each dataset, create an “archive contract” that states the approved reason for keeping the data after archiving. For every personally identifiable information (PII) item in the dataset, record whether it is needed after archiving. Apply this contract at the point where data is archived, so that any PII items marked *not needed after archiving* are not allowed to be written into the archived dataset (or are automatically removed, masked, or tokenised according to the contract).

###### WHY (control requirement)
The National Institute of Standards and Technology (NIST) SI-19(2) requires: **“Prohibit archiving of personally identifiable information elements if those elements in a dataset will not be needed after the dataset is archived.”** The guidance also explains that if PII is only needed for linking or other temporary purposes, it should not be carried into the archived dataset unless it is required for the approved archive purpose.

###### HOW (specific steps/approach)
1. **Create a versioned archive contract artefact for each dataset** that includes:
   - The approved archive purpose(s) for the dataset.
   - A list of PII items (field/attribute identifiers) in the dataset.
   - For each PII item: a recorded decision **“needed after archiving: yes/no”** that matches the approved purpose.
   - The allowed handling rule for “no” (for example: drop the field, mask it, tokenise it, or blank it) and the required output structure.
2. **Add policy checks in the archiving process** so the archive job cannot finish unless the output matches the contract:
   - Confirm the selected archive purpose matches the contract.
   - Confirm the output structure and fields match the contract’s allowed fields.
   - Identify any forbidden PII items in the data being archived.
   - Use **fail-closed** by default: if forbidden PII items are present and are not handled as the contract requires, the job is stopped.
3. **Produce the archived dataset only through a controlled transformation step** that uses the same contract version, ensuring the archived output matches the recorded decisions.
4. **Automatically record audit evidence for every archive run**, including:
   - Contract version, dataset identifier, archive purpose, and approver identity.
   - Policy check result (pass/fail) and the handling actions applied.
   - A list of archived fields (and, where possible, a sample proof at schema or record level showing forbidden PII was excluded or handled).
5. **Link to monitoring and security information and event management (SIEM)** so that attempts to break the rules (for example, including forbidden PII fields) trigger alerts and are sent to the dataset owner and the privacy/governance role for correction.

###### WHO (role responsible)
- **Data Protection Officer / Privacy Lead (or equivalent)**: approves the archive purpose and the per-PII “needed after archiving” decisions.
- **Data/Information Owner (dataset steward)**: maintains the archive contract and ensures it reflects the real dataset content.
- **Application/Data Engineering Lead**: implements the policy checks and the controlled transformation in the archiving pipeline.
- **Security/Compliance (with SIEM operations)**: monitors alerts and ensures audit evidence is kept.

###### Acceptance criteria
- For every archived dataset, an **archive contract exists** and is versioned.
- For every PII item in the dataset, the contract records **needed-after-archiving = yes/no** aligned to the approved purpose.
- Archived outputs **never include** PII items marked “not needed after archiving” (confirmed by the field list and policy check logs).
- Archive jobs **fail closed** when forbidden PII is found without the contract-approved handling.
- Each archive run produces **audit-ready evidence** (contract version, approver identity, policy result, and archived field list).

###### Actions Required for Compliance

- [ ] Create an archive contract template that records the approved reason for archiving and the specific personal data (per person) that must be kept after archiving.
- [ ] For each dataset, identify and record the personal data (PII) elements (field or attribute identifiers), and link them to the archive contract.
- [ ] Add policy-as-code checks to the archiving process so it stops and does not proceed (“fails closed”) if forbidden personal data fields are found.
- [ ] Carry out a controlled change step that removes, hides, or replaces data only in line with the contract version.
- [ ] Automate the creation of evidence for each archive run, including the contract version, the identity of the approver, the policy outcome, and the archived field list.
- [ ] Set up security information and event management (SIEM) alerts for attempted archive jobs that break the contract, and send them to the dataset owner or the personal data (PII) governance role.


---

#### SI-19.3 — Release (Enhancement)

This expectation is about making sure that when you share a dataset, you do not accidentally include personal information about people that is not needed for the purpose of the sharing. Without this, someone could use the released information to identify individuals, which can cause privacy harm, complaints, regulatory action, and loss of trust.

To meet this expectation, before any dataset is released, the organisation must review how the data will be used and, for each type of personal information, decide whether it is necessary. If it is not necessary, the organisation must remove it. If removal alone is not enough, the organisation must change it so individuals cannot be easily identified, using approved methods and any available automated tools that help with removing identifying details.

Named, authorised people with privacy and information responsibilities must carry out and/or approve the process of removing identifying details, ensure the release system only publishes the cleaned version, complete the required privacy assessments, and keep clear records showing what decisions were made and what actions were taken before release.

##### PII release gate with automated de-identification and hard block

- Category: Software
- Priority: Critical

###### WHAT
Set up a mandatory “dataset release gate” that (1) checks whether personal data is needed for the intended use and (2) removes or disguises any personal data that is not needed, using approved and enforceable methods. The gate must stop the release if personal data is still present after the changes are applied.

###### WHY (control requirement)
SI-19(3) requires that personal data elements are removed from a dataset before it is released when those elements do not need to be included in the release. The guidance also requires the data custodian to consider the intended use, decide what is necessary, and then apply disguising (de-identification) methods when personal data is not needed.

###### HOW (specific steps/approach)
1. **Create a central release process** (a data governance platform or a ticketing/approval system) that every external or unauthorised dataset export must go through. The process must record: the dataset identifier, intended use, recipient type (external/unauthorised), and a decision for each personal data element on whether it is necessary.
2. **Set approved disguising methods as enforceable rules** (for example: remove direct identifiers; mask email addresses and phone numbers; generalise dates; replace stable identifiers with tokens) and keep them versioned. Store the rule versions and the transformation logic so changes can be audited.
3. **Add automated personal data detection and supporting evidence** to the process to identify personal data in the dataset (using the data structure/schema and, where possible, the full export or sample). Produce a detection report showing what was found, the confidence level, and the evidence.
4. **Apply the approved changes automatically** to create the release-ready dataset, and produce a transformation evidence report showing what changed (before/after mapping), which rule versions were used, and how many records were affected.
5. **Enforce a strict “no release” block**: the process must not allow release if automated checks show disallowed personal data remains in the output after the changes (or if detection confidence is above an agreed threshold and the issue cannot be resolved).
6. **Require named human approval**: the data custodian (and privacy and information security authorised roles) must approve (a) the necessity decisions and (b) any exception handling where personal data retention is proposed. Approvals must be recorded against the specific dataset release request.
7. **Link all records needed for audit**: attach the release decision record, transformation evidence, and references to the relevant privacy assessment (PIA) and security/privacy plan sections to the release process record.

###### WHO (role responsible)
- **Data custodian**: completes the intended-use review and the per-personal-data necessity decisions.
- **Privacy officer / information security lead (authorised roles)**: approves the necessity decisions and any exceptions; confirms the release gate output.
- **Platform/data engineering team**: builds the release process integration, the enforceable rules, and the automated personal data detection and transformation.
- **Audit/compliance function**: periodically reviews release gate logs and checks that evidence is complete.

###### Acceptance criteria
- No dataset marked for external or unauthorised release can be published unless it passes the release gate.
- For each release request, the system must produce: (1) intended-use/necessity decisions, (2) automated personal data detection evidence, (3) transformation evidence showing the approved disguising was applied, and (4) a clear pass/fail outcome.
- Releases are blocked when disallowed personal data is detected in the post-change dataset output.
- All approvals and transformation records are kept with tamper-resistant audit logging and can be retrieved using the dataset identifier and the release request ID.

###### Actions Required for Compliance

- [ ] Set up a required process for releasing datasets to external or unauthorised recipients, where you must record (1) the intended use and (2) whether each piece of personal data is necessary for that purpose.
- [ ] Set up “policy-as-code” to automatically apply only approved de-identification transformations, and keep versioned copies of the rules so changes can be audited.
- [ ] Add automated personal data (PII) discovery to the release process so that, for each dataset, you automatically produce proof of detection evidence.
- [ ] Automate the application of approved data de-identification changes and produce reports showing the data before and after the changes as evidence
- [ ] Set up a “hard release block” so publishing is stopped if, after data transformation, disallowed personal data (PII) is detected.
- [ ] Require named human approval from authorised privacy and security roles for decisions on whether something is necessary, and for any exceptions.
- [ ] Enable permanent (unchangeable) audit logs and link release decisions, transformation evidence, and privacy impact assessment (PIA) and security plan references to each release record.


---

#### SI-19.4 — Removal, Masking, Encryption, Hashing, or Replacement of Direct Identifiers (Enhancement)

This requirement is about ensuring that datasets no longer include obvious personal details such as names, identification numbers, or other direct references. If this is not done, sensitive information could be traced back to real people, which could result in privacy breaches, unwanted profiling, or misuse of personal data.

To meet this expectation, the organisation must use approved de-identification methods to remove, hide, encrypt, convert to a coded form (hash), or replace direct identifiers in datasets. The organisation should choose the approach that best keeps the data useful while protecting privacy.

If identifiers are changed in a way that still allows records to be linked together, the organisation must use suitable methods and keys. Stronger protection is required when different keys are used for different identifiers.

The organisation must also document the resulting de-identified datasets and ensure they are supported by appropriate tools or automated processes. Clear responsibility must be assigned to staff who have information security and privacy duties.

##### Automated de-identification of direct identifiers in datasets

- Category: Software
- Priority: Critical

###### WHAT must be done
Set up an approved, repeatable process to **remove, hide (mask), encrypt, hash, or replace direct identifiers** in datasets before they are stored, exported, shared, or used for analysis.

###### WHY (control requirement)
The National Institute of Standards and Technology (NIST) **SI-19(4)** enhancement requires that direct identifiers in a dataset are **removed, masked, encrypted, hashed, or replaced**. It also requires that when **encryption or hashing** is used, **approved methods (algorithms)** are used and **keys are used** (for example, AES or HMAC). Key use must be controlled (for example, using the same key versus different keys for different identifiers).

###### HOW (specific steps/approach)
1. **Define approved de-identification methods for each identifier type** in the organisation’s de-identification procedure:  
   - **Removal** (delete the field/column) where the business purpose does not need the identifier.  
   - **Masking** (for example, fixed repeating characters) where partial recognisability is acceptable.  
   - **Hashing** (for example, HMAC) or **encryption** (for example, AES) where linked records must still be connectable.  
   - **Replacement** with a keyword or substitute value where cryptographic linking is not needed.  

2. **Implement an automated de-identification service/library** integrated into the application’s data pipeline(s) (for example, extract, transform, load (ETL) / extract, load, transform (ELT) jobs, streaming data changes, API export endpoints, reporting jobs):  
   - Use a **data dictionary** (or schema registry) to identify which fields are direct identifiers.  
   - Apply the agreed transformation **when the dataset is created or exported**, and ensure any derived datasets are also processed.  

3. **Use key-based cryptographic methods where required**:  
   - For **hashing**: use an **HMAC-style approach** with an organisation-approved key.  
   - For **encryption**: use **AES** with an organisation-approved key.  
   - Where feasible, use **different keys for each identifier** (or for each identifier category), as this provides a higher level of security.  
   - Store keys in the enterprise **secrets/key vault** and control access using the existing identity and access management.  

4. **Ensure consistency and keep audit evidence**:  
   - Version the de-identification settings (method, identifier field mapping, key version, pipeline version).  
   - Record events for each transformation (dataset ID, fields changed, method used, key version) to support audit evidence.  

5. **Check results automatically**:  
   - Add automated tests that stop the build/release if direct identifier patterns/values appear in outputs (including checks for identifier columns and checks for known identifier formats).  
   - Where deterministic tokenisation/encryption/hashing is used, validate that linking still works (for example, joins still function).  

###### WHO (role responsible)
- **Data Protection Officer / Privacy Lead**: approves which de-identification method to use and whether linking is acceptable.  
- **Application/Data Engineering Lead**: builds the de-identification service and integrates it into the pipelines.  
- **Security Architect / Cryptography Subject Matter Expert (SME)**: approves the approved methods and key strategy (including using different keys per identifier where feasible).  
- **Platform/DevOps Lead**: ensures key vault integration, logging, and automated validation are deployed across environments.  

###### Acceptance criteria
- For every dataset identified as containing direct identifiers, the production/exported dataset contains **no direct identifier values in clear form** (using the approved method: removed/masked/encrypted/hashed/replaced).  
- If encryption/hashing is used, the implementation uses **approved algorithms** (AES for encryption; HMAC-style for hashing) and uses **vault-managed keys**.  
- The system records **evidence**: the transformation configuration version, the method used per field, and the **key version** used.  
- Automated validation checks show that direct identifier columns/values are not present in outputs, and that linking works where required.

###### Actions Required for Compliance

- [ ] Create and get approval for a de-identification mapping that, for each direct identifier field, states whether to remove, mask, encrypt, hash, or replace it.
- [ ] Set up a data de-identification step and include it in every way data sets are created and exported (extract, transform and load (ETL) / extract, load and transform (ELT), streaming, reporting, and application programming interface (API) exports).
- [ ] Set up encryption and hashing using only approved methods (use **Advanced Encryption Standard (AES)** for encryption and **hash-based message authentication code (HMAC)-style** methods for hashing), and ensure encryption keys are stored and used from the secure vault.
- [ ] Use a key strategy that, where possible, uses different keys for each identifier (or for each type of identifier), and record which key version was used.
- [ ] Add automated validation tests that fail if output includes direct identifier columns or values, and check that linked data is correctly connected where required.
- [ ] Enable audit records that capture the dataset ID, the fields that were changed, the method used, and the key version, and keep this evidence for audit purposes.


---

#### SI-19.5 — Statistical Disclosure Control (Enhancement)

This requirement is about making sure that any numbers, tables, or conclusions an organisation publishes or shares cannot be used to identify a specific person or organisation. Without this, even “summary” information can accidentally reveal who someone is—especially when different releases are compared or combined. For example, it may be possible to spot a single person’s details by looking at small changes in counts over time.

To meet this expectation, the organisation must set clear written rules for how it will change or anonymise published results. Before anything is released, it must check that the proposed figures cannot identify anyone. It must also ensure the protection still works even if multiple summaries are viewed together.

The organisation must apply these protections to raw numerical figures, tables that combine categories, and any statistical findings. It must use its documented anonymisation approach and keep anonymised data for analysis.

It must also record how the risk of disclosure was assessed, including the methods and tools used, and name the responsible staff. Finally, it must verify and keep evidence that every released output meets the requirement that it cannot identify individuals or organisations.

##### Automated statistical disclosure control in release pipeline

- Category: Software
- Priority: Critical

###### WHAT
Implement an automated release process that alters or anonymises numerical data, contingency tables, and statistical results so that no individual or organisation can be identified from the published outputs (including by combining information across multiple releases).

###### WHY (control requirement)
National Institute of Standards and Technology (NIST) SI-19(5) requires that numerical data, contingency tables, and statistical findings are altered or anonymised so that no individual or organisation is identifiable in the analysis results. The guidance also highlights the risk of identification by comparing multiple releases—for example, where small counts in one month, combined with other months, could reveal someone’s information.

###### HOW (specific steps/approach)
1. **Define disclosure rules as enforceable policy**: Create a version-controlled “statistical disclosure control policy” that sets, for each output type (counts, rates, averages, contingency tables, and statistical findings), which changes are allowed (for example, hiding small values, rounding, dominance checks, and removing identifying categories) and the conditions for release (pass/fail criteria).
2. **Route all publishable outputs through a controlled pipeline**: Ensure the application publishes statistical outputs only through a dedicated service/workflow that uses **de-identified analysis datasets** (any raw identifiers stay in restricted storage) and produces **de-identified release outputs**.
3. **Run disclosure-risk checks before release**: For each proposed output, automatically calculate disclosure-risk indicators and apply the policy rules, including:
   - contingency-table checks (for example, minimum cell size, dominance/uniqueness patterns, and rules for hiding or combining cells);
   - numerical output checks (for example, rounding/hiding thresholds and stability checks for small groups);
   - statistical finding checks (for example, hiding results for small samples, and hiding/flagging unstable coefficients or subgroup results).
4. **Add multi-release inference checks (linking/differencing)**: For time-based or repeated reporting, run automated checks to estimate whether successive releases could allow someone to isolate an individual/organisation—for example, by running differencing simulations across adjacent periods and detecting repeated table structures or cell patterns.
5. **Generate audit-ready evidence for each release**: Produce an analysis/disclosure report that records the inputs (de-identified dataset identifiers), the changes applied, risk metrics, tool versions, and the final pass/fail decision; keep this evidence for audit.
6. **Enforce release gating and approvals**: Prevent publication unless the pipeline meets the non-identifiability requirements; allow an explicit, logged exception workflow only when the policy permits—otherwise default to hiding/withholding.

###### WHO
- **Data/Privacy Engineering Lead**: owns the disclosure control policy-as-code and pipeline design.
- **Analytics/Business Intelligence (BI) Release Owner**: ensures all reporting outputs are routed through the pipeline.
- **Privacy Officer / Data Protection Officer (DPO)** (or delegated privacy governance): reviews and approves policy thresholds and exception criteria.
- **Security/Compliance Engineer**: ensures audit logging, evidence retention, and integration with governance processes.

###### Acceptance criteria
- Every published numerical output, contingency table, and statistical finding is produced by the disclosure-controlled pipeline (no direct bypass).
- For each release output, the pipeline produces an audit-ready disclosure report showing which policy rules were applied and the pass/fail risk results.
- Multi-release inference checks are run for repeated/time-series outputs, and releases are blocked or hidden when inference risk exceeds the defined thresholds.
- De-identified datasets are used for analysis and release, and raw identifiers are not included in release outputs.
- Evidence (policy version, tool versions, risk metrics, changes applied, and decisions) is retained and can be retrieved for audit.

###### Actions Required for Compliance

- [ ] Create a version-controlled “policy as code” statistical disclosure control policy that defines suppression, rounding, and dominance rules for each output type.
- [ ] Set up a controlled process that moves analytics results to release only when the outputs were created using de-identified datasets.
- [ ] Add automated checks to assess disclosure risk for contingency tables and numerical or statistical findings, using policy-based pass or fail rules to allow or block publication.
- [ ] Set up checks that run across multiple release versions to confirm repeated reporting outputs are consistent, using time-series difference and linkage simulations.
- [ ] For each software release, generate and keep an auditable disclosure report that includes the changes made (transformations), the risk measures (risk metrics), and the versions of the tools and policies used.
- [ ] Set up a process that blocks releases unless release requirements are met, and use a logged exception process that, if the requirements are not met, defaults to suppressing or withholding the release.


---

#### SI-19.6 — Differential Privacy (Enhancement)

This requirement is about protecting people’s privacy when you publish or share results from analysing personal information. It means deliberately adding small, unpredictable random variation to the figures before anyone can see them. Without this, even “de-identified” statistics could still be linked back to individuals—especially if the same results are repeated or combined—leading to unwanted disclosure and loss of trust.

To meet this requirement, the organisation must use **differential privacy** when producing de-identified outputs. This means the random noise must be added automatically as part of generating the final results (not after release, and not just described in documents). This should apply to results from online queries and, where used, to outputs from statistical learning and to synthetic data.

The organisation must also measure and record how much the privacy protection reduces accuracy or usefulness, keep the supporting privacy assessment evidence, and appoint named people with responsibility for privacy and information security to oversee and approve the approach.

##### Differential privacy noise injection in DP analytics outputs

- Category: Software
- Priority: Critical

###### WHAT
Implement differential privacy (DP) by adding **non-deterministic (random) noise** to the results of mathematical operations **before** any de-identified outputs are reported or returned to users. Apply this to (a) **online query/analytics** responses and (b) any **DP-based machine-learning outputs** and/or **synthetic data** produced from personal data.

###### WHY (control requirement)
SI-19(6) enhancement requires: **“Prevent disclosure of personally identifiable information by adding non-deterministic noise to the results of mathematical operations before the results are reported.”** The guidance further requires DP to be applied to outputs (including online query systems) and recognises the need to **measure the privacy versus usefulness (accuracy/utility) trade-off**.

###### HOW (specific approach)
1. **Create a DP output boundary**: send all personal-data-derived analytics queries, machine-learning inference outputs (when they are derived from personal data), and synthetic-data generation through a DP-enabled service/library so that noise is added **while the response is being created**.
2. **Use the right DP method for each output type**: for each metric/output (for example, counts, averages, histograms, and other summaries), choose and configure an appropriate DP method and set the noise level to meet the agreed privacy settings.
3. **Ensure the noise is non-deterministic**: use a cryptographically secure source of randomness for generating DP noise, and make sure the DP method runs at the time of the request (not by changing the output after it has been released).
4. **Control privacy budgets and manage queries**: put in place per-user/per-tenant privacy budget controls (ε, δ) and apply rate limiting or denial when budgets are used up to reduce the risk of cumulative disclosure from repeated queries.
5. **Measure and record the trade-offs**: run tests comparing non-DP versus DP outputs to see how much usefulness (accuracy/utility) is reduced; record the chosen privacy settings and the measured impact as part of privacy impact/risk evidence.
6. **Keep audit-ready evidence and approvals**: store DP settings as configuration-as-code for DP parameters, budget rules, and query policies; keep evidence of calibration, evaluations, and approvals by named responsible roles.

###### WHO
- **Data Protection Officer (DPO) / Privacy Lead**: approves the DP approach, privacy settings, and acceptance of the trade-off.
- **Application/Data Engineering Lead**: implements the DP-enabled analytics boundary and integrates DP methods.
- **Security Architect / AppSec**: checks that non-deterministic noise is generated correctly, that secure randomness is used, and that the approach is auditable.
- **System Owner**: ensures the DP configuration is deployed consistently across environments (development/testing/production/disaster recovery) and kept up to date.

###### Acceptance criteria
- For every endpoint/query that returns de-identified results derived from personal data, the response is produced by a DP-enabled component that adds **non-deterministic noise before** returning results.
- DP noise generation uses a secure randomness source and runs at the time of the request (no deterministic/post-release noise).
- Privacy budgets (ε, δ) are enforced so that repeated querying is limited, and when budgets are exhausted the system denies or throttles requests.
- Documented evaluation evidence exists showing the measured privacy versus usefulness (accuracy/utility) trade-offs for each major output type.
- DP settings, budget rules, and query policies are stored as version-controlled configuration with recorded approvals, and audit evidence is retained.

###### Actions Required for Compliance

- [ ] Identify all application endpoints and jobs that generate de-identified outputs based on personal data, including data from user queries, machine learning (ML) outputs, and synthetic data.
- [ ] Set up a data-processing boundary or service that uses differential privacy so that all relevant outputs are produced by the differential privacy mechanism when the response is generated.
- [ ] Set up calibrated differential privacy (DP) controls for each output type, and make sure the noise is created using a cryptographically secure, unpredictable source of randomness.
- [ ] Set and enforce privacy limits (ε and δ). If a user repeats queries beyond those limits, block the requests or slow them down (throttle) to prevent further use.
- [ ] Run and record differential privacy (DP) evaluation experiments to measure how accurate the results are, and how much usefulness is lost, for each output category under the chosen privacy settings.
- [ ] Store data processing (DP) settings, budget rules, and query policies in version-controlled configuration, and keep audit records showing approvals and calibration.


---

#### SI-19.7 — Validated Algorithms and Software (Enhancement)

This requirement is about making sure that when personal information is removed from data, it is done using methods that have been proven to work, and the software that carries out those methods is also proven to do it correctly. Without this, you might believe you have protected people’s information, but the “scrubbing” could still leave behind details that can identify someone, or it could work for one type of data but not another (for example, different kinds of numbers or dates). It could also change after a software update without anyone noticing.

To meet this expectation, the organisation must use de-identification methods (de-identification algorithms) that have been tested and validated for the specific types of personal data in scope, and it must use only de-identification software that has been validated to run those exact methods. The organisation must keep clear records showing which de-identification method and software version applies to each type of data, make sure the live (production) setup matches what was validated, and re-check that any changes to the de-identification components do not affect the validated behaviour.

##### Pin and validate de-identification algorithms/software via dID-BOM

- Category: Software
- Priority: Critical

###### WHAT
Set up de-identification using **validated algorithms** and **validated software** that are proven to carry out those algorithms correctly. Also make sure the production data-processing pipeline uses the **exact validated algorithm/software version** for each in-scope data type and dataset context.

###### WHY (control requirement)
SI-19(7) requires: “Perform de-identification using validated algorithms and software that is validated to implement the algorithms.” The guidance highlights risks such as:
- de-identification may still leave data that can be identified
- it may work for one data type but not another (for example, integers versus floating point numbers)
- the software may use a different algorithm than intended or contain defects (bugs)

###### HOW (specific approach)
Create and enforce a **de-identification Validation Bill of Materials (dID-BOM)**, and stop de-identification jobs so they **fail closed** if the configured algorithm/software does not match the validated record.

1. **Build a dID-BOM registry** that maps each in-scope PII data type and dataset context (for example, string/date formats, integer versus floating point, locale-specific date formats, and null/edge cases) to:
   - the validated algorithm identifier and version
   - the validated de-identification software component/build (for example, container digest, signed build ID, package lock hash)
   - a link to the validation evidence/report
   - the required input/output rules (field typing rules and expected transformation behaviour)
2. **Lock the de-identification runtime** so the pipeline cannot change behaviour without you knowing:
   - deploy the de-identification component using unchangeable artefact identifiers (container digest / signed build ID)
   - record those identifiers in the dID-BOM
3. **Enforce that the algorithm matches the software**:
   - use “policy-as-code” in continuous integration and continuous delivery (CI/CD) and during runtime (pre-check admission control) to compare the job’s configured algorithm/software identifiers against the dID-BOM
   - if there is any mismatch (algorithm version, software build, or schema contract version), **block the job** and raise an alert for approval or re-validation
4. **Run automated regression tests for each validated data type/context**:
   - keep a “golden” test set that covers each validated data type/context and edge cases
   - confirm the outputs meet validation expectations (for example, no remaining direct identifiers; correct handling of numeric formats and floating point; correct date parsing/formatting)
5. **Control changes**:
   - any change to the algorithm selection, de-identification library/component version, or configuration that could affect transformation behaviour must trigger an impact assessment workflow that either re-validates or selects an already-validated equivalent from the dID-BOM

###### WHO
- **Data Protection Officer / Privacy Lead**: owns the inventory of in-scope PII data types/contexts and approves the mapping to validation evidence.
- **Application/Data Engineering Lead**: builds the dID-BOM registry, implements pipeline pinning, and sets up regression tests.
- **Security/Compliance Engineer**: implements the policy-as-code enforcement and ensures evidence is ready for audit.
- **Release Manager / Change Manager**: ensures change requests follow the re-validation/approved-equivalent route.

###### Acceptance criteria
- For every in-scope PII data type/context, the dID-BOM includes a validated algorithm identifier/version and the exact validated de-identification software build identifier.
- De-identification pipeline jobs **fail closed** when algorithm/software identifiers do not match the dID-BOM.
- The de-identification runtime uses unchangeable artefact identifiers that match the dID-BOM entries.
- Automated regression tests exist and run for each validated data type/context, including edge cases (for example, nulls, locale-specific dates, and integer versus floating point handling).
- Evidence is auditable: each production run can be traced to the relevant dID-BOM entry (algorithm version, software build ID, and validation report reference).

###### Actions Required for Compliance

- [ ] Create a dID-BOM register that links each in-scope personal data (PII) type and context to the approved algorithm version and the exact approved software build identifier.
- [ ] Fix the de-identification step in the pipeline by using unchangeable (immutable) file identifiers, and record those identifiers in the de-identification bill of materials (dID-BOM).
- [ ] Set up automated “policy-as-code” checks before running de-identification jobs, so the jobs are stopped if the algorithm or software identifiers do not match the dID-BOM.
- [ ] Create and run automated regression tests for each approved data type and use case, including edge cases such as missing values (nulls), dates that vary by locale, and differences between whole numbers (integers) and decimal numbers (floating point).
- [ ] Add audit logging to record, for each de-identification run, the specific dID-BOM entry that was used (algorithm version, software build identifier, and a reference to the validation evidence).
- [ ] Update the change-management process so that any change to an algorithm, library, or configuration triggers either re-validation or selection of an already-validated equivalent of the dID-BOM.


---

#### SI-19.8 — Motivated Intruder (Enhancement)

This requirement is about stress-testing anonymised information to check whether it could be traced back to identify real people. Even if data is described as “de-identified”, there is still a risk that someone with enough knowledge, computing power, money, and access to other information could link records together and work out who a person is. This could cause privacy harm, complaints, and regulatory or reputational damage.

To meet this expectation, the organisation must run a “motivated intruder” test on the exact anonymised dataset version it plans to use. The test must use realistic assumptions about what an attacker might already know, what resources they could use, what other data they could access, and what skills they might have.

The organisation must document:
- what was tested,
- what assumptions were used,
- what attempts were made to identify individuals,
- and the results.

It must then clearly state whether re-identification was possible. If any risk is found, the organisation must improve its anonymisation approach, update its privacy risk records, and re-test to confirm the changes worked.

##### Motivated intruder test harness for each de-identified dataset release

- Category: Manual
- Priority: Critical

###### WHAT
Run a motivated intruder test on the **exact de-identified dataset version** that is intended for release. Use **realistic assumptions about what an attacker could do** (such as having inside knowledge, enough computing and money, access to other data, and the right skills) to try **re-identifying or linking** one or more individuals/records.

###### WHY (control requirement)
The National Institute of Standards and Technology (NIST) requirement SI-19(8) enhancement says: **“Perform a motivated intruder test on the de-identified dataset to determine if the identified data remains or if the de-identified data can be re-identified.”** The guidance also requires the test to state and use realistic assumptions about attacker capabilities and to document the results. The test cannot, by itself, prove the data is safe, but it must be used as a diagnostic tool.

###### HOW (specific steps/approach)
1. **Freeze the dataset version and capture evidence**: Identify the dataset extract and its version/date. Calculate and store a cryptographic hash of the de-identified dataset file(s) used for the test, so the test can be repeated and is clearly tied to the release version.
2. **Set attacker assumptions**: In the test plan, clearly state the intruder assumptions, including:
   - **Inside knowledge** (for example, familiarity with how the data was collected, what the attributes mean, and the data structure)
   - **Computing resources** (for example, standard cloud computing versus high-performance computing, and the time available)
   - **Financial resources** (for example, the ability to buy commercial datasets)
   - **Access to other data** (for example, public records, previously released datasets, and any permitted supporting datasets)
   - **Skills** (for example, a general data analyst versus someone with specialist re-identification capability)
3. **Choose and run linkage/re-identification methods**: Use a controlled test setup to carry out realistic linkage attempts, such as:
   - matching deterministically using quasi-identifiers,
   - probabilistic linkage using scoring thresholds,
   - linking using time alignment (matching within a time window),
   - exploiting rare combinations of attributes.
4. **Carry out targeted re-identification attempts**: Try to re-identify **one or more individuals/records within scope** using only the resources and supporting data allowed by the attacker assumptions. Record which attributes enabled the linkage and the confidence/decision thresholds used.
5. **Decide and document results**: Produce an audit-ready report that includes: dataset version/hash, scope, attacker assumptions, methods used, number/type of attempts, success criteria, evidence of linkage (for example, matched record identifiers in a controlled way), and a clear conclusion on whether re-identification was possible.
6. **Fix issues and re-test if risk is found**: If linkage succeeds beyond the agreed tolerance, update the de-identification approach (for example, stronger generalisation, suppression, time-bucketing, or other approved techniques) and re-run the motivated intruder test on the updated de-identified dataset version.

###### WHO (role responsible)
- **Data Protection Officer / Privacy Lead**: owns the test plan, attacker assumptions, and success criteria.
- **Data Engineering / Analytics Lead**: builds and runs the linkage test setup in a controlled environment.
- **Security/Compliance Lead**: reviews the audit evidence, confirms testing was done on the correct dataset release artefact, and checks governance/approvals.

###### Acceptance criteria
- The test is run on the **exact de-identified dataset version** intended for release (verifiable using the stored dataset hash).
- The test plan documents attacker assumptions covering inside knowledge, computing and financial resources, access to supporting data, and skills.
- Re-identification attempts are carried out using the defined linkage methods and are recorded with evidence and decision thresholds.
- A documented conclusion states whether re-identification/linkage was feasible.
- If feasible, remediation is completed and a re-test is done (or a scheduled re-test is approved and tracked) using updated evidence.

###### Actions Required for Compliance

- [ ] Freeze and record the exact de-identified dataset version used for testing, including a cryptographic hash of the release file.
- [ ] Create a motivated intruder testing plan that clearly states the attacker assumptions, including: inside knowledge, computing power, available budget, access to supporting information, and required skills.
- [ ] Set up a controlled test system for linking and re-identifying records that supports repeatable (deterministic), chance-based (probabilistic), and time-based (temporal) matching, with documented threshold values.
- [ ] Carry out re-identification attempts aimed at one or more in-scope individuals or records, and record evidence of the linkage attempts and their results.
- [ ] Produce an audit-ready report that clearly sets out the scope, approach, assumptions, what counts as success, and a clear conclusion on whether re-identification is feasible.
- [ ] If re-identification is possible, update the way the data is de-identified and re-run the motivated intruder test on the updated version of the dataset.


---

### SI-20 — Tainting (Control)

This requirement is about placing traceable “breadcrumbs” inside your most sensitive on-premises information. The goal is to prove whether data was copied out or removed in the wrong way. Without this, confidential or secret information could be taken by outsiders, or accidentally or deliberately removed by insiders, and you might not be able to confirm what happened, when it happened, or where the information went.

To meet this expectation, the organisation must deliberately embed traceable markers in on-premises data stores, file servers, databases, and email systems that hold Confidential and Secret information. This should be done using methods such as false records, hidden indicators within files, or controlled email recipients and other controlled “call-back” content. Each marker must be linked to the specific system and purpose. There must also be clear, documented ways to check for the markers, investigate if markers are missing or changed, and notify the right people.

The overall approach must be planned and documented, take privacy into account, be protected against tampering, and be supported by automated detection and evidence-handling so the results can be reviewed.

##### Database canary records with integrity checks and export detection

- Category: Software
- Priority: Critical

###### WHAT
Add traceable “deception” markers (also called “taint” markers) to on-premises Confidential and Secret database systems. This is done by inserting uniquely identifiable, database-valid “canary” records (and/or marker strings in specific fields) and then continuously checking that they still exist and have not been changed. The approach also checks whether these markers show up in places they should not—such as exports, staging areas, database replicas, or restored backups—to help confirm unauthorised data copying (exfiltration) or improper removal.

###### WHY (control requirement)
The National Institute of Standards and Technology (NIST) requirement **SI-20** asks the organisation to “embed data or capabilities in the following systems or system components to determine if organisational data has been exfiltrated or improperly removed” for the in-scope systems/components listed in `{{ param, si-20_odp }}` (on-premises data stores, file servers, databases, and email systems that hold Confidential and Secret information). This solution covers the database part by embedding traceable markers and using automated checks to provide evidence when markers are missing, changed, or found in unexpected locations.

###### HOW (specific steps/approach)
1. **Define the taint scope and where markers go**: For each in-scope on-premises database, identify the exact schema/table(s) or column(s) where canary records/fields will be added. Create a mapping that links each marker ID to `{system, database, schema, table/column, purpose, deployment version}`.
2. **Choose a passive taint method**: Use **canary records** (rows that look valid but are not real data) and/or **field-level marker strings** that do not interfere with application behaviour. Prefer dedicated deception tables/views or clearly isolated columns with strict access controls.
3. **Insert markers through controlled change**: Add markers using the organisation’s normal DBA (database administrator) and CI-CD (continuous integration and continuous delivery) change process—not ad-hoc changes. Record approvals, the change ticket, and the deployment hash/version, and store the marker mapping in a secured “taint registry”.
4. **Protect marker integrity**: Use the principle of least privilege so only the taint deployment process can write or refresh markers. Where possible, make markers hard to change using database features (for example, restricted update permissions, triggers that block changes, or read-only views for normal users).
5. **Automate verification (to detect improper removal)**: Run scheduled checks using a dedicated least-privileged service account to confirm marker presence and integrity (for example, expected row counts, checksums/hashes of marker fields, and the absence of unauthorised changes).
6. **Detect exfiltration (to detect unexpected appearance)**: Connect marker-ID detection to existing visibility for data movement (ETL/export jobs, database replication, data loss prevention (DLP) scanning, and file transfer logs). Alert when marker IDs are seen in exports, staging environments, or other destinations that are not part of approved workflows.
7. **Incident workflow and evidence handling**: If markers are missing/changed or appear in unexpected places, trigger an incident and security orchestration, automation and response (SOAR) workflow to gather evidence (query results, database audit logs, export/ETL logs, replication logs, and the taint registry mapping) and notify the data owner and the security operations centre (SOC).

###### WHO (role responsible)
- **Application/Data Owner**: approves the taint scope, purpose, and any acceptable operational impact.
- **Database Administrator (DBA)/Platform Engineering**: implements marker insertion, integrity protections, and scheduled verification checks.
- **SOC/Security information and event management (SIEM)/Data loss prevention (DLP) Engineering**: implements alerting, correlation rules, and evidence collection.
- **Information Security/Compliance**: maintains governance for the taint registry, performs periodic reviews, and supports audit readiness.

###### Acceptance criteria
- For each in-scope on-premises Confidential and Secret database, at least one taint marker method (canary records and/or field-level markers) is deployed and mapped to a unique marker ID in the secured taint registry.
- Automated scheduled checks run successfully and detect (and alert on) missing or altered markers, with enough information to identify the affected system/component and the marker’s purpose.
- The detection logic identifies marker IDs appearing in unapproved exports/replicas/staging destinations and generates an alert/incident.
- Evidence collected when detection occurs includes: marker mapping, verification results, relevant database audit logs, and relevant export/ETL/replication/DLP logs.
- Marker insertion/refresh is performed only through controlled change, with recorded approvals and deployment versioning.

###### Actions Required for Compliance

- [ ] Identify all in-scope on-premises databases that store Confidential or Secret data, and record the exact points where that data can be introduced (database schema, table, and column).
- [ ] Create a marker identification (ID) system and a protected taint register that links each marker to the relevant system, component, purpose, and deployment version.
- [ ] Set up “canary” records and/or field-level marker strings using a dedicated deception table or view, or by using separate, isolated columns filled with values that match the approved database schema.
- [ ] Use the organisation’s normal change process to deploy the markers, and record the approvals, the change ticket reference, and the deployment hash/version in the taint register.
- [ ] Set up least-privilege access and integrity protections so that only the taint deployment mechanism can change the markers.
- [ ] Set up scheduled automated checks that confirm each marker is present and unchanged, and raise alerts if any marker is missing or has been altered.
- [ ] Add detection rules to link (correlate) marker IDs found in exports, extract-transform-load (ETL) processes, replication, and data loss prevention (DLP) scans, and use the results to start incident response workflows that collect supporting evidence.


---

### SI-21 — Information Refresh (Control)

This requirement is about preventing sensitive information from being kept around longer than necessary. It should be regularly updated (or recreated only when needed), and then removed when it is no longer required. If confidential and secret information (including any copies made for analysis or recovery) is left unchanged for long periods, it becomes a more attractive target for criminals. If it is stolen, it can be copied and taken away more easily.

To meet this requirement, the organisation must keep a documented list of all confidential and secret data sets, including any versions created from them and any backups. It must also ensure that each confidential item is refreshed at least once every 90 days and each secret item at least once every 30 days. Alternatively, the organisation can create the information only when it is needed, and then securely delete it as soon as it is no longer required.

Named, responsible people must carry out the updating and deletion using documented procedures. People responsible for security and privacy must be clearly involved. The organisation must record evidence showing that the updates and deletions happened at the required times.

##### Automated refresh & purge for Confidential/Secret datasets

- Category: Software
- Priority: Critical

###### WHAT
Set up an “information refresh” process that works in one of two ways: (a) refreshes each in-scope Confidential or Secret dataset by the required maximum schedule, or (b) creates it when requested. After it is no longer needed, the process must securely delete it. The process must also produce proof that shows when refreshes happened and that deletions completed successfully.

###### WHY (control requirement)
The National Institute of Standards and Technology (NIST) SI-21 requires: “Refresh {{information}} at {{frequencies}} or generate the information on demand and delete the information when no longer needed.” The guidance explains that keeping information longer than necessary increases the chance of an attacker compromising it, capturing it, and taking it out of the organisation.

###### HOW (specific steps/approach)
1. **Create a master refresh list (register)** for all in-scope Confidential and Secret datasets, including any derived datasets and backups. For each item, record: data classification (Confidential/Secret), the source system, whether it is refreshed on a schedule or created on demand, what it depends on or how it is derived, and the required maximum cadence (Confidential ≤ 90 days; Secret ≤ 30 days).
2. **Set up a standard refresh workflow** for each dataset type. This workflow must rebuild/refresh the dataset (and any derived datasets), then **securely delete** any replaced or temporary copies. Use service accounts (workload identities) with the minimum permissions needed to run the workflow.
3. **Run refreshes using an orchestration tool** so that each dataset is refreshed no later than its maximum cadence. For on-demand mode, set up a request process that triggers creation and requires an explicit “completion” step that immediately starts secure deletion.
4. **Check that deletion really happened**: after a refresh or after on-demand completion, confirm deletion success using built-in platform checks (for example, object lifecycle completion, database removal/compaction completion, backup rotation status, or secure wipe completion markers). If confirmation cannot be completed, the workflow must stop with a failure.
5. **Create audit evidence automatically**: record the dataset identifier, classification, last refresh time, job run identifiers, version/build identifiers, deletion start and end times, and the deletion verification result. Store this evidence in an unchangeable (or tamper-evident) log system and link it to the relevant change or request record.
6. **Monitor and alert on missed timelines**: continuously calculate how many days have passed since the last successful refresh for each dataset. Alert (using security information and event management (SIEM) and security orchestration, automation and response (SOAR)) if a dataset is approaching or has exceeded its maximum cadence, or if deletion verification fails.

###### WHO (role responsible)
- **Data Owner / Information Security Owner**: approves the refresh register and decisions on dataset classification and cadence.
- **Application/Data Engineering Lead**: builds the refresh and deletion workflows for the application’s data stores and derived outputs.
- **Security Operations / Security Operations Centre (SOC)**: monitors alerts for missed timelines and deletion failures, and ensures audit evidence is kept.
- **Platform/Infrastructure Engineer**: ensures the underlying storage/database features support the checks needed to verify deletion.

###### Acceptance criteria
- For every Confidential dataset in the register, there is at least one successful refresh within every 90-day period (or on-demand creation occurs with deletion immediately after completion).
- For every Secret dataset in the register, there is at least one successful refresh within every 30-day period (or on-demand creation occurs with deletion immediately after completion).
- Derived datasets and backup/restore artefacts are included in the register and are refreshed/generated and deleted using the same cadence/mode rules.
- Every refresh/generation run produces audit evidence showing: when the refresh happened, the identity that carried out the work (workload identity), and confirmed deletion completion.
- Workflows must fail or raise alerts when deletion verification cannot be completed, and cadence breach alerts must be generated before or at the maximum cadence threshold.

###### Actions Required for Compliance

- [ ] Create and keep an up-to-date master list of all Confidential and Secret datasets, including any derived datasets and backups.
- [ ] Set a refresh approach for each dataset (either scheduled or on-demand) and enforce the maximum refresh frequency: **Confidential** data must be refreshed at least every **90 days**, and **Secret** data at least every **30 days**.
- [ ] Set up an organised process that rebuilds datasets and securely deletes any older or temporary copies that are no longer needed.
- [ ] Set up secure deletion checks using the platform’s built-in lifecycle or verification signals, and stop the process if the check fails.
- [ ] For every run, capture evidence that can be audited (including the time, the dataset and version used, who carried out the run, and the results of the deletion check) and keep this evidence for audit purposes.
- [ ] Set up monitoring to detect missed scheduled actions (“cadence-breach”) and failures to delete data (“deletion-failure”), and send alerts to security information and event management (SIEM) and security orchestration, automation and response (SOAR).


---

### SI-22 — Information Diversity (Control)

This requirement is about making sure your key services can keep working even if their usual information sources fail or are interfered with. If the information used to confirm who someone is, decide what they are allowed to do, retrieve important mission data, process critical messages, or record what happened is corrupted or not available, the service could stop, make incorrect decisions, or lose the ability to prove events later.

To meet this expectation, the organisation must first identify and document alternative information sources for:
- confirming identity and permissions (authentication and authorisation),
- retrieving mission data,
- handling command-and-control messages, and
- recording audit logs.

Examples include independent Domain Name System (DNS) resolvers, redundant message queues, locally stored cached configuration data, and backup database replicas.

It must then ensure that, if the main source is corrupted or unavailable, essential identity services, application service functions, database services, and logging and monitoring collectors switch to these alternative sources. This should allow operations to continue in a reduced capacity, but still in a usable way.

##### SI-22 multi-source failover for essential service inputs

- Category: Software
- Priority: Critical

###### WHAT
Set up and run backup (alternative) information sources for every **essential function/service**, so the system can keep working in a **reduced but usable** way if the main information is **corrupted or not available**.

###### WHY (control requirement)
Security guidance (SI-22) requires that actions taken by a system service/function—based on the information it receives—stay reliable even if that information is corrupted, fabricated, changed, or deleted. The organisation must define **alternative information sources** for **essential functions and services**, and make sure systems/components use these alternatives when the main source fails.

###### HOW (specific steps/approach)
1. **Create an “information diversity map”** for each essential function/service and the systems/components that carry it out, showing **primary vs alternative** information sources. Use the organisation-defined scope:
   - Essential functions/services: **authentication and authorisation; mission data retrieval; command-and-control message processing; audit logging**.
   - Systems/components: **identity services; application service tier; database services; logging and monitoring collectors**.
   - Alternative sources (examples to implement where applicable): **independent domain name system (DNS) resolvers; duplicate message queues; locally cached configuration data; secondary database replicas**.
2. **Implement health-checked switching for each function**:
   - **Availability failure triggers** (for example: DNS resolver cannot be reached, queue consumer cannot be reached, replica cannot be reached).
   - **Corruption or tampering triggers** (for example: DNS response validation failures, message integrity or signature verification failures, replica data divergence or integrity checks, cached configuration integrity hash mismatch).
   - Set thresholds and detection signals so that “corrupted or unavailable” can be measured in day-to-day operations.
3. **Set up alternative routes for each essential function**:
   - **Authentication/authorisation:** make sure identity services can fall back to alternative DNS resolution and/or redundant messaging inputs; continue authorisation decisions using the best available validated information.
   - **Mission data retrieval and command-and-control processing:** send reads to **secondary database replicas** and ensure message processing can continue using redundant queue routes.
   - **Audit logging:** make sure collectors can keep receiving and forwarding audit events using redundant queues and/or locally cached configuration (for example: collector routing/endpoint settings) until the primary source is restored.
4. **Plan degraded-mode behaviour** so lower-quality information is still good enough:
   - Apply time limits and “staleness” limits for cached configuration.
   - Ensure queue consumer handling allows continued processing without data loss beyond agreed tolerances.
   - Document expectations for how consistent replica reads are (for example: “eventual consistency is acceptable for mission reads” where applicable).
5. **Create audit-ready evidence**:
   - Keep the information diversity map, failover trigger definitions, and runbook procedures.
   - Record failover events (what triggered it, which alternative was used, how long it lasted, and the result) for each essential function.

###### WHO
- **System/Service Owner**: responsible for the information diversity map and what reduced-quality operation is acceptable.
- **Platform/Infrastructure Engineer**: sets up DNS, queue, replica, and cache configurations and the switching mechanisms.
- **Security Engineer**: checks that the corruption/tampering detection logic and integrity checks work correctly.
- **Operations/Site Reliability Engineering (SRE)/Monitoring Lead**: maintains runbooks, dashboards, and evidence collection.

###### Acceptance criteria
- For each essential function/service in the organisation-defined parameters, there is a documented mapping of **primary and alternative** information sources.
- For each function, the system demonstrably switches to the alternative source when the primary is **unavailable** and when corruption/tampering triggers are met (as defined by the trigger thresholds).
- During failover, the relevant systems/components (identity services, application tier, database services, logging/monitoring collectors) continue operating in a **reduced but usable** way, with documented limitations on data quality.
- Evidence exists for at least one controlled test per essential function showing: the trigger condition, the failover action, and the return to the primary source.

###### Actions Required for Compliance

- [ ] Create an information diversity map for each essential function or service. For each one, list the primary and alternative sources of information and the responsible systems or components.
- [ ] Set clear operational failover triggers for both service unavailability and data corruption or tampering, including measurable thresholds and the specific detection signals that indicate each issue.
- [ ] Set up separate Domain Name System (DNS) resolver routes and make sure services can check whether the resolver target is correct and switch to a different target without needing a redeployment.
- [ ] Set up backup (redundant) message queue routes and configure the message receivers to continue processing safely during a failover, using correct offset and acknowledgement handling.
- [ ] Set up additional database replicas to retrieve mission data and command-and-control inputs, and add checks to confirm data integrity and detect differences so degraded (reduced) reads remain safe.
- [ ] Set up locally stored, cached configuration data with integrity protection and time limits (TTL) to prevent outdated information for logging and monitoring collectors and other critical configuration.
- [ ] For each essential function, create and run failover tests. Record evidence showing what triggers the failover, how the alternative option is chosen, how the system behaves in degraded mode, and how it recovers.


---

### SI-23 — Information Fragmentation (Control)

This expectation is about protecting sensitive information by splitting it into separate parts, so it is much harder for someone to steal and remove everything at once.  

When the organisation stores or sends **Confidential** or **Secret** information for external sharing, remote access, or during periods of higher threat risk, it must first identify exactly which information is in scope. This includes export-controlled technical information and regulated health information. It must then split that information into fragments and store those fragments in different locations, such as: separate on-premises data stores, dedicated application services, and isolated network segments. Each location must have clearly different access rules, so access to one fragment does not automatically allow access to the others.  

The organisation should document when splitting is required, what information it applies to, and how the fragments are separated and kept apart. It must also ensure that its privacy and security plans, system design and security architecture, and day-to-day procedures all reflect this approach. Finally, it must assign clear responsibilities to the right people to implement it correctly and keep it working as intended.

##### Fragment Confidential/Secret data across isolated stores and services

- Category: Software
- Priority: Critical

###### WHAT
Set up an information “split and spread” capability for in-scope **Confidential/Secret** datasets. When defined **circumstances** apply (for example, external sharing, remote access, or high-risk threat periods), the data is broken into separate parts and **distributed across different on-premises data stores, dedicated application services, and separate network areas**.

###### WHY (control requirement)
Security control SI-23 says that, based on the organisation-defined **circumstances**, **information**, and **systems/components**, the organisation **may consider splitting information into separate parts and placing those parts across multiple systems/components and locations**. This is intended to make it harder for an attacker to use the information and to improve the chances of detection. The level of splitting must match the impact and classification level, and the defined **circumstances**.

###### HOW (specific approach)
1. **Define what triggers splitting and what is in scope (policy-as-code + live run-time flags):**
   - Turn the organisation-defined **circumstances** (SI-23 ODP.01) into clear live conditions (for example, the workflow state for external sharing, a remote access session being established, and a threat-period flag raised by SecOps).
   - Keep an official list of in-scope **information** (SI-23 ODP.02): Confidential/Secret datasets, including export-controlled technical data and regulated health information.
2. **Split and distribute the data (application/data layer):**
   - When a trigger condition is active for an in-scope dataset, split it into fragments (for example, encrypted content parts and only the minimum lookup/provenance parts needed for authorised reassembly).
   - Store the fragments in **separate on-premises data stores** (different clusters/accounts) and/or provide them via **dedicated application services** (for example, Fragment Retrieval Service A for content parts, and Service B for lookup/provenance).
   - Make sure each fragment is reachable only through **separate, isolated network areas**, with different access routes (for example, separate VLAN/VRF or ZTNA application connectors for each fragment service).
3. **Apply different access rules for each fragment (authorisation + network):**
   - Use separate authorisation rules/roles and separate service identities for each fragment type, so that access to one fragment does not allow access to the others.
   - Use network separation so that being able to connect to one fragment service/area is not enough to access other fragments.
4. **Allow authorised reassembly without removing the protections:**
   - Provide a controlled, logged reassembly process that only runs when the trigger conditions are met and the required authorisation checks pass. It must retrieve fragments from their respective services/stores using fragment-specific credentials.
5. **Record and keep evidence of the design and operation (audit-ready):**
   - Document in the system design/security architecture/security plan: the splitting triggers, the in-scope datasets, the fragment types, where each fragment is placed (stores/services/network areas), and how access is controlled separately for each fragment type.
   - Keep an auditable log of splitting activity (dataset identifier, trigger condition, fragment identifiers/locations, and reassembly workflow identifiers).

###### WHO
- **System Owner / Application Owner:** responsible for implementing the splitting capability and ensuring it is used for in-scope datasets.
- **Security Architect:** defines the fragment model, the access boundaries, and the network separation requirements.
- **Platform/Infrastructure Engineer:** implements isolated network areas and controls how services connect.
- **IAM/Access Management Lead:** implements fragment-specific roles, service identities, and authorisation rules.
- **SecOps/SOC (or Threat Intelligence function):** manages the high-risk threat-period flag used as a trigger.

###### Acceptance criteria
- When a defined **circumstance** is active, in-scope Confidential/Secret datasets are stored/transmitted as **multiple fragments** distributed across the defined **systems/components** (separate on-premises stores and/or dedicated services and isolated network areas).
- A user/service account authorised for one fragment cannot retrieve other fragments (confirmed through access tests and network reachability tests).
- Reassembly is only possible through the controlled workflow with the correct authorisation, and it produces audit evidence.
- The system design/security architecture/security plan documents: the triggers, the in-scope information, the fragment distribution locations, and how separate access control is enforced.
- Splitting and reassembly events are logged with enough detail for audit and incident investigation.

###### Actions Required for Compliance

- [ ] Define and implement automated policy checks (“policy-as-code”) for SI-23 situations—external sharing, remote access, and high-risk threat periods—and connect these checks to the processes that manage how datasets are handled.
- [ ] Create an official catalogue of in-scope datasets for Confidential and Secret data (including export-controlled technical data and regulated health information), and ensure all datasets are correctly labelled when they are first added.
- [ ] Create a fragment model (for example, split content into smaller “shards” and use small lookup and source-tracking fragments) and build the fragmentation process into the application and data pipeline.
- [ ] Store each fragment in separate on-premises data stores and/or dedicated fragment services, ensuring fragments are not stored together in the same location.
- [ ] Set up separate, isolated network areas and use different service access points for each fragment type, so that network connections cannot pass across fragment boundaries.
- [ ] Set up authorisation rules for each fragment separately, and use separate service identities and roles, so that access to one fragment does not allow access to other fragments.
- [ ] Update the system design, security architecture, and security plan, and implement audit logging for the fragmentation and authorised reassembly workflows.

